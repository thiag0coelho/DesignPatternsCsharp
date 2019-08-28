using static System.Console;

namespace ChainOfResponsability
{
    class Program
    {
        /// <summary>
        /// Each Goblin in hand adds +1 defense. Each Goblin King in hand adds +1 attack.
        /// </summary>
        static void Main(string[] args)
        {
            var game = new Game();

            var goblin = new Goblin(game);
            game.Creatures.Add(goblin);

            var goblin2 = new Goblin(game);
            game.Creatures.Add(goblin2);

            var goblin3 = new GoblinKing(game);
            game.Creatures.Add(goblin3);

            WriteLine(goblin);
            WriteLine(goblin2);
            WriteLine(goblin3);
            ReadLine();
        }
    }
}
