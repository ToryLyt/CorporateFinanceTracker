using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class SubCategory
    {
        private int _id;
        private int _categoryId;
        private string _name = "";
        private string _description = "";

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int CategoryId
        {
            get { return _categoryId; }
            set { _categoryId = value; }
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
