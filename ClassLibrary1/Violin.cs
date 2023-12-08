using System;

public class Violin : MusicalInstrument
{
    public Violin() : base() { }

    public Violin(string name, string characteristics) : base(name, characteristics) { }

    public Violin(Violin original) : base(original) { }

    public override void Sound()
    {
        Console.WriteLine("Violin sound: Screechy Elegance");
    }
}

namespace ClassLibrary1
{
    public class Violin
    {
    }
}