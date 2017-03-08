/*
 * Created by SharpDevelop.
 * User: Chad
 * Date: 1/20/2017
 * Time: 12:29 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace The_Quest
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox playerPic;
		private System.Windows.Forms.PictureBox mace;
		private System.Windows.Forms.PictureBox bow;
		private System.Windows.Forms.PictureBox sword;
		private System.Windows.Forms.PictureBox bluePotion;
		private System.Windows.Forms.PictureBox redPotion;
		private System.Windows.Forms.PictureBox ghoulPic;
		private System.Windows.Forms.PictureBox ghostPic;
		private System.Windows.Forms.PictureBox batPic;
		private System.Windows.Forms.PictureBox invRed;
		private System.Windows.Forms.PictureBox invBlue;
		private System.Windows.Forms.PictureBox invSword;
		private System.Windows.Forms.PictureBox invBow;
		private System.Windows.Forms.PictureBox invMace;
		private System.Windows.Forms.Button moveUp;
		private System.Windows.Forms.Button atkUp;
		private System.Windows.Forms.Button moveDown;
		private System.Windows.Forms.Button atkDown;
		private System.Windows.Forms.Button moveRight;
		private System.Windows.Forms.Button atkRight;
		private System.Windows.Forms.Button moveLeft;
		private System.Windows.Forms.Button atkLeft;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label playerHP;
		private System.Windows.Forms.Label batHP;
		private System.Windows.Forms.Label ghostHP;
		private System.Windows.Forms.Label ghoulHP;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mace = new System.Windows.Forms.PictureBox();
			this.bow = new System.Windows.Forms.PictureBox();
			this.sword = new System.Windows.Forms.PictureBox();
			this.bluePotion = new System.Windows.Forms.PictureBox();
			this.redPotion = new System.Windows.Forms.PictureBox();
			this.ghoulPic = new System.Windows.Forms.PictureBox();
			this.ghostPic = new System.Windows.Forms.PictureBox();
			this.batPic = new System.Windows.Forms.PictureBox();
			this.playerPic = new System.Windows.Forms.PictureBox();
			this.invRed = new System.Windows.Forms.PictureBox();
			this.invBlue = new System.Windows.Forms.PictureBox();
			this.invSword = new System.Windows.Forms.PictureBox();
			this.invBow = new System.Windows.Forms.PictureBox();
			this.invMace = new System.Windows.Forms.PictureBox();
			this.moveUp = new System.Windows.Forms.Button();
			this.atkUp = new System.Windows.Forms.Button();
			this.moveDown = new System.Windows.Forms.Button();
			this.atkDown = new System.Windows.Forms.Button();
			this.moveRight = new System.Windows.Forms.Button();
			this.atkRight = new System.Windows.Forms.Button();
			this.moveLeft = new System.Windows.Forms.Button();
			this.atkLeft = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.playerHP = new System.Windows.Forms.Label();
			this.batHP = new System.Windows.Forms.Label();
			this.ghostHP = new System.Windows.Forms.Label();
			this.ghoulHP = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.mace)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bluePotion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.redPotion)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ghoulPic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ghostPic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.batPic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerPic)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invRed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invBlue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invSword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invBow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.invMace)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mace
			// 
			this.mace.BackColor = System.Drawing.Color.Transparent;
			this.mace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.mace.Image = ((System.Drawing.Image)(resources.GetObject("mace.Image")));
			this.mace.Location = new System.Drawing.Point(804, 270);
			this.mace.Name = "mace";
			this.mace.Size = new System.Drawing.Size(50, 50);
			this.mace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.mace.TabIndex = 1;
			this.mace.TabStop = false;
			this.mace.Visible = false;
			// 
			// bow
			// 
			this.bow.BackColor = System.Drawing.Color.Transparent;
			this.bow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.bow.Image = ((System.Drawing.Image)(resources.GetObject("bow.Image")));
			this.bow.Location = new System.Drawing.Point(748, 270);
			this.bow.Name = "bow";
			this.bow.Size = new System.Drawing.Size(50, 50);
			this.bow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.bow.TabIndex = 2;
			this.bow.TabStop = false;
			this.bow.Visible = false;
			// 
			// sword
			// 
			this.sword.BackColor = System.Drawing.Color.Transparent;
			this.sword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.sword.Image = ((System.Drawing.Image)(resources.GetObject("sword.Image")));
			this.sword.Location = new System.Drawing.Point(692, 270);
			this.sword.Name = "sword";
			this.sword.Size = new System.Drawing.Size(50, 50);
			this.sword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.sword.TabIndex = 3;
			this.sword.TabStop = false;
			this.sword.Visible = false;
			// 
			// bluePotion
			// 
			this.bluePotion.BackColor = System.Drawing.Color.Transparent;
			this.bluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.bluePotion.Image = ((System.Drawing.Image)(resources.GetObject("bluePotion.Image")));
			this.bluePotion.Location = new System.Drawing.Point(636, 270);
			this.bluePotion.Name = "bluePotion";
			this.bluePotion.Size = new System.Drawing.Size(50, 50);
			this.bluePotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.bluePotion.TabIndex = 4;
			this.bluePotion.TabStop = false;
			this.bluePotion.Visible = false;
			// 
			// redPotion
			// 
			this.redPotion.BackColor = System.Drawing.Color.Transparent;
			this.redPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.redPotion.Image = ((System.Drawing.Image)(resources.GetObject("redPotion.Image")));
			this.redPotion.Location = new System.Drawing.Point(580, 270);
			this.redPotion.Name = "redPotion";
			this.redPotion.Size = new System.Drawing.Size(50, 50);
			this.redPotion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.redPotion.TabIndex = 5;
			this.redPotion.TabStop = false;
			this.redPotion.Visible = false;
			// 
			// ghoulPic
			// 
			this.ghoulPic.BackColor = System.Drawing.Color.Transparent;
			this.ghoulPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ghoulPic.Image = ((System.Drawing.Image)(resources.GetObject("ghoulPic.Image")));
			this.ghoulPic.Location = new System.Drawing.Point(524, 270);
			this.ghoulPic.Name = "ghoulPic";
			this.ghoulPic.Size = new System.Drawing.Size(50, 50);
			this.ghoulPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ghoulPic.TabIndex = 6;
			this.ghoulPic.TabStop = false;
			this.ghoulPic.Visible = false;
			// 
			// ghostPic
			// 
			this.ghostPic.BackColor = System.Drawing.Color.Transparent;
			this.ghostPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ghostPic.Image = ((System.Drawing.Image)(resources.GetObject("ghostPic.Image")));
			this.ghostPic.Location = new System.Drawing.Point(468, 270);
			this.ghostPic.Name = "ghostPic";
			this.ghostPic.Size = new System.Drawing.Size(50, 50);
			this.ghostPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ghostPic.TabIndex = 7;
			this.ghostPic.TabStop = false;
			this.ghostPic.Visible = false;
			// 
			// batPic
			// 
			this.batPic.BackColor = System.Drawing.Color.Transparent;
			this.batPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.batPic.Image = ((System.Drawing.Image)(resources.GetObject("batPic.Image")));
			this.batPic.Location = new System.Drawing.Point(412, 270);
			this.batPic.Name = "batPic";
			this.batPic.Size = new System.Drawing.Size(50, 50);
			this.batPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.batPic.TabIndex = 8;
			this.batPic.TabStop = false;
			this.batPic.Visible = false;
			// 
			// playerPic
			// 
			this.playerPic.BackColor = System.Drawing.Color.Transparent;
			this.playerPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.playerPic.Image = ((System.Drawing.Image)(resources.GetObject("playerPic.Image")));
			this.playerPic.Location = new System.Drawing.Point(112, 77);
			this.playerPic.Name = "playerPic";
			this.playerPic.Size = new System.Drawing.Size(50, 50);
			this.playerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.playerPic.TabIndex = 0;
			this.playerPic.TabStop = false;
			// 
			// invRed
			// 
			this.invRed.BackColor = System.Drawing.Color.Transparent;
			this.invRed.Image = ((System.Drawing.Image)(resources.GetObject("invRed.Image")));
			this.invRed.Location = new System.Drawing.Point(410, 433);
			this.invRed.Name = "invRed";
			this.invRed.Size = new System.Drawing.Size(50, 50);
			this.invRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.invRed.TabIndex = 13;
			this.invRed.TabStop = false;
			this.invRed.Visible = false;
			this.invRed.Click += new System.EventHandler(this.InvRedClick);
			// 
			// invBlue
			// 
			this.invBlue.BackColor = System.Drawing.Color.Transparent;
			this.invBlue.Image = ((System.Drawing.Image)(resources.GetObject("invBlue.Image")));
			this.invBlue.Location = new System.Drawing.Point(335, 433);
			this.invBlue.Name = "invBlue";
			this.invBlue.Size = new System.Drawing.Size(50, 50);
			this.invBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.invBlue.TabIndex = 12;
			this.invBlue.TabStop = false;
			this.invBlue.Visible = false;
			this.invBlue.Click += new System.EventHandler(this.InvBlueClick);
			// 
			// invSword
			// 
			this.invSword.BackColor = System.Drawing.Color.Transparent;
			this.invSword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.invSword.Image = ((System.Drawing.Image)(resources.GetObject("invSword.Image")));
			this.invSword.Location = new System.Drawing.Point(110, 433);
			this.invSword.Name = "invSword";
			this.invSword.Size = new System.Drawing.Size(54, 54);
			this.invSword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.invSword.TabIndex = 11;
			this.invSword.TabStop = false;
			this.invSword.Visible = false;
			this.invSword.Click += new System.EventHandler(this.InvSwordClick);
			// 
			// invBow
			// 
			this.invBow.BackColor = System.Drawing.Color.Transparent;
			this.invBow.Image = ((System.Drawing.Image)(resources.GetObject("invBow.Image")));
			this.invBow.Location = new System.Drawing.Point(185, 433);
			this.invBow.Name = "invBow";
			this.invBow.Size = new System.Drawing.Size(50, 50);
			this.invBow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.invBow.TabIndex = 10;
			this.invBow.TabStop = false;
			this.invBow.Visible = false;
			this.invBow.Click += new System.EventHandler(this.InvBowClick);
			// 
			// invMace
			// 
			this.invMace.BackColor = System.Drawing.Color.Transparent;
			this.invMace.Image = ((System.Drawing.Image)(resources.GetObject("invMace.Image")));
			this.invMace.Location = new System.Drawing.Point(260, 433);
			this.invMace.Name = "invMace";
			this.invMace.Size = new System.Drawing.Size(50, 50);
			this.invMace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.invMace.TabIndex = 9;
			this.invMace.TabStop = false;
			this.invMace.Visible = false;
			this.invMace.Click += new System.EventHandler(this.InvMaceClick);
			// 
			// moveUp
			// 
			this.moveUp.Location = new System.Drawing.Point(577, 424);
			this.moveUp.Name = "moveUp";
			this.moveUp.Size = new System.Drawing.Size(34, 23);
			this.moveUp.TabIndex = 14;
			this.moveUp.Text = "↑";
			this.moveUp.UseVisualStyleBackColor = true;
			this.moveUp.Click += new System.EventHandler(this.MoveUpClick);
			// 
			// atkUp
			// 
			this.atkUp.Location = new System.Drawing.Point(712, 424);
			this.atkUp.Name = "atkUp";
			this.atkUp.Size = new System.Drawing.Size(34, 23);
			this.atkUp.TabIndex = 15;
			this.atkUp.Text = "↑";
			this.atkUp.UseVisualStyleBackColor = true;
			this.atkUp.Click += new System.EventHandler(this.AtkUpClick);
			// 
			// moveDown
			// 
			this.moveDown.Location = new System.Drawing.Point(577, 482);
			this.moveDown.Name = "moveDown";
			this.moveDown.Size = new System.Drawing.Size(34, 23);
			this.moveDown.TabIndex = 16;
			this.moveDown.Text = "↓";
			this.moveDown.UseVisualStyleBackColor = true;
			this.moveDown.Click += new System.EventHandler(this.MoveDownClick);
			// 
			// atkDown
			// 
			this.atkDown.Location = new System.Drawing.Point(712, 482);
			this.atkDown.Name = "atkDown";
			this.atkDown.Size = new System.Drawing.Size(34, 23);
			this.atkDown.TabIndex = 17;
			this.atkDown.Text = "↓";
			this.atkDown.UseVisualStyleBackColor = true;
			this.atkDown.Click += new System.EventHandler(this.AtkDownClick);
			// 
			// moveRight
			// 
			this.moveRight.Location = new System.Drawing.Point(601, 453);
			this.moveRight.Name = "moveRight";
			this.moveRight.Size = new System.Drawing.Size(34, 23);
			this.moveRight.TabIndex = 18;
			this.moveRight.Text = "→";
			this.moveRight.UseVisualStyleBackColor = true;
			this.moveRight.Click += new System.EventHandler(this.MoveRightClick);
			// 
			// atkRight
			// 
			this.atkRight.Location = new System.Drawing.Point(741, 453);
			this.atkRight.Name = "atkRight";
			this.atkRight.Size = new System.Drawing.Size(34, 23);
			this.atkRight.TabIndex = 19;
			this.atkRight.Text = "→";
			this.atkRight.UseVisualStyleBackColor = true;
			this.atkRight.Click += new System.EventHandler(this.AtkRightClick);
			// 
			// moveLeft
			// 
			this.moveLeft.Location = new System.Drawing.Point(549, 453);
			this.moveLeft.Name = "moveLeft";
			this.moveLeft.Size = new System.Drawing.Size(34, 23);
			this.moveLeft.TabIndex = 20;
			this.moveLeft.Text = "←";
			this.moveLeft.UseVisualStyleBackColor = true;
			this.moveLeft.Click += new System.EventHandler(this.MoveLeftClick);
			// 
			// atkLeft
			// 
			this.atkLeft.Location = new System.Drawing.Point(684, 453);
			this.atkLeft.Name = "atkLeft";
			this.atkLeft.Size = new System.Drawing.Size(34, 23);
			this.atkLeft.TabIndex = 21;
			this.atkLeft.Text = "←";
			this.atkLeft.UseVisualStyleBackColor = true;
			this.atkLeft.Click += new System.EventHandler(this.AtkLeftClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(575, 508);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 22;
			this.label1.Text = "Move";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(709, 508);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 17);
			this.label2.TabIndex = 23;
			this.label2.Text = "Attack";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.5F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.5F));
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.playerHP, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.batHP, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.ghostHP, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.ghoulHP, 1, 3);
			this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(577, 339);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 75);
			this.tableLayoutPanel1.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "Player";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 18);
			this.label4.TabIndex = 1;
			this.label4.Text = "Bat";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 36);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 18);
			this.label5.TabIndex = 2;
			this.label5.Text = "Ghost";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(3, 54);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(59, 18);
			this.label6.TabIndex = 3;
			this.label6.Text = "Ghoul";
			// 
			// playerHP
			// 
			this.playerHP.Location = new System.Drawing.Point(68, 0);
			this.playerHP.Name = "playerHP";
			this.playerHP.Size = new System.Drawing.Size(129, 18);
			this.playerHP.TabIndex = 4;
			this.playerHP.Text = "label7";
			// 
			// batHP
			// 
			this.batHP.Location = new System.Drawing.Point(68, 18);
			this.batHP.Name = "batHP";
			this.batHP.Size = new System.Drawing.Size(129, 18);
			this.batHP.TabIndex = 5;
			this.batHP.Text = "label8";
			// 
			// ghostHP
			// 
			this.ghostHP.Location = new System.Drawing.Point(68, 36);
			this.ghostHP.Name = "ghostHP";
			this.ghostHP.Size = new System.Drawing.Size(129, 18);
			this.ghostHP.TabIndex = 6;
			this.ghostHP.Text = "label9";
			// 
			// ghoulHP
			// 
			this.ghoulHP.Location = new System.Drawing.Point(68, 54);
			this.ghoulHP.Name = "ghoulHP";
			this.ghoulHP.Size = new System.Drawing.Size(129, 18);
			this.ghoulHP.TabIndex = 7;
			this.ghoulHP.Text = "label10";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(882, 553);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.atkLeft);
			this.Controls.Add(this.moveLeft);
			this.Controls.Add(this.atkRight);
			this.Controls.Add(this.moveRight);
			this.Controls.Add(this.atkDown);
			this.Controls.Add(this.moveDown);
			this.Controls.Add(this.atkUp);
			this.Controls.Add(this.moveUp);
			this.Controls.Add(this.invRed);
			this.Controls.Add(this.invBlue);
			this.Controls.Add(this.invSword);
			this.Controls.Add(this.invBow);
			this.Controls.Add(this.invMace);
			this.Controls.Add(this.playerPic);
			this.Controls.Add(this.batPic);
			this.Controls.Add(this.ghostPic);
			this.Controls.Add(this.ghoulPic);
			this.Controls.Add(this.redPotion);
			this.Controls.Add(this.bluePotion);
			this.Controls.Add(this.sword);
			this.Controls.Add(this.bow);
			this.Controls.Add(this.mace);
			this.Name = "MainForm";
			this.Text = "The Quest";
			((System.ComponentModel.ISupportInitialize)(this.mace)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bluePotion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.redPotion)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ghoulPic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ghostPic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.batPic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerPic)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invRed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invBlue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invSword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invBow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.invMace)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
