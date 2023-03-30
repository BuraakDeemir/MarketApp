
using DataLayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer
{
	public abstract class BaseUser
	{
		public abstract VWKisiKullanici Login(string UserName, string Password);
		public abstract void SingUp(string Name,string Surname,string UserName,string Pass,string Phone,string Email,string Adress, string City, string District);

		public abstract List<TblKisiAdres> GetAdressById(int PersonId);

		public abstract List<YeniAdresTablosu> GetCity(int AdressId);
		public abstract int GetCityId(string CityName);
		public abstract void DeleteAdressById(int AdressId);

		public abstract int AdressCount(int PersonId);

		public abstract void AddNewAdress(int PersonId, string Adress, string City, string District);

		public abstract void UpdateAdress(int AdressId, string Adress,string City, string District);
		public abstract TblKisiAdres ShowAdressForUpdate(int AdressId);

		public abstract VwProfilShow GetProfilShow(int PersonId);
	}
}
