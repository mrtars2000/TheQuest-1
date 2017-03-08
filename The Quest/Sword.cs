/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 1/20/2017
 * Time: 1:47 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace The_Quest
{
	/// <summary>
	/// Description of Sword.
	/// </summary>
	class Sword : Weapon
	{
		public Sword(Game game, Point location)
			:base(game,location) { }

		int numberOfSwings = 0;
		bool enemyHit;

		public override string Name { get { return "Sword"; } }

        // attacks in 3 squares, starting with original direction
        // if no enemy, check clockwise
        // if no enemy check counter-clockwise
        // radius 10, up to 3 damage
        public override void Attack(Direction direction, Random random)
		{
			if (numberOfSwings <3 && !enemyHit)
			{
				numberOfSwings++;
				switch (direction)
				{
					// add 50 to range since the point only takes into account top-left coordinates
                    // swinging from center of player
					case Direction.Up:
						foreach (Enemy enemy in game.Enemies)
						{
							if (Nearby(enemy.Location, 60))
							{
								if ((enemy.Location.Y <= game.PlayerLocation.Y) && (enemy.Location.X >= game.PlayerLocation.X)
							    && (enemy.Location.X <= game.PlayerLocation.X + 50))
								{
									enemy.Hit(3, random);
									enemyHit = true;
								}
							}
						}
						if (!enemyHit)
							Attack(Direction.Right, random);
						break;
					case Direction.Right:
						foreach (Enemy enemy in game.Enemies)
						{
							if (Nearby(game.PlayerLocation, enemy.Location, 60))
							{
								if ((enemy.Location.X >= game.PlayerLocation.X) && (enemy.Location.Y >= game.PlayerLocation.Y)
							    && (enemy.Location.Y <= game.PlayerLocation.Y + 50))
								{
									enemy.Hit(3, random);
									enemyHit = true;
								}
							}
						}
						if (!enemyHit)
							Attack(Direction.Down, random);
						break;
					case Direction.Down:
						foreach (Enemy enemy in game.Enemies)
						{
							if (Nearby(game.PlayerLocation, enemy.Location, 60))
							{
								if ((enemy.Location.Y >= game.PlayerLocation.Y) && (enemy.Location.X <= game.PlayerLocation.X + 50)
							    && (enemy.Location.X >= game.PlayerLocation.X))
								{
									enemy.Hit(3, random);
									enemyHit = true;
								}
							}
						}
						if (!enemyHit)
							Attack(Direction.Left, random);
						break;
					case Direction.Left:
						foreach (Enemy enemy in game.Enemies)
						{
							if (Nearby(game.PlayerLocation, enemy.Location, 60))
							{
								if ((enemy.Location.X <= game.PlayerLocation.X) && (enemy.Location.Y >= game.PlayerLocation.Y)
							    && (enemy.Location.Y <= game.PlayerLocation.Y + 50))
								{
									enemy.Hit(3, random);
									enemyHit = true;
								}
							}
						}
						if (!enemyHit)
							Attack(Direction.Up, random);
						break;
				}
			}
			numberOfSwings = 0;
			enemyHit = false;
		}
	}
}
