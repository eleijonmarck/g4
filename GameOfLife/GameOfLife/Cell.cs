using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Rules;

namespace GameOfLife
{
    public class Cell
    {
        private readonly IEnumerable<ILifeRule> _lifeRules;

        public Cell(IEnumerable<ILifeRule> lifeRules, bool shouldStartOutAlive)
        {
            _lifeRules = lifeRules;
            IsAlive = shouldStartOutAlive;
        }

        /* is this a form of convention, 
         * to write readonly and private statements 
         * on the top of the constructor?
        */
        public bool IsAlive { get; set; }

        public Cell Split(int amountOfNeighbors)
        {
            var shouldLive = _lifeRules.Where(x => x.ShouldHandle(IsAlive)).All(x => x.ShouldLive(amountOfNeighbors));
            return new Cell(_lifeRules, shouldLive);
        }
    }
}
