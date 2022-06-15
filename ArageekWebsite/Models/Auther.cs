using ArageekWebsite.Parent;

namespace ArageekWebsite.Models
{
    public class Auther : Humen
    {
        public string Bio { get; set; }
        public List<Artical> articals { get; set; }
    }
}
