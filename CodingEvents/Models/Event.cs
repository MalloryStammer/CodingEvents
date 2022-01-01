using System;
namespace CodingEvents.Models
{
    public class Event
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public Event(string name, string description, DateTime date)
        {
            Name = name;
            Description = description;
            Date = date; 
        }


        public override string ToString()
        {
            return Name;
        }
    }
}
