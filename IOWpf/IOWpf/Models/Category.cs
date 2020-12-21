using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOWpf.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string Category_name { get; set; }
        public virtual ICollection<Expense_Category> Expense_Categories { get; set; }    
        
        /*
         * zwraca listę stringów z wszystkimi kategoriami wczytanymi z bazy danych - zamiast ,,globalnej" list z main window wczytywać liste ta metoda
         */
        public List<string> getList()
        {
            List<String> catlist = new List<string>();

            using (var db = new Application_context())
            {
                List<Category> cats = new List<Category> { };
                cats = db.Categories.ToList();
                for (int i = 0; i < cats.Count(); i++)
                {
                    catlist.Add(cats[i].Category_name);
                }
            }

            return catlist;
        }


        public void addCategory(String catname)
        {
            using (var db = new Application_context())
            {
                Category category = new Category();
                category.Category_name = catname;
                db.Categories.Add(category);
                db.SaveChanges();
            }
        }
    }
}
