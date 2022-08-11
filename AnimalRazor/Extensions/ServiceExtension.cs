using AnimalRazor.Models;
using AnimalRazor.Repozitorys;
using AnimalRazor.Repozitorys.Interfaces;

namespace AnimalRazor.Extensions
{
    public static class ServiceExtension
    {
        public static void RegisterRepos(this IServiceCollection collection)
        {
            collection.AddTransient<IModel, Cats>();
            collection.AddTransient<IModel, Dogs>();
            collection.AddTransient<IAnimal, AnimalRepozitory>();
            //collection.AddTransient<AnimalRepozitory>();

        }
    }
}
