using RapidLaunch.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models.Repository
{
    public class EFRepository<T> : IDataRepository<T>
    {
        private RapidLaunchDbContext _context;

        public EFRepository(RapidLaunchDbContext context)
        {
            _context = context;
        }

        public IQueryable<Provider> Providers => _context.Providers;

        public IQueryable<Address> Addresses => _context.Addresses;

        public IQueryable<Contact> Contacts => _context.Contacts;

        public IQueryable<Department> Departments => _context.Departments;

        public IQueryable<DepartmentHistory> DepartmentHistories => _context.DepartmentHistories;

        public IQueryable<Position> Positions => _context.Positions;

        public IQueryable<Launch> Launches => _context.Launches;

        public IQueryable<LaunchOrbit> LaunchOrbits => _context.LaunchOrbits;

        public IQueryable<LaunchPad> LaunchPads => _context.LaunchPads;

        public IQueryable<LaunchSite> LaunchSites => _context.LaunchSites;

        public IQueryable<LaunchStatus> LaunchStatuses => _context.LaunchStatuses;

        public IQueryable<Manufacturer> Manufacturers => _context.Manufacturers;

        public IQueryable<PayHistory> PayHistories => _context.PayHistories;

        public IQueryable<PayRate> PayRates => _context.PayRates;

        public IQueryable<Person> People => _context.People;

        public IQueryable<Rocket> Rockets => _context.Rockets;

        public IQueryable<RocketCategory> RocketCategories => _context.RocketCategories;

        public IQueryable<RocketModel> RocketModels => _context.RocketModels;

        public IQueryable<RocketModelLink> RocketModelLinks => _context.RocketModelLinks;

        public IQueryable<RocketStatus> RocketStatuses => _context.RocketStatuses;

        public IQueryable<Shift> Shifts => _context.Shifts;

        public IQueryable<Staff> Staff => _context.Staff;

        public IQueryable<LaunchHistory> LaunchHistories => _context.LaunchHistories;

        public IQueryable<T> Items => throw new NotImplementedException();

        public async void Create(T item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
        }

        public async void Update(T item)
        {
            _context.Update(item);
            await _context.SaveChangesAsync();
        }

        public async void Delete(T item)
        {
            _context.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}
