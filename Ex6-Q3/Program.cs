/*
BSc in Science in Computing & Multimedia
Object-Oriented Programming - BSC20921
Stage 2, Semester 2
Class Exercises

Student Name:             Mateus Fonseca Campos
Student Number:           24088
Student Email:            24088@student.dorset-college.ie
*/

﻿using System;

namespace Ex6_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Harold’s Home Services ===========\n");

            Job j1 = new Job("wash windows", 3.5, (decimal)25);
            Job j2 = new Job("walk dogs", 2.3, (decimal)13.50);
            Job j3 = j1 + j2;

            Job[] jobArr = {j1, j2, j3};

            foreach (Job job in jobArr) {
              job.Display();
              Console.WriteLine();
            }

            Console.WriteLine("=========== Harold’s Home Services ===========");

            Console.Write("\nPress \"Enter/Return\" to end... ");
            Console.ReadLine();
        }
    }

    class Job
    {
        private decimal hourlyRate;
        private double timeToCompletion;

        public Job(string jobDescription, double timeToCompletion, decimal hourlyRate) {
            JobDescription = jobDescription;
            HourlyRate = hourlyRate;
            TimeToCompletion = timeToCompletion;
        }

        public string JobDescription { get; set; }
        public decimal TotalFee { get; private set; }

        public decimal HourlyRate {
            get { return hourlyRate; }
            set {
                hourlyRate = value;
                TotalFee = hourlyRate*(decimal)TimeToCompletion;
            }
        }

        public double TimeToCompletion {
            get { return timeToCompletion; }
            set {
                timeToCompletion = value;
                TotalFee = (decimal)timeToCompletion*HourlyRate;
            }
        }

        public static Job operator+ (Job a, Job b) {
           return new Job(
               a.JobDescription + " and " + b.JobDescription,
               a.TimeToCompletion + b.TimeToCompletion,
               (a.HourlyRate + b.HourlyRate)/2
           );
        }

        public void Display() {
          Console.WriteLine("{0} {1}", "Job description:", JobDescription);
          Console.WriteLine("{0} {1}", "Time to completion:", TimeToCompletion);
          Console.WriteLine("{0} {1:C}", "Hourly Rate:", HourlyRate);
          Console.WriteLine("{0} {1:C}", "Total Fee:", TotalFee);
        }
    }
}
