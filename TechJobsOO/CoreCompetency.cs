using System;
namespace TechJobsOO
{
    public class CoreCompetency
    {
        private int Id { get; }
        private static int NextId = 1;
        public string Value { get; set; }

       
        // TODO: Change the fields to auto-implemented properties.

        public CoreCompetency()
        {
            
            Id = NextId;
            NextId++;
        }

        public CoreCompetency(string v) : this()
        {
            Value = v;
        }

        public override bool Equals(object obj)
        {
            return obj is CoreCompetency competency &&
                   Id == competency.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
    
}
