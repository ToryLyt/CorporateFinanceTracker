using System;
using System.Collections.Generic;
using System.Text;

namespace Shared.Models
{
    public class Account
    {
        private int _id;
        private string _name = "";
        private int _currencyId;
        private int _departmentId;
        private int _ownerUserId;

        private decimal _balance;

        private DateTime _dateCreated;
        private DateTime _dateModified;

        private int _createdByUserId;
        private int _lastModifiedByUserId;

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
        public int CurrencyId
        {
            get { return _currencyId; }
            set { _currencyId = value; }
        }
        public int DepartmentId
        {
            get { return _departmentId; }
            set { _departmentId = value; }
        }

        public int OwnerUserId
        {
            get { return _ownerUserId; }
            set { _ownerUserId = value; }
        }
        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public DateTime DateCreated
        {
            get { return _dateCreated; }
            set { _dateCreated = value; }
        }
        public DateTime DateModified
        {
            get
            {
                return _dateModified;
            }
            set { _dateModified = value; }
        }
        public int CreatedByUserId
        {
            get
            {
                return _createdByUserId;
            }
            set { _createdByUserId = value; }
        }
        public int LastModifiedByUserId
        {
            get { return _lastModifiedByUserId; }
            set { _lastModifiedByUserId = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
    }
}
