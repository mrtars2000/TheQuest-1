/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 1/20/2017
 * Time: 1:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace The_Quest
{
	/// <summary>
	/// Description of Enemy.
	/// </summary>
	abstract class Enemy : Mover
	{
		const int NearPlayerDistance = 25;
		
		public int HitPoints { get; set; }
		public bool Dead { get { if (HitPoints <= 0) return true; return false; } }
		
		public Enemy(Game game, Point location, int hitPoints)
			:base(game, location) {	HitPoints = hitPoints; }

		public abstract void Move(Random random);

		public void Hit(int maxDamage, Random random)
		{
			HitPoints -= random.Next(1, maxDamage);
		}

		protected bool NearPlayer()
		{
			return (Nearby(game.PlayerLocation, NearPlayerDistance));
		}

		protected Direction FindPlayerDirection(Point playerLocation)
		{
			Direction directionToMove;
			
			if (playerLocation.X > location.X + 10)
				directionToMove = Direction.Right;
			else if (playerLocation.X < location.X - 10)
				directionToMove = Direction.Left;
			else if (playerLocation.Y < location.Y - 10)
				directionToMove = Direction.Up;
			else
				directionToMove = Direction.Down;
			return directionToMove;
		}
	}
}
