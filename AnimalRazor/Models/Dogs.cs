namespace AnimalRazor.Models
{
    public class Dogs : Animal
    {
        public override string GetSound() => "gav-gav";
        public override string GetType() => "dog";
    }
}
