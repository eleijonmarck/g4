using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Rules
{
    public interface ILifeRule
    {
        bool ShouldHandle(bool isAlive);
        bool ShouldLive(int numberOfNeighbors);
    }
}
