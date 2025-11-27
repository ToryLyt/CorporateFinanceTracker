using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class User
    {
        private int _id;
        private string _name;
        private string _surname;
        private DateTime _birthDate;
        private DateTime _dateCreated;
        private string _login;
        private string _email;
        private string _password;
        private string _phone;
        private int _addressId;

        private int _roleId;
        private int _positionId;
        private int _departmentId;

        private bool _isActive;


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

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }        
        }

        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { _dateCreated = value; }
        }

        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public int AddressId
        {
            get { return _addressId; }
            set { _addressId = value; }
        }
        
        public int RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }
        public int PositionId
        {
            get { return _positionId; }
            set { _positionId = value; }
        }
        public int DepartmentId
        {
            get { return _departmentId; }
            set { _departmentId = value; }
        }
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public string FullName
        {
            get { return $"{_name} {_surname}"; }
        }
    }
}
