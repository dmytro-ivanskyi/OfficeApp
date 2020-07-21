using System.Collections.Generic;

namespace OfficeApp.Domain
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int OfficeId { get; set; }
        public Office Office { get; set; }
        public List<Task> Tasks { get; set; }
        public List<UserPermission> UserPermissions { get; set; }
    }
}
