using AnimalRazor.Models;
using AnimalRazor.Repozitorys.Interfaces;

namespace AnimalRazor.Repozitorys
{
    public class AnimalRepozitory : IAnimal
    {
        private readonly IEnumerable<IModel> _model;
        private List<string> read { get; set; }

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

        public List<string> ReadFile()
        {          
            string path = "App_Data/AnimalRead.txt";
            read = new List<string>();
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    read.Add(line);
                }
            }
            return read;
        }
    }
}