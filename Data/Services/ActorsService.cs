using Microsoft.EntityFrameworkCore;
using MovieTickets.Models;

namespace MovieTickets.Data.Services
{
    public class ActorsService : IActorsService
    {

        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) 
        {  
            _context = context; 
        }

        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var results = await _context.Actors.ToListAsync();
            return results;
        }

        public async Task<Actor> GetByIdAsync (int id)
        {
            var results = await _context.Actors.FirstOrDefaultAsync(n => n.ActorId == id);
            return results;  
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Actors.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
