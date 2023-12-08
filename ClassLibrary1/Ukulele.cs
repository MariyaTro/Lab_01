using System;

public class Ukulele : MusicalInstrument
{
    public Ukulele() : base() { }

    public Ukulele(string name, string characteristics) : base(name, characteristics) { }

    public Ukulele(Ukulele original) : base(original) { }

    public override void Sound()
    {
        Console.WriteLine("Ukulele sound: Twangy Delight");
    }
}
