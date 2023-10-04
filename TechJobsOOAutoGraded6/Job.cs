using System;

namespace TechJobsOOAutoGraded6
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

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job (string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object? obj)
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
            string employer;
            if (EmployerName.Value == "")
            {
                employer = "Data not available";
            } else
            {
                employer = EmployerName.Value;
            }

            string location;
            if (EmployerLocation.Value == "")
            {
                location = "Data not available";
            } else
            {
                location = EmployerLocation.Value;
            }

            string jobType;
            if (JobType.Value == "")
            {
                jobType = "Data not available";
            } else
            {
                jobType = JobType.Value;
            }

            string jobCoreCompetency;
            if (JobCoreCompetency.Value == "")
            {
                jobCoreCompetency = "Data not available";
            } else
            {
                jobCoreCompetency = JobCoreCompetency.Value;
            }
            return $"\nID: {Id}\nName: {Name}\nEmployer: {employer}\nLocation: {location}\nPosition Type: {jobType}\nCore Competency: {jobCoreCompetency}\n";
        }
    }
}

