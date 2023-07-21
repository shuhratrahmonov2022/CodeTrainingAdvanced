using _03.SimpleWebApi.Models.Foundations.Guests;
using Microsoft.EntityFrameworkCore;

namespace _03.SimpleWebApi.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Guest>Guests { get; set; }
    }
}
