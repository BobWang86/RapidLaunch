using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RapidLaunch.Data;
using RapidLaunch.Models;
using RapidLaunch.Models.ViewModels;

namespace RapidLaunch.Controllers
{
    public class StaffController : Controller
    {
        private readonly RapidLaunchDbContext _context;

        public StaffController(RapidLaunchDbContext context)
        {
            _context = context;
        }

        // GET: Staff
        public async Task<IActionResult> Index()
        {
            var staff = await _context.Staff
                .Include(s => s.Person)
                    .ThenInclude(p => p.Contact)
                .Include(s => s.Position)
                    .ThenInclude(p => p.Department)
                .ToListAsync();
            var viewModel = new DepartmentVM
            {
                ExecutiveStaff = staff.Where(s => s.Position.Department.Name == "Executive").ToList(),
                WebDesignStaff = staff.Where(s => s.Position.Department.Name == "Web Design").ToList(),
                SoftwareEngineeringStaff = staff.Where(s => s.Position.Department.Name == "Software Engineering").ToList(),
                MarketingStaff = staff.Where(s => s.Position.Department.Name == "Marketing").ToList(),
                SalesStaff = staff.Where(s => s.Position.Department.Name == "Sales").ToList(),
                FinanceStaff = staff.Where(s => s.Position.Department.Name == "Finance").ToList(),
                HumanResourcesStaff = staff.Where(s => s.Position.Department.Name == "Human Resources").ToList(),
                InformationServicesStaff = staff.Where(s => s.Position.Department.Name == "Information Services").ToList(),
                DocumentControlStaff = staff.Where(s => s.Position.Department.Name == "Document Control").ToList(),
                QualityAssuranceStaff = staff.Where(s => s.Position.Department.Name == "Quality Assurance").ToList()
            };
            return View(viewModel);
        }

        public IActionResult StaffCard(Staff staff)
        {
            return PartialView("StaffCardPartial", staff);
        }

        public async Task<IActionResult> Manage()
        {
            var staff = await _context.Staff
                .Include(s => s.Person)
                    .ThenInclude(p => p.Contact)
                        .ThenInclude(c => c.Address)
                .Include(s => s.Position)
                    .ThenInclude(p => p.Department)
                .ToListAsync();
            return View(staff);
        }

        // GET: Staff/Create
        public IActionResult Create()
        {
            ViewData["PersonID"] = new SelectList(_context.People.Where(p => p.Staff == null), "PersonID", "FirstName");
            ViewData["PositionID"] = new SelectList(_context.Positions, "PositionID", "Name");
            List<PersonVM> people = _context.People
                .Include(p => p.Contact)
                    .ThenInclude(c => c.Address)
                .Select(p => new PersonVM
                {
                    PersonID = p.PersonID,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    BirthDate = p.BirthDate,
                    NationalInsuranceNumber = p.NationalInsuranceNumber,
                    PhoneNumber = p.Contact.PhoneNumber,
                    EmailAddress = p.Contact.EmailAddress,
                    AddressLine1 = p.Contact.Address.AddressLine1,
                    AddressLine2 = p.Contact.Address.AddressLine2,
                    City = p.Contact.Address.City,
                    State = p.Contact.Address.State,
                    Country = p.Contact.Address.Country,
                    PostalCode = p.Contact.Address.PostalCode,
                    Hired = p.Staff == null ? false : true
                }).ToList();
            ViewData["ExistingPeople"] = people;

            return View();
        }

        // POST: Staff/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaffID,PersonID,PositionID,HireDate")] Staff staff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(staff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonID"] = new SelectList(_context.People, "PersonID", "FirstName", staff.PersonID);
            ViewData["PositionID"] = new SelectList(_context.Positions, "PositionID", "Name", staff.PositionID);
            return View(staff);
        }

