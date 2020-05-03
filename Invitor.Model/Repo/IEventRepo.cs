using System.Collections.Generic;
using System.Threading.Tasks;

namespace Invitor.Model.eventRepo
{
    public interface IEventRepo
    {
        Task<Event> Add(Event evente);
        Task<IEnumerable<Event>> GetAllAsync();
    }
}