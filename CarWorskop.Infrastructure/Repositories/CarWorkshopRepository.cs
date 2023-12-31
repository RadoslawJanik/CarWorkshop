﻿
using CarWorkshop.Domain.Interfaces;
using CarWorskop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorskop.Infrastructure.Repositories
{
    internal class CarWorkshopRepository : ICarWorkshopRepository
    {
        private readonly CarWorkshopDbContext _dbContext;

        public CarWorkshopRepository(CarWorkshopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Commit()
     => _dbContext.SaveChangesAsync();

        public async Task Create(CarWorkshop.Domain.Entities.CarWorkshop carWorkshop)
        {
            _dbContext.Add(carWorkshop);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<CarWorkshop.Domain.Entities.CarWorkshop>> GetAll()
         => await _dbContext.CarWorkshops.ToListAsync();


        public async Task<CarWorkshop.Domain.Entities.CarWorkshop> GetByEncodedName(string encodedName)
     => await _dbContext.CarWorkshops.FirstAsync(c => c.EncodedName == encodedName);


        public Task<CarWorkshop.Domain.Entities.CarWorkshop?> GetByName(string name)
       => _dbContext.CarWorkshops.FirstOrDefaultAsync(cw => cw.Name.ToLower() == name.ToLower());
    }
}
