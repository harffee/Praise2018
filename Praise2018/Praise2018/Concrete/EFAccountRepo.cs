using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Praise2018.Abstract;
using Praise2018.Models;

namespace Praise2018.Concrete
{
    public class EFAccountRepo:IAccountsRepo
    {
        //context用于接收数据库的数据
        private EFDbContext context = new EFDbContext();
       
        public IQueryable<Account> Accounts
        {
            get { return context.Accounts; }
        }

        
    }
    
}