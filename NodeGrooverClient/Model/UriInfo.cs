using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeGrooverClient.Model
{
    public class UriInfo
    {
        public Category category { get; set; }
    }
    public class Category
    {
        public Meta meta { get; set; }
    }
    public class Meta
    {
        public string filename { get; set; }
    }

}
