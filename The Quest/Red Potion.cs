/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 1/20/2017
 * Time: 1:50 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace The_Quest
{
	/// <summary>
	/// Description of Red_Potion.
	/// </summary>
	class Red_Potion : Weapon, IPotion
	{
		public bool Used { get; set; }
		
		public Red_Potion(Game game, Point location)
			:base(game, location) {}
		
		public override string Name { get { return "Red Potion"; } }
		
		public override void Attack(Direction direction, Random random)	{ Used = true; }
	}
}
