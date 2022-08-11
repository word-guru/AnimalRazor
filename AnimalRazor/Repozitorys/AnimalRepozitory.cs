using AnimalRazor.Models;
using AnimalRazor.Repozitorys.Interfaces;

namespace AnimalRazor.Repozitorys
{
    public class AnimalRepozitory : IAnimal
    {
        private readonly IEnumerable<IModel> _model;
        private List<string> read;

        public AnimalRepozitory(IEnumerable<IModel> model)
        {
            _model = model;             
        }

        public List<IModel> GetAnimals()
        {
            return _model.ToList();
        }

        public void SaveFile(string path = "App_Data/Animal.txt")
        {
            string _path = path;

            using (StreamWriter writer = new StreamWriter(_path, false))
            {
                foreach (var animal in _model)
                {
                    writer.Write($"{animal.GetType()} ");
                    writer.WriteLine(animal.GetSound());
                }
            }
        }
 
    }
}
