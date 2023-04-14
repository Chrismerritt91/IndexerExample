class Program
{

    static void Main()
    {

        //create an object of Car class
        Car c = new Car();

        //call get accessor off indexer
        Console.WriteLine(c[0]);//output BMW
        Console.WriteLine(c["first"]);//output BMW

        //call set accessor of index
        c[0] = "Nissan";

        Console.WriteLine(c[0]);//output Nissan


        Console.ReadKey();

    }


}