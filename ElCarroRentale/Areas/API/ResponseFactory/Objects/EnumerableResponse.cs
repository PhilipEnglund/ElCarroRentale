using System.Collections.Generic;

namespace ElCarroRentale.Areas.API.ResponseFactory.Objects
{
    public class EnumerableResponse<TResource>
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public string Previous { get; set; }
        public IEnumerable<TResource> Results { get; set; }
    }
}