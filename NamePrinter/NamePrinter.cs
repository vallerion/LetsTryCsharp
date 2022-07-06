namespace NamePrinter
{
    public class Printer
    {
        private string Name;
        
        public Printer(string name)
        {
            Name = name;
        }
        
        public void Print()
        {
            System.Console.WriteLine("Name: " + Name);
        }
    }
}