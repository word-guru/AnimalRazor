using AnimalRazor.Repozitorys.Interfaces;

namespace AnimalRazor.Models
{
    public class Dogs : IModel
    {
        public string TypeAnimal { get; set; } = "Собака";
        public string Sound { get; set; } = "Гав-гав";

        /*Dogs() 
        {
            TypeAnimal = "Собака";
            Sound = "Гав-гав";
        }*/
        public string GetSound() => Sound;
        public string GetType() => TypeAnimal;
    }
}
