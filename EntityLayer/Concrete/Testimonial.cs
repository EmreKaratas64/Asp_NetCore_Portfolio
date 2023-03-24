using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string ClientName { get; set; }
        public string Company{ get; set; }
        public string Comment{ get; set; }
        public string ImageUrll{ get; set; }
        public bool Active { get; set; }
    }
}
