﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Adress : Entity
    {
        public Guid ProviderId { get; set; }
        public string NameStreet { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string CEP { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string  State { get; set; }
        public Provider Provider { get; set; }
    }

}
