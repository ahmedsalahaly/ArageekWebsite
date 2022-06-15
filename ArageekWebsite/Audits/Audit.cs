using ArageekWebsite.Bases;

namespace ArageekWebsite.Audits
{
    public class Audit : Base
    {
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; } = DateTime.Now;
    }
}
