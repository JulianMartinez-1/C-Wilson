class Cat : DomesticAnimals
{
    //Implement abstract mmethod
    public override string sound()
    {
        return "Miau Miau";
    }

    public void view_sound_cat()
    {
        Console.WriteLine(sound());
    }
}