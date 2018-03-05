using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Praise2018.Models;
using Praise2018.Abstract;


namespace Praise2018.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin
        private IAccountsRepo repo;
        public AccountController (IAccountsRepo accountRepo)
        {
            this.repo = accountRepo;
        }
        public PartialViewResult UserList()
        {
            
                //取出Name和头像
                //var member = from b in db.Accounts

                             //select b;

           // IEnumerable people = member.ToArray();
           // IEnumerable people = new IEnumerable(member);
                return PartialView(repo);
            
        }

       
    }
}
