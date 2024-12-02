namespace RacingGame
{
	partial class RacingGame
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RacingGame));
			this.pB_Fon = new System.Windows.Forms.PictureBox();
			this.pB_Fon2 = new System.Windows.Forms.PictureBox();
			this.pB_Player = new System.Windows.Forms.PictureBox();
			this.pB_Enemy1 = new System.Windows.Forms.PictureBox();
			this.pB_Enemy2 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label_GameOwer = new System.Windows.Forms.Label();
			this.button_Restart = new System.Windows.Forms.Button();
			this.pB_Coin = new System.Windows.Forms.PictureBox();
			this.label_Count = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pB_Fon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_Fon2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_Player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_Enemy1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_Enemy2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_Coin)).BeginInit();
			this.SuspendLayout();
			// 
			// pB_Fon
			// 
			this.pB_Fon.Image = ((System.Drawing.Image)(resources.GetObject("pB_Fon.Image")));
			this.pB_Fon.InitialImage = ((System.Drawing.Image)(resources.GetObject("pB_Fon.InitialImage")));
			this.pB_Fon.Location = new System.Drawing.Point(0, 0);
			this.pB_Fon.Name = "pB_Fon";
			this.pB_Fon.Size = new System.Drawing.Size(785, 560);
			this.pB_Fon.TabIndex = 0;
			this.pB_Fon.TabStop = false;
			// 
			// pB_Fon2
			// 
			this.pB_Fon2.BackColor = System.Drawing.Color.Transparent;
			this.pB_Fon2.Image = ((System.Drawing.Image)(resources.GetObject("pB_Fon2.Image")));
			this.pB_Fon2.Location = new System.Drawing.Point(0, -560);
			this.pB_Fon2.Name = "pB_Fon2";
			this.pB_Fon2.Size = new System.Drawing.Size(785, 580);
			this.pB_Fon2.TabIndex = 0;
			this.pB_Fon2.TabStop = false;
			// 
			// pB_Player
			// 
			this.pB_Player.BackColor = System.Drawing.Color.Transparent;
			this.pB_Player.Image = ((System.Drawing.Image)(resources.GetObject("pB_Player.Image")));
			this.pB_Player.Location = new System.Drawing.Point(412, 391);
			this.pB_Player.Name = "pB_Player";
			this.pB_Player.Size = new System.Drawing.Size(130, 150);
			this.pB_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pB_Player.TabIndex = 1;
			this.pB_Player.TabStop = false;
			// 
			// pB_Enemy1
			// 
			this.pB_Enemy1.BackColor = System.Drawing.Color.Transparent;
			this.pB_Enemy1.Image = ((System.Drawing.Image)(resources.GetObject("pB_Enemy1.Image")));
			this.pB_Enemy1.Location = new System.Drawing.Point(92, -131);
			this.pB_Enemy1.Name = "pB_Enemy1";
			this.pB_Enemy1.Size = new System.Drawing.Size(130, 150);
			this.pB_Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pB_Enemy1.TabIndex = 2;
			this.pB_Enemy1.TabStop = false;
			// 
			// pB_Enemy2
			// 
			this.pB_Enemy2.BackColor = System.Drawing.Color.Transparent;
			this.pB_Enemy2.Image = ((System.Drawing.Image)(resources.GetObject("pB_Enemy2.Image")));
			this.pB_Enemy2.Location = new System.Drawing.Point(251, -141);
			this.pB_Enemy2.Name = "pB_Enemy2";
			this.pB_Enemy2.Size = new System.Drawing.Size(130, 150);
			this.pB_Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pB_Enemy2.TabIndex = 2;
			this.pB_Enemy2.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 20;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label_GameOwer
			// 
			this.label_GameOwer.AutoSize = true;
			this.label_GameOwer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label_GameOwer.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_GameOwer.ForeColor = System.Drawing.SystemColors.Window;
			this.label_GameOwer.Location = new System.Drawing.Point(304, 75);
			this.label_GameOwer.Name = "label_GameOwer";
			this.label_GameOwer.Size = new System.Drawing.Size(190, 45);
			this.label_GameOwer.TabIndex = 3;
			this.label_GameOwer.Text = "Game ower";
			// 
			// button_Restart
			// 
			this.button_Restart.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button_Restart.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_Restart.ForeColor = System.Drawing.SystemColors.Window;
			this.button_Restart.Location = new System.Drawing.Point(303, 167);
			this.button_Restart.Name = "button_Restart";
			this.button_Restart.Size = new System.Drawing.Size(191, 42);
			this.button_Restart.TabIndex = 4;
			this.button_Restart.Text = "Restart";
			this.button_Restart.UseVisualStyleBackColor = false;
			this.button_Restart.Click += new System.EventHandler(this.button_Restart_Click);
			// 
			// pB_Coin
			// 
			this.pB_Coin.Image = ((System.Drawing.Image)(resources.GetObject("pB_Coin.Image")));
			this.pB_Coin.Location = new System.Drawing.Point(462, 23);
			this.pB_Coin.Name = "pB_Coin";
			this.pB_Coin.Size = new System.Drawing.Size(32, 32);
			this.pB_Coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pB_Coin.TabIndex = 5;
			this.pB_Coin.TabStop = false;
			// 
			// label_Count
			// 
			this.label_Count.AutoSize = true;
			this.label_Count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label_Count.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label_Count.ForeColor = System.Drawing.SystemColors.Window;
			this.label_Count.Location = new System.Drawing.Point(12, 23);
			this.label_Count.Name = "label_Count";
			this.label_Count.Size = new System.Drawing.Size(74, 25);
			this.label_Count.TabIndex = 3;
			this.label_Count.Text = "Count: ";
			// 
			// RacingGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(786, 561);
			this.Controls.Add(this.pB_Coin);
			this.Controls.Add(this.button_Restart);
			this.Controls.Add(this.label_Count);
			this.Controls.Add(this.label_GameOwer);
			this.Controls.Add(this.pB_Enemy2);
			this.Controls.Add(this.pB_Enemy1);
			this.Controls.Add(this.pB_Player);
			this.Controls.Add(this.pB_Fon2);
			this.Controls.Add(this.pB_Fon);
			this.MaximizeBox = false;
			this.Name = "RacingGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RacingGame";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RacingGame_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.pB_Fon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_Fon2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_Player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_Enemy1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_Enemy2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pB_Coin)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pB_Fon;
		private System.Windows.Forms.PictureBox pB_Fon2;
		private System.Windows.Forms.PictureBox pB_Player;
		private System.Windows.Forms.PictureBox pB_Enemy1;
		private System.Windows.Forms.PictureBox pB_Enemy2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label_GameOwer;
		private System.Windows.Forms.Button button_Restart;
		private System.Windows.Forms.PictureBox pB_Coin;
		private System.Windows.Forms.Label label_Count;
	}
}