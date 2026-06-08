namespace ConsoleApp
{
    //Engineering class definition
    public class Engineering
    {
        public string? indexNumber;
        public string? name;
        public int level;
        private int _level
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
                else
                {
                    level = value;
                }
            }
        }

        // Constructor of Engineering class with parameters
        public Engineering(string name, string indexNumber, int level)
        {
            this.name = name;
            this.indexNumber = indexNumber;
            this.level = level;
        }

        // Parameterless constructor (optional, for object initializer syntax)
        public Engineering() { }

        // Welcome user method
        public void Welcome()
        {
            Console.WriteLine($"\nWelcome to the Engineering faculty, {name}. Your index number is {indexNumber} and your level is {level}");
        }
    }
}