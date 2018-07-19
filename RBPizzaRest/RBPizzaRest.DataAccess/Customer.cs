﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RBPizzaRest.DataAccess
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
    }
}
