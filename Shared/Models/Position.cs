using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class Position
    {
        private int _id;
        private string _name="";
        private string _description="";

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
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
