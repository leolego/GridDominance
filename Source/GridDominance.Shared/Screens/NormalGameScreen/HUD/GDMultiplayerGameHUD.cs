﻿using System.Collections.Generic;
using System.Linq;
using GridDominance.Shared.Network.Multiplayer;
using GridDominance.Shared.Resources;
using GridDominance.Shared.Screens.OverworldScreen.HUD.Multiplayer;
using GridDominance.Shared.Screens.ScreenGame;
using Microsoft.Xna.Framework;
using MonoSAMFramework.Portable.ColorHelper;
using MonoSAMFramework.Portable.DebugTools;
using MonoSAMFramework.Portable.GameMath.Geometry;
using MonoSAMFramework.Portable.Input;
using MonoSAMFramework.Portable.Network.Multiplayer;
using MonoSAMFramework.Portable.RenderHelper;
using MonoSAMFramework.Portable.Screens;
using MonoSAMFramework.Portable.Screens.HUD;
using MonoSAMFramework.Portable.Screens.HUD.Elements.Primitives;
using MonoSAMFramework.Portable.Screens.HUD.Enums;

namespace GridDominance.Shared.Screens.NormalGameScreen.HUD
{
	public class GDMultiplayerGameHUD : GameHUD, IGDGameHUD
	{
		public GDGameScreen GDOwner => (GDGameScreen)Screen;

		public const float COUNTDOWN_TIME = 3f; // sec

		private List<HUDElement> _cornerElements = new List<HUDElement>();
		private HUDRectangle _backgroundRect;

		private HUDImage _countdown;

		public GDMultiplayerGameHUD(GDGameScreen scrn, GDMultiplayerCommon mp) : base(scrn, Textures.HUDFontRegular)
		{
			AddElement(new HUDPauseButton(false, false, true));

			_backgroundRect = new HUDRectangle(-10)
			{
				Alignment = HUDAlignment.TOPLEFT,
				RelativePosition = FPoint.Zero,
				Definition = HUDBackgroundDefinition.CreateSimple(Color.Black * 0.3f),
				Size = new FSize(100, 100),
			};
			AddElement(_backgroundRect);

			var mpcsc = new MultiplayerConnectionStateControl(mp)
			{
				Alignment = HUDAlignment.TOPLEFT,
				RelativePosition = new FPoint(4, 4),
				TextColor = FlatColors.Clouds,
			};

			AddElement(mpcsc);
			_cornerElements.Add(mpcsc);

			if (mp.SessionUserID == 0)
			{
				if (mp.SessionCapacity == 2)
				{
					var lbl = new HUDLambdaLabel
					{
						Alignment = HUDAlignment.TOPLEFT,
						RelativePosition = new FPoint(4, 44),
						Font = Textures.HUDFontBold,
						FontSize = 32,
						Size = new FSize(200, 32),
						TextColor = FlatColors.Clouds,
						AutoSize = true,

						Lambda = () => (mp.ConnState == SAMNetworkConnection.ConnectionState.Offline) ? "Ping: -" : $"Ping: {(int) (mp.UserConn[1].InGamePing.Value * 1000)}ms",
					};
					AddElement(lbl);
					_cornerElements.Add(lbl);
				}
				else
				{
					int idx = 0;
					for (int i = 1; i < mp.SessionCapacity; i++)
					{
						int uid = i;

						var lbl = new HUDLambdaLabel
						{
							Alignment = HUDAlignment.TOPLEFT,
							RelativePosition = new FPoint(4, 44 + 40 * idx),
							Font = Textures.HUDFontBold,
							FontSize = 32,
							Size = new FSize(200, 32),
							TextColor = Color.White,
							AutoSize = true,

							Lambda = () => $"Ping[{uid}]: {(int) (mp.UserConn[uid].InGamePing.Value * 1000)}ms",
						};
						AddElement(lbl);
						_cornerElements.Add(lbl);

						idx++;
					}
				}
			}
			else
			{
				var lbl = new HUDLambdaLabel
				{
					Alignment = HUDAlignment.TOPLEFT,
					RelativePosition = new FPoint(4, 44),
					Font = Textures.HUDFontBold,
					FontSize = 32,
					Size = new FSize(200, 32),
					TextColor = Color.White,
					AutoSize = true,

					Lambda = () => $"Ping: {(int) (mp.UserConn[0].InGamePing.Value * 1000)}ms",
				};

				AddElement(lbl);
				_cornerElements.Add(lbl);
			}

			_countdown = new HUDImage(100)
			{
				Alignment = HUDAlignment.CENTER,
				Image = Textures.TexTitleNumber[3],
				ImageAlignment = HUDImageAlignment.UNDERSCALE,

				Size = new FSize(320, 320),
				
			};
			AddElement(_countdown);

			var x = _cornerElements.Max(e => e.Right);
			var y = _cornerElements.Max(e => e.Bottom);
			_backgroundRect.Size = new FSize(x + 4f, y + 4f);
		}
		
		protected override void OnUpdate(SAMTime gameTime, InputState istate)
		{
#if DEBUG
			root.IsVisible = !DebugSettings.Get("HideHUD");
#endif

			var x = _cornerElements.Max(e => e.RelativeRight);
			var y = _cornerElements.Max(e => e.RelativeBottom);
			_backgroundRect.Size = new FSize(x+4f, y+4f);

			if (GDOwner.LevelTime / GDOwner.GameSpeed < COUNTDOWN_TIME * (1/3f))
			{
				_countdown.Image = Textures.TexTitleNumber[3];
				GDOwner.IsCountdown = true;
			}
			else if (GDOwner.LevelTime / GDOwner.GameSpeed < COUNTDOWN_TIME * (2 / 3f))
			{
				_countdown.Image = Textures.TexTitleNumber[2];
				GDOwner.IsCountdown = true;
			}
			else if (GDOwner.LevelTime / GDOwner.GameSpeed < COUNTDOWN_TIME * (3 / 3f))
			{
				_countdown.Image = Textures.TexTitleNumber[1];
				GDOwner.IsCountdown = true;
			}
			else
			{
				_countdown.IsVisible = false;
				GDOwner.IsCountdown = false;
			}
		}
	}
}
