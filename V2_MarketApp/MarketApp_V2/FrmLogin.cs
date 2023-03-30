using BussinesLayer;
using DataLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApp_V2
{
	public partial class FrmLogin : Form
	{
		User user;
		VWKisiKullanici userAccount;
		public FrmLogin()
		{
			InitializeComponent();

			StartPosition = FormStartPosition.CenterScreen;
			Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
			int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 1;
			int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 1;
			//Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
			Size = new Size(w, h);
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			string UserName = TxtUserName.Text;
			string Password = TxtPassword.Text;
			if (user == null)
			{
				user = new User();
			}
			userAccount = user.Login(UserName, Password);
			if (userAccount != null)
			{
				FrmMain frmMain = new FrmMain();
				frmMain.UserId = userAccount.KullaniciId;
				this.Hide();
				frmMain.ShowDialog();
			}
			else
			{
				MessageBox.Show("Kayıt Bulunamadı.");
			}

		}

		private void BtnSingIn_Click(object sender, EventArgs e)
		{
			FrmSinIn frmSinIn = new FrmSinIn();
			frmSinIn.Show();
		}

		private void TxtUserName_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
