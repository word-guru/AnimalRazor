using AnimalRazor.Repozitorys.Interfaces;

namespace AnimalRazor.Models
{
    public class Cats : IModel
    {
        public string TypeAnimal { get; set; } = "Кот";
        public string Sound { get; set; } = "Мяу-Мяу";

       /* Cats()
        {
            TypeAnimal = "Кот";
            Sound = "Мяу-Мяу";
        }*/

        public string GetSound() => Sound;
        public string GetType() => TypeAnimal;
       
    }
}
