using System;
using System.Collections.Generic;
using Задачи.Classes;

namespace Задачи
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 1 - студент и мероприятие");
            List<Student> students = new List<Student>();

            /* try
            {
                string[] lines = File.ReadAllLines("students.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(' ');

                    if (parts.Length == 2)
                    {
                        string name = parts[0];
                        string group = parts[1];

                        students.Add(new Student { Name = name, Group = group });
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при считывании студентов из файла: " + ex.Message);
            }*/


            Console.WriteLine("\nУпр 2 - Пользователь и его хобби");
            // Создание списка людей с их увлечениями и реакциями
            List<Person> people = new List<Person>
        {
            new Person("Олег", "Сериалы", "О, я так долго ждал выхода этого сериала! Обязательно буду смотреть!"),
            new Person("Джамшут", "Футбол", "Конечно, пойду на этот матч! Моя любимая команда играет!"),
            new Person("Мухамед", "Концерты", "Ура! Мой любимый исполнитель дает концерт! Не могу дождаться!")
        };

            // Ввод события от пользователя
            Console.Write("Введите событие: ");
            string eventInput = Console.ReadLine();

            // Поиск людей, у которых увлечение совпадает с событием
            List<Person> matchingPeople = people.FindAll(person => person.Hobby == eventInput);

            // Вывод реакции людей на событие
            if (matchingPeople.Count > 0)
            {
                foreach (Person person in matchingPeople)
                {
                    Console.WriteLine($"{person.Name}: {person.Reaction}");
                }
            }
            else
            {
                Console.WriteLine("Никто из людей не проявил интерес к данному событию.");
            }
        }
    }
}
