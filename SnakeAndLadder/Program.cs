namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Problem");
            //Object creation of SnakeLadder class
            SnakeLadder snakeLadder = new SnakeLadder();
            snakeLadder.Game();
            Console.ReadLine();
        }
    }
}