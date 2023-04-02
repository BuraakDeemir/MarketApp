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
	public partial class FrmNewAdress : Form
	{
		public int UserId;
		public int CityId = 0;
		User User = new User();
		public FrmNewAdress()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
			int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
			int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 1;
			Size = new Size(w, h);

			List<YeniAdresTablosu> City = User.GetCity(0);
			foreach (var item in City)
			{
				CmbCity.Items.Add(item.SehirIlceMahalleAdi);
			}
		}
		
		private void BtnSave_Click(object sender, EventArgs e)
		{
			if (TxtNewAdress.Text == "" && CmbCity.Text =="" && CmbDistrict.Text =="")
			{
				MessageBox.Show("Lütfen Boş Alanları Doldurunuz.");
			}
			else
			{
                User.AddNewAdress(UserId, TxtNewAdress.Text, CmbCity.SelectedItem.ToString(), CmbDistrict.SelectedItem.ToString());
                MessageBox.Show("İşlem Başarılı");
                this.Close();
            }
			
		}

		private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
		{
			string CityName = CmbCity.SelectedItem.ToString();
			CityId = User.GetCityId(CityName);
			List<YeniAdresTablosu> District = User.GetCity(CityId);
			CmbDistrict.Text = "";
			CmbDistrict.Items.Clear();
			foreach (var item in District)
			{
				CmbDistrict.Items.Add(item.SehirIlceMahalleAdi);
			}
		}
	}
}
