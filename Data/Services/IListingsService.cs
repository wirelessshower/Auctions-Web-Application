using Auctions.Models;

namespace Auctions.Data.Services
{
    public interface IListingsService
    {
        IQueryable<Listing> GetAll();
        Task Add(Listing listing);
        Task<Listing> GetByID(int? id);
        Task SaveChanges();
    }
}
