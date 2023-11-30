
namespace Задачи.Classes
{
    public class Person
    {
        public string Name { get; }
        public string Hobby { get; }
        public string Reaction { get; }

        public Person(string name, string hobby, string reaction)
        {
            Name = name;
            Hobby = hobby;
            Reaction = reaction;
        }
    }
}
