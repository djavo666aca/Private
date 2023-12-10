namespace Private
{
     class Program
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
                
     
        static void Main(string[] args)
        {
           Program p1 = new Program();

            Console.WriteLine(p1.Id());
            Console.WriteLine(p1.Mnozi());

        }
    }
}
