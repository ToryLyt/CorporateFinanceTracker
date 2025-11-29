using System.Collections.Generic;
using Shared.Models;

namespace Shared.Services.Interfaces
{
    public interface ITransactionSorter
    {
        List<Transaction> SortByDate(List<Transaction> list, bool ascending);
        List<Transaction> SortByAmount(List<Transaction> list, bool ascending);
        List<Transaction> SortByCategory(List<Transaction> list, bool ascending);
    }
}
