using AnimalRazor.Models;

namespace AnimalRazor.Repozitorys.Interfaces
{
    public interface IAnimal
    {
        List<IModel> GetAnimals();
        void SaveFile(string path);
    }
}
