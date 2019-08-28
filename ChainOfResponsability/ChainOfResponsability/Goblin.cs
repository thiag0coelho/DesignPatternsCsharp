using System;

namespace ChainOfResponsability
{
    public class Goblin : Creature
    {
        public override void Query(object source, StatQuery sq)
        {
            if (ReferenceEquals(source, this))
            {
                sq.Result += sq.Statistic switch
                {
                    Statistic.Attack => baseAttack,
                    Statistic.Defense => baseDefense,
                    _ => throw new ArgumentOutOfRangeException(),
                };
            }
            else
            {
                if (sq.Statistic == Statistic.Defense)
                {
                    sq.Result++;
                }
            }
        }

        public override int Defense
        {
            get
            {
                var q = new StatQuery { Statistic = Statistic.Defense };
                foreach (var c in game.Creatures)
                    c.Query(this, q);
                return q.Result;
            }
        }

        public override int Attack
        {
            get
            {
                var q = new StatQuery { Statistic = Statistic.Attack };
                foreach (var c in game.Creatures)
                    c.Query(this, q);
                return q.Result;
            }
        }

        public Goblin(Game game) : base(game, 1, 1)
        {
        }

        protected Goblin(Game game, int baseAttack, int baseDefense) : base(game,
          baseAttack, baseDefense)
        {
        }

        public override string ToString()
        {
            return $"{nameof(Attack)}: {Attack}, {nameof(Defense)}: {Defense}";
        }
    }
}
