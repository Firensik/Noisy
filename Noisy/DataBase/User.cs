using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noisy.DataBase
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    

        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
