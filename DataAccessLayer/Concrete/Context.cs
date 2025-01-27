using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext 
    {

        //baska katmanın sınıfını methodunu propunu kullanmak ıstıyrosan o katmanı buraya referans olarak eklemek zorundayız.
        public DbSet<About> Abouts { get; set; }  //abouts verıtabanındaki tablo ısmı about ıse proje sınıfı ıcınde yer alan ısmıdır.

        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Content> Contents { get; set; }

        public DbSet<Heading> Headings { get; set; }

        public DbSet<Writer> Writers { get; set; }



    }
}
