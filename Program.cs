namespace Private
{
    class Storage 
    {
        private string Ime = "Milovan";
        private string Prezime = "Jovanovic";
        private int Br = 100;

        public string Id()
        {
            return Ime + " " + Prezime;
        }
        public int Mnozi()
        {
            return Br * 2;
        }


    }
    class Program
    {   static void Main(string[] args)
        {
            Storage p1 = new Storage();

            Console.WriteLine(p1.Id());
            Console.WriteLine(p1.Mnozi());

        }
    }
}
