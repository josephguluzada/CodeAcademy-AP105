using AdoNetSolid.Concretes;
using AdoNetSolid.DAL;
using AdoNetSolid.Models;

namespace AdoNetSolid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country();
            country.Name = "Azerbaijan";
            country.AvgSalary = 1250;
            country.Population = 190000000;
            country.RegionId = 1;


            CountryService countryService = new CountryService();

            //countryService.Create(country);
            //countryService.Delete(23);

            //List<Country> countries = countryService.GetAll();

            //foreach (Country item in countries)
            //{
            //    Console.WriteLine(item);
            //}

            //CreateCountry(country);

            //foreach (var item in GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            Country country1 = GetById(8);
            Console.WriteLine(country1);
        }

        public static void CreateCountry(Country country)
        {
            AppDbContext context = new AppDbContext();

            context.Countries.Add(country);
            context.SaveChanges();
        }

        public static List<Country> GetAll()
        {
            AppDbContext context = new AppDbContext();
            return context.Countries.ToList();
        }

        public static Country GetById(int id)
        {
            AppDbContext context = new AppDbContext();

            Country country = context.Countries.FirstOrDefault(c => c.Id == id);
            if (country is null) throw new NullReferenceException();

            return country;
        }
    }
}