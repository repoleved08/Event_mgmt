using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventManagement.Data;
using EventManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.Services.Iservice
{
public class EfCoreEventRepository : IEventRepository
{
    private readonly AppDbContext _dbContext;

    public EfCoreEventRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Event>> GetEventsAsync()
    {
        return await _dbContext.Events.ToListAsync();
    }

    public async Task<Event> GetEventAsync(int id)
    {
        return await _dbContext.Events.FindAsync(id);
    }

    public async Task CreateEventAsync(Event @event)
    {
        _dbContext.Events.Add(@event);
        await _dbContext.SaveChangesAsync();
    }

    public async Task UpdateEventAsync(Event @event)
    {
        _dbContext.Entry(@event).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteEventAsync(int id)
    {
        var @event = await _dbContext.Events.FindAsync(id);
        if (@event != null)
        {
            _dbContext.Events.Remove(@event);
            await _dbContext.SaveChangesAsync();
        }
    }
}

}
