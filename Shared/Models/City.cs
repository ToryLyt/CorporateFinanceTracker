using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class City
    {
        private int _id;
        private string _name;
        private int _countryId;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int CountryId
        {
            get { return _countryId; }
            set { _countryId = value; }
        }
    }
}
