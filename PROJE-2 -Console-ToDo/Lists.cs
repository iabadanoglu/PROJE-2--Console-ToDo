using System;
using System.Collections;
using System.Collections.Generic;

namespace PROJE_2__Console_ToDo
{
    public class Lists
    {
        public static int personNumber = 5;
        //static int[] lines = { 1, 2, 3 };
        public static Random randomNumber = new Random();

        public static string[] lines = { "(1) TODO Line", "(2) IN PROGRESS Line", "(3) DONE Line", "(4) Vazgeç\n" };
        public static SortedDictionary<int, Card> cards = new SortedDictionary<int, Card>();
        public static string[] processes = { "(1) Board Listelemek", "(2) Board'a Kart Eklemek", "(3) Board'dan Kart Silmek", "(4) Kart Taşımak", "(5) Çıkış\n" };
        public static int id = 1;
    }
}




