using System;
using System.Collections.Generic;
using Shared.Models;
using Shared.Services.Interfaces;

namespace Shared.Services.Implementations
{
    public class TransactionService : ITransactionService
    {
        private List<Transaction> _transactions = new List<Transaction>();

        public bool Create(Transaction trx)
        {
            if (trx == null)
            {
                return false;
            }

            trx.Id = _transactions.Count + 1;
            trx.DateCreated = DateTime.Now;
            trx.DateModified = DateTime.Now;

            _transactions.Add(trx);
            return true;
        }

        public bool Update(Transaction trx)
        {
            if (trx == null || trx.Id <= 0)
            {
                return false;
            }

            for (int i = 0; i < _transactions.Count; i++)
            {
                if (_transactions[i].Id == trx.Id)
                {
                    trx.DateModified = DateTime.Now;
                    _transactions[i] = trx;
                    return true;
                }
            }

            return false;
        }

        public bool Cancel(int transactionId, int userId)
        {
            for (int i = 0; i < _transactions.Count; i++)
            {
                if (_transactions[i].Id == transactionId)
                {
                    _transactions[i].StatusId = 5;
                    _transactions[i].LastModifiedByUserId = userId;
                    _transactions[i].DateModified = DateTime.Now;
                    return true;
                }
            }

            return false;
        }

        public Transaction GetById(int id)
        {
            for (int i = 0; i < _transactions.Count; i++)
            {
                if (_transactions[i].Id == id)
                    return _transactions[i];
            }

            return null;
        }

        public List<Transaction> GetAll()
        {
            return _transactions;
        }
    }
}