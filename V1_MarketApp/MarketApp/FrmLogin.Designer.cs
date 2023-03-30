namespace MarketApp
{
	partial class FrmLogin
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.LblForget = new System.Windows.Forms.LinkLabel();
			this.BtnSingIn = new System.Windows.Forms.Button();
			this.BtnLogin = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtUserName = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(230, 1479);
			this.panel2.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.panel6);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(230, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(750, 1479);
			this.panel3.TabIndex = 2;
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 1101);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(750, 351);
			this.panel6.TabIndex = 2;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.IndianRed;
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel5.Controls.Add(this.LblForget);
			this.panel5.Controls.Add(this.BtnSingIn);
			this.panel5.Controls.Add(this.BtnLogin);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.TxtPassword);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.TxtUserName);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 351);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(750, 750);
			this.panel5.TabIndex = 1;
			// 
			// LblForget
			// 
			this.LblForget.AutoSize = true;
			this.LblForget.Font = new System.Drawing.Font("Berlin Sans FB", 10.125F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblForget.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.LblForget.LinkColor = System.Drawing.Color.White;
			this.LblForget.Location = new System.Drawing.Point(453, 333);
			this.LblForget.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblForget.Name = "LblForget";
			this.LblForget.Size = new System.Drawing.Size(192, 30);
			this.LblForget.TabIndex = 9;
			this.LblForget.TabStop = true;
			this.LblForget.Text = "ForgetPassword";
			// 
			// BtnSingIn
			// 
			this.BtnSingIn.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSingIn.Location = new System.Drawing.Point(450, 492);
			this.BtnSingIn.Margin = new System.Windows.Forms.Padding(4);
			this.BtnSingIn.Name = "BtnSingIn";
			this.BtnSingIn.Size = new System.Drawing.Size(195, 90);
			this.BtnSingIn.TabIndex = 8;
			this.BtnSingIn.Text = "Sing In";
			this.BtnSingIn.UseVisualStyleBackColor = true;
			this.BtnSingIn.Click += new System.EventHandler(this.BtnSingIn_Click);
			// 
			// BtnLogin
			// 
			this.BtnLogin.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnLogin.Location = new System.Drawing.Point(108, 492);
			this.BtnLogin.Margin = new System.Windows.Forms.Padding(4);
			this.BtnLogin.Name = "BtnLogin";
			this.BtnLogin.Size = new System.Drawing.Size(313, 90);
			this.BtnLogin.TabIndex = 7;
			this.BtnLogin.Text = "Login";
			this.BtnLogin.UseVisualStyleBackColor = true;
			this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Berlin Sans FB", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(100, 319);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(188, 48);
			this.label4.TabIndex = 6;
			this.label4.Text = "Password";
			// 
			// TxtPassword
			// 
			this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TxtPassword.Font = new System.Drawing.Font("Arial", 18F);
			this.TxtPassword.Location = new System.Drawing.Point(108, 381);
			this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.TxtPassword.Multiline = true;
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '*';
			this.TxtPassword.Size = new System.Drawing.Size(537, 75);
			this.TxtPassword.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(100, 149);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(199, 48);
			this.label3.TabIndex = 4;
			this.label3.Text = "Username";
			// 
			// TxtUserName
			// 
			this.TxtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TxtUserName.Font = new System.Drawing.Font("Arial", 18F);
			this.TxtUserName.Location = new System.Drawing.Point(108, 211);
			this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
			this.TxtUserName.Multiline = true;
			this.TxtUserName.Name = "TxtUserName";
			this.TxtUserName.Size = new System.Drawing.Size(537, 75);
			this.TxtUserName.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(750, 351);
			this.panel4.TabIndex = 0;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(1224, 1479);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(1250, 1550);
			this.MinimumSize = new System.Drawing.Size(1250, 1550);
			this.Name = "FrmLogin";
			this.Text = "Market";
			this.panel3.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.LinkLabel LblForget;
		private System.Windows.Forms.Button BtnSingIn;
		private System.Windows.Forms.Button BtnLogin;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxtUserName;
		private System.Windows.Forms.Panel panel4;
	}
}