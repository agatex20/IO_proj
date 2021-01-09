using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Admin : Grown_up
    {
        public Admin() 
        {
            name = "Unlogged";
        }

        public Admin(string name, string password) : base(name, password) { }

        public override void AddToBase(String name, String password,int type)
        {
            using(var db = new Application_context())
            {
                if(type==1)
                {
                    var temp = new Grown_up();
                    temp.name = name;
                    temp.password = password;
                    temp.BalanceId = 1;
                    db.Grown_Ups.Add(temp);
                }
                if(type==2)
                {
                    var temp = new Child();
                    temp.name = name;
                    temp.password = password;
                    temp.newBalanceId();
                    db.Children.Add(temp);
                }
                if(type==3)
                {
                    var temp = new Admin();
                    temp.name = name;
                    temp.password = password;
                    temp.BalanceId = 1;
                    db.Admins.Add(temp);
                }

                db.SaveChanges();
            }
        }

       
    }
}
