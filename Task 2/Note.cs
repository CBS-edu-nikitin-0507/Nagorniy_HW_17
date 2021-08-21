using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Note
    {
        public int frequency { get; private set; }
        public bool pause { get; private set; }
        public int duration { get; private set; }

        public Note(int frequency, int duration, bool pause)
        {
            this.frequency = frequency;
            this.pause = pause;
            this.duration = duration;
        }

        public static Note Do(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 261,
                2 => 523,
                3 => 1046,
                4 => 2093,
                5 => 4186,
                _ => 261
            };
            return new Note(frequency, duration, false);

        }
        public static Note Re(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 324,
                2 => 637,
                3 => 1235,
                4 => 2332,
                5 => 4342,
                _ => 432
            };
            return new Note(frequency, duration, false);

        }
        public static Note Mi(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 546,
                2 => 765,
                3 => 1435,
                4 => 2456,
                5 => 4565,
                _ => 657
            };
            return new Note(frequency, duration, false);

        }
        public static Note Fa(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 675,
                2 => 978,
                3 => 1657,
                4 => 2654,
                5 => 4765,
                _ => 879
            };
            return new Note(frequency, duration, false);

        }
        public static Note Sol(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 876,
                2 => 1254,
                3 => 1876,
                4 => 2876,
                5 => 4987,
                _ => 1023
            };
            return new Note(frequency, duration, false);

        }
        public static Note La(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 1023,
                2 => 1403,
                3 => 2034,
                4 => 3034,
                5 => 5342,
                _ => 1200
            };
            return new Note(frequency, duration, false);

        }
        public static Note Si(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 1256,
                2 => 1564,
                3 => 2243,
                4 => 3243,
                5 => 5635,
                _ => 261
            };
            return new Note(frequency, duration, false);

        }
        public static Note Pause(int octave, int duration)
        {
            int frequency = (octave) switch
            {
                1 => 0,
                2 => 0,
                3 => 0,
                4 => 0,
                5 => 0,
                _ => 0
            };
            return new Note(frequency, duration, true);
        }
    }
}
