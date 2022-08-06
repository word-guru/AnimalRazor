namespace AnimalRazor.Models
{
    public class Cats : Animal
    {
      
        public override string GetSound() => "my-my";
        public override string GetType() => "cat";
       
    }
}
