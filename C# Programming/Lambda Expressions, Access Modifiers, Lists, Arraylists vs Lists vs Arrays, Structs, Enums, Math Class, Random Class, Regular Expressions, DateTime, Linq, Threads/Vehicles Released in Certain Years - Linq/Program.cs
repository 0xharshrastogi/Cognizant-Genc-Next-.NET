using Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace LinqApp1
{
    public class Program
    {
        public static List<Vehicle> VehicleList = new List<Vehicle>()
                                {
                                    new Vehicle("HO345","CRV","Honda",2015),
                                    new Vehicle("HY562","Creta","Hyundai",2017),
                                    new Vehicle("RE198","Duster","Reanult",2014),
                                    new Vehicle("MA623","Spacio","Suzuki",2014),
                                    new Vehicle("TR498","Nexon","Tata",2015),
                                    new Vehicle("TR981","Zest","Tata",2016),
                                    new Vehicle("HO245","WRV","Honda",2018)

                                };

        static void Main(string[] args)
        {
            Console.WriteLine("Enter From Year:");
            var fromYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter To Year:");
            var toYear = int.Parse(Console.ReadLine());

            GetVehicleName(fromYear, toYear);
        }

        public static void GetVehicleName(int fromYear, int toYear)
        {
            var vehicles = VehicleList.Where((vehicle) => vehicle.ReleaseYear >= fromYear && vehicle.ReleaseYear <= toYear);
            foreach (var vehicle in vehicles) Console.WriteLine(vehicle.VehicleName);
        }


        /** DO NOT CHANGE this ParameterExpression **/
        public static ParameterExpression variableExpr = Expression.Variable(typeof(IEnumerable<Vehicle>), "sampleVar");

        public static Expression GetMyExpression(int fromYear, int toYear)
        {
            Expression assignExpr = Expression.Assign(variableExpr, Expression.Constant(from vehicle in VehicleList
                                                                                        where vehicle.ReleaseYear >= fromYear && vehicle.ReleaseYear <= toYear
                                                                                        select vehicle));
            return assignExpr;
        }

    }
}
