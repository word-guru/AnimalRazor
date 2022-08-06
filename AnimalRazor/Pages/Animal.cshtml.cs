using AnimalRazor.Models;
using AnimalRazor.Repozitorys;
using AnimalRazor.Repozitorys.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AnimalRazor.Pages
{
    public class AnimalModel : PageModel
    {
        private readonly IAnimal _animal;
        public List<Animal> animals { get; set; }
       
        public AnimalModel(IAnimal animal)
        {
            _animal = animal;
        }

        public void OnGet()
        {
           
            animals = _animal.GetAnimals();
           

        }
    }
}
