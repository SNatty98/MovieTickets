﻿using Microsoft.EntityFrameworkCore;
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

        public void Add(Actor actor)
        {
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAll()
        {
            var results = await _context.Actors.ToListAsync();
            return results;
        }

        public Actor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor Update(int id, Actor newActor)
        {
            throw new NotImplementedException();
        }
    }
}
