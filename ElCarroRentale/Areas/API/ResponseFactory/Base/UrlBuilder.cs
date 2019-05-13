using ElCarroRentale.Interfaces.ResponseFactory.Base;
using Microsoft.AspNetCore.Http;

namespace ElCarroRentale.Areas.API.ResponseFactory.Base
{
    public class UrlBuilder : IUrlBuilder
    {
        public string GetNextPaginated(HttpContext context, int skip, int take)
        {
            var path = context.Request.Host + context.Request.Path.ToString().ToLower();

            if (!path.Contains($"?skip={skip}&take={take}"))
            {
                return path + $"?skip={skip + take}&take={take}";
            }

            return path.Replace($"skip={skip}", $"skip={skip + take}");
        }

        public string GetPreviousPaginated(HttpContext context, int skip, int take)
        {
            var path = context.Request.Host + context.Request.Path.ToString().ToLower();
            
            if (!path.Contains($"?skip={skip}&take={take}"))
            {
                return path + $"?skip={skip - take}&take={take}";
            }

            return path.Replace($"?skip={skip}", $"?skip={skip - take}");
        }

        public bool NextPaginationAvailable(int collectionCount, int skip, int take)
        {
            if (skip == 0)
            {
                return collectionCount > take;
            }

            var returnedCount = skip + take;

            return returnedCount < collectionCount;
        }

        public bool PreviousPaginationAvailable(int skip)
        {
            return skip != 0;
        }

        public string GetSelfUri(HttpContext context, string controllerPath, int entityIdentifier)
        {
            return context.Request.Host + $"/thecapi/{controllerPath}/{entityIdentifier}";
        }
    }
}