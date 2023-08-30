using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary.Models
{
    public class AccessType
    {
        public int Id { get; set; }
        public string? AccessDescription { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
