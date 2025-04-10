﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }


        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurname { get; set; }

        [StringLength(100)]
        public string WriterImage { get; set; }

        [StringLength(50)]
        public string WriterMail { get; set; }

        [StringLength(20)]
        public string WriterPassword { get; set; }



        //Bire çok ilişki için ICollection kullanılır


        //Writer-Heading ilişkisi
        public ICollection<Heading> Headings { get; set; }



        //Writer-Content ilişkisi
        public ICollection<Content> Contents { get; set; }

    }
}
