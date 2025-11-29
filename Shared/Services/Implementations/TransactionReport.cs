using System.Collections.Generic;
using Shared.Models;
using Shared.Services.Interfaces;

namespace Shared.Services.Implementations
{
    public class TransactionReport : ITransactionReport
    {
        public decimal GetTotalIncome(List<Transaction> list)
        {
            decimal total = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsIncome)
                    total += list[i].Amount;
            }

            return total;
        }

        public decimal GetTotalExpense(List<Transaction> list)
        {
            decimal total = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (!list[i].IsIncome)
                    total += list[i].Amount;
            }

            return total;
        }

        public decimal GetBalance(List<Transaction> list)
        {
            return GetTotalIncome(list) - GetTotalExpense(list);
        }
    }
}
