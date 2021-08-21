using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
   static class MelodyParser
    {
        public static Note[] ParseMelody(string melody)
        {
            
            char[] melodyArr = melody.ToCharArray();
            Note[] notes = new Note[melodyArr.Length];

            for (int i = 0; i < melodyArr.Length; i++)
            {
                switch (melodyArr[i])
                {
                    case '0':
                        {

                            notes[i] = Note.Do(1, 500);
                           
                            break;
                        }
                    case '1':
                        {
                            notes[i] = Note.Re(2, 500);
                            
                            break;
                        }
                    case '2':
                        {
                            notes[i] = Note.Mi(3, 500);
                           
                            break;
                        }
                    case '3':
                        {
                            notes[i] = Note.Fa(3, 500);
                           
                            break;
                        }
                    case '4':
                        {
                            notes[i] = Note.Sol(2, 500);
                            
                            break;
                        }
                    case '5':
                        {
                            notes[i] = Note.La(1, 500);
                            
                            break;
                        }
                    case '6':
                        {
                            notes[i] = Note.Si(1, 500);
                          
                            break;
                        }
                    case '7':
                        {

                            notes[i] = Note.Do(1, 500);
                           
                            break;
                        }
                    case '8':
                        {
                            notes[i] = Note.Re(1, 500);
                           
                            break;
                        }
                    case '9':
                        {
                            notes[i] = Note.Mi(1, 500);
                          
                            break;
                        }
                    case ' ':
                        {
                            notes[i] = Note.Pause(1, 0);
                           
                            break;
                        }
                }
            }
            return notes;
        }

    }
}
