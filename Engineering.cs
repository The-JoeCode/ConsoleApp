namespace ConsoleApp
{
    //Engineering class definition
    public class Engineering
    {
        public string? indexNumber;
        public string? name;
        public int level;
        private int _level //private variables usually must have _(coding standard for easy identification)
        {
            //Getters and setters
            //These are used to validate inputs
            get => _level;
            set
            {
                if (value > 400)
                {
                    Console.WriteLine("Level cannot be greater than 400");
                }
            }
        }
        // Constructor of Engineering class
        public Engineering(string name, string indexNumber, int level)
        {
            this.name = name;
            this.indexNumber = indexNumber;
            this.level = level;
        }
        // Welcome user method
        public void Welcome()
        {
            Console.WriteLine($"\nWelcome to the Engineering faculty, {name}. Your index number is {indexNumber} and your level is {level}");
        }
    }
}