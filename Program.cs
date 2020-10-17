using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Player OriPlayer = new Player("Ori Eliyahu");
            OriPlayer.Play(new OneShoot());
            OriPlayer.Play(new TwoShoot());
            OriPlayer.Play(new BoomShoot());
        }
    }
}
