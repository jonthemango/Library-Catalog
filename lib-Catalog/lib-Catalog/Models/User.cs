﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lib_Catalog.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Password_hash { get; set; }

        public bool IsActive { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhysicalAddress { get; set;}

        public string Email { get; }

        public string PhoneNumber { get; set; }
    }
}