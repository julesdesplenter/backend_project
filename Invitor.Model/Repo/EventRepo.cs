using Invitor.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invitor.Model.eventRepo
{
    public class EventRepo : IEventRepo
    {
        private readonly InvitorDbContext context;

        public EventRepo(InvitorDbContext invitorDbContext)
        {
            this.context = invitorDbContext;
        }

        public async Task<Event> Add(Event evente)
        {
            try
            {
                var result = context.Event.AddAsync(evente);
                await context.SaveChangesAsync();
                return evente;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.InnerException.Message);
                return null;
            }
        }

        public async Task<IEnumerable<Event>> GetAllAsync()
        {
            return await context.Event.OrderBy(t => t.StartTime).ToListAsync();
        }
    }
}
