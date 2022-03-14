using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopEnrollmentApp
{
    public class TraineeBL
    {
        public bool SaveTraineeDetails(TraineeBO objBO)
        {
            TraineeDA h = new TraineeDA();
            bool b = h.AddTraineeDetails(objBO);
            return b;
        }
    }
}