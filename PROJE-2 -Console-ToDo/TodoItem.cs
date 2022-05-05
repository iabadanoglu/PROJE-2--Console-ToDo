﻿namespace PROJE_2__Console_ToDo
{
    class TodoItem
    {
        public TodoItem(string text, int number)
        {
            Text = text;
            Number = number;
        }

        public string Text { get; }
        public int Number { get; }

        public override string ToString()
        {
            return "#" + Number + " " + Text;
        }
    }
}