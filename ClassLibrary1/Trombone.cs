using System;

public class Trombone : MusicalInstrument
{
    public Trombone() : base() { }

    public Trombone(string name, string characteristics) : base(name, characteristics) { }

    public Trombone(Trombone original) : base(original) { }

    public override void Sound()
    {
        Console.WriteLine("Trombone sound: Bold Brass");
    }
}
