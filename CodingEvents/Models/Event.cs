using System;
namespace CodingEvents.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string ContactEmail { get; set; }
        public int Id { get; set; }

        public Event()
        {
        }

        public Event(string name, string description, DateTime date)
        {
            Name = name;
            Description = description;
            Date = date;
            ContactEmail = ContactEmail;
        }


        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
