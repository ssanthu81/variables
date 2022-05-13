class First
{
    int i = 10;
    static void Main(string[] args) {

        First f = new First();
        First f1 = new First();
        First f2 = new First();
        Console.WriteLine(f.i + "   " + f1.i);
        f2.i = 30;
        Console.WriteLine(f.i + "   " + f2.i);
      
        Console.ReadLine();

    }

}
