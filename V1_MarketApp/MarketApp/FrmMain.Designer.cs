namespace MarketApp
{
	partial class FrmMain
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnAccount = new System.Windows.Forms.Button();
			this.BtnAdress = new System.Windows.Forms.Button();
			this.BtnOrder = new System.Windows.Forms.Button();
			this.BtnBasket = new System.Windows.Forms.Button();
			this.BtnProduct = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.PnlCizgi = new System.Windows.Forms.Panel();
			this.PnlCategory = new System.Windows.Forms.FlowLayoutPanel();
			this.panel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.IndianRed;
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(10, 10);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1954, 306);
			this.panel1.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(30, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(314, 58);
			this.label2.TabIndex = 1;
			this.label2.Text = "Hoşgeldiniz...";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(1430, 170);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(508, 105);
			this.label1.TabIndex = 0;
			this.label1.Text = "MarketApp";
			// 
			// BtnAccount
			// 
			this.BtnAccount.BackColor = System.Drawing.Color.IndianRed;
			this.BtnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAccount.Font = new System.Drawing.Font("Arial", 14F);
			this.BtnAccount.ForeColor = System.Drawing.Color.White;
			this.BtnAccount.Location = new System.Drawing.Point(1300, 33);
			this.BtnAccount.Margin = new System.Windows.Forms.Padding(4);
			this.BtnAccount.Name = "BtnAccount";
			this.BtnAccount.Size = new System.Drawing.Size(240, 100);
			this.BtnAccount.TabIndex = 4;
			this.BtnAccount.Text = "Profilim";
			this.BtnAccount.UseVisualStyleBackColor = false;
			this.BtnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
			// 
			// BtnAdress
			// 
			this.BtnAdress.BackColor = System.Drawing.Color.IndianRed;
			this.BtnAdress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnAdress.Font = new System.Drawing.Font("Arial", 14F);
			this.BtnAdress.ForeColor = System.Drawing.Color.White;
			this.BtnAdress.Location = new System.Drawing.Point(983, 33);
			this.BtnAdress.Margin = new System.Windows.Forms.Padding(4);
			this.BtnAdress.Name = "BtnAdress";
			this.BtnAdress.Size = new System.Drawing.Size(240, 100);
			this.BtnAdress.TabIndex = 3;
			this.BtnAdress.Text = "Adresler";
			this.BtnAdress.UseVisualStyleBackColor = false;
			this.BtnAdress.Click += new System.EventHandler(this.BtnAdress_Click);
			// 
			// BtnOrder
			// 
			this.BtnOrder.BackColor = System.Drawing.Color.IndianRed;
			this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnOrder.Font = new System.Drawing.Font("Arial", 14F);
			this.BtnOrder.ForeColor = System.Drawing.Color.White;
			this.BtnOrder.Location = new System.Drawing.Point(670, 33);
			this.BtnOrder.Margin = new System.Windows.Forms.Padding(4);
			this.BtnOrder.Name = "BtnOrder";
			this.BtnOrder.Size = new System.Drawing.Size(240, 100);
			this.BtnOrder.TabIndex = 2;
			this.BtnOrder.Text = "Siparişler";
			this.BtnOrder.UseVisualStyleBackColor = false;
			this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
			// 
			// BtnBasket
			// 
			this.BtnBasket.BackColor = System.Drawing.Color.IndianRed;
			this.BtnBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBasket.Font = new System.Drawing.Font("Arial", 14F);
			this.BtnBasket.ForeColor = System.Drawing.Color.White;
			this.BtnBasket.Location = new System.Drawing.Point(355, 33);
			this.BtnBasket.Margin = new System.Windows.Forms.Padding(4);
			this.BtnBasket.Name = "BtnBasket";
			this.BtnBasket.Size = new System.Drawing.Size(240, 100);
			this.BtnBasket.TabIndex = 1;
			this.BtnBasket.Text = "Sepet";
			this.BtnBasket.UseVisualStyleBackColor = false;
			this.BtnBasket.Click += new System.EventHandler(this.BtnBasket_Click);
			// 
			// BtnProduct
			// 
			this.BtnProduct.BackColor = System.Drawing.Color.IndianRed;
			this.BtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnProduct.Font = new System.Drawing.Font("Trebuchet MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.BtnProduct.ForeColor = System.Drawing.Color.White;
			this.BtnProduct.Location = new System.Drawing.Point(40, 33);
			this.BtnProduct.Margin = new System.Windows.Forms.Padding(4);
			this.BtnProduct.Name = "BtnProduct";
			this.BtnProduct.Size = new System.Drawing.Size(240, 100);
			this.BtnProduct.TabIndex = 0;
			this.BtnProduct.Text = "Ürünler";
			this.BtnProduct.UseVisualStyleBackColor = false;
			this.BtnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.BackColor = System.Drawing.Color.IndianRed;
			this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnExit.Font = new System.Drawing.Font("Arial", 14F);
			this.BtnExit.ForeColor = System.Drawing.Color.White;
			this.BtnExit.Location = new System.Drawing.Point(1693, 33);
			this.BtnExit.Margin = new System.Windows.Forms.Padding(4);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(233, 100);
			this.BtnExit.TabIndex = 5;
			this.BtnExit.Text = "Çıkış Yap";
			this.BtnExit.UseVisualStyleBackColor = false;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(213)))));
			this.panel2.Controls.Add(this.PnlCizgi);
			this.panel2.Controls.Add(this.BtnAccount);
			this.panel2.Controls.Add(this.BtnExit);
			this.panel2.Controls.Add(this.BtnAdress);
			this.panel2.Controls.Add(this.BtnProduct);
			this.panel2.Controls.Add(this.BtnOrder);
			this.panel2.Controls.Add(this.BtnBasket);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 316);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1954, 173);
			this.panel2.TabIndex = 0;
			// 
			// PnlCizgi
			// 
			this.PnlCizgi.BackColor = System.Drawing.Color.IndianRed;
			this.PnlCizgi.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.PnlCizgi.Location = new System.Drawing.Point(0, 163);
			this.PnlCizgi.Name = "PnlCizgi";
			this.PnlCizgi.Size = new System.Drawing.Size(1954, 10);
			this.PnlCizgi.TabIndex = 6;
			// 
			// PnlCategory
			// 
			this.PnlCategory.BackColor = System.Drawing.Color.IndianRed;
			this.PnlCategory.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlCategory.Location = new System.Drawing.Point(10, 489);
			this.PnlCategory.Name = "PnlCategory";
			this.PnlCategory.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
			this.PnlCategory.Size = new System.Drawing.Size(1954, 110);
			this.PnlCategory.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.AutoScroll = true;
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(10, 599);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.panel3.Size = new System.Drawing.Size(1954, 1211);
			this.panel3.TabIndex = 5;
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(233)))), ((int)(((byte)(213)))));
			this.ClientSize = new System.Drawing.Size(1974, 1820);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.PnlCategory);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximumSize = new System.Drawing.Size(2000, 2000);
			this.MinimumSize = new System.Drawing.Size(2000, 1400);
			this.Name = "FrmMain";
			this.Padding = new System.Windows.Forms.Padding(10);
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "FrmMain";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnProduct;
		private System.Windows.Forms.Button BtnExit;
		private System.Windows.Forms.Button BtnAccount;
		private System.Windows.Forms.Button BtnAdress;
		private System.Windows.Forms.Button BtnOrder;
		private System.Windows.Forms.Button BtnBasket;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.FlowLayoutPanel PnlCategory;
		private System.Windows.Forms.FlowLayoutPanel panel3;
		private System.Windows.Forms.Panel PnlCizgi;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel5;
	}
}