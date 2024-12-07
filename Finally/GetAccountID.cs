using Finally.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally
{
    internal class GetAccountID
    {
        public static int? ID { get; set; }

        public static int? Role {  get; set; }
        
        public static string Password { get; set;}
    }
}
