﻿using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string noData = "Data not available.";
            string nameData = Name;
            string employerData = EmployerName.Value;
            string locationData = EmployerLocation.Value;
            string jobTypeData = JobType.Value;
            string coreCompData = JobCoreCompetency.Value;

            return $"\nID: {Id} \nName: {(!string.IsNullOrEmpty(nameData) ? nameData : noData)} \nEmployer: {(!string.IsNullOrEmpty(employerData) ? employerData : noData)} \nLocation: {(!string.IsNullOrEmpty(locationData) ? locationData : noData)} \nPosition Type: {(!string.IsNullOrEmpty(jobTypeData) ? jobTypeData : noData)} \nCore Competency: {(!string.IsNullOrEmpty(coreCompData) ? coreCompData : noData)} \n";
        }
    }
}
