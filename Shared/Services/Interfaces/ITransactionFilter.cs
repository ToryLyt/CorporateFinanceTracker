using System;
using System.Collections.Generic;
using Shared.Models;

namespace Shared.Services.Interfaces
{
    public interface ITransactionFilter
    {
        List<Transaction> FilterByDateRange(List<Transaction> list, DateTime from, DateTime to);
        List<Transaction> FilterByStatus(List<Transaction> list, int statusId);
        List<Transaction> FilterByProject(List<Transaction> list, int projectId);
        List<Transaction> FilterByCategory(List<Transaction> list, int categoryId);
        List<Transaction> FilterByAmountRange(List<Transaction> list, decimal min, decimal max);
    }
}
