using AdoNetSolid.Abstracts;
using AdoNetSolid.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSolid.Concretes
{
    public class CountryService : IService<Country>
    {
        public void Create(Country model)
        {
            int check = SQLManager.ExecuteQuery($"INSERT INTO Countries VALUES ('{model.Name}',{model.AvgSalary}, {model.Population}, {model.RegionId})");
            if (check > 0) Console.WriteLine("Inserted!");
            else Console.WriteLine("Error!");
        }

        public void Delete(int id)
        {
            int check = SQLManager.ExecuteQuery($"DELETE FROM Countries WHERE Id = {id}");
            if (check > 0) Console.WriteLine("Deleted!");
            else Console.WriteLine("Error!");
        }

        public List<Country> GetAll()
        {
            List<Country> list = new List<Country>();

            var datas = SQLManager.Reader("SELECT * FROM Countries");

            foreach (DataRow row in datas.Rows)
            {
                list.Add(new Country { Id = Convert.ToInt32(row[0]), Name = row[1].ToString(), AvgSalary = Convert.ToDecimal(row[2]), Population = Convert.ToInt32(row[3]), RegionId = Convert.ToInt32(row[4]) });
            }

            return list;
        }

        public Country GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
