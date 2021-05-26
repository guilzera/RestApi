using System.Collections.Generic;

namespace RestApi.Hypermedia.Abstract
{
    public interface iSupportHypermedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
