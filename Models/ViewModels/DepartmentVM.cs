using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models.ViewModels
{
    public class DepartmentVM
    {
        public List<Staff> ExecutiveStaff { get; set; }
        public List<Staff> WebDesignStaff { get; set; }
        public List<Staff> SoftwareEngineeringStaff { get; set; }
        public List<Staff> SalesStaff { get; set; }
        public List<Staff> MarketingStaff { get; set; }
        public List<Staff> FinanceStaff { get; set; }
        public List<Staff> HumanResourcesStaff { get; set; }
        public List<Staff> InformationServicesStaff { get; set; }
        public List<Staff> DocumentControlStaff { get; set; }
        public List<Staff> QualityAssuranceStaff { get; set; }
    }
}
