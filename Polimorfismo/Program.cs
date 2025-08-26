Console.WriteLine("Enter an animal code (1. for Dog, 2. for Cat or 0. Exit): ");
short AnimalCode = short.Parse(Console.ReadLine());

while (AnimalCode != 0)
{
    Console.WriteLine("Type a Id: ");
    string AnimalId = Console.ReadLine();

    Console.WriteLine("Type an Age: ");
    short AnimalAge = short.Parse(Console.ReadLine());

    switch (AnimalCode)
    {
        case 1:
            var Dog = new Dog()
            {
                Id = AnimalId,
                Age = AnimalAge
            };
            Console.WriteLine($"The Dog data is Id {Dog.Id} and age {Dog.Age}");
            Dog.view_sound_dog();
            Dog.to_run();
            break;
        case 2:
            var Cat = new Cat()
            {
                Id = AnimalId,
                Age = AnimalAge
            };
            Console.WriteLine($"The Cat data is Id {Cat.Id} and age {Cat.Age}");
            Cat.view_sound_cat();
            Cat.to_run();
            break;
        default:
            Console.WriteLine("Animal code not valid");
            break;
    }

    Console.WriteLine("Enter an animal code (1. for Dog, 2. for Cat or 0. Exit): ");
    AnimalCode = short.Parse(Console.ReadLine());
}