using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Praise2018.Models;

namespace Praise2017.Concrete
{
    public class EFDbContext : DbContext
    {
       
        //两个表名 Accounts,Details
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}