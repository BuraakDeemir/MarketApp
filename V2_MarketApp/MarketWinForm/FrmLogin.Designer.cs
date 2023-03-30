namespace MarketWinForm
{
	partial class FrmLogin
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
			this.panel1 = new System.Windows.Forms.Panel();
			this.LinkForget = new System.Windows.Forms.LinkLabel();
			this.BtnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtPasword = new System.Windows.Forms.TextBox();
			this.TxtUserName = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.LinkForget);
			this.panel1.Controls.Add(this.BtnLogin);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.TxtPasword);
			this.panel1.Controls.Add(this.TxtUserName);
			this.panel1.Location = new System.Drawing.Point(506, 334);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(485, 561);
			this.panel1.TabIndex = 0;
			// 
			// LinkForget
			// 
			this.LinkForget.AutoSize = true;
			this.LinkForget.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.LinkForget.ForeColor = System.Drawing.Color.White;
			this.LinkForget.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.LinkForget.LinkColor = System.Drawing.Color.White;
			this.LinkForget.Location = new System.Drawing.Point(305, 243);
			this.LinkForget.Name = "LinkForget";
			this.LinkForget.Size = new System.Drawing.Size(132, 20);
			this.LinkForget.TabIndex = 4;
			this.LinkForget.TabStop = true;
			this.LinkForget.Text = "Forget Password";
			// 
			// BtnLogin
			// 
			this.BtnLogin.ActiveBorderThickness = 1;
			this.BtnLogin.ActiveCornerRadius = 20;
			this.BtnLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
			this.BtnLogin.ActiveForecolor = System.Drawing.Color.White;
			this.BtnLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
			this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(113)))), ((int)(((byte)(67)))));
			this.BtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.BackgroundImage")));
			this.BtnLogin.ButtonText = "Login";
			this.BtnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BtnLogin.ForeColor = System.Drawing.Color.SeaGreen;
			this.BtnLogin.IdleBorderThickness = 1;
			this.BtnLogin.IdleCornerRadius = 20;
			this.BtnLogin.IdleFillColor = System.Drawing.Color.White;
			this.BtnLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
			this.BtnLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.BtnLogin.Location = new System.Drawing.Point(45, 354);
			this.BtnLogin.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(392, 67);
			this.BtnLogin.TabIndex = 3;
			this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(45, 230);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(141, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(45, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 35);
			this.label1.TabIndex = 1;
			this.label1.Text = "Username";
			// 
			// TxtPasword
			// 
			this.TxtPasword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TxtPasword.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtPasword.Location = new System.Drawing.Point(45, 268);
			this.TxtPasword.Multiline = true;
			this.TxtPasword.Name = "TxtPasword";
			this.TxtPasword.PasswordChar = '*';
			this.TxtPasword.Size = new System.Drawing.Size(392, 57);
			this.TxtPasword.TabIndex = 0;
			// 
			// TxtUserName
			// 
			this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TxtUserName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TxtUserName.Location = new System.Drawing.Point(45, 151);
			this.TxtUserName.Multiline = true;
			this.TxtUserName.Name = "TxtUserName";
			this.TxtUserName.Size = new System.Drawing.Size(392, 57);
			this.TxtUserName.TabIndex = 0;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(213)))));
			this.ClientSize = new System.Drawing.Size(1478, 1444);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Market";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private LinkLabel LinkForget;
		private Bunifu.Framework.UI.BunifuThinButton2 BtnLogin;
		private Label label2;
		private Label label1;
		private TextBox TxtPasword;
		private TextBox TxtUserName;
	}
}