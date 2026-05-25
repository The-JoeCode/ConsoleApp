namespace ConsoleApp
{
    public class Engineering
    {
        public string indexNumber;
        public string name;
        public int level;
        public void Welcome()
        {
            Console.WriteLine($"Welcome {name}. Your index number is {indexNumber} and your level is {level}");
        }
    }
}