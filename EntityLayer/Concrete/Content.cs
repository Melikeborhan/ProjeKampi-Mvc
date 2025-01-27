using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
      
        public DateTime ContentDate { get; set; }

        //Bire çok ilişki için ICollection kullanılır


        //Burada Heading-Content ile ilişkisi

        //heading ile ilişkili olacak HeadinID alanı
        public int HeadingID { get; set; }
        //Burada Heading ile ilişkili olacak
        public virtual Heading Heading { get; set; }


        //Burada Writer-Content ile ilişkisi
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }



    }
}
