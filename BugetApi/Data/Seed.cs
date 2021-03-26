using BugetApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugetApi.Data
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            // Seed Departament
            if (!context.Departaments.Any())
            {
                var departaments = new List<Departament>
                {
                    new Departament
                    {
                        NumeUtilizator="vladmoisei",
                        Denumire="Facturi",
                    },
                    new Departament
                    {
                        NumeUtilizator="vladmoisei",
                        Denumire="Familie",
                    },
                };

                context.Departaments.AddRange(departaments);
            }

            // Seed Cheltuieli
            if (!context.Cheltuialas.Any())
            {
                var cheltuieli = new List<Cheltuiala>
                {
                    new Cheltuiala
                    {
                        Data=DateTime.Now,
                        NumeUtilizator="vladmoisei",
                        Denumire="Benzina",
                        Suma=400,
                        IsCheltuialaObligatorie=true,
                        IsCheltuit=false
                    },
                    new Cheltuiala
                    {
                        Data=DateTime.Now.AddDays(3),
                        NumeUtilizator="vladmoisei",
                        Denumire="Factura Curent",
                        Suma=250,
                        IsCheltuialaObligatorie=true,
                        IsCheltuit=true
                    },
                    new Cheltuiala
                    {
                        Data=DateTime.Now.AddDays(1),
                        NumeUtilizator="vladmoisei",
                        Denumire="Factura gaze",
                        Suma=100,
                        IsCheltuialaObligatorie=true,
                        IsCheltuit=false
                    },new Cheltuiala
                    {
                        Data=DateTime.Now.AddDays(2),
                        NumeUtilizator="vladmoisei",
                        Denumire="Factura RDS",
                        Suma=105,
                        IsCheltuialaObligatorie=true,
                        IsCheltuit=false
                    },
                };

                context.Cheltuialas.AddRange(cheltuieli);
            }


            await context.SaveChangesAsync();
        }
    }
}
