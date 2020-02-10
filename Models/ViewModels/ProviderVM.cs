using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RapidLaunch.Models.ViewModels
{
    public class ProviderVM
    {
        public IEnumerable<Provider> Providers { get; set; }
        public IEnumerable<RocketModel> RocketModels { get; set; }
        public IEnumerable<RocketModelLink> RocketModelLinks { get; set; }
    }
}
