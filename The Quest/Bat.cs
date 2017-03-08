/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 1/22/2017
 * Time: 8:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace The_Quest
{
	/// <summary>
	/// Description of Bat.
	/// </summary>
	class Bat : Enemy
	{
		public Bat(Game game, Point location)
			:base(game, location, 6) {}

		public override void Move(Random random)
		{
			// 50% chance to follow player
			if (random.Next(0,2) == 1)
				location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
			// random direction
			else
				location = Move((Direction)random.Next(0,4), game.Boundaries);

			if (NearPlayer())
			{
				// attack for 0-2 damage
				game.HitPlayer(2, random);
			}
		}
	}
}
