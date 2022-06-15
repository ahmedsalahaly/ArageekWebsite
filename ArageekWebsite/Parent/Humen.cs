using ArageekWebsite.Audits;

namespace ArageekWebsite.Parent
{
    public class Humen : Audit
    {
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public string? Mobile { get; set; }
        public DateTime? BirthDay { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
