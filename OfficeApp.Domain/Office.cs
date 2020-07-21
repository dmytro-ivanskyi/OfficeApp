using System.Collections.Generic;

namespace OfficeApp.Domain
{
    public class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
