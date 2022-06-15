
namespace LiskovSubstitutionPrinciple
{
    /*The Liskov Substitution Principle states that, if A is a subtype of B, then objects of 
     * type B should be replaced with the objects of type A. Given that it doesn't break the functionality
     */
    public abstract class Car
    {
        public abstract string GetColor();
    }
}
