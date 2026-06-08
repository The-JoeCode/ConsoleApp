namespace ConsoleApp
{
    public class Shape
    {
        public virtual void Describe()
        {
            Console.WriteLine("I am a shape");
        }
    }
    public class Circle : Shape
    {
        public override void Describe()
        {
            Console.WriteLine("I am a circle");
        }
    }

    public class Triangle : Shape
    {
        public override void Describe()
        {
            Console.WriteLine("I am a triangle");
        }
    }
}