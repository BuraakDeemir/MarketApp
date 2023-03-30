using BussinesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApp
{
	public partial class FrmSinIn : Form
	{
		public FrmSinIn()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
			int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
			int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 1;
			Size = new Size(w, h);
		}

		private void BtnSingUp_Click(object sender, EventArgs e)
		{
			if (TxtName.Text == "" || TxtSurname.Text == "" || TxtUsername.Text == "" ||
				TxtPhone.Text == "" || TxtEmail.Text == "" || TxtPasword.Text == "" ||
				TxtPassCheck.Text == "" || TxtAdress.Text == "")
			{
				MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.");
			}
			else if (TxtPasword.Text != TxtPassCheck.Text)
			{
				TxtPasword.Text = "";
				TxtPassCheck.Text = "";
				MessageBox.Show("Lüften Şifrenizi Kontrol Ediniz. \nPassword ve Password Check alanlarına girdiğiniz veriler aynı olmalıdır.");
			}
			else
			{
				User user = new User();
				user.SingUp(TxtName.Text, TxtSurname.Text, TxtUsername.Text,
					TxtPasword.Text, TxtPhone.Text, TxtEmail.Text, TxtAdress.Text);
				MessageBox.Show("Kayıt Eklendi.");
				this.Close();
			}
			

		}
	}
}
