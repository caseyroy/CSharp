using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Human
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
        private int health { get; set; }

        // add a public "getter" property to access health
        public int ShowMe
        {
            get
            {
                return this.health;
            }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public void SetName(string name)
        {
            Name = name;
            health = 100;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
        }
        public void SetVals(string name, int str = 3, int intel = 3, int dex = 3, int hp = 100)
        {
            Name = name;
            health = hp;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
        }
        // Add a constructor to assign custom values to all fields

        // Build Attack method
        public int Attack(Human target)
        {
            int dmg = (int)(10 * Strength);
            target.health -= dmg;
            System.Console.WriteLine($"{Name} attacks {target.Name} for {dmg} points of damage!");
            return target.health;
        }
    }

}
