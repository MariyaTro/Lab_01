using System;

public abstract class MusicalInstrument
{
    protected string name;
    protected string characteristics;

    public MusicalInstrument()
    {
        this.name = "Unknown";
        this.characteristics = "Unknown characteristics";
    }

    public MusicalInstrument(string name, string characteristics)
    {
        this.name = name;
        this.characteristics = characteristics;
    }

    public MusicalInstrument(MusicalInstrument original)
    {
        this.name = original.name;
        this.characteristics = original.characteristics;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetCharacteristics(string characteristics)
    {
        this.characteristics = characteristics;
    }

    public string GetCharacteristics()
    {
        return this.characteristics;
    }

    public abstract void Sound();

    public void Show()
    {
        Console.WriteLine($"Musical Instrument: {name}");
    }

    public void Desc()
    {
        Console.WriteLine($"Characteristics: {characteristics}");
    }

    public void History()
    {
        Console.WriteLine($"History of {name}: The history of this instrument dates back to ancient times.");
    }

    public void ShowInfo()
    {
        Show();
        Desc();
        History();
    }
}
