using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AccountMemberDAO
    {
        public static AccountMember CheckExist(string username, string password)
        {
            CourseManagementDbContext _context = new CourseManagementDbContext();
            AccountMember accountMember = _context.AccountMembers.FirstOrDefault(u => u.Username == username && u.Password == password);
            return accountMember;
        }
    }
}