        // GET: Staff/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff.FindAsync(id);
            if (staff == null)
            {
                return NotFound();
            }
            ViewData["PersonID"] = new SelectList(_context.People, "PersonID", "FirstName", staff.PersonID);
            ViewData["PositionID"] = new SelectList(_context.Positions, "PositionID", "Name", staff.PositionID);
            return View(staff);
        }

        // POST: Staff/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StaffID,PersonID,PositionID,HireDate")] Staff staff)
        {
            if (id != staff.StaffID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(staff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StaffExists(staff.StaffID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PersonID"] = new SelectList(_context.People, "PersonID", "FirstName", staff.PersonID);
            ViewData["PositionID"] = new SelectList(_context.Positions, "PositionID", "Name", staff.PositionID);
            return View(staff);
        }

        // GET: Staff/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var staff = await _context.Staff
                .Include(s => s.Person)
                .Include(s => s.Position)
                .FirstOrDefaultAsync(m => m.StaffID == id);
            if (staff == null)
            {
                return NotFound();
            }

            return View(staff);
        }

        // POST: Staff/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var staff = await _context.Staff.FindAsync(id);
            _context.Staff.Remove(staff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StaffExists(int id)
        {
            return _context.Staff.Any(e => e.StaffID == id);
        }

        private bool PersonExists(int id)
        {
            return _context.People.Any(e => e.PersonID == id);
        }

        // GET: People/Create
        public IActionResult PersonCreate()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PersonCreate(
            [Bind("PersonID,FirstName,LastName,BirthDate,NationalInsuranceNumber,PhoneNumber,EmailAddress,AddressLine1,AddressLine2,City,State,Country,PostalCode")] PersonVM personVM)
        {
            if (ModelState.IsValid)
            {
                Address address = new Address { 
                    AddressLine1 = personVM.AddressLine1,
                    AddressLine2 = personVM.AddressLine2,
                    City = personVM.City,
                    State = personVM.State,
                    Country = personVM.Country,
                    PostalCode = personVM.PostalCode
                };
                _context.Addresses.Add(address);
                _context.SaveChanges();
                int addressID = _context.Addresses.Count();

                Contact contact = new Contact
                {
                    PhoneNumber = personVM.PhoneNumber,
                    EmailAddress = personVM.EmailAddress,
                    AddressID = addressID
                };
                _context.Contacts.Add(contact);
                _context.SaveChanges();
                int contactID = _context.Contacts.Count();

                Person person = new Person { 
                    FirstName = personVM.FirstName,
                    LastName = personVM.LastName,
                    BirthDate = personVM.BirthDate,
                    NationalInsuranceNumber = personVM.NationalInsuranceNumber,
                    ContactID = contactID
                };
                _context.People.Add(person);
                _context.SaveChanges();
                return RedirectToAction(nameof(Create));
            }
            return View(personVM);
        }

        // GET: People/Edit/5
        public async Task<IActionResult> PersonEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.People
                .Include(p => p.Contact)
                    .ThenInclude(c => c.Address)
                .FirstOrDefaultAsync(p => p.PersonID == id);
            if (person == null)
            {
                return NotFound();
            }
            PersonVM personVM = new PersonVM
            {
                PersonID = person.PersonID,
                FirstName = person.FirstName,
                LastName = person.LastName,
                BirthDate = person.BirthDate,
                NationalInsuranceNumber = person.NationalInsuranceNumber,
                PhoneNumber = person.Contact.PhoneNumber,
                EmailAddress = person.Contact.EmailAddress,
                AddressLine1 = person.Contact.Address.AddressLine1,
                AddressLine2 = person.Contact.Address.AddressLine2,
                City = person.Contact.Address.City,
                State = person.Contact.Address.State,
                Country = person.Contact.Address.Country,
                PostalCode = person.Contact.Address.PostalCode,
                Hired = person.Staff == null ? false : true
            };
            ViewData["ContactID"] = person.ContactID;
            ViewData["AddressID"] = person.Contact.AddressID;
            return View(personVM);
        }

        // POST: People/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PersonEdit(int id, int contactID, int addressID,
            [Bind("PersonID,FirstName,LastName,BirthDate,NationalInsuranceNumber,PhoneNumber,EmailAddress,AddressLine1,AddressLine2,City,State,Country,PostalCode")] PersonVM personVM)
        {
            Address address = new Address
            {
                AddressID = addressID,
                AddressLine1 = personVM.AddressLine1,
                AddressLine2 = personVM.AddressLine2,
                City = personVM.City,
                State = personVM.State,
                Country = personVM.Country,
                PostalCode = personVM.PostalCode
            };

            Contact contact = new Contact
            {
                ContactID = contactID,
                PhoneNumber = personVM.PhoneNumber,
                EmailAddress = personVM.EmailAddress,
                AddressID = addressID
            };

            Person person = new Person
            {
                PersonID = personVM.PersonID,
                FirstName = personVM.FirstName,
                LastName = personVM.LastName,
                BirthDate = personVM.BirthDate,
                NationalInsuranceNumber = personVM.NationalInsuranceNumber,
                ContactID = contactID
            };

            if (id != person.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(address);
                    _context.Update(contact);
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.PersonID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Create));
            }
            return View(person);
        }

        // GET: People/Delete/5
        public async Task<IActionResult> PersonDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var person = await _context.People
                .Include(p => p.Contact)
                .FirstOrDefaultAsync(m => m.PersonID == id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        // POST: People/Delete/5
        [HttpPost, ActionName("PersonDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PersonDeleteConfirmed(int id)
        {
            var person = await _context.People.FindAsync(id);
            _context.People.Remove(person);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Create));
        }
    }
}
