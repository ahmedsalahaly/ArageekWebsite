using ArageekWebsite.Audits;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArageekWebsite.Models
{
    public class Artical : Audit
    {
        public string ArticalName { get; set; }
        public string Body { get; set; }
        public bool IsDisplay { get; set; }
        public int AutherId { get; set; }
        [ForeignKey("AutherId")]
        public Auther auther { get; set; }
        public int CategoreyId { get; set; }
        [ForeignKey("CategoreyId")]
        public Category category { get; set; }
    }
}
