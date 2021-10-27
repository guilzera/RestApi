using RestApi.Hypermedia;
using RestApi.Hypermedia.Abstract;
using System;
using System.Collections.Generic;

namespace RestApi.Dato.VO
{
    public class BookVO : ISupportsHyperMedia
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public DateTime LauchDate { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}
