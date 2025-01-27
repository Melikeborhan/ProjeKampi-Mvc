using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }


        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }


        //2-Sen benim ilişkili sınıfındaki CateyoryId alanım olacaksın dedik
        public int CategoryID { get; set; }
        //3-Category sınıfından virtual ıle ilişkili olduğunu belirttik
        public virtual Category Category { get; set; }


        //Bu sefer heading ile Content kısmını ilişkilendireceğiz
        //Heading burada Content sınıfını karsılayacak
        public ICollection<Content> Contents { get; set; }




        //Writer-Heading ilişkisi
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

         


    }
}
