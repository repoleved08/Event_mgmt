using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManagement.Entities;
using EventManagement.Services.Iservice;

namespace EventManagement.Services
{
public class EventService : IEventService
{
    private readonly IEventRepository _eventRepository;

    public EventService(IEventRepository eventRepository)
    {
        _eventRepository = eventRepository;
    }

    public async Task<IEnumerable<Event>> GetEventsAsync()
    {
        return await _eventRepository.GetEventsAsync();
    }

    public async Task<Event> GetEventAsync(int id)
    {
        return await _eventRepository.GetEventAsync(id);
    }

    public async Task CreateEventAsync(Event @event)
    {
        await _eventRepository.CreateEventAsync(@event);
    }

    public async Task UpdateEventAsync(Event @event)
    {
        await _eventRepository.UpdateEventAsync(@event);
    }

    public async Task DeleteEventAsync(int id)
    {
        await _eventRepository.DeleteEventAsync(id);
    }
}

}
