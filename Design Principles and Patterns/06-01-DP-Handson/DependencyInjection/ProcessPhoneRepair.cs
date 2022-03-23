using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles.DependencyInjection
{
    class ProcessPhoneRepair
    {
        /// <summary>
        /// Method that lists the steps in a phone's repair
        /// Any phone model that IMPLEMENTS all the methods of the interface IPhone can be INSERTED AS DEPENDENCIES to this method.
        /// This would be the common set of steps in the repair
        /// </summary>
        /// <param name="phone">Any class that implements the IPhone interface</param>
        public void RepairSteps(IPhone phone)
        {
            string part1 = phone.GetPhonePart1();
            Console.WriteLine(string.Format("{0} repaired", part1));

            double partCost = phone.GetPart1Cost();
            Console.WriteLine(string.Format("Repair cost {0}", partCost * 0.5));
        }
    }
}
