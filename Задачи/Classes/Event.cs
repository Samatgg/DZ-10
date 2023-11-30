using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задачи
{
    public class Event
    {
        public string Name { get; }
        public int NumberOfParticipants { get; }

        public Event(string name, int numberOfParticipants)
        {
            Name = name;
            NumberOfParticipants = numberOfParticipants;
        }
    }
}
