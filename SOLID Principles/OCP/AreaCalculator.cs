namespace OpenClosedPrinciple
{
    /*The Open/Closed principle states that classes, methods, modules etc. are open for extension, 
     * but closed for modification. Simply put, we should be creating software entities whose 
     * behaviour we can change without the need to modify its source code.
     */
    public class AreaCalculator
    {
        public double CalculateTotalArea(Shape shape)
        {
            System.Console.WriteLine($"Total area of type {shape.GetType()} is {shape.Area()} ");
            return shape.Area();
        }
    }
}

