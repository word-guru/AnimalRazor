using AnimalRazor.Models;
using AnimalRazor.Repozitorys.Interfaces;

namespace AnimalRazor.Repozitorys
{
    public class AnimalRepozitory : IAnimal
    {
        private readonly List<Animal> animals;

        public AnimalRepozitory()
        {
            animals = new List<Animal>();
            Cats cats = new Cats();
            Dogs dogs = new Dogs();
            animals.Add(dogs);
            animals.Add(cats);
              
        }

        public List<Animal> GetAnimals() => animals;
        
        
        public void WriteFile()
        {
            string path = "App_Data/Animal.txt";

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                foreach (Animal animal in animals)
                {
                    writer.Write($"{animal.GetType()} ");
                    writer.WriteLine(animal.GetSound());
                }
            }
        }

    }
}
