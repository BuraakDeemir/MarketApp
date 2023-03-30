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
	public partial class FrmNewAdress : Form
	{
		public int UserId;
		User User = new User();
		public FrmNewAdress()
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
			User.AddNewAdress(UserId, TxtNewAdress.Text);
			MessageBox.Show("İşlem Başarılı");
			this.Close();
		}
	}
}
