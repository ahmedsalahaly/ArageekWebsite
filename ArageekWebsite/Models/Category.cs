using ArageekWebsite.Audits;

namespace ArageekWebsite.Models
{
    public class Category : Audit
    {
        public bool IsDisplay { get; set; }
        public List<Artical> articals { get; set; }
    }
}
