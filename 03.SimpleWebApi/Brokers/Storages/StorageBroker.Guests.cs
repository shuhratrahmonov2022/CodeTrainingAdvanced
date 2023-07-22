//===========================
// Header File 
//
//===========================

using _03.SimpleWebApi.Models.Foundations.Guests;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading.Tasks;

namespace _03.SimpleWebApi.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Guest>Guests { get; set; }

        public async ValueTask<Guest> InsertGuestAsync(Guest guest)
        {
            using var broker = new StorageBroker(this.configuration);

            EntityEntry<Guest> guestEntityEntry = await broker.Guests.AddAsync(guest);

            await broker.SaveChangesAsync();

            return guestEntityEntry.Entity;
        }
    }
}
