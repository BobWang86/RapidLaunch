using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using RapidLaunch.Models;
using System;
using NetTopologySuite.Geometries;
using System.Collections.Generic;
using Bogus;
using Bogus.Extensions.UnitedStates;

namespace RapidLaunch.Data
{
    public class RapidLaunchDbInitializer
    {
        public static void Initialize(IApplicationBuilder app)
        {
            RapidLaunchDbContext context = app.ApplicationServices.GetRequiredService<RapidLaunchDbContext>();
            var faker = new Faker("en");
            context.Database.EnsureCreated();
            #region RocketDB Initializer
            if (!context.Manufacturers.Any())
            {
                context.Manufacturers.AddRange(
                    new Manufacturer
                    {
                        Name = "Antrix Corporation",
                        Country = "India"
                    },
                    new Manufacturer
                    {
                        Name = "ArianeGroup",
                        Country = "Europe"
                    },
                    new Manufacturer
                    {
                        Name = "Avio S.p.A.",
                        Country = "Italy"
                    },
                    new Manufacturer
                    {
                        Name = "Airbus Defence and Space",
                        Country = "Europe"
                    },
                    new Manufacturer
                    {
                        Name = "China Aerospace Science and Technology Corporation",
                        Country = "China"
                    },
                    new Manufacturer
                    {
                        Name = "China Academy of Launch Vehicle Technology",
                        Country = "China"
                    },
                    new Manufacturer
                    {
                        Name = "Shanghai Academy of Spaceflight Technology",
                        Country = "China"
                    },
                    new Manufacturer
                    {
                        Name = "Deltaspace",
                        Country = "United States"
                    },
                    new Manufacturer
                    {
                        Name = "Eurockot Launch Services",
                        Country = "Europe"
                    },
                    new Manufacturer
                    {
                        Name = "India Space Research Organisation",
                        Country = "India"
                    },
                    new Manufacturer
                    {
                        Name = "International Launch Services",
                        Country = "United States"
                    },
                    new Manufacturer
                    {
                        Name = "ISC Kosmotras",
                        Country = "Russia"
                    },
                    new Manufacturer
                    {
                        Name = "Iranian Space Agency",
                        Country = "Iran"
                    },
                    new Manufacturer
                    {
                        Name = "Israel Aerospace Industries",
                        Country = "Israel"
                    },
                    new Manufacturer
                    {
                        Name = "Khrunichev State Research and Production Space Center",
                        Country = "Russia"
                    },
                    new Manufacturer
                    {
                        Name = "Mitsubishi Heavy Industries",
                        Country = "Japan"
                    },
                    new Manufacturer
                    {
                        Name = "Makeyev Rocket Design Bureau",
                        Country = "Russia"
                    },
                    new Manufacturer
                    {
                        Name = "NG Innovation",
                        Country = "United States"
                    },
                    new Manufacturer
                    {
                        Name = "Orbital ATK",
                        Country = "United States"
                    },
                    new Manufacturer
                    {
                        Name = "OneSpace Group",
                        Country = "China"
                    },
                    new Manufacturer
                    {
                        Name = "Rocket Lab",
                        Country = "New Zealand"
                    },
                    new Manufacturer
                    {
                        Name = "SpaceX",
                        Country = "United States"
                    },
                    new Manufacturer
                    {
                        Name = "Starsem",
                        Country = "Europe"
                    },
                    new Manufacturer
                    {
                        Name = "Skyroot aerospace",
                        Country = "India"
                    },
                    new Manufacturer
                    {
                        Name = "TsSKB-Progress",
                        Country = "Russia"
                    },
                    new Manufacturer
                    {
                        Name = "United Launch Alliance",
                        Country = "United States"
                    },
                    new Manufacturer
                    {
                        Name = "Yuzhmash",
                        Country = "Ukraine"
                    },
                    new Manufacturer
                    {
                        Name = "Yuzhnoye Design Office",
                        Country = "Ukraine"
                    }
                );
            }
            context.SaveChanges();
            if (!context.RocketCategories.Any())
            {
                context.RocketCategories.AddRange(
                    new RocketCategory
                    {
                        Name = "Small",
                        Description = "Small-lift launch vehicle: < 2,000 kilograms (4,400 lb)"
                    },
                    new RocketCategory
                    {
                        Name = "Medium",
                        Description = "Medium-lift launch vehicle: 2,000 to 20,000 kilograms (4,400 to 44,100 lb) "
                    },
                    new RocketCategory
                    {
                        Name = "Heavy",
                        Description = "Heavy-lift launch vehicle: > 20,000 to 50,000 kilograms (44,000 to 110,000 lb)"
                    },
                    new RocketCategory
                    {
                        Name = "Super Heavy",
                        Description = "Super-heavy lift vehicle: > 50,000 kilograms (110,000 lb)"
                    }
                );
            }
            context.SaveChanges();
            if (!context.Providers.Any())
            {
                context.Providers.AddRange(
                    new Provider
                    {
                        Name = "Antrix Corporation",
                        Description = "Antrix Corporation Limited (ACL), Bengaluru is a wholly owned Government of India Company under the administrative control of the Department of Space.",
                        EstablishDate = new DateTime(1992,09,27)
                    },
                    new Provider
                    {
                        Name = "Arianespace",
                        Description = "Arianespace SA is a multinational company founded in 1980 as the world's first commercial launch service provider.",
                        EstablishDate = new DateTime(1980,01,01)
                    },
                    new Provider
                    {
                        Name = "China Aerospace Science and Technology Corporation",
                        Description = "The China Aerospace Science and Technology Corporation (CASC) is the main contractor for the Chinese space program. It is state-owned and has a number of subordinate entities which design, develop and manufacture a range of spacecraft, launch vehicles, strategic and tactical missile systems, and ground equipment.",
                        EstablishDate = new DateTime(1999,07,01)
                    },
                    new Provider
                    {
                        Name = "Eurockot Launch Services",
                        Description = "Eurockot Launch Services GmbH is a commercial spacecraft launch provider and was founded in 1995. Eurockot uses an expendable launch vehicle called the Rockot to place satellites into Low-Earth orbit.",
                        EstablishDate = new DateTime(1995,01,01)
                    },
                    new Provider
                    {
                        Name = "International Launch Services",
                        Description = "International Launch Services (ILS) is a joint venture with exclusive rights to the worldwide sale of commercial Angara and Proton rocket launch services.",
                        EstablishDate = new DateTime(1995,07,10)
                    },
                    new Provider
                    {
                        Name = "ISC Kosmotras",
                        Description = "The International Space Company Kosmotras or ISC Kosmotras is a joint project, between Russia, Ukraine, and Kazakhstan, established in 1997. It developed and now operates a commercial expendable launch system using the Dnepr rocket.",
                        EstablishDate = new DateTime(1997,01,01)
                    },
                    new Provider
                    {
                        Name = "Sea Launch",
                        Description = "Sea Launch is a multinational spacecraft launch service that used a mobile maritime launch platform for equatorial launches of commercial payloads on specialized Zenit rockets.",
                        EstablishDate = new DateTime(1995,01,01)
                    },
                    new Provider
                    {
                        Name = "Mitsubishi Heavy Industries",
                        Description = "Mitsubishi Heavy Industries, Ltd. is a Japanese multinational engineering, electrical equipment and electronics company headquartered in Tokyo, Japan. MHI is one of the core companies of the Mitsubishi Group.",
                        EstablishDate = new DateTime(1884,01,01)
                    },
                    new Provider
                    {
                        Name = "Northrop Grumman Innovation Systems",
                        Description = "Northrop Grumman Innovation Systems is an American aerospace manufacturer and defense industry company that operates as the aviation division of parent company Northrop Grumman.",
                        EstablishDate = new DateTime(2015,02,09)
                    },
                    new Provider
                    {
                        Name = "SpaceX",
                        Description = "Space Exploration Technologies Corp., doing business as SpaceX, is a private American aerospace manufacturer and space transportation services company headquartered in Hawthorne, California.",
                        EstablishDate = new DateTime(2002,05,06)
                    },
                    new Provider
                    {
                        Name = "Starsem",
                        Description = "Starsem is a European-Russian company that was created in 1996 to commercialise the Soyuz launcher internationally. Starsem is headquartered in Évry, France.",
                        EstablishDate = new DateTime(1996,01,01)
                    },
                    new Provider
                    {
                        Name = "United Launch Alliance",
                        Description = "United Launch Alliance (ULA) is a US launch service provider that manufactures and operates a number of rocket vehicles capable of orbiting spacecraft.",
                        EstablishDate = new DateTime(2006,12,01)
                    }
                );
            }
            context.SaveChanges();
            if (!context.RocketModels.Any())
            {
                context.RocketModels.AddRange(
                    new RocketModel
                    {
                        Name = "PSLV",
                        Description = "Polar Satellite Launch Vehicle",
                        Height = 44,
                        Mass = 320000,
                        Diameter = 2.8,
                        PayloadLEO = 3800,
                        PayloadGTO = 1200,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "India Space Research Organisation").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "GSLV",
                        Description = "Geosynchronous Satellite Launch Vehicle",
                        Height = 49.13,
                        Mass = 414750,
                        Diameter = 2.8,
                        PayloadLEO = 5000,
                        PayloadGTO = 2700,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "India Space Research Organisation").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Vega",
                        Description = "Vettore Europeo di Generazione Avanzata",
                        Height = 30,
                        Mass = 137000,
                        Diameter = 3,
                        PayloadLEO = 1250,
                        PayloadGTO = null,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "Avio S.p.A.").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Small").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Soyuz-2",
                        Description = "21st-century version of the Russian Soyuz rocket",
                        Height = 46.3,
                        Mass = 312000,
                        Diameter = 2.95,
                        PayloadLEO = 8200,
                        PayloadGTO = 3250,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "TsSKB-Progress").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Ariane 5",
                        Description = "Ariane 5 is a European heavy-lift launch vehicle that is part of the Ariane rocket family",
                        Height = 52,
                        Mass = 777000,
                        Diameter = 5.4,
                        PayloadLEO = 16000,
                        PayloadGTO = 6950,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "Airbus Defence and Space").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Long March 3A",
                        Description = "A Long March rocket is any rocket in a family of expendable launch systems operated by the People's Republic of China",
                        Height = 52.52,
                        Mass = 241000,
                        Diameter = 3.35,
                        PayloadLEO = 8500,
                        PayloadGTO = 2600,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "China Academy of Launch Vehicle Technology").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Long March 5A",
                        Description = "A Long March rocket is any rocket in a family of expendable launch systems operated by the People's Republic of China",
                        Height = 62,
                        Mass = 867000,
                        Diameter = 5,
                        PayloadLEO = 25000,
                        PayloadGTO = 14000,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "China Academy of Launch Vehicle Technology").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Heavy").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Rokot",
                        Description = "Russian space launch vehicles supplied and operated by Khrunichev State Research and Production Space Center",
                        Height = 29,
                        Mass = 107000,
                        Diameter = 2.5,
                        PayloadLEO = 1950,
                        PayloadGTO = null,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "Khrunichev State Research and Production Space Center").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Small").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Proton-M",
                        Description = "The Proton-M, (Протон-М) GRAU index 8K82M or 8K82KM, is an expendable Russian heavy-lift launch vehicle derived from the Soviet-developed Proton",
                        Height = 58.2,
                        Mass = 705000,
                        Diameter = 7.4,
                        PayloadLEO = 23000,
                        PayloadGTO = 6300,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "Khrunichev State Research and Production Space Center").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Heavy").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Dnepr",
                        Description = "The Dnepr rocket was a space launch vehicle named after the Dnieper River. It was a converted ICBM used for launching artificial satellites into orbit, operated by launch service provider ISC Kosmotras",
                        Height = 34.3,
                        Mass = 211000,
                        Diameter = 3,
                        PayloadLEO = 4500,
                        PayloadGTO = null,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "Yuzhmash").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Zenit-2",
                        Description = "Zenit is a family of space launch vehicles designed by the Yuzhnoye Design Bureau in Dnipro",
                        Height = 59.6,
                        Mass = 46200,
                        Diameter = 3.9,
                        PayloadLEO = 13740,
                        PayloadGTO = 6000,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "Yuzhmash").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "H-IIA",
                        Description = "H-IIA (H2A) is an active expendable launch system operated by Mitsubishi Heavy Industries (MHI) for the Japan Aerospace Exploration Agency",
                        Height = 53,
                        Mass = 445000,
                        Diameter = 4,
                        PayloadLEO = 15000,
                        PayloadGTO = 6000,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "Mitsubishi Heavy Industries").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "H-IIB",
                        Description = "H-IIB (H2B) is an expendable launch system used to launch H-II Transfer Vehicles towards the International Space Station",
                        Height = 56.6,
                        Mass = 531000,
                        Diameter = 5.2,
                        PayloadLEO = 16500,
                        PayloadGTO = 8500,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "Mitsubishi Heavy Industries").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Antares",
                        Description = "Antares is an expendable launch system developed by Orbital Sciences Corporation and the Yuzhnoye Design Bureau to launch the Cygnus spacecraft to the International Space Station as part of NASA's COTS and CRS programs",
                        Height = 42.5,
                        Mass = 298000,
                        Diameter = 3.9,
                        PayloadLEO = 8000,
                        PayloadGTO = null,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "NG Innovation").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Minotaur V",
                        Description = "The Minotaur is a family of American solid fuel rockets derived from converted Minuteman and Peacekeeper intercontinental ballistic missiles",
                        Height = 24.56,
                        Mass = 89373,
                        Diameter = 2.34,
                        PayloadLEO = 532,
                        PayloadGTO = null,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "NG Innovation").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Small").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Pegasus",
                        Description = "The Pegasus is an air-launched rocket developed by Orbital Sciences Corporation (now part of Northrop Grumman Innovation Systems after Northrop Grumman acquired Orbital ATK)",
                        Height = 17.6,
                        Mass = 18500,
                        Diameter = 1.27,
                        PayloadLEO = 443,
                        PayloadGTO = null,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "NG Innovation").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Small").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Zenit-3SL",
                        Description = "The Zenit-3SL is an expendable carrier rocket operated by Sea Launch",
                        Height = 59.6,
                        Mass = 462200,
                        Diameter = 3.9,
                        PayloadLEO = null,
                        PayloadGTO = 6160,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "Yuzhnoye Design Office").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Falcon 9",
                        Description = "Falcon 9 is a partially reusable two-stage-to-orbit medium lift launch vehicle designed and manufactured by SpaceX in the United States",
                        Height = 70,
                        Mass = 549054,
                        Diameter = 3.7,
                        PayloadLEO = 22800,
                        PayloadGTO = 8300,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "SpaceX").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Medium").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Falcon Heavy",
                        Description = "The Falcon Heavy is a partially reusable heavy-lift launch vehicle designed and manufactured by SpaceX",
                        Height = 70,
                        Mass = 1420788,
                        Diameter = 3.66,
                        PayloadLEO = 63800,
                        PayloadGTO = 26700,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "SpaceX").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Super Heavy").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Soyuz-FG",
                        Description = "The Soyuz-FG launch vehicle was an improved version of the Soyuz-U from the R-7 family of rockets, designed and constructed by TsSKB-Progress",
                        Height = 49.5,
                        Mass = 305000,
                        Diameter = 2.95,
                        PayloadLEO = 6900,
                        PayloadGTO = null,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "TsSKB-Progress").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Small").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Delta IV",
                        Description = "Delta IV is a group of five expendable launch systems in the Delta rocket family introduced in the early 2000s. Originally designed by Boeing's Defense, Space & Security division for the Evolved Expendable Launch Vehicle (EELV) program",
                        Height = 72,
                        Mass = 733400,
                        Diameter = 5,
                        PayloadLEO = 28790,
                        PayloadGTO = 14220,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "United Launch Alliance").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Heavy").RocketCategoryID
                    },
                    new RocketModel
                    {
                        Name = "Atlas V",
                        Description = "Atlas V is the fifth major version in the Atlas rocket family. It is an expendable launch system originally designed by Lockheed Martin, now being operated by United Launch Alliance (ULA), a joint venture between Lockheed and Boeing",
                        Height = 58.3,
                        Mass = 590000,
                        Diameter = 3.81,
                        PayloadLEO = 20520,
                        PayloadGTO = 2900,
                        ManufacturerID = context.Manufacturers.FirstOrDefault(i => i.Name == "United Launch Alliance").ManufacturerID,
                        RocketCategoryID = context.RocketCategories.FirstOrDefault(i => i.Name == "Heavy").RocketCategoryID
                    }
                );
            }
            context.SaveChanges();
            if (!context.RocketModelLinks.Any())
            {
                context.RocketModelLinks.AddRange(
                    new RocketModelLink {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Antrix Corporation").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "PSLV").RocketModelID
                    },    
                    new RocketModelLink {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Antrix Corporation").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "GSLV").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Arianespace").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Vega").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Arianespace").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Soyuz-2").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Arianespace").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Ariane 5").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "China Aerospace Science and Technology Corporation").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Long March 3A").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "China Aerospace Science and Technology Corporation").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Long March 5A").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Eurockot Launch Services").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Rokot").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "International Launch Services").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Proton-M").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "ISC Kosmotras").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Dnepr").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Sea Launch").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Zenit-2").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Mitsubishi Heavy Industries").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "H-IIA").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Mitsubishi Heavy Industries").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "H-IIB").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Northrop Grumman Innovation Systems").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Antares").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Northrop Grumman Innovation Systems").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Minotaur V").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Northrop Grumman Innovation Systems").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Pegasus").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Sea Launch").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Zenit-3SL").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "SpaceX").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Falcon 9").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "SpaceX").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Falcon Heavy").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "Starsem").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Soyuz-FG").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "United Launch Alliance").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Delta IV").RocketModelID
                    },
                    new RocketModelLink
                    {
                        ProviderID = context.Providers.FirstOrDefault(i => i.Name == "United Launch Alliance").ProviderID,
                        RocketModelID = context.RocketModels.FirstOrDefault(i => i.Name == "Atlas V").RocketModelID
                    }
                );
            }
            context.SaveChanges();
            if (!context.RocketStatuses.Any())
            {
                context.RocketStatuses.AddRange(
                    new RocketStatus
                    {
                        Name = "Active"
                    },
                    new RocketStatus
                    {
                        Name = "Retired"
                    },
                    new RocketStatus
                    {
                        Name = "Repair"
                    },
                    new RocketStatus
                    {
                        Name = "Recycle"
                    }
                );
            }
            context.SaveChanges();
            if (!context.Rockets.Any())
            {
                HashSet<int> rocketModelList = new HashSet<int>(context.RocketModels.Select(r => r.RocketModelID));
                int rocketStatusCount = context.RocketStatuses.Count();
                foreach (int modelID in rocketModelList)
                {
                    string rocketModelName = context.RocketModels.FirstOrDefault(r => r.RocketModelID == modelID).Name;

                    for (int i = 1; i <= 3; i++)
                    {
                        context.Rockets.Add(new Rocket {
                            ManufactureDate = faker.Date.Between(new DateTime(1945, 01, 01), DateTime.Now),
                            RocketCode = $"{rocketModelName}-RCT{i}",
                            RocketModelID = modelID,
                            RocketStatusID = faker.Random.Number(1, rocketStatusCount)
                        });
                    }
                }
            }
            context.SaveChanges();
            if (!context.LaunchSites.Any())
            {
                context.LaunchSites.AddRange(
                    new LaunchSite
                    {
                        Country = "Algeria",
                        Name = "Interarmy Special Vehicles Test Centre (CIEES)",
                        Location = new Point(-2.83581, 31.09951) { SRID = 4326 },
                        BuildDate = new DateTime(1947,01,01)
                    },
                    new LaunchSite
                    {
                        Country = "Kenya",
                        Name = "Broglio Space Center",
                        Location = new Point(40.21340, -2.94080) { SRID = 4326 },
                        BuildDate = new DateTime(1964, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "China",
                        Name = "Jiuquan Satellite Launch Center",
                        Location = new Point(100.29833, 40.96056) { SRID = 4326 },
                        BuildDate = new DateTime(1970, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "China",
                        Name = "Xichang Satellite Launch Center",
                        Location = new Point(102.02814, 28.24646) { SRID = 4326 },
                        BuildDate = new DateTime(1984, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "China",
                        Name = "	Wenchang Satellite Launch Center",
                        Location = new Point(110.57408, 19.365217) { SRID = 4326 },
                        BuildDate = new DateTime(2016, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "India",
                        Name = "Satish Dhawan Space Centre",
                        Location = new Point(13.73740, 80.23510) { SRID = 4326 },
                        BuildDate = new DateTime(1971, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Iran",
                        Name = "Emamshahr Space Center",
                        Location = new Point(36.42000, 55.02000) { SRID = 4326 },
                        BuildDate = new DateTime(1996, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Israel",
                        Name = "Palmachim Air Force Base",
                        Location = new Point(34.68020, 31.88484) { SRID = 4326 },
                        BuildDate = new DateTime(1987, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Japan",
                        Name = "Tanegashima Space Center",
                        Location = new Point(130.96813, 30.39096) { SRID = 4326 },
                        BuildDate = new DateTime(1967, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "South Korea",
                        Name = "Naro Space Center, Gohueng",
                        Location = new Point(127.52793, 34.42585) { SRID = 4326 },
                        BuildDate = new DateTime(2008, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Russia",
                        Name = "Yasny Cosmodrome",
                        Location = new Point(59.85003, 51.20706) { SRID = 4326 },
                        BuildDate = new DateTime(2006, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Russia",
                        Name = "Vostochny Cosmodrome",
                        Location = new Point(128.333, 51.883) { SRID = 4326 },
                        BuildDate = new DateTime(2016, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "France",
                        Name = "Ile du Levant",
                        Location = new Point(6.478887, 43.04507) { SRID = 4326 },
                        BuildDate = new DateTime(1948, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Italy",
                        Name = "Salto di Quirra",
                        Location = new Point(9.963303, 39.62731) { SRID = 4326 },
                        BuildDate = new DateTime(1964, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Russia",
                        Name = "Plesetsk Cosmodrome",
                        Location = new Point(40.3440, 62.5532) { SRID = 4326 },
                        BuildDate = new DateTime(1966, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Russia",
                        Name = "	Kapustin Yar Cosmodrome",
                        Location = new Point(46.25420, 48.57807) { SRID = 4326 },
                        BuildDate = new DateTime(1957, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "United Kingdom",
                        Name = "Highdown Test Site",
                        Location = new Point(-1.5763664, 50.6639354) { SRID = 4326 },
                        BuildDate = new DateTime(1956, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "United Kingdom",
                        Name = "South Uist",
                        Location = new Point(-7.33000, 57.33000) { SRID = 4326 },
                        BuildDate = new DateTime(1959, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Canada",
                        Name = "Churchill Rocket Research Range",
                        Location = new Point(-93.82030, 58.73430) { SRID = 4326 },
                        BuildDate = new DateTime(1954, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "United States",
                        Name = "Wallops Flight Facility",
                        Location = new Point(-75.47938, 37.84621) { SRID = 4326 },
                        BuildDate = new DateTime(1945, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "United States",
                        Name = "Cape Canaveral Air Force Station",
                        Location = new Point(-80.55852, 28.46675) { SRID = 4326 },
                        BuildDate = new DateTime(1956, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "United States",
                        Name = "Vandenberg Air Force Base",
                        Location = new Point(-120.60124, 34.77204) { SRID = 4326 },
                        BuildDate = new DateTime(1958, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "United States",
                        Name = "Kennedy Space Center",
                        Location = new Point(-80.6040, 28.6082) { SRID = 4326 },
                        BuildDate = new DateTime(1963, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "United States",
                        Name = "Mojave Air and Space Port",
                        Location = new Point(-118.14880, 35.05910) { SRID = 4326 },
                        BuildDate = new DateTime(2004, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "United States",
                        Name = "Mid-Atlantic Regional Spaceport",
                        Location = new Point(-75.483284, 37.833378) { SRID = 4326 },
                        BuildDate = new DateTime(2004, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Australia",
                        Name = "Woomera Test Range",
                        Location = new Point(-136.50366, -30.85875) { SRID = 4326 },
                        BuildDate = new DateTime(1950, 01, 01)
                    },
                    new LaunchSite
                    {
                        Country = "Brazil",
                        Name = "Alcântara Launch Center",
                        Location = new Point(-44.3676, -2.3160) { SRID = 4326 },
                        BuildDate = new DateTime(1950, 01, 01)
                    }
                );
            }
            context.SaveChanges();
            if (!context.LaunchOrbits.Any())
            {
                context.LaunchOrbits.AddRange(
                    new LaunchOrbit
                    {
                        Name = "LEO",
                        Description = "Low Earth Orbit"
                    },
                    new LaunchOrbit
                    {
                        Name = "SSO",
                        Description = "Sun-Synchronous Orbit"
                    },
                    new LaunchOrbit
                    {
                        Name = "Polar",
                        Description = "Polar Orbit"
                    },
                    new LaunchOrbit
                    {
                        Name = "MEO",
                        Description = "Medium Earth Orbit"
                    },
                    new LaunchOrbit
                    {
                        Name = "GTO",
                        Description = "Geostationary Transfer Orbit"
                    },
                    new LaunchOrbit
                    {
                        Name = "GEO",
                        Description = "Geostationary Orbit (Direct Injection)"
                    },
                    new LaunchOrbit
                    {
                        Name = "HEO",
                        Description = "High Earth Orbit"
                    },
                    new LaunchOrbit
                    {
                        Name = "HCO",
                        Description = "Heliocentric Orbit"
                    },
                    new LaunchOrbit
                    {
                        Name = "TLI",
                        Description = "Trans-Lunar Injection"
                    },
                    new LaunchOrbit
                    {
                        Name = "TMI",
                        Description = "Trans-Mars Injection"
                    }
                );
            }
            context.SaveChanges();
            if (!context.LaunchStatuses.Any())
            {
                context.LaunchStatuses.AddRange(
                    new LaunchStatus
                    {
                        Name = "Success"
                    },
                    new LaunchStatus
                    {
                        Name = "Failure"
                    },
                    new LaunchStatus
                    {
                        Name = "Loss During Launch"
                    },
                    new LaunchStatus
                    {
                        Name = "Loss Before Launch"
                    },
                    new LaunchStatus
                    {
                        Name = "Abort Before Launch"
                    },
                    new LaunchStatus
                    {
                        Name = "Scheduled"
                    }
                );
            }
            context.SaveChanges();
            if (!context.LaunchPads.Any())
            {
                HashSet<int> launchSiteList = new HashSet<int>(context.LaunchSites.Select(s => s.LaunchSiteID));
                foreach (int site in launchSiteList)
                {
                    string siteName = context.LaunchSites.FirstOrDefault(i => i.LaunchSiteID == site).Name;
                    for (int i = 1; i <= faker.Random.Number(1, 5); i++)
                    {
                        context.LaunchPads.Add(new LaunchPad { 
                            LaunchSiteID = site,
                            LaunchPadCode = $"{siteName}-LP{i}"
                        });
                    }
                }
            }
            context.SaveChanges();
            if (!context.Launches.Any())
            {
                HashSet<int> rocketList = new HashSet<int>(context.Rockets.Select(r => r.RocketID));
                HashSet<int> launchPadList = new HashSet<int>(context.LaunchPads.Select(p => p.LaunchPadID));
                HashSet<int> launchOrbitList = new HashSet<int>(context.LaunchOrbits.Select(r => r.LaunchOrbitID));
                List<int> launchStatusList = new List<int>(context.LaunchStatuses.Where(s => s.Name != "Scheduled").Select(s => s.LaunchStatusID));

                int launchStatus = 0;
                int launchStatusScheduled = context.LaunchStatuses.FirstOrDefault(s => s.Name == "Scheduled").LaunchStatusID;
                int launchStatusSuccess = context.LaunchStatuses.FirstOrDefault(s => s.Name == "Success").LaunchStatusID;
                for (int i = 0; i < faker.Random.Number(75, 95); i++)
                {
                    launchStatusList.Add(launchStatusSuccess);
                }

                for (int i = 0; i < 100; i++)
                {
                    int rocket = faker.PickRandom<int>(rocketList);
                    int launchPad = faker.PickRandom<int>(launchPadList);
                    int launchSite = context.LaunchPads.FirstOrDefault(p => p.LaunchPadID == launchPad).LaunchSiteID;
                    int launchOrbit = faker.PickRandom<int>(launchOrbitList);

                    DateTime rocketBuildDate = context.Rockets.FirstOrDefault(r => r.RocketID == rocket).ManufactureDate;
                    DateTime siteBuildDate = context.LaunchSites.FirstOrDefault(s => s.LaunchSiteID == launchSite).BuildDate;
                    DateTime minLaunchDate = rocketBuildDate > siteBuildDate ? rocketBuildDate : siteBuildDate;

                    DateTime launchDate = faker.Date.Between(minLaunchDate, new DateTime(2022,12,31));
                    DateTime launchTime = default(DateTime).Add(launchDate.TimeOfDay);

                    if (launchDate > DateTime.Now)
                    {
                        launchStatus = launchStatusScheduled;
                    }
                    else
                    {
                        launchStatus = faker.PickRandom<int>(launchStatusList);
                    }

                    context.Launches.Add(new Launch { 
                        LaunchDate = launchDate,
                        LaunchTime = launchTime,
                        RocketID = rocket,
                        LaunchPadID = launchPad,
                        LaunchOrbitID = launchOrbit,
                        LaunchStatusID = launchStatus
                    });
                }
            }
            context.SaveChanges();
            #endregion

            #region StaffDB Initializer
            if (!context.Shifts.Any())
            {
                context.Shifts.AddRange(
                    new Shift
                    {
                        Name = "Day",
                        StartTime = new TimeSpan(8,0,0),
                        EndTime = new TimeSpan(16,0,0)
                    },
                    new Shift
                    {
                        Name = "Evening",
                        StartTime = new TimeSpan(16, 0, 0),
                        EndTime = new TimeSpan(22, 0, 0)
                    },
                    new Shift
                    {
                        Name = "Night",
                        StartTime = new TimeSpan(0, 0, 0),
                        EndTime = new TimeSpan(8, 0, 0)
                    }
                );
            }
            context.SaveChanges();
            if (!context.PayRates.Any())
            {
                for (int i = 1; i <= 8; i++)
                {
                    context.PayRates.Add(
                        new PayRate
                        {
                            Rank = i
                        }
                    );
                }
            }
            context.SaveChanges();
            if (!context.Departments.Any())
            {
                context.Departments.AddRange(
                    new Department
                    {
                        Name = "Software Engineering",
                        GroupName = "Research and Development"
                    },
                    new Department
                    {
                        Name = "Web Design",
                        GroupName = "Research and Development"
                    },
                    new Department
                    {
                        Name = "Sales",
                        GroupName = "Sales and Marketing"
                    },
                    new Department
                    {
                        Name = "Marketing",
                        GroupName = "Sales and Marketing"
                    },
                    new Department
                    {
                        Name = "Human Resources",
                        GroupName = "Executive General and Administration"
                    },
                    new Department
                    {
                        Name = "Finance",
                        GroupName = "Executive General and Administration"
                    },
                    new Department
                    {
                        Name = "Information Services",
                        GroupName = "Executive General and Administration"
                    },
                    new Department
                    {
                        Name = "Document Control",
                        GroupName = "Quality Assurance"
                    },
                    new Department
                    {
                        Name = "Quality Assurance",
                        GroupName = "Quality Assurance"
                    },
                    new Department
                    {
                        Name = "Executive",
                        GroupName = "Executive General and Administration"
                    }
                );
            }
            context.SaveChanges();
            if (!context.Positions.Any())
            {
                context.Positions.AddRange(
                    new Position {
                        Name = "Chief Executive Officer",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Executive").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 8).PayRateID
                    },
                    new Position
                    {
                        Name = "Vice President of Engineering",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 7).PayRateID
                    },
                    new Position
                    {
                        Name = "Engineering Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 7).PayRateID
                    },
                    new Position
                    {
                        Name = "Software Engineer",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Infrastructure Technician",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Network Administrator",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Database Administrator",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Software Engineering").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Senior Web Designer",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Web Design").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 5).PayRateID
                    },
                    new Position
                    {
                        Name = "Associate Web Designer",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Web Design").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Marketing Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Marketing").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 5).PayRateID
                    },
                    new Position
                    {
                        Name = "Marketing Specialist",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Marketing").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Marketing Assistant",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Marketing").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 3).PayRateID
                    },
                    new Position
                    {
                        Name = "Sales Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Sales").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Sales Representative",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Sales").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 3).PayRateID
                    },
                    new Position
                    {
                        Name = "Document Control Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Document Control").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Document Control Assistant",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Document Control").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 3).PayRateID
                    },
                    new Position
                    {
                        Name = "Quality Assurance Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Quality Assurance").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    },
                    new Position
                    {
                        Name = "Quality Assurance Technician",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Quality Assurance").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 3).PayRateID
                    },
                    new Position
                    {
                        Name = "Information Services Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Information Services").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Human Resource Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Human Resources").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Human Resource Administrator",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Human Resources").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Chief Financial Officer",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Finance").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 6).PayRateID
                    },
                    new Position
                    {
                        Name = "Finance Manager",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Finance").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 5).PayRateID
                    },
                    new Position
                    {
                        Name = "Accountant",
                        DepartmentID = context.Departments.FirstOrDefault(d => d.Name == "Finance").DepartmentID,
                        PayRateID = context.PayRates.FirstOrDefault(p => p.Rank == 4).PayRateID
                    }
                );
            }
            context.SaveChanges();
            if (!context.Addresses.Any())
            {
                for (int i = 1; i <= 32; i++)
                {
                    context.Addresses.Add(
                        new Address { 
                            AddressLine1 = faker.Address.SecondaryAddress(),
                            AddressLine2 = faker.Address.StreetAddress(),
                            City =faker.Address.City(),
                            State = faker.Address.State(),
                            Country = faker.Address.County(),
                            PostalCode = faker.Address.ZipCode(),
                        }    
                    );
                }
            }
            context.SaveChanges();
            if (!context.Contacts.Any())
            {
                for (int i = 1; i <= 32; i++)
                {
                    context.Contacts.Add(
                        new Contact { 
                            PhoneNumber = faker.Phone.PhoneNumber(),
                            EmailAddress = faker.Internet.Email(),
                            AddressID =i
                        }
                    );
                }
            }
            context.SaveChanges();
            if (!context.People.Any())
            {
                for (int i = 1; i <= 32; i++)
                {
                    context.People.Add(
                        new RapidLaunch.Models.Person { 
                            FirstName = faker.Name.FirstName(),
                            LastName = faker.Name.LastName(),
                            BirthDate = faker.Date.Between(new DateTime(1960,1,1), new DateTime(2000,1,1)),
                            NationalInsuranceNumber = faker.Internet.Mac(),
                            ContactID = i
                        }
                    );
                }
            }
            context.SaveChanges();
            if (!context.Staff.Any())
            {
                List<int> positions = context.Positions.Select(i => i.PositionID).ToList();
                int SoftwareEngineer = context.Positions.FirstOrDefault(i => i.Name == "Software Engineer").PositionID;
                int SalesRepresentative = context.Positions.FirstOrDefault(i => i.Name == "Sales Representative").PositionID;
                int WebDesigner = context.Positions.FirstOrDefault(i => i.Name == "Associate Web Designer").PositionID;
                int Accountant = context.Positions.FirstOrDefault(i => i.Name == "Accountant").PositionID;
                for (int i = 0; i < 2; i++)
                {
                    positions.Add(SoftwareEngineer);
                    positions.Add(WebDesigner);
                    positions.Add(SalesRepresentative);
                    positions.Add(Accountant);
                }

                for (int i = 1; i <= 32; i++)
                {
                    int position = faker.PickRandom<int>(positions);
                    positions.Remove(position);

                    context.Staff.Add(
                        new Staff { 
                            PersonID = i,
                            PositionID = position,
                            HireDate = faker.Date.Between(new DateTime(2010,1,1), new DateTime(2020,1,1))
                        }
                    );
                }
            }
            context.SaveChanges();

            #endregion

        }
    }
}
