using AnimalRazor.Repozitorys;
using AnimalRazor.Repozitorys.Interfaces;

namespace AnimalRazor.Extensions
{
    public static class ServiceExtension
    {
        public static void RegisterRepos(this IServiceCollection collection)
        {
            collection.AddTransient<IAnimal, AnimalRepozitory>();
           
        }
    }
}
