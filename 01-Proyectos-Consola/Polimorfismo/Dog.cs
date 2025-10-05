class Dog : DomesticAnimals
{
    //Implement abstract mmethod
    public override string sound()
    {
        return "Guau Guau";
    }

    public void view_sound_dog()
    {
        Console.WriteLine(sound());
    }
}