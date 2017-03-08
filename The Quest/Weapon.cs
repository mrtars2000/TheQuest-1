/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 1/20/2017
 * Time: 1:33 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace The_Quest
{
	/// <summary>
	/// Description of Weapon.
	/// </summary>
	abstract class Weapon : Mover
	{
		public bool PickedUp { get; private set; }

		public Weapon(Game game, Point location)
			:base(game, location)
		{
			PickedUp = false;
		}

		public void PickUpWeapon() { PickedUp = true; }

		public abstract string Name { get; }

		public abstract void Attack(Direction direction, Random random);

		protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
		{
			Point target = game.PlayerLocation;
			
			for (int distance = 0; distance < radius; distance++)
			{
				foreach (Enemy enemy in game.Enemies)
				{
					if (Nearby(enemy.Location, target, distance))
					{
						enemy.Hit(damage, random);
						return true;
					}
				}
				target = Move(direction, target, game.Boundaries);
			}
			return false;
		}
	}
}
