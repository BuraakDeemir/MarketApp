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

namespace MarketApp
{
	public partial class FrmProfil : Form
	{
		public int UserId;
		User user = new User();
		public FrmProfil()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
			int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
			int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 1;
			//Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
			Size = new Size(w, h);

		}

		private void FrmProfil_Load(object sender, EventArgs e)
		{
			VwProfilShow vwProfilShow = user.GetProfilShow(UserId);
			TxtName.Text = vwProfilShow.Name;
			TxtSurname.Text = vwProfilShow.Surname;
			TxtUsername.Text = vwProfilShow.Username;
			TxtPasword.Text = vwProfilShow.Pass;
			TxtEmail.Text = vwProfilShow.UserEmail;
			TxtPhone.Text = vwProfilShow.Phone;
		}
	}
}
