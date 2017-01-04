﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoSAMFramework.Portable.BatchRenderer.TextureAtlases;
using MonoSAMFramework.Portable.Extensions;
using MonoSAMFramework.Portable.GameMath;
using MonoSAMFramework.Portable.GameMath.Geometry;
using MonoSAMFramework.Portable.GameMath.VectorPath;
using MonoSAMFramework.Portable.RenderHelper;
using System;
using System.Linq;

namespace MonoSAMFramework.Portable.BatchRenderer
{
	/// <summary>
	/// Thin wrapper around SpriteBatch
	/// 
	/// Some methods in this class come from MonoGameExtended.SpritebatchWrapper
	/// </summary>
	class StandardSpriteBatchWrapper : SpriteBatchCommon
	{
		private readonly SpriteBatch internalBatch;

		public StandardSpriteBatchWrapper(GraphicsDevice device)
		{
			internalBatch = new SpriteBatch(device);
		}

		public StandardSpriteBatchWrapper(SpriteBatch sbatch)
		{
			internalBatch = sbatch;
		}

		public override void Dispose()
		{
			internalBatch.Dispose();
		}

		public override void Begin(SpriteSortMode sortMode = SpriteSortMode.Deferred, BlendState blendState = null, SamplerState samplerState = null, DepthStencilState depthStencilState = null, RasterizerState rasterizerState = null, Effect effect = null, Matrix? transformMatrix = null)
		{
			OnBegin();

			internalBatch.Begin(sortMode, blendState, samplerState, depthStencilState, rasterizerState, effect, transformMatrix);
		}

		public override void End()
		{
			internalBatch.End();

			OnEnd();
		}

		public override void DrawRaw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, Vector2 scale, SpriteEffects effects, float layerDepth)
		{
#if DEBUG
			IncRenderSpriteCount();
#endif

			internalBatch.Draw(texture, position, sourceRectangle, color, rotation, origin, scale, effects, layerDepth);
		}

		public override void DrawRaw(Texture2D texture, Vector2 position, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
#if DEBUG
			IncRenderSpriteCount();
#endif

			internalBatch.Draw(texture, position, sourceRectangle, color, rotation, origin, scale, effects, layerDepth);
		}
		
		public override void DrawRaw(Texture2D texture, FRectangle destinationRectangle, Rectangle? sourceRectangle, Color color, float rotation, Vector2 origin, SpriteEffects effects, float layerDepth)
		{
#if DEBUG
			IncRenderSpriteCount();
#endif

			internalBatch.Draw(texture, destinationRectangle.Truncate(), sourceRectangle, color, rotation, origin, effects, layerDepth);
		}
		
