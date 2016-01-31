﻿using System;
using System.Collections.Generic;
using GridDominance.Shared.Framework;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace GridDominance.Shared.Screens.GameScreen.Entities
{
    class GDEntityManager
	{
		private List<GDEntity> entities = new List<GDEntity>();

	    public GDEntityManager()
	    {
		    
	    }

	    public void Update(GameTime gameTime, InputState state)
		{
			foreach (var gdEntity in entities)
			{
				gdEntity.Update(gameTime, state);
			}
		}

	    public void Draw(SpriteBatch sbatch)
	    {
		    foreach (var gdEntity in entities)
		    {
			    gdEntity.Draw(sbatch);
		    }
	    }

	    public void AddEntity(GDEntity e)
	    {
			entities.Add(e);
	    }

		public int Count()
		{
			return entities.Count;
		}
	}
}