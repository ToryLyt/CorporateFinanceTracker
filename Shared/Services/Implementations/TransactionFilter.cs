using System;
using System.Collections.Generic;
using Shared.Models;
using Shared.Services.Interfaces;

namespace Shared.Services.Implementations
{
    public class TransactionFilter : ITransactionFilter
    {
        public List<Transaction> FilterByDateRange(List<Transaction> list, DateTime from, DateTime to)
        {
            List<Transaction> result = new List<Transaction>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].TrxDate >= from && list[i].TrxDate <= to)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }

        public List<Transaction> FilterByStatus(List<Transaction> list, int statusId)
        {
            List<Transaction> result = new List<Transaction>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].StatusId == statusId)
                    result.Add(list[i]);
            }

            return result;
        }

        public List<Transaction> FilterByProject(List<Transaction> list, int projectId)
        {
            List<Transaction> result = new List<Transaction>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProjectId == projectId)
                    result.Add(list[i]);
            }

            return result;
        }

        public List<Transaction> FilterByCategory(List<Transaction> list, int categoryId)
        {
            List<Transaction> result = new List<Transaction>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CategoryId == categoryId)
                    result.Add(list[i]);
            }

            return result;
        }

        public List<Transaction> FilterByAmountRange(List<Transaction> list, decimal min, decimal max)
        {
            List<Transaction> result = new List<Transaction>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Amount >= min && list[i].Amount <= max)
                    result.Add(list[i]);
            }

            return result;
        }
    }
}