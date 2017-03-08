/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 1/20/2017
 * Time: 1:58 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Collections.Generic;

namespace The_Quest
{
	/// <summary>
	/// Description of Mover.
	/// </summary>
	abstract class Mover
	{
		const int MoveInterval = 10;
		protected Point location;
		public Point Location { get { return location; } }

		protected Game game;

		public Mover(Game game, Point location)
		{
			this.game = game;
			this.location = location;
		}

		public bool Nearby(Point locationToCheck, int distance)
		{
			if (Math.Abs(location.X - locationToCheck.X) < distance &&
			    (Math.Abs(location.Y - locationToCheck.Y) < distance))
			    return true;
			return false; 
		}

		public bool Nearby(Point playerLocation, Point targetLocation, int distance)
		{
			if ((Math.Abs(playerLocation.X - targetLocation.X) <= distance) &&
			    Math.Abs(playerLocation.Y - targetLocation.Y) <= distance)
				return true;
			return false;
		}

		public Point Move(Direction direction, Rectangle boundaries)
		{
			Point newLocation = location;
			switch(direction)
			{
				case Direction.Up:
					if (newLocation.Y - MoveInterval >= boundaries.Top)
						newLocation.Y -= MoveInterval;
					else
						newLocation.Y = boundaries.Top;
					break;
				case Direction.Down:
					if (newLocation.Y + MoveInterval <= boundaries.Bottom)
						newLocation.Y += MoveInterval;
					else
						newLocation.Y = boundaries.Bottom;
					break;
				case Direction.Left:
					if (newLocation.X - MoveInterval >= boundaries.Left)
						newLocation.X -= MoveInterval;
					else
						newLocation.X = boundaries.Left;
					break;
				case Direction.Right:
					if (newLocation.X + MoveInterval <= boundaries.Right)
						newLocation.X += MoveInterval;
					else
						newLocation.X = boundaries.Right;
					break;
			}
			return newLocation;
		}
		
		public Point Move(Direction direction, Point targetLocation, Rectangle boundaries)
		{
			return new Point(200, 400);
		}
	}
}
