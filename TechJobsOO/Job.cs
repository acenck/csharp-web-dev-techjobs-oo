using System;
using System.Collections.Generic;
using System.Linq;

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

        // TODO: Add the two necessary constructors. Check!


        public Job()
        {
            Id = nextId;
            nextId++;
           
          
        }

    

        public Job(string name, Employer employer, Location location, PositionType type, CoreCompetency competency) : this()
        {
            Name = name;
            EmployerName = employer;
            EmployerLocation = location;
            JobType = type;
            JobCoreCompetency = competency;
        }


        // TODO: Generate Equals() and GetHashCode() methods. Check!

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
            int id = Id;
            string name = Name;
            string employer = EmployerName?.Value;
            string location = EmployerLocation?.Value;
            string job = JobType?.Value;
            string competency = JobCoreCompetency?.Value;
            string emptyField = "Data not available";
                            
            //bonus message to declare non-existent job when all fields are empty
            var jobData = new List<string>() { name, employer, location, job, competency};

            if (jobData.All(element => element == null || element == string.Empty))
            {
                return "OOPS! This job does not seem to exist.";
            }

             
            // data not available applied to output for null or empty fields
            for(int i=0; i < jobData.Count; i++)
            {
                if(jobData[i] == string.Empty || jobData[i] == null)
                {

                    jobData[i] = emptyField;
                    
                }
                
                
            }

            
                return $"\nID: {id}" +
                $"\nName: {jobData[0]}" +
                $"\nEmployer: {jobData[1]}" +
                $"\nLocation: {jobData[2]}" +
                $"\nJob: {jobData[3]}" +
                $"\nCompetency: {jobData[4]}" +
                $"\n";

            
            

        }

    }

}

            


        
