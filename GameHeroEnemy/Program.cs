using System;

namespace GameHeroEnemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GameEngine engine = new GameEngine();
            Models.Enemy enemy = new Models.Enemy();
            Models.Hero hero = new Models.Hero();

            engine.StartGame(enemy, hero);
            Console.WriteLine(engine.Result());

        }

       
    }
}
