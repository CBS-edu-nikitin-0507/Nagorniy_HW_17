using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string melody = " 8453453455345";
            Note[] notes = MelodyParser.ParseMelody(melody);
            Player.Play(notes);
        }
    }
}
