/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 1/20/2017
 * Time: 1:15 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace The_Quest
{
	/// <summary>
	/// Description of Player.
	/// </summary>
	class Player : Mover
	{
		Weapon equippedWeapon;
		public Weapon EquippedWeapon { get { return equippedWeapon; } }

		public int Hitpoints { get; private set; }
		
		List<Weapon> inventory = new List<Weapon>();
        // list of weapons in inventory
		public IEnumerable<string> Weapons {
			get {
				List<string> names = new List<string>();
				foreach (Weapon weapon in inventory)
				{
					names.Add(weapon.Name);
					if (weapon is IPotion)
					{
						IPotion potion = weapon as IPotion;
						if (potion.Used)
							names.Remove(weapon.Name);
					}	
				}
				return names;
			}
		}

		public Player(Game game, Point location)
			:base(game, location)
		{
            // starting hitpoints
			Hitpoints = 100;
		}

        // register player hit
		public void Hit(int maxDamage, Random random)
		{
			Hitpoints -= random.Next(1, maxDamage);
		}

        // increase HP when potion used
		public void IncreaseHealth(int health, Random random)
		{
			Hitpoints += random.Next(1, health+1);
		}

        // equip weapon
		public void Equip(string weaponName)
		{
			foreach (Weapon weapon in inventory)
			{
				if (weapon.Name == weaponName)
					equippedWeapon = weapon;
			}
		}
		
        // remove potion from inventory after use
		public void Remove(Weapon weapon)
		{
			inventory.Remove(weapon);
		}

        // move player
		public void Move(Direction direction)
		{
			location = Move(direction, game.Boundaries);
			Point playerCenter = new Point(game.PlayerLocation.X + 25, game.PlayerLocation.Y + 25);
			Point targetCenter = new Point(game.WeaponInRoom.Location.X + 25, game.WeaponInRoom.Location.Y + 25);

			if (!game.WeaponInRoom.PickedUp)
			{
				if (Nearby(playerCenter, targetCenter, 30))
				{
					game.WeaponInRoom.PickUpWeapon();
					if (equippedWeapon == null)
					{
						equippedWeapon = game.WeaponInRoom;
						game.Equip(game.WeaponInRoom.Name);
					}
					inventory.Add(game.WeaponInRoom);

				}
			}
		}

        // attack from player
		public void Attack(Direction direction, Random random)
		{
			if (equippedWeapon != null)
			{
				equippedWeapon.Attack(direction, random);
                // heal instead if using potion
				if (equippedWeapon is IPotion)
				{
					if (equippedWeapon.Name == "Blue Potion")
						IncreaseHealth(10, random);
					else
						IncreaseHealth(10, random);
					equippedWeapon = null;
				}
			}
		}
	}
}
