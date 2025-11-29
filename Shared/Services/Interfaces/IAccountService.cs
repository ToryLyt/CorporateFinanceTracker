using System.Collections.Generic;
using Shared.Models;

namespace Shared.Services.Interfaces
{
    public interface IAccountService
    {
        bool Create(Account acc);
        bool Update(Account acc);
        bool Deactivate(int accountId, int userId);
        Account GetById(int id);
        List<Account> GetAll();
    }
}
