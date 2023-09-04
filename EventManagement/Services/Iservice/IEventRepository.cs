using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManagement.Entities;

namespace EventManagement.Services.Iservice
{
public interface IEventRepository
{
    Task<IEnumerable<Event>> GetEventsAsync();
    Task<Event> GetEventAsync(int id);
    Task CreateEventAsync(Event @event);
    Task UpdateEventAsync(Event @event);
    Task DeleteEventAsync(int id);
}

}
