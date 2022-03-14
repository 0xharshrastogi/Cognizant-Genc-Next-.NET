using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkShopEnrollmentApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TraineeBO objTraineeBO = new TraineeBO();
            TraineeBL objTraineeBL = new TraineeBL();
            string traineeName = string.Empty;
            string batchCode = string.Empty;
            int numberOfTrainees = 0;

            try
            {
                Console.WriteLine("Enter number of trainees:");
                numberOfTrainees = int.Parse(Console.ReadLine());
            }
            catch (FormatException traineeNumberException)
            {
                Console.WriteLine(traineeNumberException.Message);
                Environment.Exit(0);
            }

            for (int i = 0; i < numberOfTrainees; i++)
            {
                try
                {
                    Console.WriteLine("\nEnter Trainee Name:");
                    traineeName = Console.ReadLine();
                    if (string.IsNullOrEmpty(traineeName))
                        throw new Exception("Trainee Name can not be null or empty");
                    else
                        objTraineeBO.TraineeName = traineeName;
                }

                catch (Exception nameException)
                {
                    Console.WriteLine(nameException.Message);
                    Environment.Exit(0);
                }

                try
                {
                    Console.WriteLine("Enter Trainee Id:");
                    objTraineeBO.TraineeId = long.Parse(Console.ReadLine());
                }
                catch (FormatException idException)
                {
                    Console.WriteLine(idException.Message);
                    Environment.Exit(0);
                }

                try
                {
                    Console.WriteLine("Enter Trainee Batch Code:");
                    batchCode = Console.ReadLine();
                    if (string.IsNullOrEmpty(batchCode))
                        throw new Exception("Batch Code can not be null or empty");
                    else
                        objTraineeBO.BatchCode = batchCode;
                }
                catch (Exception batchCodeException)
                {
                    Console.WriteLine(batchCodeException.Message);
                    Environment.Exit(0);
                }

                bool insertResult = objTraineeBL.SaveTraineeDetails(objTraineeBO);

                if (insertResult == true)
                {
                    Console.WriteLine("Trainee Details Successfully added to database");
                }
                else
                {
                    Console.WriteLine("Trainee insertion failed..Duplicate TraineeId present or wrong application logic");
                    Console.WriteLine("Try Again");
                    i--;
                }
            }
        }
    }
}