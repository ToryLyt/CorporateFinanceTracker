using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Shared.Models
{
    public class Project
    {
        private int _id;
        private string _name="";
        private string _description="";
        private bool _isActive=true;

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
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
    }
}
