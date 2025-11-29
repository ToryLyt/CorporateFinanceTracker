using System;
using System.Collections.Generic;
using Shared.Models;
using Shared.Services.Interfaces;

namespace Shared.Services.Implementations
{
    public class AccountService : IAccountService
    {
        private List<Account> _accounts = new List<Account>();

        public bool Create(Account acc)
        {
            if (acc == null)
                return false;

            acc.Id = _accounts.Count + 1;
            acc.DateCreated = DateTime.Now;
            acc.DateModified = DateTime.Now;
            acc.IsActive = true;

            _accounts.Add(acc);
            return true;
        }

        public bool Update(Account acc)
        {
            if (acc == null || acc.Id <= 0)
                return false;

            for (int i = 0; i < _accounts.Count; i++)
            {
                if (_accounts[i].Id == acc.Id)
                {
                    acc.DateModified = DateTime.Now;
                    _accounts[i] = acc;
                    return true;
                }
            }

            return false;
        }

        public bool Deactivate(int accountId, int userId)
        {
            for (int i = 0; i < _accounts.Count; i++)
            {
                if (_accounts[i].Id == accountId)
                {
                    _accounts[i].IsActive = false;
                    _accounts[i].LastModifiedByUserId = userId;
                    _accounts[i].DateModified = DateTime.Now;
                    return true;
                }
            }

            return false;
        }

        public Account GetById(int id)
        {
            for (int i = 0; i < _accounts.Count; i++)
            {
                if (_accounts[i].Id == id)
                    return _accounts[i];
            }

            return null;
        }

        public List<Account> GetAll()
        {
            return _accounts;
        }
    }
}