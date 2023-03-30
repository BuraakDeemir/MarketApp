
using BussinesLayer;
using DataLayers;

namespace MarketWinForm
{
	public partial class FrmLogin : Form
	{
		Kullanici kullanici;
		VWKisiKullanici KisiKullanici;
		public FrmLogin()
		{
			InitializeComponent();
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			string KullaniciAdi = TxtUserName.Text;
			string Sifre = TxtPasword.Text;	
			if (kullanici == null)
			{
				kullanici = new Kullanici();
			}
			KisiKullanici = kullanici.DoGiris(KullaniciAdi, Sifre);
			if (KisiKullanici != null)
			{
				FrmMain frmMain = new FrmMain();
				frmMain.ShowDialog();
			}


		}
	}
}