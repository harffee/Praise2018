using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Praise2018.Models;

namespace Praise2018.Controllers
{
    public class HomeController : Controller
    {
        //获取当前登录用户
        string user = System.Environment.UserName;

        //加载StartPage页面
        public ViewResult StartPage()
        {
            return View();
        }

        private EFDbContext db = new EFDbContext();


        public PartialViewResult DetailList()
        {
            var query = from b in db.Details
                            //orderby b.UpdateDate
                        select b;

            return PartialView(query);
        }

        
        //显示本月排行
        public PartialViewResult TopPraise()
        {
            
            int month = DateTime.Now.Month;
            IEnumerable<string> member = from b in db.Accounts
                            select b.Name;
            string[] people = member.ToArray();
            //创建一个数组用来存储本月的用户名及Got数量
            string[][] rank = new string[people.Length][];
            for (int i=0;i< people.Length;i++)
            {
                rank[i][0] = people[i];
                rank[i][1] = (from b in db.Details
                              
                              where b.Name == people[i]
                              select b).Count().ToString();
            }
            //对rank数组排序
            for (int i = 0; i < people.Length; i++)
            {
                rank[i][1] = rank.OrderBy(s => s.rank[i][1]);
            }
            
            
            return PartialView(ViewBag.rank);
        }

        ////显示当前用户信息
        public PartialViewResult PerInfo()
        {
            //得到赞总数
            //发出赞总数
            //当前用户角色 都要被显示
            var info = from b in db.Accounts
                       where b.Alias == user
                       select b;
            return PartialView(info);
        }

        //查询用户

        //Make Praise
        public PartialViewResult Praise()
        {
            var member = from b in db.Accounts
                                         select b;
           
            return PartialView(member);
        }

        

    }
}