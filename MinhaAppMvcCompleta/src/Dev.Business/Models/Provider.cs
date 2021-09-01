using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Provider : Entity
    {
        public string Name{ get; set; }
        public string Document { get; set; }
        public ProviderType ProviderType { get; set; }
        public Adress Adress { get; set; }
        public bool Active { get; set; }
        /* EF Relation */
        public IEnumerable<Product> Products { get; set; }

    }


}
