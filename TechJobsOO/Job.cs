using System;
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
            return $"ID: {Id} \nName: {Name} \nEmployer: {EmployerName} \nLocation: {EmployerLocation} \nJob: {JobType} \nCompetency: {JobCoreCompetency} \n";
        }
    }
}
