namespace GameOfLife.Rules
{
    public class LiveCellWithMoreThanThreeLiveNeighborsRule : ILifeRule
    {
        public bool ShouldHandle(bool isAlive)
        {
            return isAlive;
        }

        public bool ShouldLive(int numberOfNeighbors)
        {
            return numberOfNeighbors < 4;
        }
    }
}