namespace CarService.Migrations
{
    using CarService.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarService.Models.CarServiceContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CarService.Models.CarServiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Merken.AddOrUpdate(a => a.Id,
             new Merk() { Id = 1, Name = "Alfa Romeo", },
             new Merk() { Id = 2, Name = "Audi" },
             new Merk() { Id = 3, Name = "BMW" },
             new Merk() { Id = 4, Name = "Citroen" },
             new Merk() { Id = 5, Name = "Daewoo" },
             new Merk() { Id = 6, Name = "Daihatsu" },
             new Merk() { Id = 7, Name = "Fiat" },
             new Merk() { Id = 8, Name = "Ford" },
             new Merk() { Id = 9, Name = "Honda" },
             new Merk() { Id = 10, Name = "Hyundai" },
             new Merk() { Id = 11, Name = "Jaguar" },
             new Merk() { Id = 12, Name = "Kia" },
             new Merk() { Id = 13, Name = "Landrover" },
             new Merk() { Id = 14, Name = "Mazda" },
             new Merk() { Id = 15, Name = "Mercedes" },
             new Merk() { Id = 16, Name = "Mitsubishi" },
             new Merk() { Id = 17, Name = "Nissan" },
             new Merk() { Id = 18, Name = "Opel" },
             new Merk() { Id = 19, Name = "Peugeot" },
             new Merk() { Id = 20, Name = "Porsche" },
             new Merk() { Id = 21, Name = "Renault" },
             new Merk() { Id = 22, Name = "Rover" },
             new Merk() { Id = 23, Name = "Saab" },
             new Merk() { Id = 24, Name = "Seat" },
             new Merk() { Id = 25, Name = "Skoda" },
             new Merk() { Id = 26, Name = "Smart" },
             new Merk() { Id = 27, Name = "Subaru" },
             new Merk() { Id = 28, Name = "Suzuki" },
             new Merk() { Id = 29, Name = "Toyota" },
             new Merk() { Id = 30, Name = "Volkswagen" },
             new Merk() { Id = 31, Name = "Volvo" }
             );

