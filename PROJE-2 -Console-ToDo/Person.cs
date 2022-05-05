using System;

namespace PROJE_2__Console_ToDo
{
    public class Person

    {
        int id = 0;
        private string name;
        private string surname;

        public int ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public Person(int id, string name, string surname)
        {
            ID = id;
            Name = name;
            Surname = surname;
        }
    }
}
