using Microsoft.AspNetCore.Http;

namespace ElCarroRentale.Interfaces.ResponseFactory.Base
{
    public interface IUrlBuilder
    {
        string GetNextPaginated(HttpContext context, int skip, int take);
        string GetPreviousPaginated(HttpContext context, int skip, int take);
        bool NextPaginationAvailable(int collectionCount, int skip, int take);
        bool PreviousPaginationAvailable(int skip);
        string GetSelfUri(HttpContext context, string controllerPath, int entityIdentifier);
    }
}