using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class Address
    {
        private int _id;
        private int _countryId;
        private int _cityId;
        private string _street;
        private int _houseNum;
        private int _apartment;
        private string _postalCode;

        public int Id
        {
            get { return _id; } 
            set {  _id = value; }
        }

        public int CountryId
        {
            get { return _countryId; }
            set { _countryId = value; }
        }
        public int CityId
        {
            get { return _cityId; }
            set { _cityId = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public int HouseNum
        {
            get { return _houseNum; }
            set { _houseNum = value; }
        }

        public int Apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
        }

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }
    }
}
