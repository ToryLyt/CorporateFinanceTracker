using System.Collections.Generic;
using Shared.Models;
using Shared.Services.Interfaces;

namespace Shared.Services.Implementations
{
    public class TransactionSorter : ITransactionSorter
    {
        public List<Transaction> SortByDate(List<Transaction> list, bool ascending)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    var swap = ascending
                        ? list[j].TrxDate > list[j + 1].TrxDate
                        : list[j].TrxDate < list[j + 1].TrxDate;

                    if (swap)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }

        public List<Transaction> SortByAmount(List<Transaction> list, bool ascending)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    var swap = ascending
                        ? list[j].Amount > list[j + 1].Amount
                        : list[j].Amount < list[j + 1].Amount;

                    if (swap)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }

        public List<Transaction> SortByCategory(List<Transaction> list, bool ascending)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    var swap = ascending
                        ? list[j].CategoryId > list[j + 1].CategoryId
                        : list[j].CategoryId < list[j + 1].CategoryId;

                    if (swap)
                    {
                        var temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
        }
    }
}
