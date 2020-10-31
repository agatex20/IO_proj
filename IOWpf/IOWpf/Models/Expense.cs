using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace IOWpf.Models
{
    public class Expense : Money_flow
    {
        public int ExpenseId { get; set; }
        public int? UserId { get; set; }                             // Foreign key 
        public virtual User User { get; set; }                       // Expense is associated with one User

        //private ImageSource bill_photo { get; set; }

        public virtual ICollection<Category> Categories { get; set; }


        public Expense() { }

        public Expense(float amount, string creatorName, string date, string description, bool ifChilds /*ImageSource billPhoto,*/) : base(amount, creatorName, date, description, ifChilds)
        {
            //bill_photo = billPhoto;
            
        }

    }
}
