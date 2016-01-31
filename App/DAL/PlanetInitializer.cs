using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models;

namespace App.DAL
{
    public class PlanetInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            var details = new List<Details> {
                new Details { name  = "Mercury", distanceFromSun ="57.910.000 km", mass="3,285 × 10^23 kg", density="5,43 g/cm³", diameter="4.879,4 km", gravity="3.7 m/s²", orbit="0.240 846 yr"},
                new Details { name  = "Venus", distanceFromSun ="108 208 930 km", mass="4.8675×10^24 kg", density="5.243 g/cm³", diameter="12,092 km", gravity="8.87 m/s²", orbit="0.615198 yr"},
                new Details { name  = "Earth", distanceFromSun ="149 598 261 km", mass="5,972 × 10^24 kg", density="5,515 g/cm³", diameter="12 756,2 km", gravity="9,780327 m/s²", orbit="1 yr"},
                new Details { name  = "Mars", distanceFromSun ="227.939.100 km", mass="6,4174×10^23 kg", density="3,933 g/cm³", diameter="6792,4 km", gravity="3.711 m/s²", orbit="1,8808 yr"},
                new Details { name  = "Jupiter", distanceFromSun ="778 547 200 km", mass="1,8986×10^27 kg", density="1,326 g/cm³", diameter="142 984 ± 8 km", gravity="24,79 m/s²", orbit="11,85920 yr"},
                new Details { name  = "Saturn", distanceFromSun ="1 433 449 370 km", mass="5,6846 × 10^26 kg", density="0,687 g/cm³", diameter="120 536 km", gravity="10,44 m/s²", orbit="29,4571 yr"},
                new Details { name  = "Uranus", distanceFromSun ="2 876 679 082 km", mass="(8,6810 ± 0,0013)×10^25 kg", density="1,27 g/cm³", diameter="51 118 ± 8 km", gravity="8,69 m/s²", orbit="84,323326 yr"},
                new Details { name  = "Neptune", distanceFromSun ="4 5034 436 61 km", mass="1,0243×10^26 kg", density="1,638 g/cm³", diameter="49 528 km", gravity="11,15 m/s²", orbit="164,79 yr"},
                new Details { name  = "Pluto", distanceFromSun ="5 906 376 272 km", mass="(1,305 ± 0,007) × 10^22 kg", density="2,03 ± 0,06 g/cm³", diameter="2 370 ± 10 km", gravity="0,658 m/s²", orbit="248,09 yr"},
            };
            details.ForEach(s => context.Details.Add(s));
            context.SaveChanges();
        }
    }
}
