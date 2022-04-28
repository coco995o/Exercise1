using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        public class Job
        {
            private string jobDescription;
            private double timeInHours;
            private double perHourRate;
            private double totalFee;

            public Job() 
            { 
            }
            public string JobDescription
            {
                get 
                { 
                    return jobDescription;
                }
                set 
                { 
                    jobDescription = value;
                }
            }
            public double TimeInHours
            {
                get 
                {
                    return timeInHours;
                }
                set 
                {
                    timeInHours = value;
                }
            }
            public double PerHourRate
            {
                get 
                { 
                    return perHourRate;
                }
                set 
                { 
                    perHourRate = value;
                }
            }
            public double TotalFee
            {
                get 
                { 
                    return totalFee;
                }
            }
            public void calcTotalFee() 
            {
                totalFee = timeInHours * perHourRate;
            }
        }
        static void Main(string[] args)
        {
            Job job1 = new Job();
            job1.JobDescription = "We wash";
            job1.TimeInHours = 3;
            job1.PerHourRate = 15;
            job1.calcTotalFee();
            Console.WriteLine("The total fee for the first job is:{0}", job1.TotalFee);

            Job job2 = new Job();
            job2.JobDescription = "We repair your car";
            job2.TimeInHours = 8;
            job2.PerHourRate = 30;
            job2.calcTotalFee();
            Console.WriteLine("The total fee for the second job is:{0}", job2.TotalFee);

            Job addedJob=new Job();
            addedJob.JobDescription = job1.JobDescription + " and " + job2.JobDescription;
            Console.WriteLine(addedJob.JobDescription);
        }
    }
}
