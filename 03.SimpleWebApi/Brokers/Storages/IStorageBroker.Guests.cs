using _03.SimpleWebApi.Models.Foundations.Guests;
using System.Threading.Tasks;

namespace _03.SimpleWebApi.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Guest> InsertGuestAsync(Guest guest);
       
    }
}
