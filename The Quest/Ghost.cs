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
	/// Description of Ghost.
	/// </summary>
	class Ghost : Enemy
	{
		public Ghost(Game game, Point location)
			:base(game, location, 8)
		{
		}
		
		public override void Move(Random random)
		{
			// 1 in 3 chance to follow player or stand still
			if (random.Next(0,3) == 0)
				location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);

			if (NearPlayer())
			{
				// attack for 0-3 damage
				game.HitPlayer(3, random);
			}
		}
	}
}
