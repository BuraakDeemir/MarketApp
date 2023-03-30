using BussinesLayer;
using BussinesLayer.Concrete;
using DataLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketApp_V2
{
	public partial class FrmMain : Form
	{
		public int UserId = 1;
		public int CategoryId;
		Category category = new Category();
		Basket basket = new Basket();
		TblSepet Basket = new TblSepet();
		Order order = new Order();
		Form PeiceForm;
		Form FrmOrderDetails;
		User user = new User();
		int Counter = 1;
		private static DbInfoTechSales_NewEntities Context;
		public FrmMain()
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
			Rectangle screen = Screen.FromPoint(Cursor.Position).WorkingArea;
			int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 1;
			int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 1;
			//Location = new Point(screen.Left + (screen.Width - w) / 2, screen.Top + (screen.Height - h) / 2);
			Size = new Size(w, h);
			Context = new DbInfoTechSales_NewEntities();
			ShowCategories();
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnProduct_Click(object sender, EventArgs e)
		{
			PnlCategory.Controls.Clear();
			ShowCategories(); //'Ürünler' Butonu...
		}

		private void LblCategory_Click(object sender, EventArgs e)
		{
			ShowProductByCategories(sender);
		}

		private void BtnProductAdd_Click(object sender, EventArgs e)
		{
			SetOrderPiece(sender); // Ürünler Altında Oluşturulan 'Sepete Ekle' Butonu...
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			// 'Sepete Ekle' Butonuna tıklandığında adet bilgisinin sorulduğu form sayfasındaki 'Ekle' Butonu...
			if (sender is Button)
			{
				Button Sender = sender as Button;
				Sender.DialogResult = DialogResult.OK;
				Form ParentForm = Sender.Parent as Form;
			}
		}

		private void BtnBasket_Click(object sender, EventArgs e)
		{
			int BasketCount = basket.BasketCount(UserId);
			if (BasketCount <= 0)
				ShowBasketFreeInfo(); // Sepet Boş ise bu method çalışır...
			else
				ShowBasketDetails(); // Sepette bulunan Ürünleri Listeler...
		}

		private void BtnOrderOk_Click(object sender, EventArgs e)
		{
			// Sepet sayfasında bulunan 'Sipariş Ver / Onayla' Butonuna toklandığında bu alan çalışır ve kullanıcının siparişi alınır.
			// Bu buton 'ShowBasketDetails' methodu içerisinde dinamik olarak oluşturulmuştur.
			DialogResult DR = MessageBox.Show("Siparişi Onaylıyormusunuz ?", "Sipariş Onayı", MessageBoxButtons.YesNo);
			if (DR == DialogResult.Yes)
			{
				order.OrderAdd(UserId);
				BtnBasket.PerformClick();
			}

		}

		private void BtnAllBasketDelete_Click(object sender, EventArgs e)
		{
			// Sepet sayfasında bulunan 'Tümünü Sil' Butonuna tıklandığında bu alan Çalışır ve Sepette bulunan tüm ürünler silinir.
			// Bu buton 'ShowBasketDetails' methodu içerisinde dinamik olarak oluşturulmuştur.
			DialogResult DR = MessageBox.Show("Sepetteki Tüm Ürünler Silinsin mi?", "Tüm Sepeti Silme", MessageBoxButtons.YesNo);
			if (DR == DialogResult.Yes)
			{
				basket.DeleteAllBasketByUserId(UserId);
				BtnBasket.PerformClick();
			}
		}

		private void BtnDeleteProduct_Click(object sender, EventArgs e)
		{
			// Sepet sayfasında bulunan 'Ürünü Sil' Butonuna tıklandığında bu alan Çalışır ve bağlı olduğu ürün sepetten silinir.
			// Bu buton 'ShowBasketDetails' methodu içerisinde dinamik olarak oluşturulmuştur.
			Button BTN = sender as Button;
			int BasketId = Convert.ToInt32(BTN.Name);
			basket.DeleteBasketbyBasketId(BasketId);
			BtnBasket.PerformClick();
		}

		private void BtnOrder_Click(object sender, EventArgs e)
		{
			{
				int OrderCount = order.OrderCount(UserId);
				if (OrderCount <= 0)
					ShowOrderFreeInfo(); // Daha önce verilen bir sipariş yok ise bu method çalışır...
				else
					ShowOrderDetails(); //Kullanıcının vermiş olduğu siparişleri listelemek için bu method çalışır...
			}
		}

		private void BtnOrderDetails_Click(object sender, EventArgs e)
		{
			OpenOrderDetailsForm(sender); // Sipariş Detay Buttonu...
		}
		private void BtnClose_Click(object sender, EventArgs e)
		{
			// 'OpenOrderDetailsForm' methodu içerisinde dinamik olarak oluşturulur
			// Sipariş detaylarının gösterildiği form sayfasının kapatılmasını sağlar.
			if (sender is Button)
			{
				Button Sender = sender as Button;
				Sender.DialogResult = DialogResult.OK;
				Form ParentForm = Sender.Parent as Form;
			}
		}

		private void BtnAdress_Click(object sender, EventArgs e)
		{
			panel3.Controls.Clear();
			panel3.Width = 600;


			Button BtnAdressAdd = new Button();
			BtnAdressAdd.Text = " + Yeni Adres";
			BtnAdressAdd.Name = "BtnAdressAdd";
			BtnAdressAdd.FlatStyle = FlatStyle.Flat;
			BtnAdressAdd.Width = 120;
			BtnAdressAdd.Height = 40;
			BtnAdressAdd.Margin = new Padding(15,20,0,15);
			BtnAdressAdd.BackColor = Color.FromArgb(92, 60, 187);
			BtnAdressAdd.Parent = panel3;
			BtnAdressAdd.Font = new Font("Arial", 11);
			BtnAdressAdd.ForeColor = Color.White;
			BtnAdressAdd.Click += BtnAdressAdd_Click;



			int AdressCount = user.AdressCount(UserId);
			if (AdressCount <= 0)
				ShowAdressFreeInfo(); // Sistemde Kayıtlı bir adres Bulunmuyor ise Bu Mehod Çalışır...
			else
				ShowAdressDetails(); // Kullanıcının sistemde kayıtlı olan adreslerini göstermek için bu method çalışır.
		}

		private void BtnUpdateAdress_Click(object sender, EventArgs e)
		{
			// Bu buton 'ShowAdressDetails' methodu içerisinde dinamik olarak oluşturlmuştur.
			Button BTN = sender as Button;
			FrmUpdateAdress FrmUpdateAdress = new FrmUpdateAdress();
			FrmUpdateAdress.AdressId = Convert.ToInt32(BTN.Name);
			FrmUpdateAdress.ShowDialog();
			BtnAdress.PerformClick();
			Refresh();
		}

		private void BtnAdressAdd_Click(object sender, EventArgs e)
		{
			// Bu buton 'ShowAdressDetails' methodu içerisinde dinamik olarak oluşturulmuştur.
			FrmNewAdress frmNewAdress = new FrmNewAdress();
			frmNewAdress.UserId = UserId;
			frmNewAdress.ShowDialog();
			BtnAdress.PerformClick();
		}

		private void BtnDeleteAdress_Click(object sender, EventArgs e)
		{
			// Bu buton 'ShowAdressDetails' methodu içerisinde dinamik olarak oluşturulmuştur.
			Button BTN = sender as Button;
			int AdressId = Convert.ToInt32(BTN.Name);
			user.DeleteAdressById(AdressId);
			BtnAdress.PerformClick();
		}

		private void BtnAccount_Click(object sender, EventArgs e)
		{
			// Kullanıcı Menüden 'Profil' buttonuna tıkladığında seçili panel içerisinde 'FrmProfil' isimli formu açar.
			panel3.Controls.Clear();
			FrmProfil frmProfil = new FrmProfil();
			frmProfil.TopLevel = false;
			frmProfil.UserId = UserId;
			panel3.Controls.Add(frmProfil);
			frmProfil.Show();
		}

		//-------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Bu method, 'FrmMain isimli formda Menüdeki 'Ürünler' Buttonuna
		/// tıklandığında Açılır Menü İçerisinde Ürünlerin Bağlı Bulunduğu
		/// Kategorileri Gösterir.
		/// </summary>
		private void ShowCategories()
		{
			foreach (var item in Context.TblKategori)
			{
				Counter = 2;
				LinkLabel LblCategory = new LinkLabel();
				LblCategory.Text = item.KategoriAdi;
				LblCategory.Name = item.KategoriId.ToString();
				LblCategory.AutoSize = true;

				LblCategory.Parent = PnlCategory;
				LblCategory.Dock = DockStyle.Left;
				LblCategory.ForeColor = Color.White;
				//LblCategory.Margin = new Padding(20, 20, 0, 20);
				LblCategory.Font = new Font("Arial", 14,FontStyle.Bold);
				LblCategory.LinkColor = Color.White;
				LblCategory.Click += LblCategory_Click;
				LblCategory.LinkBehavior = LinkBehavior.NeverUnderline;

				Label LBL = new Label();
				LBL.Text ="";
				LBL.Name = item.KategoriId.ToString();
				LBL.Width = 50;
				LBL.Parent = PnlCategory;
				LBL.Dock = DockStyle.Left;

			}
		}
		//-------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Bu Method Kategoriler Menüsünden Seçilen Kategoriye Bağlı Bulunan
		/// Ürünleri Listeler. Ürünler Döngü Yardımı ile Görüntülenir. Döngü İçerisinde
		/// Ürünler Listelenirken her ürün için dinamik olarak 'Sepete Ekle' Butonunu
		/// oluşturulur.'Sepete Ekle' butonu tetiklendiğinde 'SetOrderPiece' isimli method çalışır.
		/// </summary>
		private void ShowProductByCategories(object sender)
		{
			panel3.Controls.Clear();
			Label LBL = sender as Label;
			CategoryId = Convert.ToInt32(LBL.Name);
			List<VWUrunVeKategoriler> result = category.CategoryShowById(CategoryId);
			foreach (var item in result)
			{
				FlowLayoutPanel PnlProductCard = new FlowLayoutPanel();
				PnlProductCard.FlowDirection = FlowDirection.TopDown;
				PnlProductCard.Height = 140;
				PnlProductCard.Width = 127;
				PnlProductCard.Name = (item.UrunId).ToString();
				PnlProductCard.Parent = panel3;
				PnlProductCard.Margin = new Padding(5, 5, 5, 20);
				PnlProductCard.Padding = new Padding(0, 5, 0, 0);
				PnlProductCard.BackColor = Color.FromArgb(92, 60, 187);

				Panel pnlImg = new Panel();
				pnlImg.Height = 55;
				pnlImg.Width = 117;
				pnlImg.Margin = new Padding(5, 0, 5, 10);
				pnlImg.Name = (item.UrunKodu).ToString();
				pnlImg.BackColor = Color.FromArgb(251,211,12);
				PnlProductCard.Controls.Add(pnlImg);

				Label lblProductName = new Label();
				lblProductName.Height = 20;
				lblProductName.Width = 110;
				lblProductName.Margin = new Padding(5, 0, 5, 0);
				lblProductName.Font = new Font("Arial", 9);
				lblProductName.Name = (item.UrunAdi).ToString();
				lblProductName.ForeColor = Color.White;
				lblProductName.Text = (item.UrunAdi).ToString();
				PnlProductCard.Controls.Add(lblProductName);

				Label lblProductprice = new Label();
				lblProductprice.Height = 20;
				lblProductprice.Width = 110;
				lblProductprice.Margin = new Padding(5, 0, 5, 0);
				lblProductprice.Name = (item.BirimFiyat).ToString();
				lblProductprice.ForeColor = Color.White;
				lblProductprice.Font = new Font("Arial", 8);
				lblProductprice.Text = ("Fiyat : " + (item.BirimFiyat) + " TL").ToString();
				PnlProductCard.Controls.Add(lblProductprice);

				Button BtnProductAdd = new Button();
				BtnProductAdd.Width = 117;
				BtnProductAdd.Height = 25;
				BtnProductAdd.FlatStyle = FlatStyle.Flat;
				BtnProductAdd.Name = item.UrunId.ToString();
				BtnProductAdd.Text = "Ekle";
				BtnProductAdd.Dock= DockStyle.Right;
				BtnProductAdd.Font = new Font("Arial", 9);
				BtnProductAdd.ForeColor = Color.White;
				BtnProductAdd.Margin = new Padding(5, 0, 5, 5);
				BtnProductAdd.Click += BtnProductAdd_Click;
				PnlProductCard.Controls.Add(BtnProductAdd);
			}
		}
		//-------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Kullanıcı 'Sepete Ekle' butona tıkladığında bir form sayfası açılır ve kullanıcıdan seçmiş 
		/// olduğu üründen sepete kaç adet eklemek istediği bilgisi alınır. Adet bilgisi Alındıktan sonra
		/// BussinesLayer/Concrete/Basket.cs adresindeki 'AddProductToBasket' fonksiyonu kullanılarak
		/// ürün kullanıcının Sepetine Eklenir.
		/// </summary>
		private void SetOrderPiece(object sender)
		{
			int BasketId = 0;
			Button BTN = sender as Button;
			Basket.SepetTarihi = DateTime.Now;
			BasketId = basket.CreateBasket(Basket);
			int ProductId = Convert.ToInt32(BTN.Name);
			List<TblUrun> Product = basket.ShowProductByProductId(ProductId);

			PeiceForm = new Form();
			PeiceForm.StartPosition = FormStartPosition.CenterParent;
			PeiceForm.BackColor = Color.FromArgb(92, 60, 187);
			PeiceForm.Width = 320;
			PeiceForm.Height = 200;
			PeiceForm.MinimizeBox = false;
			PeiceForm.MaximizeBox = false;

			FlowLayoutPanel PnlPiece = new FlowLayoutPanel();
			PnlPiece.Dock = DockStyle.Fill;
			PnlPiece.Parent = PeiceForm;
			PnlPiece.Padding = new Padding(20);

			Label LblPiece = new Label();
			LblPiece.Name = "lblAdet";
			LblPiece.Text = "Lütfen Adet Girin: ";
			LblPiece.Font = new Font("Arial", 13);
			LblPiece.Width = 260;
			LblPiece.Height = 30;
			LblPiece.ForeColor = Color.White;
			LblPiece.Parent = PnlPiece;


			NumericUpDown NmrPiece = new NumericUpDown();
			NmrPiece.Width = 260;
			NmrPiece.Parent = PnlPiece;
			NmrPiece.Font = new Font("Arial", 13);

			Button BtnAdd = new Button();
			BtnAdd.Text = "Ekle";
			BtnAdd.Width = 260;
			BtnAdd.Height = 50;
			BtnAdd.Parent = PnlPiece;
			BtnAdd.Font = new Font("Arial", 13);
			BtnAdd.ForeColor = Color.White;
			BtnAdd.DialogResult = DialogResult.OK;
			BtnAdd.Click += BtnAdd_Click;
			DialogResult dr = PeiceForm.ShowDialog();
			if (dr == DialogResult.OK)
			{
				if (NmrPiece.Value > 0)
				{
					decimal Piece = NmrPiece.Value;
					decimal UnitPrice = Convert.ToDecimal(Product[0].BirimFiyat);
					decimal Sub = UnitPrice * Piece;
					double Tax = Convert.ToDouble(Product[0].KdvOrani);
					double TaxTotal = Convert.ToDouble(Sub) * Convert.ToDouble(Tax);
					basket.AddProductToBasket(new TblSepetDetay()
					{
						KisiId = UserId,
						SepetId = BasketId,
						UrunId = ProductId,
						Adet = NmrPiece.Value,
						BirimFiyat = UnitPrice,
						AraToplam = Sub,
						KdvOrani = Tax,
						KdvToplami = TaxTotal.ToString(),
					});
				}
				else if (NmrPiece.Value <= 0)
					MessageBox.Show("Girilen Adet 0'dan Küçük Olamaz.");
			}
		}
		//-------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Kullanı Menüden 'Sepet' butonuna tıkladığında sepete önceden eklenmiş bir ürün yoksa 'Sepette ürün bulunmamaktadır'
		/// bilgisini göstermek için bu method çalıştırılır.
		/// </summary>
		private void ShowBasketFreeInfo()
		{
			panel3.Controls.Clear();
			FlowLayoutPanel BasketFree = new FlowLayoutPanel();
			BasketFree.BackColor = Color.FromArgb(92, 60, 187);
			BasketFree.Name = "BasketFree";
			BasketFree.Margin = new Padding(15, 0, 0, 0);
			BasketFree.Parent = panel3;
			BasketFree.Width = 800;
			BasketFree.Height = 200;

			Label LblBasketFree = new Label();
			LblBasketFree.Margin = new Padding(0, 0, 0, 5);
			LblBasketFree.Name = "LblBasketFree";
			LblBasketFree.Text = "Sepette Ürün Bulunmamaktadır.";
			LblBasketFree.Font = new Font("Arial", 20);
			LblBasketFree.Width = 800;
			LblBasketFree.Height = 200;
			LblBasketFree.TextAlign = ContentAlignment.MiddleCenter;
			LblBasketFree.ForeColor = Color.White;
			LblBasketFree.Parent = BasketFree;
		}

		//-------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Kullancı menüden 'Sepet' butonuna tıkladığında sepette bulunan ürünleri listeler.
		/// method içerisinde dinamik olarak oluşturulmuş buttonlarda mevcuttur. Butonların işlevleri
		/// aşağıda açıklanmıştır.
		/// Tümünü Sil = Bu buton tetiklendiğinde öncesinde sepete eklenen tüm ürünler silinir.
		/// Sepeti Onayla / Sipariş Ver = Bu buton tetiklendiğinde sepette bulunan tüm ürünler sipariş olarak alınır ve sepet listesi sıfırlanır.
		/// Ürünü Sil = Bu buton sepet içerisinde her ürün için dinamik olarak oluşturulur ve tetiklendiğinde bağlı bulunduğu ürünü siler.
		/// </summary>
		private void ShowBasketDetails()
		{
			panel3.Controls.Clear();
			panel3.Width = 600;
			List<VwBasket> result = basket.GetBasketByUserId(UserId);
			Button BtnAllBasketDelete = new Button();
			BtnAllBasketDelete.Text = "Tümünü Sil";
			BtnAllBasketDelete.Name = "BtnAllBasketDelete";
			BtnAllBasketDelete.FlatStyle = FlatStyle.Flat;
			BtnAllBasketDelete.Width = 120;
			BtnAllBasketDelete.Height = 40;
			BtnAllBasketDelete.Margin = new Padding(15, 15, 50, 15);
			BtnAllBasketDelete.BackColor = Color.FromArgb(92, 60, 187);
			BtnAllBasketDelete.Parent = panel3;
			BtnAllBasketDelete.Font = new Font("Arial", 11);
			BtnAllBasketDelete.ForeColor = Color.White;
			BtnAllBasketDelete.Click += BtnAllBasketDelete_Click;

			Button BtnOrderOk = new Button();
			BtnOrderOk.Text = "Sepeti Onayla / Sipariş Ver";
			BtnOrderOk.Name = "BtnAllBasketDelete";
			BtnOrderOk.FlatStyle = FlatStyle.Flat;
			BtnOrderOk.Width = 200;
			BtnOrderOk.Height = 40;
			BtnOrderOk.Margin = new Padding(0, 15, 50, 0);
			BtnOrderOk.BackColor = Color.FromArgb(92, 60, 187);
			BtnOrderOk.Parent = panel3;
			BtnOrderOk.Font = new Font("Arial", 11);
			BtnOrderOk.ForeColor = Color.White;
			BtnOrderOk.Click += BtnOrderOk_Click;
			foreach (var item in result)
			{
				FlowLayoutPanel PnlBasket = new FlowLayoutPanel();
				PnlBasket.BackColor = Color.FromArgb(92, 60, 187);
				PnlBasket.Name = item.UrunAdi;
				PnlBasket.Margin = new Padding(15, 0, 0, 20);
				PnlBasket.Parent = panel3;
				PnlBasket.Width = 800;
				PnlBasket.Height = 200;

				FlowLayoutPanel PnlBasketLeft = new FlowLayoutPanel();
				PnlBasketLeft.BackColor = Color.FromArgb(92, 60, 187);
				PnlBasketLeft.Padding = new Padding(10, 10, 10, 10);
				PnlBasketLeft.Name = item.UrunAdi;
				PnlBasketLeft.Parent = PnlBasket;
				PnlBasketLeft.Width = 400;
				PnlBasketLeft.Height = 200;

				FlowLayoutPanel PnlBasketRight = new FlowLayoutPanel();
				PnlBasketRight.BackColor = Color.FromArgb(92, 60, 187);
				PnlBasketRight.Padding = new Padding(10, 10, 10, 10);
				PnlBasketRight.Name = item.UrunAdi;
				PnlBasketRight.Parent = PnlBasket;
				PnlBasketRight.Width = 200;
				PnlBasketRight.Height = 200;


				Label LblProductName = new Label();
				LblProductName.Margin = new Padding(0, 0, 0, 5);
				LblProductName.Name = item.UrunId.ToString();
				LblProductName.Text = item.UrunAdi;
				LblProductName.Font = new Font("Arial", 13);
				LblProductName.Width = 260;
				LblProductName.Height = 30;
				LblProductName.ForeColor = Color.White;
				LblProductName.Parent = PnlBasketLeft;

				Label LblProductPiece = new Label();
				LblProductPiece.Margin = new Padding(0, 0, 0, 5);
				LblProductPiece.Name = item.UrunId.ToString();
				LblProductPiece.Text = "Adet : " + item.Adet.ToString();
				LblProductPiece.Font = new Font("Arial", 11);
				LblProductPiece.Width = 260;
				LblProductPiece.Height = 30;
				LblProductPiece.ForeColor = Color.White;
				LblProductPiece.Parent = PnlBasketLeft;

				Label LblUnitPrice = new Label();
				LblUnitPrice.Margin = new Padding(0, 0, 0, 5);
				LblUnitPrice.Name = item.UrunId.ToString();
				LblUnitPrice.Text = "Birim Fiyatı : " + item.BirimFiyat.ToString() + " TL";
				LblUnitPrice.Font = new Font("Arial", 11);
				LblUnitPrice.Width = 260;
				LblUnitPrice.Height = 30;
				LblUnitPrice.ForeColor = Color.White;
				LblUnitPrice.Parent = PnlBasketLeft;

				Label LblTotalTax = new Label();
				LblTotalTax.Margin = new Padding(0, 0, 0, 5);
				LblTotalTax.Name = item.UrunId.ToString();
				LblTotalTax.Text = "Vergiler Toplamı : " + item.KdvToplami.ToString() + " TL";
				LblTotalTax.Font = new Font("Arial", 11);
				LblTotalTax.Width = 260;
				LblTotalTax.Height = 30;
				LblTotalTax.ForeColor = Color.White;
				LblTotalTax.Parent = PnlBasketLeft;

				Label LblSub = new Label();
				LblSub.Margin = new Padding(0, 0, 0, 5);
				LblSub.Name = item.UrunId.ToString();
				double Sub = Convert.ToDouble(Convert.ToDouble(item.AraToplam) + Convert.ToDouble(item.KdvToplami));
				LblSub.Text = "Toplam : " + Sub.ToString() + " TL";
				LblSub.Font = new Font("Arial", 11);
				LblSub.Width = 260;
				LblSub.Height = 30;
				LblSub.ForeColor = Color.White;
				LblSub.Parent = PnlBasketLeft;

				Button BtnDeleteProduct = new Button();
				BtnDeleteProduct.Text = "Ürünü Sil";
				BtnDeleteProduct.Name = item.SepetId.ToString();
				BtnDeleteProduct.FlatStyle = FlatStyle.Flat;
				BtnDeleteProduct.Width = 100;
				BtnDeleteProduct.Height = 40;
				BtnDeleteProduct.BackColor = Color.FromArgb(92, 60, 187);
				BtnDeleteProduct.Parent = PnlBasketRight;
				BtnDeleteProduct.Font = new Font("Arial", 11);
				BtnDeleteProduct.ForeColor = Color.White;
				BtnDeleteProduct.Click += BtnDeleteProduct_Click;
			}
		}
		//-------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Kullanı Menüden 'Siparişler' butonuna tıkladığında önceden verilmiş bir sipariş yoksa 'Sipariş bulunmamaktadır'
		/// bilgisini göstermek için bu method çalıştırılır.
		/// </summary>
		private void ShowOrderFreeInfo()
		{
			panel3.Controls.Clear();
			FlowLayoutPanel BasketFree = new FlowLayoutPanel();
			BasketFree.BackColor = Color.FromArgb(92, 60, 187);
			BasketFree.Name = "BasketFree";
			BasketFree.Margin = new Padding(15, 0, 0, 0);
			BasketFree.Parent = panel3;
			BasketFree.Width = 800;
			BasketFree.Height = 200;

			Label LblBasketFree = new Label();
			LblBasketFree.Margin = new Padding(0, 0, 0, 5);
			LblBasketFree.Name = "LblBasketFree";
			LblBasketFree.Text = "Sipariş Bulunmamaktadır.";
			LblBasketFree.Font = new Font("Arial", 20);
			LblBasketFree.Width = 800;
			LblBasketFree.Height = 200;
			LblBasketFree.TextAlign = ContentAlignment.MiddleCenter;
			LblBasketFree.ForeColor = Color.White;
			LblBasketFree.Parent = BasketFree;
		}

		//-------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Kullanı Menüden 'Siparişler' butonuna tıkladığında sipariş geçmişi listelenir. 
		/// Listelen her sipariş için 'Sipariş Detay' isimli dinamik bir button oluşturulmuştur. Bu buton bağlı bulunduğu
		/// siparişin içeriğini bir form sayfasında listeler.
		/// </summary>
		private void ShowOrderDetails()
		{
			panel3.Controls.Clear();
			panel3.Width = 600;
			List<VwOrder> result = order.GetOrderByPersonId(UserId);
			foreach (var item in result)
			{
				FlowLayoutPanel PnlOrder = new FlowLayoutPanel();
				PnlOrder.BackColor = Color.FromArgb(92, 60, 187);
				PnlOrder.Name = item.OrderId.ToString();
				PnlOrder.Margin = new Padding(15, 0, 0, 15);
				PnlOrder.Parent = panel3;
				PnlOrder.Width = 800;
				PnlOrder.Height = 230;

				FlowLayoutPanel PnlOrderLeft = new FlowLayoutPanel();
				PnlOrderLeft.BackColor = Color.FromArgb(92, 60, 187);
				PnlOrderLeft.Padding = new Padding(10, 10, 10, 10);
				PnlOrderLeft.Name = item.OrderId.ToString();
				PnlOrderLeft.Parent = PnlOrder;
				PnlOrderLeft.Width = 400;
				PnlOrderLeft.Height = 230;

				FlowLayoutPanel PnlOrderRight = new FlowLayoutPanel();
				PnlOrderRight.BackColor = Color.FromArgb(92, 60, 187);
				PnlOrderRight.Padding = new Padding(10, 10, 10, 10);
				PnlOrderRight.Name = item.OrderId.ToString();
				PnlOrderRight.Parent = PnlOrder;
				PnlOrderRight.Width = 300;
				PnlOrderRight.Height = 230;

				Button BtnOrderDetails = new Button();
				BtnOrderDetails.Text = "Sipariş Detay";
				BtnOrderDetails.Name = item.OrderId.ToString();
				BtnOrderDetails.FlatStyle = FlatStyle.Flat;
				BtnOrderDetails.Width = 150;
				BtnOrderDetails.Height = 40;
				BtnOrderDetails.Margin = new Padding(120, 70, 0, 0);
				BtnOrderDetails.BackColor = Color.FromArgb(92, 60, 187);
				BtnOrderDetails.Parent = PnlOrderRight;
				BtnOrderDetails.Font = new Font("Arial", 11);
				BtnOrderDetails.ForeColor = Color.White;
				BtnOrderDetails.Click += BtnOrderDetails_Click;

				Label LblOrderId = new Label();
				LblOrderId.Margin = new Padding(0, 0, 0, 5);
				LblOrderId.Name = item.OrderId.ToString();
				LblOrderId.Text = "Sipariş Numarası : " + item.OrderId.ToString();
				LblOrderId.Font = new Font("Arial", 13);
				LblOrderId.Width = 260;
				LblOrderId.Height = 30;
				LblOrderId.ForeColor = Color.White;
				LblOrderId.Parent = PnlOrderLeft;

				Label LblOrderDate = new Label();
				LblOrderDate.Margin = new Padding(0, 0, 0, 5);
				LblOrderDate.Name = item.OrderId.ToString();
				LblOrderDate.Text = "Tarih : " + item.CreateDate.ToString();
				LblOrderDate.Font = new Font("Arial", 11);
				LblOrderDate.Width = 260;
				LblOrderDate.Height = 30;
				LblOrderDate.ForeColor = Color.White;
				LblOrderDate.Parent = PnlOrderLeft;

				Label LblSub = new Label();
				LblSub.Margin = new Padding(0, 0, 0, 5);
				LblSub.Name = item.OrderId.ToString();
				LblSub.Text = "Ara Toplam : " + item.AraToplam.ToString() + " TL";
				LblSub.Font = new Font("Arial", 11);
				LblSub.Width = 260;
				LblSub.Height = 30;
				LblSub.ForeColor = Color.White;
				LblSub.Parent = PnlOrderLeft;

				Label LblTotalTax = new Label();
				LblTotalTax.Margin = new Padding(0, 0, 0, 5);
				LblTotalTax.Name = item.OrderId.ToString();
				LblTotalTax.Text = "Vergiler Toplamı : " + item.Vergiler.ToString() + " TL";
				LblTotalTax.Font = new Font("Arial", 11);
				LblTotalTax.Width = 260;
				LblTotalTax.Height = 30;
				LblTotalTax.ForeColor = Color.White;
				LblTotalTax.Parent = PnlOrderLeft;

				Label LblTotal = new Label();
				LblTotal.Margin = new Padding(0, 0, 0, 5);
				LblTotal.Name = item.OrderId.ToString();
				LblTotal.Text = "Toplam : " + item.Toplam.ToString() + " TL";
				LblTotal.Font = new Font("Arial", 11);
				LblTotal.Width = 260;
				LblTotal.Height = 30;
				LblTotal.ForeColor = Color.White;
				LblTotal.Parent = PnlOrderLeft;

				Label LblStatution = new Label();
				LblStatution.Margin = new Padding(0, 0, 0, 5);
				LblStatution.Name = item.OrderId.ToString();
				LblStatution.Text = "Sipariş Durumu : " + item.Situation.ToString();
				LblStatution.Font = new Font("Arial", 11);
				LblStatution.Width = 260;
				LblStatution.Height = 30;
				LblStatution.ForeColor = Color.White;
				LblStatution.Parent = PnlOrderLeft;
			}
		}
		//-------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// 'ShowOrderDetails' methodu içerisinde dinamik olarak oluşturulan 'Sipariş Detay' butonuna tıklandığında bir form sayfasının
		/// açılmasını sağlar ve form içerisinde bağlı bulunduğu siparişin detaylarını gösterir.
		/// </summary>
		private void OpenOrderDetailsForm(object sender)
		{
			Button BTN = sender as Button;
			int OrderId = Convert.ToInt32(BTN.Name);
			List<TblOrderDetails> TblOrderDetails = order.GetOrderDetailsByOrderId(OrderId);
			PeiceForm = new Form();
			PeiceForm.StartPosition = FormStartPosition.CenterParent;
			PeiceForm.BackColor = Color.FromArgb(92, 60, 187);
			PeiceForm.Width = 350;
			PeiceForm.Height = 300;
			PeiceForm.MinimizeBox = false;
			PeiceForm.MaximizeBox = false;

			FlowLayoutPanel PnlOrderDetails = new FlowLayoutPanel();
			PnlOrderDetails.Dock = DockStyle.Fill;
			PnlOrderDetails.Parent = PeiceForm;
			PnlOrderDetails.Padding = new Padding(20);
			PnlOrderDetails.AutoScroll = true;

			Label LblPiece = new Label();
			LblPiece.Name = "lblAdet";
			LblPiece.Text = "Sipariş Detay : ";
			LblPiece.Font = new Font("Arial", 13);
			LblPiece.Width = 260;
			LblPiece.Height = 30;
			LblPiece.ForeColor = Color.White;
			LblPiece.Parent = PnlOrderDetails;

			foreach (var item in TblOrderDetails)
			{
				Label LblOrderName = new Label();
				LblOrderName.Name = "lblAdet";
				LblOrderName.Text = order.ShowProductByProductId((int)item.ProductId);
				LblOrderName.Font = new Font("Arial", 13);
				LblOrderName.Width = 260;
				LblOrderName.Height = 30;
				LblOrderName.ForeColor = Color.White;
				LblOrderName.Parent = PnlOrderDetails;
			}

			Button BtnClose = new Button();
			BtnClose.Text = "Kapat";
			BtnClose.Width = 260;
			BtnClose.Height = 50;
			BtnClose.Parent = PnlOrderDetails;
			BtnClose.Location = new Point(50, 469);
			BtnClose.Font = new Font("Arial", 13);
			BtnClose.ForeColor = Color.White;
			BtnClose.DialogResult = DialogResult.OK;
			BtnClose.Click += BtnClose_Click;
			DialogResult dr = PeiceForm.ShowDialog();
		}

		//-------------------------------------------------------------------------------------------------------------------

		/// <summary>
		/// Kullanıcı Menüden 'Adresler' butonuna tıkladığında Sistemde kayıtlı bir adres bulunmuyor ise 
		/// 'Sistemde Kayıtlı Adresiniz Bulunmamaktadır.' bilgisini göstermek için bu method çalışır...
		/// </summary>
		private void ShowAdressFreeInfo()
		{
			FlowLayoutPanel AdressFree = new FlowLayoutPanel();
			AdressFree.BackColor = Color.FromArgb(92, 60, 187);
			AdressFree.Name = "AdressFree";
			AdressFree.Margin = new Padding(15, 0, 0, 0);
			AdressFree.Parent = panel3;
			AdressFree.Width = 800;
			AdressFree.Height = 200;

			Label LblAdressFree = new Label();
			LblAdressFree.Margin = new Padding(0, 0, 0, 5);
			LblAdressFree.Name = "LblAdressFree";
			LblAdressFree.Text = "Sistemde Kayıtlı Adresiniz Bulunmamaktadır.";
			LblAdressFree.Font = new Font("Arial", 20);
			LblAdressFree.Width = 800;
			LblAdressFree.Height = 200;
			LblAdressFree.TextAlign = ContentAlignment.MiddleCenter;
			LblAdressFree.ForeColor = Color.White;
			LblAdressFree.Parent = AdressFree;
		}

		/// <summary>
		/// Kullancı menüden 'Adresler' butonuna tıkladığında Sistemde Kayıtlı olan adresler listeler.
		/// method içerisinde dinamik olarak oluşturulmuş buttonlarda mevcuttur. Butonların işlevleri
		/// aşağıda açıklanmıştır.
		/// Sil = Bu buton tetiklendiğinde bağlı bulunduğu adres bilgilerini sistemden siler.
		/// Düzenle = Bu buton tetiklendiğinde bağlı bulunduğu adres bilgilerinin düzenlenmesi için dinamik bir form sayfası açılır.
		/// </summary>
		private void ShowAdressDetails()
		{
			List<TblKisiAdres> TblPersonAdress = user.GetAdressById(UserId);
			foreach (var item in TblPersonAdress)
			{
				FlowLayoutPanel PnlAdress = new FlowLayoutPanel();
				PnlAdress.BackColor = Color.FromArgb(92, 60, 187);
				PnlAdress.Name = item.AdresId.ToString();
				PnlAdress.Margin = new Padding(15, 0, 0, 20);
				PnlAdress.Parent = panel3;
				PnlAdress.Width = 800;
				PnlAdress.Height = 100;


				FlowLayoutPanel PnlAdressLeft = new FlowLayoutPanel();
				PnlAdressLeft.BackColor = Color.FromArgb(92, 60, 187);
				PnlAdressLeft.Name = item.AdresId.ToString();
				PnlAdressLeft.Margin = new Padding(10, 10, 10, 10);
				PnlAdressLeft.Parent = PnlAdress;
				PnlAdressLeft.Width = 90;
				PnlAdressLeft.Height = 100;

				FlowLayoutPanel PnlAdressCenter = new FlowLayoutPanel();
				PnlAdressCenter.BackColor = Color.FromArgb(92, 60, 187);
				PnlAdressCenter.Name = item.AdresId.ToString();
				PnlAdressCenter.Margin = new Padding(10, 10, 10, 10);
				PnlAdressCenter.Parent = PnlAdress;
				PnlAdressCenter.Width = 350;
				PnlAdressCenter.Height = 100;

				FlowLayoutPanel PnlAdressRight = new FlowLayoutPanel();
				PnlAdressRight.BackColor = Color.FromArgb(92, 60, 187);
				PnlAdressRight.Name = item.AdresId.ToString();
				PnlAdressRight.Margin = new Padding(10, 10, 10, 10);
				PnlAdressRight.Parent = PnlAdress;
				PnlAdressRight.Width = 230;
				PnlAdressRight.Height = 100;

				Label LblAdress = new Label();
				LblAdress.Margin = new Padding(10, 20, 0, 15);
				LblAdress.AutoSize = true;
				LblAdress.Name = item.AdresId.ToString();
				LblAdress.Text = "Adres : ";
				LblAdress.Font = new Font("Arial", 13);
				LblAdress.Width = 260;
				LblAdress.Height = 30;
				LblAdress.ForeColor = Color.White;
				LblAdress.Parent = PnlAdressLeft;

				Label LblAdressText = new Label();
				LblAdressText.Margin = new Padding(10, 20, 0, 15);
				LblAdressText.AutoSize = true;
				LblAdressText.Name = item.AdresId.ToString();
				LblAdressText.Text = (item.City + " | " +  item.District + " | " + item.Adres);
				LblAdressText.Font = new Font("Arial", 13);
				LblAdressText.Width = 260;
				LblAdressText.Height = 30;
				LblAdressText.ForeColor = Color.White;
				LblAdressText.Parent = PnlAdressCenter;

				Button BtnDeleteAdress = new Button();
				BtnDeleteAdress.Margin = new Padding(30, 20, 0, 0);
				BtnDeleteAdress.Text = "Sil";
				BtnDeleteAdress.Name = item.AdresId.ToString();
				BtnDeleteAdress.FlatStyle = FlatStyle.Flat;
				BtnDeleteAdress.Width = 60;
				BtnDeleteAdress.Height = 40;
				BtnDeleteAdress.BackColor = Color.FromArgb(92, 60, 187);
				BtnDeleteAdress.Parent = PnlAdressRight;
				BtnDeleteAdress.Font = new Font("Arial", 11);
				BtnDeleteAdress.ForeColor = Color.White;
				BtnDeleteAdress.Click += BtnDeleteAdress_Click;

				Button BtnUpdateAdress = new Button();
				BtnUpdateAdress.Margin = new Padding(20, 20, 0, 0);
				BtnUpdateAdress.Text = "Düzenle";
				BtnUpdateAdress.Name = item.AdresId.ToString();
				BtnUpdateAdress.FlatStyle = FlatStyle.Flat;
				BtnUpdateAdress.Width = 100;
				BtnUpdateAdress.Height = 40;
				BtnUpdateAdress.BackColor = Color.FromArgb(92, 60, 187);
				BtnUpdateAdress.Parent = PnlAdressRight;
				BtnUpdateAdress.Font = new Font("Arial", 11);
				BtnUpdateAdress.ForeColor = Color.White;
				BtnUpdateAdress.Click += BtnUpdateAdress_Click;
			}
		}

	
	}
}
