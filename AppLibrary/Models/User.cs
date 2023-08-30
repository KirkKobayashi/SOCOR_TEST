using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class User
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public int AccessTypeId { get; set; }
        public AccessControlType MyProperty { get; set; }
    }
}
