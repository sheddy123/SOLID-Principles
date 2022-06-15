
namespace LiskovSubstitutionPrinciple
{
    public class BMW : Car
    {
        public override string GetColor()
        {
            System.Console.WriteLine("This is BMW Red");
            return "BMW Red";
        }
    }
}
