using System;
using System.Collections.Generic;
using System.Text;
using Shared.Models;

namespace Shared.Services.Interfaces
{
    public interface ITransactionService
    {
        bool Create(Transaction trx);
        bool Update(Transaction trx);
        bool Cancel(int transactionId, int userId);
        Transaction GetById(int id);
        List<Transaction> GetAll();
    }
}
