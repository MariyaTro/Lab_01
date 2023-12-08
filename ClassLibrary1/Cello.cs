using System;

public class Cello : MusicalInstrument
{
    public Cello() : base() { }

    public Cello(string name, string characteristics) : base(name, characteristics) { }

    public Cello(Cello original) : base(original) { }

    public override void Sound()
    {
        Console.WriteLine("Cello sound: Resonant Melody");
    }
}
