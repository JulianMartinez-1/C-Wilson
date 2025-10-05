abstract class DomesticAnimals
{
    //properties
    public string Id { get; set; }
    //public short Age {age; set;}

    short age;

    public short Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value >= 1 && value <= 5)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Age not validate");
            }
        }
    }


    //Method

    public void to_run()
    {
        Console.WriteLine("Is runnig");
    }

    public abstract string sound();

}
