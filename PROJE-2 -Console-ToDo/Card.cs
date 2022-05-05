using System;

namespace PROJE_2__Console_ToDo
{
    public class Card

    {
        int id = 0;
        int line = 1;
        private string title;
        private string content;
        private int assignedPerson;
        private string size;

        public int ID { get => id; set => id = value; }
        public int Line { get => line; set => line = value; }
        public string Title { get => title; set => title = value; }
        public string Content { get => content; set => content = value; }
        public int AssignedPerson { get => assignedPerson; set => assignedPerson = value; }
        public string Size { get => size; set => size = value; }

        public Card(int id, int line, string title, string content, int assignedPerson, string size)
        {
            ID = id;
            Title = title;
            Content = content;
            Line = line;
            AssignedPerson = assignedPerson;
            Size = size;
        }
    }
}
