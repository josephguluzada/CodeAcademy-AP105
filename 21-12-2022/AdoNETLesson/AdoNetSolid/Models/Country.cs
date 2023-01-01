using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSolid.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AvgSalary { get; set; }
        public int Population { get; set; }
        public int RegionId { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} {AvgSalary} {Population} {RegionId}";
        }
    }
}
