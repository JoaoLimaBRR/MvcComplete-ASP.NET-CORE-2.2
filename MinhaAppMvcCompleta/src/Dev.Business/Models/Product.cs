using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Product : Entity
    {
        public Guid ProviderId { get; set; }
        public string Name { get; set; }
        public string Describe { get; set; }
        public string Image { get; set; }
        public decimal Value { get; set; }
        public DateTime RegistrationSDate { get; set; }
        /* EF Relation */
        public Provider Provider { get; set; }
    }
}
