using System;
using System.Collections.Generic;
using Shared.Models;

namespace Shared.Services.Interfaces
{
    public interface ITransactionReport
    {
        decimal GetTotalIncome(List<Transaction> list);
        decimal GetTotalExpense(List<Transaction> list);
        decimal GetBalance(List<Transaction> list);
    }
}