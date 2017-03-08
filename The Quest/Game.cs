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
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace The_Quest
{
	/// <summary>
	/// Description of Game.
	/// </summary>
	public class Game
	{
		internal IEnumerable<Enemy> Enemies { get; private set; }
		internal Weapon WeaponInRoom { get; private set; }

		Player player;
		public Point PlayerLocation { get { return player.Location; } }
		public int PlayerHitPoints { get { return player.Hitpoints; } }
		internal Weapon EquippedWeapon { get { return player.EquippedWeapon; } }
		public IEnumerable<string> PlayerWeapons { get { return player.Weapons; } }

		int level = 0;
		public int Level { get { return level; } }

		Rectangle boundaries;
		public Rectangle Boundaries { get { return boundaries; } }

		public Game(Rectangle boundaries)
		{
			this.boundaries = boundaries;
			player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
		}

		public void Move(Direction direction, Random random)
		{
			player.Move(direction);
			foreach (Enemy enemy in Enemies)
				enemy.Move(random);
		}

		public void Equip(string weaponName)
		{
			player.Equip(weaponName);
		}

		public bool CheckPlayerInventory(string weaponName)
		{
			return player.Weapons.Contains(weaponName);
		}

		public void HitPlayer(int maxDamage, Random random)
		{
			player.Hit(maxDamage, random);
		}

		public void IncreasePlayerHealth(int health, Random random)
		{
			player.IncreaseHealth(health, random);
		}

		public void Attack(Direction direction, Random random)
		{
			player.Attack(direction, random);
			foreach (Enemy enemy in Enemies)
				enemy.Move(random);
		}

		Point GetRandomLocation(Random random)
		{
			int maxTop = boundaries.Top, maxRight = boundaries.Width;
			
			int left = boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
			top = boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10;
			
			if (left > maxRight)
				left = maxRight - 50;
			else if (left < boundaries.Left)
				left = boundaries.Left;
			if (top < maxTop)
				top = maxTop + 50;

			return new Point(left, top);
		}

		public void NewLevel(Random random)
		{
			level++;
			switch (level)
			{
				case 1:
					Enemies = new List<Enemy>()
					{
						new Bat(this, GetRandomLocation(random)),
					};
					WeaponInRoom = new Sword(this, GetRandomLocation(random));
					break;
				case 2:
					Enemies = new List<Enemy>()
					{
						new Ghost(this, GetRandomLocation(random)),
					};
					WeaponInRoom = new Blue_Potion(this, GetRandomLocation(random));
					break;
				case 3:
					Enemies = new List<Enemy>()
					{
						new Ghoul(this, GetRandomLocation(random)),
					};
					WeaponInRoom = new Bow(this, GetRandomLocation(random));
					break;
				case 4:
					Enemies = new List<Enemy>()
					{
						new Bat(this, GetRandomLocation(random)),
						new Ghost(this, GetRandomLocation(random)),
					};
					if (!CheckPlayerInventory("Bow"))
						WeaponInRoom = new Bow(this, GetRandomLocation(random));
					else if (!CheckPlayerInventory("Blue Potion"))
						WeaponInRoom = new Blue_Potion(this, GetRandomLocation(random));						
					break;
				case 5:
					Enemies = new List<Enemy>()
					{
						new Bat(this, GetRandomLocation(random)),
						new Ghoul(this, GetRandomLocation(random)),
					};
					WeaponInRoom = new Red_Potion(this, GetRandomLocation(random));
					break;
				case 6:
					Enemies = new List<Enemy>()
					{
						new Ghost(this, GetRandomLocation(random)),
						new Ghoul(this, GetRandomLocation(random))
					};
					WeaponInRoom = new Mace(this, GetRandomLocation(random));
					break;
				case 7:
					Enemies = new List<Enemy>()
					{
						new Bat(this, GetRandomLocation(random)),
						new Ghost(this, GetRandomLocation(random)),
						new Ghoul(this, GetRandomLocation(random))
					};
					if (!CheckPlayerInventory("Mace"))
						WeaponInRoom = new Red_Potion(this, GetRandomLocation(random));
					else if (!CheckPlayerInventory("Red Potion"))
						WeaponInRoom = new Red_Potion(this, GetRandomLocation(random));
					break;
				default:
					EndGame();
					break;
					
			}
		}
		
		public void EndGame()
		{
			MessageBox.Show("You've beaten the game!", "Congrats!");
			Application.Exit();
		}

	}
}
