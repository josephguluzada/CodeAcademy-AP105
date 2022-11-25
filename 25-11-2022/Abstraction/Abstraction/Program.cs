namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Mestan";
            cat.Age = 3;
            cat.MakeSound();
            cat.Eat();

            Dog dog = new Dog();
            dog.Name = "Alabas";
            dog.Age = 2;
            dog.HasCollar = true;
            dog.MakeSound();
            dog.Eat();

            PetDog petDog = new PetDog();
            petDog.MakeSound();
            petDog.Eat();
            
        }
    }
}