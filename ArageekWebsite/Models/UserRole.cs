
using ArageekWebsite.Bases;

namespace ArageekWebsite.Models
{
    public class UserRole : Base
    {
        public string Name { get; set; }
        public List<User> users { get; set; }
    }
}
