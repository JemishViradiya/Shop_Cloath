using Food2Home_Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F2H_Bussiness
{
    public class Customer_Entity
    {
        DatabaseContext db = new DatabaseContext();
        public List<Customer_Info> Get_List()
        {
            var List = db.Users.ToList();
            return (List);
        }
    }
}
