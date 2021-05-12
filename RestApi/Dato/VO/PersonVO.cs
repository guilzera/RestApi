﻿using System.Text.Json.Serialization;

namespace RestApi.Dato.VO
{
    public class PersonVO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
    }
}