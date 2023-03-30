
using DataLayers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
	public class User : BaseUser
	{
		private static DbInfoTechSales_NewEntities Context;
		public User()
		{
			Context = new DbInfoTechSales_NewEntities();
		}

		public override void AddNewAdress(int PersonId, string Adress,string City,string District)
		{
			TblKisiAdres TblAdressForAdd = new TblKisiAdres()
			{
				KisiId = PersonId,
				Adres = Adress,
				City = City,
				District = District
			};
			Context.TblKisiAdres.Add(TblAdressForAdd);
			Context.SaveChanges();
		}
		public override List<YeniAdresTablosu> GetCity(int AdressId)
		{
			return (from data in Context.YeniAdresTablosu
				   where data.UstID== AdressId
				   select data).ToList();
		}
		public override int GetCityId(string CityName)
		{
			var CityId = (from data in Context.YeniAdresTablosu
					where data.SehirIlceMahalleAdi == CityName
					select data).FirstOrDefault();
			return CityId.ID;
		}

		public override int AdressCount(int PersonId)
		{
			return (from data in Context.TblKisiAdres
					where
					data.KisiId == PersonId
					select data).ToList().Count();
		}

		public override void DeleteAdressById(int AdressId)
		{
			TblKisiAdres TblPersonAdressForDelete = (from data in Context.TblKisiAdres
													 where
													 data.AdresId == AdressId
													 select data).SingleOrDefault();
			Context.TblKisiAdres.Remove(TblPersonAdressForDelete);
			Context.SaveChanges();
		}

		public override List<TblKisiAdres> GetAdressById(int PersonId)
		{
			return (from data in Context.TblKisiAdres
					where
					data.KisiId == PersonId
					select data).ToList();
		}

		public override VwProfilShow GetProfilShow(int PersonId)
		{
			return (from data in Context.VwProfilShow
					where
					data.PersonId == PersonId
					select data).FirstOrDefault();
		}

		public override VWKisiKullanici Login(string UserName, string Password)
		{
			return (from data in Context.VWKisiKullanici
					where
					data.KullaniciAdi == UserName &&
					data.Sifre == Password
					select data).SingleOrDefault();
		}

		public override TblKisiAdres ShowAdressForUpdate(int AdressId)
		{
			return (from data in Context.TblKisiAdres
					where
					data.AdresId == AdressId
					select data).SingleOrDefault();
		}

		

		public override void SingUp(string Name, string Surname, string UserName, string Pass, string Phone, string Email, string Adress, string City,string District)
		{
			DateTime CreateDate = DateTime.Now;
			TblKisi tblPersonAdd = new TblKisi()
			{
				Ad = Name,
				Soyad = Surname,
				CreateDate = CreateDate,
			};
			Context.TblKisi.Add(tblPersonAdd);
			Context.SaveChanges();
			int PersonId = tblPersonAdd.KisiId;
			TblKullanici TblUserAdd = new TblKullanici()
			{
				KisiId = PersonId,
				KullaniciAdi = UserName,
				Sifre = Pass,
				SonGirisTarihi = CreateDate,
				KayitTarihi = CreateDate,

			};
			Context.TblKullanici.Add(TblUserAdd);
			Context.SaveChanges();
			TblKisiTelefon TblUserPhoneAdd = new TblKisiTelefon()
			{
				KisiId = PersonId,
				Telefon = Phone,
			};
			Context.TblKisiTelefon.Add(TblUserPhoneAdd);
			Context.SaveChanges();
			TblKisiAdres TblUserAdressAdd = new TblKisiAdres()
			{
				KisiId = PersonId,
				Adres = Adress,
				City = City,
				District = District,
			};
			Context.TblKisiAdres.Add(TblUserAdressAdd);
			Context.SaveChanges();
			TblEmail TblEmailAdd = new TblEmail()
			{
				KisiId = PersonId,
				Email = Email,
			};
			Context.TblEmail.Add(TblEmailAdd);
			Context.SaveChanges();
		}

		public override void UpdateAdress(int AdressId, string Adress, string City, string District)
		{
			var DataAdress = Context.TblKisiAdres.FirstOrDefault(p => p.AdresId == AdressId);
			int XUserId = DataAdress.KisiId.Value;
			Context.TblKisiAdres.Remove(DataAdress);
			TblKisiAdres tblKisiAdres = new TblKisiAdres()
			{
				KisiId = XUserId,
				Adres = Adress,
				City = City,
				District = District,
			};
			Context.TblKisiAdres.Add(tblKisiAdres);
			Context.SaveChanges();
		}
	}
}
