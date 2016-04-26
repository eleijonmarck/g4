﻿namespace GameOfLife.Rules
{
    public class LiveCellWithFewerThanTwoNeighborsRule : ILifeRule
    {
        public bool ShouldHandle(bool isAlive)
        {
            return isAlive;
        }

        public bool ShouldLive(int numberOfNeighbors)
        {
            return numberOfNeighbors >= 2;
        }
    }
}