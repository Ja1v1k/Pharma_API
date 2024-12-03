﻿using System.ComponentModel.DataAnnotations;

namespace Pharma.Model
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Dob {  get; set; }
        public string Zipcode { get; set; }
        public string Mobile { get; set; }
    }
}