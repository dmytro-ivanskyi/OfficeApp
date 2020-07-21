using System.Collections.Generic;

namespace OfficeApp.Domain
{
    public class Permission
    {
        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string Descripssion { get; set; }
        public List<UserPermission> UserPermissions { get; set; }
    }
}
