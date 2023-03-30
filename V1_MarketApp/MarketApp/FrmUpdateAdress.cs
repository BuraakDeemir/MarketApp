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
	public partial class FrmUpdateAdress : Form
	{
		public int AdressId;
		User User = new User();
		public FrmUpdateAdress()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
			int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
			int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 1;
			Size = new Size(w, h);
		}

		private void BtnSave_Click(object sender, EventArgs e)
		{
			User.UpdateAdress(AdressId, TxtAdress.Text);
			MessageBox.Show("İşlem Başarılı");
			this.Close();
		}

		private void FrmUpdateAdress_Load(object sender, EventArgs e)
		{
			TblKisiAdres tblKisiAdres = User.ShowAdressForUpdate(AdressId);
			TxtAdress.Text = tblKisiAdres.Adres.ToString();
		}
	}
}
