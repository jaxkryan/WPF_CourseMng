using Finally.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finally
{
    public class GetAccountID
    {
        private static GetAccountID _instance;
        public static GetAccountID Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetAccountID();
                }
                return _instance;
            }
        }

        public int? ID { get; set; }
        public int? Role { get; set; }
        public string Password { get; set; }
    }
}
