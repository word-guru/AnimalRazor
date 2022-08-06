using AnimalRazor.Models;

namespace AnimalRazor.Repozitorys.Interfaces
{
    public interface IAnimal
    {
        //string GetType(int i);
        //string GetSound(int i);
        List<Animal> GetAnimals();
        void WriteFile();
    }
}
