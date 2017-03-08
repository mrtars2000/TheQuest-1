/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 1/20/2017
 * Time: 12:29 AM
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
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Game game;
		Random random = new Random();

		public MainForm()
		{
			InitializeComponent();
			game = new Game(new Rectangle(76, 56, 460, 170));
			game.NewLevel(random);
			UpdateCharacters();
		}

        // if player clicks sword button
		void InvSwordClick(object sender, EventArgs e)
		{
			if (game.CheckPlayerInventory("Sword"))
				SwapWeapons("Sword");
		}

        // if player clicks bow button
        void InvBowClick(object sender, EventArgs e)
		{
			if (game.CheckPlayerInventory("Bow"))
				SwapWeapons("Bow");
		}

        // if player clicks mace button
        void InvMaceClick(object sender, EventArgs e)
		{
			if (game.CheckPlayerInventory("Mace"))
				SwapWeapons("Mace");
		}

        // if player clicks blue potion button
        void InvBlueClick(object sender, EventArgs e)
		{
			if (game.CheckPlayerInventory("Blue Potion"))
			    SwapWeapons("Blue Potion");

		}

        // if player clicks red potion button
        void InvRedClick(object sender, EventArgs e)
		{
			if (game.CheckPlayerInventory("Red Potion"))
				SwapWeapons("Red Potion");
		}

		void SwapWeapons(string weaponName)
		{
			invBow.BorderStyle = BorderStyle.None;
			invSword.BorderStyle = BorderStyle.None;
			invMace.BorderStyle = BorderStyle.None;
			invBlue.BorderStyle = BorderStyle.None;
			invRed.BorderStyle = BorderStyle.None;
			
			game.Equip(weaponName);
            TurnOnArrows();
			switch (weaponName)
			{
				case "Sword":
					invSword.BorderStyle = BorderStyle.Fixed3D;
					break;
				case "Bow":
					invBow.BorderStyle = BorderStyle.Fixed3D;
					break;
				case "Mace":
					invMace.BorderStyle = BorderStyle.Fixed3D;
					break;
				case "Blue Potion":
					invBlue.BorderStyle = BorderStyle.Fixed3D;
                    TurnOffArrows();
					break;
				case "Red Potion":
					invRed.BorderStyle = BorderStyle.Fixed3D;
                    TurnOffArrows();
					break;
			}
		}

        // turn off attack arrows if player holding a potion
        public void TurnOffArrows()
        {
            atkUp.Text = "Drink";
            atkUp.AutoSize = true;
            atkRight.Visible = false;
            atkDown.Visible = false;
            atkLeft.Visible = false;
        }

        // turn on attack arrows if player holding a weapon
        public void TurnOnArrows()
        {
            atkUp.Text = "↑";
            atkUp.Width = 26;
            atkRight.Visible = true;
            atkDown.Visible = true;
            atkLeft.Visible = true;
        }

		public void UpdateCharacters()
		{
			playerPic.Location = game.PlayerLocation;
			playerHP.Text = game.PlayerHitPoints.ToString();
			
			bool showBat = false;
			bool showGhost = false;
			bool showGhoul = false;
			
			int enemiesShown = 0;
			
			// populate hitpoint fields
			foreach (Enemy enemy in game.Enemies)
			{
				if (enemy is Bat)
				{
					batPic.Location = enemy.Location;
					batHP.Text = enemy.HitPoints.ToString();
					if (enemy.HitPoints > 0)
					{
						showBat = true;
						enemiesShown++;
					}
					else
						showBat = false;
				}
				
				if (enemy is Ghost)
				{
					ghostPic.Location = enemy.Location;
					ghostHP.Text = enemy.HitPoints.ToString();
					if (enemy.HitPoints > 0)
					{
						showGhost = true;
						enemiesShown++;
					}
					else
						showGhoul = false;
				}
				
				if (enemy is Ghoul)
				{
					ghoulPic.Location = enemy.Location;
					ghoulHP.Text = enemy.HitPoints.ToString();
					if (enemy.HitPoints > 0)
					{
						showGhoul = true;
						enemiesShown++;
					}
					else
						showGhoul = false;
				}
			}

			// set visibility for enemies and hitpoint field
			batPic.Visible = label4.Visible = batHP.Visible = showBat;
			ghostPic.Visible = label5.Visible = ghostHP.Visible = showGhost;
			ghoulPic.Visible = label6.Visible = ghoulHP.Visible = showGhoul;

			sword.Visible = bow.Visible = mace.Visible = bluePotion.Visible = redPotion.Visible = false;
			Control weaponControl = null;
			
			switch (game.WeaponInRoom.Name)
			{
				case "Sword":
					weaponControl = sword;
					break;
				case "Bow":
					weaponControl = bow;
					break;
				case "Mace":
					weaponControl = mace;
					break;
				case "Red Potion":
					weaponControl = redPotion;
					break;
				case "Blue Potion":
					weaponControl = bluePotion;
					break;
			}
	
			weaponControl.Visible = true;
			weaponControl.Location = game.WeaponInRoom.Location;

			if (game.WeaponInRoom.PickedUp)
				weaponControl.Visible = false;
			else
				weaponControl.Visible = true;

			// death
			if (game.PlayerHitPoints <= 0)
			{
				MessageBox.Show("You died.", "You lose!");
				Application.Exit();
			}

			// check level advancement
			if (enemiesShown < 1)
			{
				MessageBox.Show("You have defeated all enemies on this level.", "Level clear!");
				game.NewLevel(random);
				UpdateCharacters();
			}

            // update character inventory
			if (game.CheckPlayerInventory("Bow"))
				invBow.Visible = true;
			if (game.CheckPlayerInventory("Sword"))
				invSword.Visible = true;
			if (game.CheckPlayerInventory("Mace"))
				invMace.Visible = true;
			if (game.CheckPlayerInventory("Red Potion"))
				invRed.Visible = true;
			else
				invRed.Visible = false;
			if (game.CheckPlayerInventory("Blue Potion"))
				invBlue.Visible = true;
			else
				invBlue.Visible = false;

            if (game.EquippedWeapon != null)
                if (game.EquippedWeapon.Name != "Blue Potion" && game.EquippedWeapon.Name != "Red Potion")
                    TurnOnArrows();
		}

		// movement buttons
		void MoveUpClick(object sender, EventArgs e)
		{
			game.Move(Direction.Up, random);
			UpdateCharacters();
		}

		void MoveRightClick(object sender, EventArgs e)
		{
			game.Move(Direction.Right, random);
			UpdateCharacters();
		}

		void MoveDownClick(object sender, EventArgs e)
		{
			game.Move(Direction.Down, random);
			UpdateCharacters();
		}

		void MoveLeftClick(object sender, EventArgs e)
		{
			game.Move(Direction.Left, random);
			UpdateCharacters();
		}

		// attack buttons
		void AtkUpClick(object sender, EventArgs e)
		{
			game.Attack(Direction.Up, random);
            if (game.EquippedWeapon == null && game.CheckPlayerInventory("Sword"))
            {
                SwapWeapons("Sword");
                TurnOnArrows();
            }
            UpdateCharacters();
		}

		void AtkRightClick(object sender, EventArgs e)
		{
			game.Attack(Direction.Right, random);
			UpdateCharacters();
		}

		void AtkDownClick(object sender, EventArgs e)
		{
			game.Attack(Direction.Down, random);
			UpdateCharacters();
		}

		void AtkLeftClick(object sender, EventArgs e)
		{
			game.Attack(Direction.Left, random);
			UpdateCharacters();
		}
	}
}