		public override void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color)
		{
#if DEBUG
			IncRenderTextCount(text.Length);
#endif

			internalBatch.DrawString(spriteFont, text, position, color);
		}

		public override void DrawString(SpriteFont spriteFont, string text, Vector2 position, Color color, float rotation, Vector2 origin, float scale, SpriteEffects effects, float layerDepth)
		{
#if DEBUG
			IncRenderTextCount(text.Length);
#endif

			internalBatch.DrawString(spriteFont, text, position, color, rotation, origin, scale, effects, layerDepth);
		}
		
		public void DrawPolygon(Vector2 offset, Vector2[] points, Color color, bool closed, float thickness)
		{
			if (points.Length == 0)
				return;

			if (points.Length == 1)
			{
				DrawPoint(points[0], color, (int)thickness);
				return;
			}

			var texture = StaticTextures.SinglePixel;

			for (var i = 0; i < points.Length - 1; i++)
				DrawPolygonEdge(texture, points[i] + offset, points[i + 1] + offset, color, thickness);

			if (closed) DrawPolygonEdge(texture, points[points.Length - 1] + offset, points[0] + offset, color, thickness);
		}

		private void DrawPolygonEdge(TextureRegion2D texture, Vector2 point1, Vector2 point2, Color color, float thickness)
		{
#if DEBUG
			IncRenderSpriteCount();
#endif

			var length = Vector2.Distance(point1, point2);
			var angle = (float)Math.Atan2(point2.Y - point1.Y, point2.X - point1.X);
			var scale = new Vector2(length, thickness);

			internalBatch.Draw(
				texture: texture.Texture,
				position: point1, 
				sourceRectangle: texture.Bounds, 
				color: color, 
				rotation: angle, 
				scale: scale);
		}

		public override void FillRectangle(FRectangle rectangle, Color color)
		{
			FillRectangle(rectangle.Location, rectangle.Size, color);
		}

		public override void FillRectangle(Vector2 location, Vector2 size, Color color)
		{
#if DEBUG
			IncRenderSpriteCount();
#endif

			internalBatch.Draw(
				StaticTextures.SinglePixel.Texture, 
				location,
				StaticTextures.SinglePixel.Bounds, 
				color, 
				0, 
				Vector2.Zero, 
				size, 
				SpriteEffects.None, 
				0);
		}
		
		public override void DrawRectangle(FRectangle rectangle, Color color, float thickness = 1f)
		{
#if DEBUG
			IncRenderSpriteCount(4);
#endif

			var pixel = StaticTextures.SinglePixel;
			var topLeft = new Vector2(rectangle.X, rectangle.Y);
			var topRight = new Vector2(rectangle.Right - thickness, rectangle.Y);
			var bottomLeft = new Vector2(rectangle.X, rectangle.Bottom - thickness);
			var horizontalScale = new Vector2(rectangle.Width, thickness);
			var verticalScale = new Vector2(thickness, rectangle.Height);

			internalBatch.Draw(pixel.Texture, topLeft,    sourceRectangle: pixel.Bounds, scale: horizontalScale, color: color);
			internalBatch.Draw(pixel.Texture, topLeft,    sourceRectangle: pixel.Bounds, scale: verticalScale,   color: color);
			internalBatch.Draw(pixel.Texture, topRight,   sourceRectangle: pixel.Bounds, scale: verticalScale,   color: color);
			internalBatch.Draw(pixel.Texture, bottomLeft, sourceRectangle: pixel.Bounds, scale: horizontalScale, color: color);
		}

		public override void DrawRectangle(Vector2 location, Vector2 size, Color color, float thickness = 1f)
		{
			DrawRectangle(new FRectangle(location.X, location.Y, size.X, size.Y), color, thickness);
		}

		public override void DrawLine(float x1, float y1, float x2, float y2, Color color, float thickness = 1f)
		{
			DrawLine(new Vector2(x1, y1), new Vector2(x2, y2), color, thickness);
		}

		public override void DrawLine(Vector2 point1, Vector2 point2, Color color, float thickness = 1f)
		{
			var distance = Vector2.Distance(point1, point2);
			var angle = (float)Math.Atan2(point2.Y - point1.Y, point2.X - point1.X);

			DrawLine(point1, distance, angle, color, thickness);
		}

		public void DrawLine(Vector2 point, float length, float angle, Color color, float thickness = 1f)
		{
#if DEBUG
			IncRenderSpriteCount();
#endif

			var origin = new Vector2(0f, 0.5f);
			var scale = new Vector2(length, thickness);
			internalBatch.Draw(StaticTextures.SinglePixel.Texture, point, StaticTextures.SinglePixel.Bounds, color, angle, origin, scale, SpriteEffects.None, 0);
		}
		
		public void DrawPoint(Vector2 position, Color color, float size = 1f)
		{
#if DEBUG
			IncRenderSpriteCount();
#endif

			var scale = Vector2.One * size;
			var offset = new Vector2(0.5f) - new Vector2(size * 0.5f);
			internalBatch.Draw(StaticTextures.SinglePixel.Texture, position + offset, sourceRectangle: StaticTextures.SinglePixel.Bounds, color: color, scale: scale);
		}

		public override void DrawCircle(Vector2 center, float radius, int sides, Color color, float thickness = 1f)
		{
			DrawPolygon(center, CreateCircle(radius, sides), color, true, thickness);
		}

		public override void DrawCirclePiece(Vector2 center, float radius, float angleMin, float angleMax, int sides, Color color, float thickness = 1f)
		{
			Vector2[] poly = CreateCirclePiece(radius, angleMin, angleMax, sides);

			DrawPolygon(center, poly, color, false, thickness);
			DrawLine(center, center + poly.First(), color, thickness);
			DrawLine(center, center + poly.Last(), color, thickness);
		}

		public override void DrawPath(Vector2 pos, VectorPath path, int segments, Color color, float thickness = 1)
		{
			foreach (var segment in path.Segments)
			{
				if (segment is LineSegment)
				{
					DrawPathSegment(pos, segment, 1, color, thickness);
				}
				else
				{
					DrawPathSegment(pos, segment, segments, color, thickness);
				}
			}
		}

		public void DrawPathSegment(Vector2 pos, VectorPathSegment path, int segments, Color color, float thickness = 1)
		{
			var last = pos + path.Get(0);
			for (int i = 1; i <= segments; i++)
			{
				var next = pos + path.Get((path.Length * i) / segments);

				DrawPolygonEdge(StaticTextures.SinglePixel, last, next, color, thickness);

				last = next;
			}
		}

		public override void FillCircle(Vector2 center, float radius, int sides, Color color)
		{
#if DEBUG
			IncRenderSpriteCount(sides);
#endif

			float angle = FloatMath.TAU / sides;
			float sideWidth = FloatMath.Asin(angle / 2) * 2 * radius;
			float rectHeight = FloatMath.Sin(FloatMath.RAD_POS_090 - angle / 2) * radius;

			
			var r = new FRectangle(center.X - sideWidth/2, center.Y, sideWidth, rectHeight);
			
			for (int i = 0; i < sides; i++)
			{
				internalBatch.Draw(
					StaticTextures.SinglePixel.Texture,
					null,
					r.Round(),
					StaticTextures.SinglePixel.Bounds,
					new Vector2(0.5f, 0),
					angle * i,
					Vector2.One, 
					color);
			}
		}

		public override void DrawEllipse(FRectangle rectangle, int sides, Color color, float thickness = 1f)
		{
			DrawPolygon(rectangle.Center, CreateEllipse(rectangle.Width, rectangle.Height, sides), color, true, thickness);
		}
		
		public override void DrawStretched(TextureRegion2D textureRegion, FRectangle destinationRectangle, Color color)
		{
#if DEBUG
			IncRenderSpriteCount();
#endif

			internalBatch.Draw(textureRegion.Texture, destinationRectangle.Truncate(), textureRegion.Bounds, color);
		}

		public override void DrawSimple(TextureRegion2D texture, Vector2 centerTarget, float height, float width, Color color, float rotation, float layerDepth = 0)
		{
#if DEBUG
			IncRenderSpriteCount();
#endif

			var scale = new Vector2(width / texture.Bounds.Width, height / texture.Bounds.Height);

			internalBatch.Draw(
				texture.Texture,
				centerTarget,
				texture.Bounds,
				color,
				rotation,
				texture.Center(),
				scale,
				SpriteEffects.None,
				layerDepth);
		}
	}
}
