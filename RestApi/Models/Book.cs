using RestApi.Models.Base;
using System;

namespace RestApi.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime LauchDate { get; set; }
    }
}
