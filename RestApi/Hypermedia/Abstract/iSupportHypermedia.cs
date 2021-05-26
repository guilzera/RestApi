using System.Collections.Generic;

namespace RestApi.Hypermedia.Abstract
{
    public interface iSupportHyperMedia
    {
        List<HyperMediaLink> Links { get; set; }
    }
}
