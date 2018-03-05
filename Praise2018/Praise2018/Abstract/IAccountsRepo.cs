using Praise2018.Models;
using System.Linq;

namespace Praise2018.Abstract
{
    public interface IAccountsRepo
    {
       IQueryable<Account> Accounts { get; }
    }
    
}
