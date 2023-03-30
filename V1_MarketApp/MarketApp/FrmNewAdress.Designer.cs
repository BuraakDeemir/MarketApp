namespace MarketApp
{
	partial class FrmNewAdress
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtNewAdress = new System.Windows.Forms.TextBox();
			this.BtnSave = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TxtNewAdress);
			this.groupBox1.Font = new System.Drawing.Font("Berlin Sans FB", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(50, 46);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(870, 475);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "New Adress";
			// 
			// TxtNewAdress
			// 
			this.TxtNewAdress.Location = new System.Drawing.Point(25, 71);
			this.TxtNewAdress.Multiline = true;
			this.TxtNewAdress.Name = "TxtNewAdress";
			this.TxtNewAdress.Size = new System.Drawing.Size(812, 376);
			this.TxtNewAdress.TabIndex = 0;
			// 
			// BtnSave
			// 
			this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnSave.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnSave.ForeColor = System.Drawing.Color.White;
			this.BtnSave.Location = new System.Drawing.Point(240, 597);
			this.BtnSave.Name = "BtnSave";
			this.BtnSave.Size = new System.Drawing.Size(480, 117);
			this.BtnSave.TabIndex = 1;
			this.BtnSave.Text = "Save Adress";
			this.BtnSave.UseVisualStyleBackColor = true;
			this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// FrmNewAdress
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(974, 806);
			this.Controls.Add(this.BtnSave);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximumSize = new System.Drawing.Size(1000, 877);
			this.MinimumSize = new System.Drawing.Size(1000, 877);
			this.Name = "FrmNewAdress";
			this.Text = "New Adress";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox TxtNewAdress;
		private System.Windows.Forms.Button BtnSave;
	}
}