using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonsLib
{
    public class SeasonTeller
    {
        public string DisplaySeasonBy(string monthName)
        {
            string seasonName;

            if (monthName.Equals("February", StringComparison.OrdinalIgnoreCase) || monthName.Equals("March", StringComparison.OrdinalIgnoreCase))
            {
                seasonName = "Spring";
            }
            else if (monthName.Equals("April", StringComparison.OrdinalIgnoreCase) || monthName.Equals("May", StringComparison.OrdinalIgnoreCase) || monthName.Equals("June", StringComparison.OrdinalIgnoreCase))
            {
                seasonName = "Summer";
            }
            else if (monthName.Equals("July", StringComparison.OrdinalIgnoreCase) || monthName.Equals("August", StringComparison.OrdinalIgnoreCase) || monthName.Equals("September", StringComparison.OrdinalIgnoreCase))
            {
                seasonName = "Monsoon";
            }
            else if (monthName.Equals("October", StringComparison.OrdinalIgnoreCase) || monthName.Equals("November", StringComparison.OrdinalIgnoreCase))
            {

                seasonName = "Autumn";

            }
            else if (monthName.Equals("December", StringComparison.OrdinalIgnoreCase) || monthName.Equals("January", StringComparison.OrdinalIgnoreCase))
            {

                seasonName = "Winter";

            }
            else
            {
                return "Invalid Season";

            }

            return seasonName;
        }
    }
}