            context.CarModels.AddOrUpdate(m => m.Id,
                new CarModel()
                {
                    Id = 1,
                    ModelNaam = "Giulia",
                    MerkId = 1,
                    Prijs = 32300M
                },

                new CarModel()
                {
                    Id = 2,
                    ModelNaam = "Giulietta",
                    MerkId = 1,
                    Prijs = 23700M
                },

                new CarModel()
                {
                    Id = 3,
                    ModelNaam = "Stelvio",
                    MerkId = 1,
                    Prijs = 39500M
                },
                new CarModel()
                {
                    Id = 4,
                    ModelNaam = "MiTo",
                    MerkId = 1,
                    Prijs = 16530M
                },
                new CarModel()
                {
                    Id = 5,
                    ModelNaam = "MiTo",
                    MerkId = 1,
                    Prijs = 16530M
                },
                 new CarModel()
                 {
                     Id = 6,
                     ModelNaam = "156",
                     MerkId = 1,

                 },
                  new CarModel()
                  {
                      Id = 7,
                      ModelNaam = "Brera",
                      MerkId = 1,

                  },
                 new CarModel()
                 {
                     Id = 7,
                     ModelNaam = "Spider",
                     MerkId = 1,

                 },
                 new CarModel()
                 {
                     Id = 8,
                     ModelNaam = "A1",
                     MerkId = 2,
                     Prijs = 16530M
                 },
                 new CarModel()
                 {
                     Id = 9,
                     ModelNaam = "A3",
                     MerkId = 2,
                     Prijs = 23100M
                 },
                 new CarModel()
                 {
                     Id = 10,
                     ModelNaam = "A4",
                     MerkId = 2,
                     Prijs = 31310M
                 },
                 new CarModel()
                 {
                     Id = 11,
                     ModelNaam = "A5",
                     MerkId = 2,
                     Prijs = 37500M
                 },
                 new CarModel()
                 {
                     Id = 12,
                     ModelNaam = "A6",
                     MerkId = 2,
                     Prijs = 42300M
                 },
                 new CarModel()
                 {
                     Id = 13,
                     ModelNaam = "A7",
                     MerkId = 2,
                     Prijs = 69900M
                 },
                 new CarModel()
                 {
                     Id = 14,
                     ModelNaam = "1 Reeks",
                     MerkId = 3,
                     Prijs = 24450M
                 },
                 new CarModel()
                 {
                     Id = 15,
                     ModelNaam = "2 Reeks",
                     MerkId = 3,
                     Prijs = 24450M
                 },
                  new CarModel()
                  {
                      Id = 16,
                      ModelNaam = "3 Reeks",
                      MerkId = 3,
                      Prijs = 30750M
                  },
                   new CarModel()
                   {
                       Id = 17,
                       ModelNaam = "4 Reeks",
                       MerkId = 3,
                       Prijs = 39000M
                   },
                    new CarModel()
                    {
                        Id = 18,
                        ModelNaam = "5 Reeks",
                        MerkId = 3,
                        Prijs = 47500M
                    },
                     new CarModel()
                     {
                         Id = 19,
                         ModelNaam = "i3",
                         MerkId = 3,
                         Prijs = 38800M
                     },
                      new CarModel()
                      {
                          Id = 20,
                          ModelNaam = "X1",
                          MerkId = 3,
                          Prijs = 30600M
                      },
                       new CarModel()
                       {
                           Id = 21,
                           ModelNaam = "X3",
                           MerkId = 3,
                           Prijs = 45650M
                       },
                        new CarModel()
                        {
                            Id = 22,
                            ModelNaam = "Z4",
                            MerkId = 3,

                        },
                         new CarModel()
                         {
                             Id = 23,
                             ModelNaam = "C-Elysée",
                             MerkId = 4,
                             Prijs = 13650M
                         },
                         new CarModel()
                         {
                             Id = 24,
                             ModelNaam = "C-Zero",
                             MerkId = 4,
                             Prijs = 30235M
                         },
                         new CarModel()
                         {
                             Id = 25,
                             ModelNaam = "C1",
                             MerkId = 4,
                             Prijs = 8490M
                         },
                         new CarModel()
                         {
                             Id = 26,
                             ModelNaam = "C3",
                             MerkId = 4,
                             Prijs = 13255M
                         },
                         new CarModel()
                         {
                             Id = 27,
                             ModelNaam = "C4",
                             MerkId = 4,
                             Prijs = 16940M
                         },
                         new CarModel()
                         {
                             Id = 28,
                             ModelNaam = "C4 Cactus",
                             MerkId = 4,
                             Prijs = 16230M
                         },
                         new CarModel()
                         {
                             Id = 29,
                             ModelNaam = "C4 Picasso",
                             MerkId = 4,
                             Prijs = 24450M
                         },
                         new CarModel()
                         {
                             Id = 30,
                             ModelNaam = "C5",
                             MerkId = 4,
                             Prijs = 23595M
                         },
                         new CarModel()
                         {
                             Id = 31,
                             ModelNaam = "Nubira",
                             MerkId = 5,
                             Prijs = 2000M
                         },
                         new CarModel()
                         {
                             Id = 32,
                             ModelNaam = "Charade",
                             MerkId = 6,
                             Prijs = 500M
                         },
                         new CarModel()
                         {
                             Id = 33,
                             ModelNaam = "124 spider",
                             MerkId = 7,
                             Prijs = 27700M
                         },
                         new CarModel()
                         {
                             Id = 34,
                             ModelNaam = "500",
                             MerkId = 7,
                             Prijs = 11990M
                         },
                         new CarModel()
                         {
                             Id = 35,
                             ModelNaam = "Panda",
                             MerkId = 7,
                             Prijs = 9340M
                         },
                         new CarModel()
                         {
                             Id = 36,
                             ModelNaam = "Punto",
                             MerkId = 7,
                             Prijs = 13140M
                         },
                         new CarModel()
                         {
                             Id = 37,
                             ModelNaam = "Tipo",
                             MerkId = 7,
                             Prijs = 14790M
                         },
                         new CarModel()
                         {
                             Id = 38,
                             ModelNaam = "Bravo",
                             MerkId = 7

                         }, 
                         new CarModel()
                         {
                             Id = 39,
                             ModelNaam = "B-Max",
                             MerkId = 8,
                             Prijs = 18000M
                         },
                         new CarModel()
                         {
                             Id = 40,
                             ModelNaam = "Ecosport",
                             MerkId = 8,
                             Prijs = 18500M
                         },
                         new CarModel()
                         {
                             Id = 41,
                             ModelNaam = "Edge",
                             MerkId = 8,
                             Prijs = 43975M
                         },
                         new CarModel()
                         {
                             Id = 42,
                             ModelNaam = "Fiesta",
                             MerkId = 8,
                             Prijs = 15100M
                         },
                         new CarModel()
                         {
                             Id = 43,
                             ModelNaam = "Focus",
                             MerkId = 8,
                             Prijs = 19050M
                         },
                         new CarModel()
                         {
                             Id = 44,
                             ModelNaam = "Galaxy",
                             MerkId = 8,
                             Prijs = 37750M
                         },
                         new CarModel()
                         {
                             Id = 45,
                             ModelNaam = "Ka+",
                             MerkId = 8,
                             Prijs = 10300M
                         },
                         new CarModel()
                         {
                             Id = 46,
                             ModelNaam = "Kuga",
                             MerkId = 8,
                             Prijs = 24100M
                         },
                         new CarModel()
                         {
                             Id = 47,
                             ModelNaam = "Mondeo",
                             MerkId = 8,
                             Prijs = 34135M
                         },
                         new CarModel()
                         {
                             Id = 48,
                             ModelNaam = "S-Max",
                             MerkId = 8,
                             Prijs = 32350M
                         },
                         new CarModel()
                         {
                             Id = 49,
                             ModelNaam = "CR-V",
                             MerkId = 9

                         },
                         new CarModel()
                         {
                             Id = 50,
                             ModelNaam = "Jazz",
                             MerkId = 9

                         },
                         new CarModel()
                         {
                             Id = 51,
                             ModelNaam = "i10",
                             MerkId = 10,
                             Prijs = 24450M
                         },
                         new CarModel()
                         {
                             Id = 52,
                             ModelNaam = "i20",
                             MerkId = 10
                         },
                         new CarModel()
                         {
                             Id = 53,
                             ModelNaam = "XE",
                             MerkId = 11,
                             Prijs = 30060M
                         },
                         new CarModel()
                         {
                             Id = 54,
                             ModelNaam = "XJ",
                             MerkId = 11,
                             Prijs = 86740M
                         },
                         new CarModel()
                         {
                             Id = 55,
                             ModelNaam = "E-PACE",
                             MerkId = 11,
                             Prijs = 36050M
                         },
                         new CarModel()
                         {
                             Id = 56,
                             ModelNaam = "Carens",
                             MerkId = 12,
                             Prijs = 22090M
                         },
                         new CarModel()
                         {
                             Id = 57,
                             ModelNaam = "Rio",
                             MerkId = 12,
                             Prijs = 14390M
                         },
                         new CarModel()
                         {
                             Id = 58,
                             ModelNaam = "Picanto",
                             MerkId = 12,
                             Prijs = 10840M
                         },
                         new CarModel()
                         {
                             Id = 59,
                             ModelNaam = "Venga",
                             MerkId = 12,
                             Prijs = 15990M
                         },
                         new CarModel()
                         {
                             Id = 60,
                             ModelNaam = "cee'd",
                             MerkId = 12,
                             Prijs = 17540M
                         },
                         new CarModel()
                         {
                             Id = 61,
                             ModelNaam = "Hybrid",
                             MerkId = 12,
                             Prijs = 26490M
                         },
                         new CarModel()
                         {
                             Id = 62,
                             ModelNaam = "Optima",
                             MerkId = 12,
                             Prijs = 29090M
                         },
                         new CarModel()
                         {
                             Id = 63,
                             ModelNaam = "Soul EV",
                             MerkId = 12,
                             Prijs = 35890M
                         },
                         new CarModel()
                         {
                             Id = 64,
                             ModelNaam = "Discovery",
                             MerkId = 13,
                             Prijs = 35100M
                         },
                         new CarModel()
                         {
                             Id = 65,
                             ModelNaam = "Range Rover Evoque",
                             MerkId = 13,
                             Prijs = 36550M
                         },
                         new CarModel()
                         {
                             Id = 66,
                             ModelNaam = "Mazda2",
                             MerkId = 14,
                             Prijs = 12990M
                         },
                         new CarModel()
                         {
                             Id = 67,
                             ModelNaam = "Mazda3",
                             MerkId = 14,
                             Prijs = 18490M
                         },
                         new CarModel()
                         {
                             Id = 68,
                             ModelNaam = "CX-3",
                             MerkId = 14,
                             Prijs = 17990M
                         },
                         new CarModel()
                         {
                             Id = 69,
                             ModelNaam = "CX-5",
                             MerkId = 14,
                             Prijs = 24990M
                         },
                         new CarModel()
                         {
                             Id = 70,
                             ModelNaam = "MX-5",
                             MerkId = 14,
                             Prijs = 22590M
                         },
                         new CarModel()
                         {
                             Id = 71,
                             ModelNaam = "A-Klasse",
                             MerkId = 15,
                             Prijs = 24684M
                         },
                         new CarModel()
                         {
                             Id = 72,
                             ModelNaam = "B-Klasse",
                             MerkId = 15,
                             Prijs = 26257M
                         },
                         new CarModel()
                         {
                             Id = 73,
                             ModelNaam = "C-Klasse",
                             MerkId = 15,
                             Prijs = 31460M
                         },
                         new CarModel()
                         {
                             Id = 74,
                             ModelNaam = "CLA",
                             MerkId = 15,
                             Prijs = 29282M
                         },
                         new CarModel()
                         {
                             Id = 75,
                             ModelNaam = "GLA SUV",
                             MerkId = 15,
                             Prijs = 27951M
                         },
                         new CarModel()
                         {
                             Id = 76,
                             ModelNaam = "SPACE STAR",
                             MerkId = 16,
                             Prijs = 12189M
                         },
                         new CarModel()
                         {
                             Id = 77,
                             ModelNaam = "ASX",
                             MerkId = 16,
                             Prijs = 20689M

                         },
                         new CarModel()
                         {
                             Id = 78,
                             ModelNaam = "ECLIPSE CROSS",
                             MerkId = 16,
                             Prijs = 26489M
                         },
                         new CarModel()
                         {
                             Id = 79,
                             ModelNaam = "OUTLANDER",
                             MerkId = 16,
                             Prijs = 27490M
                         },
                         new CarModel()
                         {
                             Id = 80,
                             ModelNaam = "JUKE",
                             MerkId = 17,
                             Prijs = 16640M
                         },
                         new CarModel()
                         {
                             Id = 81,
                             ModelNaam = "MICRA",
                             MerkId = 17,
                             Prijs = 13989M
                         },
                         new CarModel()
                         {
                             Id = 82,
                             ModelNaam = "NOTE",
                             MerkId = 17,
                             Prijs = 14040M
                         },
                         new CarModel()
                         {
                             Id = 83,
                             ModelNaam = "LEAF",
                             MerkId = 17,
                             Prijs = 24739M
                         },
                         new CarModel()
                         {
                             Id = 84,
                             ModelNaam = "ADAM",
                             MerkId = 18,
                             Prijs = 12324M
                         },
                         new CarModel()
                         {
                             Id = 85,
                             ModelNaam = "ANTARA",
                             MerkId = 18,
                             Prijs = 28949M
                         },
                         new CarModel()
                         {
                             Id = 86,
                             ModelNaam = "AMPERA",
                             MerkId = 18,
                             Prijs = 36900M
                         },
                         new CarModel()
                         {
                             Id = 87,
                             ModelNaam = "ASTRA",
                             MerkId = 18,
                             Prijs = 18075M
                         },
                         new CarModel()
                         {
                             Id = 88,
                             ModelNaam = "CASCADA",
                             MerkId = 18,
                             Prijs = 26550M
                         },
                         new CarModel()
                         {
                             Id = 89,
                             ModelNaam = "CORSA",
                             MerkId = 18,
                             Prijs = 13775M
                         },
                         new CarModel()
                         {
                             Id = 90,
                             ModelNaam = "CROSSLAND X",
                             MerkId = 18,
                             Prijs = 17900M
                         },
                         new CarModel()
                         {
                             Id = 91,
                             ModelNaam = "GRANDLAND X",
                             MerkId = 18,
                             Prijs = 25599M
                         },
                         new CarModel()
                         {
                             Id = 92,
                             ModelNaam = "GTC",
                             MerkId = 18,
                             Prijs = 23374M
                         },
                         new CarModel()
                         {
                             Id = 93,
                             ModelNaam = "INSIGNIA",
                             MerkId = 18,
                             Prijs = 27504M
                         },
                         new CarModel()
                         {
                             Id = 94,
                             ModelNaam = "KARL",
                             MerkId = 18,
                             Prijs = 11650M
                         },
                         new CarModel()
                         {
                             Id = 95,
                             ModelNaam = "MERIVA",
                             MerkId = 18,
                             Prijs = 18275M
                         },
                         new CarModel()
                         {
                             Id = 96,
                             ModelNaam = "MOKKA",
                             MerkId = 18,
                             Prijs = 17850M
                         },
                         new CarModel()
                         {
                             Id = 97,
                             ModelNaam = "108",
                             MerkId = 19,
                             Prijs = 10644M
                         },
                         new CarModel()
                         {
                             Id = 97,
                             ModelNaam = "208",
                             MerkId = 19,
                             Prijs = 13624M
                         },
                         new CarModel()
                         {
                             Id = 98,
                             ModelNaam = "2008",
                             MerkId = 19,
                             Prijs = 18145M
                         },
                         new CarModel()
                         {
                             Id = 99,
                             ModelNaam = "308",
                             MerkId = 19,
                             Prijs = 20109M
                         },
                         new CarModel()
                         {
                             Id = 100,
                             ModelNaam = "3008",
                             MerkId = 19,
                             Prijs = 25999M
                         },
                         new CarModel()
                         {
                             Id = 101,
                             ModelNaam = "4007",
                             MerkId = 19,
                             Prijs = 31959M
                         },
                         new CarModel()
                         {
                             Id = 102,
                             ModelNaam = "5008",
                             MerkId = 19,
                             Prijs = 27150M
                         },
                         new CarModel()
                         {
                             Id = 103,
                             ModelNaam = "508",
                             MerkId = 19,
                             Prijs = 30750M
                         },
                         new CarModel()
                         {
                             Id = 104,
                             ModelNaam = "718 BOXSTER",
                             MerkId = 20,
                             Prijs = 55022M
                         },
                         new CarModel()
                         {
                             Id = 105,
                             ModelNaam = "718 CAYMAN",
                             MerkId = 20,
                             Prijs = 52964M
                         },
                         new CarModel()
                         {
                             Id = 106,
                             ModelNaam = "911",
                             MerkId = 20,
                             Prijs = 101252M
                         },
                         new CarModel()
                         {
                             Id = 107,
                             ModelNaam = "CAYENNE",
                             MerkId = 20,
                             Prijs = 73543M
                         },
                         new CarModel()
                         {
                             Id = 108,
                             ModelNaam = "MACAN",
                             MerkId = 20,
                             Prijs = 57259M
                         },
                         new CarModel()
                         {
                             Id = 109,
                             ModelNaam = "PANAMERA",
                             MerkId = 20,
                             Prijs = 93871M
                         },
                         new CarModel()
                         {
                             Id = 110,
                             ModelNaam = "CAPTUR",
                             MerkId = 21,
                             Prijs = 16600M
                         },
                         new CarModel()
                         {
                             Id = 111,
                             ModelNaam = "CLIO",
                             MerkId = 21,
                             Prijs = 13924M
                         },
                         new CarModel()
                         {
                             Id = 112,
                             ModelNaam = "ESPACE",
                             MerkId = 21,
                             Prijs = 36149M
                         },
                         new CarModel()
                         {
                             Id = 113,
                             ModelNaam = "KADJAR",
                             MerkId = 21,
                             Prijs = 22450M
                         },
                         new CarModel()
                         {
                             Id = 114,
                             ModelNaam = "KOLEOS",
                             MerkId = 21,
                             Prijs = 32150M
                         },
                         new CarModel()
                         {
                             Id = 115,
                             ModelNaam = "MEGANE",
                             MerkId = 21,
                             Prijs = 17949M
                         },
                         new CarModel()
                         {
                             Id = 116,
                             ModelNaam = "SCENIC",
                             MerkId = 21,
                             Prijs = 21849M
                         }, 
                         new CarModel()
                         {
                             Id = 117,
                             ModelNaam = "TALISMAN",
                             MerkId = 21,
                             Prijs = 26249M
                         },
                         new CarModel()
                         {
                             Id = 118,
                             ModelNaam = "TWINGO",
                             MerkId = 21,
                             Prijs = 10300M
                         },
                         new CarModel()
                         {
                             Id = 119,
                             ModelNaam = "TWIZY",
                             MerkId = 21,
                             Prijs = 6990M
                         },
                         new CarModel()
                         {
                             Id = 120,
                             ModelNaam = "ZOE",
                             MerkId = 21,
                             Prijs = 22249M
                         },
                         new CarModel()
                         {
                             Id = 121,
                             ModelNaam = "75",
                             MerkId = 22,
                             Prijs = 2000M
                         },
                         new CarModel()
                         {
                             Id = 122,
                             ModelNaam = "9-3X",
                             MerkId = 23
                         },
                         new CarModel()
                         {
                             Id = 123,
                             ModelNaam = "9-7X",
                             MerkId = 23
                         },
                         new CarModel()
                         {
                             Id = 124,
                             ModelNaam = "ALHAMBRA",
                             MerkId = 24,
                             Prijs = 32989M
                         },
                         new CarModel()
                         {
                             Id = 125,
                             ModelNaam = "ATECA",
                             MerkId = 24,
                             Prijs = 20673M
                         },
                         new CarModel()
                         {
                             Id = 125,
                             ModelNaam = "IBIZA",
                             MerkId = 24,
                             Prijs = 13754M
                         },
                         new CarModel()
                         {
                             Id = 126,
                             ModelNaam = "LEON",
                             MerkId = 24,
                             Prijs = 16319M
                         },
                         new CarModel()
                         {
                             Id = 127,
                             ModelNaam = "MII",
                             MerkId = 24,
                             Prijs = 9545M
                         },
                         new CarModel()
                         {
                             Id = 128,
                             ModelNaam = "TOLEDO",
                             MerkId = 24,
                             Prijs = 18509M
                         },
                         new CarModel()
                         {
                             Id = 129,
                             ModelNaam = "CITIGO",
                             MerkId = 25,
                             Prijs = 9230M
                         },
                         new CarModel()
                         {
                             Id = 130,
                             ModelNaam = "FABIA",
                             MerkId = 25,
                             Prijs = 12596M
                         },
                         new CarModel()
                         {
                             Id = 131,
                             ModelNaam = "KODIAQ",
                             MerkId = 25,
                             Prijs = 26164M
                         },
                         new CarModel()
                         {
                             Id = 132,
                             ModelNaam = "OCTAVIA",
                             MerkId = 25,
                             Prijs = 20120M
                         },
                         new CarModel()
                         {
                             Id = 133,
                             ModelNaam = "RAPID",
                             MerkId = 25,
                             Prijs = 17757M
                         },
                         new CarModel()
                         {
                             Id = 134,
                             ModelNaam = "SUPERB",
                             MerkId = 25,
                             Prijs = 27285M
                         },
                         new CarModel()
                         {
                             Id = 135,
                             ModelNaam = "YETI",
                             MerkId = 25,
                             Prijs = 19474M
                         },
                         new CarModel()
                         {
                             Id = 136,
                             ModelNaam = "FORFOUR",
                             MerkId = 26,
                             Prijs = 10890M
                         },
                         new CarModel()
                         {
                             Id = 137,
                             ModelNaam = "FORTWO",
                             MerkId = 26,
                             Prijs = 9922M
                         },
                         new CarModel()
                         {
                             Id = 138,
                             ModelNaam = "BRZ",
                             MerkId = 27,
                             Prijs = 33794M
                         },
                         new CarModel()
                         {
                             Id = 139,
                             ModelNaam = "FORESTER",
                             MerkId = 27,
                             Prijs = 26694M
                         },
                         new CarModel()
                         {
                             Id = 140,
                             ModelNaam = "IMPREZA",
                             MerkId = 27,
                             Prijs = 42295M
                         },
                         new CarModel()
                         {
                             Id = 141,
                             ModelNaam = "LEVORG",
                             MerkId = 27,
                             Prijs = 30695M
                         },
                         new CarModel()
                         {
                             Id = 142,
                             ModelNaam = "OUTBACK",
                             MerkId = 27,
                             Prijs = 34295M
                         },
                         new CarModel()
                         {
                             Id = 143,
                             ModelNaam = "XV",
                             MerkId = 27,
                             Prijs = 19994M
                         },
                         new CarModel()
                         {
                             Id = 144,
                             ModelNaam = "BALENO",
                             MerkId = 28,
                             Prijs = 16198M
                         },
                         new CarModel()
                         {
                             Id = 145,
                             ModelNaam = "CELERIO",
                             MerkId = 28,
                             Prijs = 10798M
                         },
                         new CarModel()
                         {
                             Id = 146,
                             ModelNaam = "IGNIS",
                             MerkId = 28,
                             Prijs = 14198M
                         },
                         new CarModel()
                         {
                             Id = 147,
                             ModelNaam = "JIMNY",
                             MerkId = 28,
                             Prijs = 15399M
                         },
                         new CarModel()
                         {
                             Id = 148,
                             ModelNaam = "SWIFT",
                             MerkId = 28,
                             Prijs = 14698M
                         },
                         new CarModel()
                         {
                             Id = 149,
                             ModelNaam = "SX4S-CROSS",
                             MerkId = 28,
                             Prijs = 19499M
                         },
                         new CarModel()
                         {
                             Id = 150,
                             ModelNaam = "VITARA",
                             MerkId = 28,
                             Prijs = 19299M
                         },
                         new CarModel()
                         {
                             Id = 151,
                             ModelNaam = "AURIS",
                             MerkId = 29,
                             Prijs = 19360M
                         },
                         new CarModel()
                         {
                             Id = 152,
                             ModelNaam = "AVENSIS",
                             MerkId = 29,
                             Prijs = 26340M
                         },
                         new CarModel()
                         {
                             Id = 153,
                             ModelNaam = "AYGO",
                             MerkId = 29,
                             Prijs = 11760M
                         },
                         new CarModel()
                         {
                             Id = 154,
                             ModelNaam = "C-HR",
                             MerkId = 29,
                             Prijs = 22580M
                         },
                         new CarModel()
                         {
                             Id = 155,
                             ModelNaam = "COROLLA",
                             MerkId = 29,
                             Prijs = 23639M
                         },
                         new CarModel()
                         {
                             Id = 156,
                             ModelNaam = "GT86",
                             MerkId = 29,
                             Prijs = 33400M
                         },
                         new CarModel()
                         {
                             Id = 157,
                             ModelNaam = "LANDCRUISER",
                             MerkId = 29,
                             Prijs = 37699M
                         },
                         new CarModel()
                         {
                             Id = 158,
                             ModelNaam = "MIRAI",
                             MerkId = 29,
                             Prijs = 79900M
                         },
                         new CarModel()
                         {
                             Id = 159,
                             ModelNaam = "PRIUS",
                             MerkId = 29,
                             Prijs = 30310M
                         },
                         new CarModel()
                         {
                             Id = 160,
                             ModelNaam = "RAV4",
                             MerkId = 29,
                             Prijs = 28650M
                         },
                         new CarModel()
                         {
                             Id = 161,
                             ModelNaam = "VERSO",
                             MerkId = 29,
                             Prijs = 22040M
                         },
                         new CarModel()
                         {
                             Id = 162,
                             ModelNaam = "YARIS",
                             MerkId = 29,
                             Prijs = 14989M
                         },
                         new CarModel()
                         {
                             Id = 163,
                             ModelNaam = "CC",
                             MerkId = 30,
                             Prijs = 34990M
                         },
                         new CarModel()
                         {
                             Id = 164,
                             ModelNaam = "GOLF",
                             MerkId = 30,
                             Prijs = 18067M
                         },
                         new CarModel()
                         {
                             Id = 165,
                             ModelNaam = "GOLF PLUS",
                             MerkId = 30,
                             Prijs = 19763M
                         },
                         new CarModel()
                         {
                             Id = 166,
                             ModelNaam = "JETTA",
                             MerkId = 30,
                             Prijs = 24100M
                         },
                         new CarModel()
                         {
                             Id = 167,
                             ModelNaam = "NEW BEETLE",
                             MerkId = 30,
                             Prijs = 19153M
                         },
                         new CarModel()
                         {
                             Id = 168,
                             ModelNaam = "PASSAT",
                             MerkId = 30,
                             Prijs = 27609M
                         },
                         new CarModel()
                         {
                             Id = 169,
                             ModelNaam = "POLO",
                             MerkId = 30,
                             Prijs = 14389M
                         },
                         new CarModel()
                         {
                             Id = 170,
                             ModelNaam = "SCIROCCO",
                             MerkId = 30,
                             Prijs = 26847M
                         },
                         new CarModel()
                         {
                             Id = 171,
                             ModelNaam = "SHARAN",
                             MerkId = 30,
                             Prijs = 33983M
                         }, 
                         new CarModel()
                         {
                             Id = 172,
                             ModelNaam = "TIGUAN",
                             MerkId = 30,
                             Prijs = 27699M
                         },
                         new CarModel()
                         {
                             Id = 173,
                             ModelNaam = "TOUAREG",
                             MerkId = 30,
                             Prijs = 55840M
                         },
                         new CarModel()
                         {
                             Id = 174,
                             ModelNaam = "TOURAN",
                             MerkId = 30,
                             Prijs = 24634M
                         },
                         new CarModel()
                         {
                             Id = 175,
                             ModelNaam = "T-ROC",
                             MerkId = 30,
                             Prijs = 20818M
                         },
                         new CarModel()
                         {
                             Id = 176,
                             ModelNaam = "UP!",
                             MerkId = 30,
                             Prijs = 10486M
                         },
                         new CarModel()
                         {
                             Id = 177,
                             ModelNaam = "S60",
                             MerkId = 31,
                             Prijs = 30340M
                         },
                         new CarModel()
                         {
                             Id = 178,
                             ModelNaam = "S60 CROSS COUNTRY",
                             MerkId = 31,
                             Prijs = 36940M
                         },
                         new CarModel()
                         {
                             Id = 179,
                             ModelNaam = "S90",
                             MerkId = 31,
                             Prijs = 44599M
                         },
                         new CarModel()
                         {
                             Id = 180,
                             ModelNaam = "V40",
                             MerkId = 31,
                             Prijs = 24699M
                         },
                         new CarModel()
                         {
                             Id = 181,
                             ModelNaam = "V40 CROSS COUNTRY",
                             MerkId = 31,
                             Prijs = 36940M
                         },
                         new CarModel()
                         {
                             Id = 182,
                             ModelNaam = "V60",
                             MerkId = 31,
                             Prijs = 31840M
                         },
                         new CarModel()
                         {
                             Id = 183,
                             ModelNaam = "V60 CROSS COUNTRY",
                             MerkId = 31,
                             Prijs = 35839M
                         },
                         new CarModel()
                         {
                             Id = 184,
                             ModelNaam = "V90",
                             MerkId = 31,
                             Prijs = 41999M
                         },
                         new CarModel()
                         {
                             Id = 185,
                             ModelNaam = "XC40",
                             MerkId = 31,
                             Prijs = 30400M
                         },
                         new CarModel()
                         {
                             Id = 186,
                             ModelNaam = "XC60",
                             MerkId = 31,
                             Prijs = 47300M
                         },
                         new CarModel()
                         {
                             Id = 187,
                             ModelNaam = "XC90",
                             MerkId = 31,
                             Prijs = 59600M
                         }

                 );
        }
    }
}

      