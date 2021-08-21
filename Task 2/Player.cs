using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    static class Player
    {
        public static void Play(Note[] notes)
        {
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i].pause == false)
                {
                    Console.Beep(notes[i].frequency, notes[i].duration);

                }else
                {
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                }

            }
        }
    }
}
