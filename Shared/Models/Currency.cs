using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class Currency
    {
        private int _id;
        private string _name="";
        private string _code="";
        private string _symbol="";
        private int _decimalPlaces;

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
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public string Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }
        public int DecimalPlaces
        {
            get { return _decimalPlaces; }
            set { _decimalPlaces = value; }
        }
    }
}
