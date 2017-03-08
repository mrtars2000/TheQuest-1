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
	/// Description of Mace.
	/// </summary>
	class Mace : Weapon
	{
		public Mace(Game game, Point location)
			:base(game, location) {}
		
		public override string Name { get { return "Mace"; } }
		
		public override void Attack(Direction direction, Random random)
		{
			// full circle swing
			// radius 20
			// up to 6 damge

            foreach (Enemy enemy in game.Enemies)
            {
                if (Nearby(game.PlayerLocation, enemy.Location, 20))
                    enemy.Hit(3, random);
            }
		}
	}
}
