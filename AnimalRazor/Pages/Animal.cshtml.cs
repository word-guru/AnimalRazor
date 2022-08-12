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
        public List<string> _read { get; set; }

        public AnimalModel(IAnimal animal)
        {
            _animal = animal;
        }
        public List<IModel> _model { get; set; }

        public void OnGet()
        {  
            _model = _animal.GetAnimals();           
        }

        public IActionResult OnPostSaveFile()
        {
            _animal.SaveFile("App_Data/AnimalRead.txt");
            return RedirectToPage("");
        }
        public IActionResult OnPostReadFile()
        {
            _read = _animal.ReadFile();
            return RedirectToPage("");
        }
        //public void OnGetReadFile()
        //{
        //    string file_path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/AnimalRead.txt");
        //    // Тип файла - content-type
        //    string file_type = "text/plain";
        //    // Имя файла - необязательно
        //    string file_name = "AnimalRead.txt";
        //    //return PhysicalFile(file_path, file_type, file_name);

        //}
    }
}
