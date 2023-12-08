using System;

class Program
{
    static void Main(string[] args)
    {
        MusicalInstrument[] instruments = new MusicalInstrument[]
        {
            new Violin("Violin", "String instrument"),
            new Trombone("Trombone", "Brass instrument"),
            new Ukulele("Ukulele", "String instrument"),
            new Cello("Cello", "String instrument with a deeper sound")
        };

        foreach (var instrument in instruments)
        {
            instrument.ShowInfo();
            instrument.Sound();
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
