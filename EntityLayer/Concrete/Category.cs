using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool  CategoryStatus { get; set; }


        //1-Category sınıfında ICollectıon türünde bir property tanımladık ve sen Heading sınıfıyla ilişkili olacaksın dedik.
        public ICollection<Heading> Headings { get; set; }

    }
}
