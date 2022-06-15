
namespace LiskovSubstitutionPrinciple
{
    public class VolksWagen : Car
    {
        public override string GetColor()
        {
            System.Console.WriteLine("This is Volkswagen Green");
            return "Volkwagen Green";
        }
    }
}
