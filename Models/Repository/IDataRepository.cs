using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models.Repository
{
    public interface IDataRepository<T>
    {
        IQueryable<Address> Addresses { get; }
        IQueryable<Contact> Contacts { get; }
        IQueryable<Department> Departments { get; }
        IQueryable<DepartmentHistory> DepartmentHistories { get; }
        IQueryable<Position> Positions { get; }
        IQueryable<Launch> Launches { get; }
        IQueryable<LaunchOrbit> LaunchOrbits { get; }
        IQueryable<LaunchPad> LaunchPads { get; }
        IQueryable<LaunchSite> LaunchSites { get; }
        IQueryable<LaunchStatus> LaunchStatuses { get; }
        IQueryable<Manufacturer> Manufacturers { get; }
        IQueryable<PayHistory> PayHistories { get; }
        IQueryable<PayRate> PayRates { get; }
        IQueryable<Person> People { get; }
        IQueryable<Provider> Providers { get; }
        IQueryable<Rocket> Rockets { get; }
        IQueryable<RocketCategory> RocketCategories { get; }
        IQueryable<RocketModel> RocketModels { get; }
        IQueryable<RocketModelLink> RocketModelLinks { get; }
        IQueryable<RocketStatus> RocketStatuses { get; }
        IQueryable<Shift> Shifts { get; }
        IQueryable<Staff> Staff { get; }
        IQueryable<LaunchHistory> LaunchHistories { get; }

        IQueryable<T> Items { get; }

        void Create(T item);
        void Update(T item);
        void Delete(T item);
    }
}
