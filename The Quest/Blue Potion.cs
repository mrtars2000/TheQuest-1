/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 1/20/2017
 * Time: 1:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace The_Quest
{
	/// <summary>
	/// Description of Blue_Potion.
	/// </summary>
	class Blue_Potion : Weapon, IPotion
	{
		bool used;
		public bool Used { get { return used; } }

		public Blue_Potion(Game game, Point location)
			:base(game, location) {}

		public override string Name { get { return "Blue Potion"; } }

		public override void Attack(Direction direction, Random random)
		{
			used = true;
		}
	}
}
