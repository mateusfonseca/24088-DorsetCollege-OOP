using System;

namespace Ex6_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Job j1 = new Job("wash windows", (decimal)3.5, 25);
            Job j2 = new Job("walk dogs", (decimal)2.3, 13.50);
            Job j3 = j1 + j2;

            System.Console.WriteLine(j1.JobDescription);
            System.Console.WriteLine(j1.TimeToCompletion);
            System.Console.WriteLine(j1.HourlyRate);
            System.Console.WriteLine(j1.TotalFee);
            System.Console.WriteLine();
            System.Console.WriteLine(j2.JobDescription);
            System.Console.WriteLine(j2.TimeToCompletion);
            System.Console.WriteLine(j2.HourlyRate);
            System.Console.WriteLine(j2.TotalFee);
            System.Console.WriteLine();
            System.Console.WriteLine(j3.JobDescription);
            System.Console.WriteLine(j3.TimeToCompletion);
            System.Console.WriteLine(j3.HourlyRate);
            System.Console.WriteLine(j3.TotalFee);
            System.Console.WriteLine();
        }
    }

    class Job
    {
        private string jobDescription;
        private decimal hourlyRate, totalFee;
        private double timeToCompletion;

        public Job(string jobDescription, decimal hourlyRate, double timeToCompletion) {
            this.JobDescription = jobDescription;
            this.HourlyRate = hourlyRate;
            this.TimeToCompletion = timeToCompletion;
        }

        public string JobDescription {
            get {
                return jobDescription;
            }
            set {
                jobDescription = value;
            }
        }
        public decimal HourlyRate {
            get {
                return hourlyRate;
            }
            set {
                hourlyRate = value;
                this.TotalFee = hourlyRate*(decimal)this.timeToCompletion;
            }
        }
        public decimal TotalFee {
            get {
                return totalFee;
            }
            private set {
                totalFee = value;
            }
        }
        public double TimeToCompletion {
            get {
                return timeToCompletion;
            }
            set {
                timeToCompletion = value;
                this.TotalFee = (decimal)timeToCompletion*this.hourlyRate;
            }
        }

        public static Job operator+ (Job a, Job b) {
         return new Job(
             a.JobDescription + " and " + b.JobDescription,
             (a.HourlyRate + b.HourlyRate)/2,
             a.TimeToCompletion + b.TimeToCompletion
         );
        }
    }
}
