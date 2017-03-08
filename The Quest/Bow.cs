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

namespace The_Quest
{
	/// <summary>
	/// Description of Bow.
	/// </summary>
	class Bow : Weapon
	{
		public Bow(Game game, Point location)
			:base(game, location) {}
		
		public override string Name { get { return "Bow"; } }
		
		bool enemyHit;


        // attack radius of 30
        // 1 damage
        // can only attack in one direction
        public override void Attack(Direction direction, Random random)
		{
			switch (direction)
			{
				case Direction.Up:
					foreach (Enemy enemy in game.Enemies)
					{
						if (enemy.Location.Y <= game.PlayerLocation.Y && enemy.Location.X >= game.PlayerLocation.X
						    && enemy.Location.X <= game.PlayerLocation.X + 50)
						{
							if (Nearby(game.PlayerLocation, enemy.Location, 30) && !enemyHit)
							{
								enemy.Hit(1, random);
								enemyHit = true;
							}
						}
					}
					break;
				case Direction.Right:
					foreach (Enemy enemy in game.Enemies)
					{
						if (enemy.Location.X >= game.PlayerLocation.X && enemy.Location.Y >= game.PlayerLocation.Y
						    && enemy.Location.Y <= game.PlayerLocation.Y + 50)
						{
							if (Nearby(game.PlayerLocation, enemy.Location, 30) && !enemyHit)
							{
								enemy.Hit(1, random);
								enemyHit = true;
							}
						}
					}
					break;
				case Direction.Down:
					foreach (Enemy enemy in game.Enemies)
					{
						if (enemy.Location.Y >= game.PlayerLocation.Y && enemy.Location.X >= game.PlayerLocation.X
						    && enemy.Location.X <= game.PlayerLocation.X + 50)
						{
							if (Nearby(game.PlayerLocation, enemy.Location, 30) && !enemyHit)
							{
								enemy.Hit(1, random);
								enemyHit = true;
							}
						}
					}
					break;
				case Direction.Left:
					foreach (Enemy enemy in game.Enemies)
					{
						if (enemy.Location.X <= game.PlayerLocation.X && enemy.Location.Y >= game.PlayerLocation.Y
						    && enemy.Location.X <= game.PlayerLocation.Y + 50)
						{
							if (Nearby(game.PlayerLocation, enemy.Location, 30) && !enemyHit)
							{
								enemy.Hit(1, random);
								enemyHit = true;
							}
						}
					}
					break;
			}
			enemyHit = false;

		}
	}
}
