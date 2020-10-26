using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace IOWpf.Models
{
    class Expense : Money_flow
    {
        private ImageSource bill_photo;
        private string category;


        public Expense(float amount, string creatorName, string date, string description, bool ifChilds, ImageSource billPhoto, string category) : base(amount, creatorName, date, description, ifChilds)
        {
            bill_photo = billPhoto;
            this.category = category;
        }

        public override void edit()
        {
            base.edit();
        }

        public override bool get_direction()
        {
            return base.get_direction();
        }

        public void add_photo()
        {

        }
    }
}
