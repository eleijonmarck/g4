namespace GameOfLife.Rules
{
    public class LiveCellWithTwoOrThreeNeighborsRule : ILifeRule
    {
        public bool ShouldHandle(bool isAlive)
        {
            return isAlive;
        }

        public bool ShouldLive(int numberOfNeighbors)
        {
            return numberOfNeighbors == 2 || numberOfNeighbors == 3;
        }
    }
}