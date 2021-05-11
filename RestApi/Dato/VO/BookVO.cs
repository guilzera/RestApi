using System;

namespace RestApi.Dato.VO
{
    public class BookVO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime LauchDate { get; set; }
    }
}
