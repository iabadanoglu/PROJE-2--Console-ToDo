using System;
using System.Collections.Generic;

namespace PROJE_2__Console_ToDo
{
    public class Cards
    {
        static int[] lines = { 1, 2, 3 };
        public static Random randomNumber = new Random();
        public static int personNumber = Persons.persons.Count;
        public static string[] sizes = { "XS", "S", "M", "L", "XL" };

        public static List<Card> cards = new List<Card>()
        {
            {new Card(0, 1, "Title-1", "Content 1", 1, "L")},
            {new Card(1, 1, "Title-1", "Content 1", 1, "L")},
            {new Card(2, 2, "Title 2", "Content 2", 2, "S")},
            {new Card(3, 3, "Title 3", "Content 3", 3, "XL")},
            {new Card(4, 1, "Title 4", "Content 4", 4, "XS")},
            {new Card(5, 2, "Title 5", "Content 5", 5, "M")},
            {new Card(6, 3, "Title 6", "Content 6", 1, "L")},
            {new Card(7, 1, "Title 7", "Content 7", 2, "S")},
            {new Card(8, 2, "Title 8", "Content 8", 3, "XL")},
            {new Card(9, 3, "Title 9", "Content 9", 4, "XS")},
            {new Card(10, 1, "Title 10", "Content 10", 5, "M")}
        };
    }
}




