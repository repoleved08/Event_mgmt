using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagement.Entities
{

    public class User
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }=string.Empty;
        public string Name { get; set; }=string.Empty;
        public string Email { get; set; }=string.Empty;
    }


}
