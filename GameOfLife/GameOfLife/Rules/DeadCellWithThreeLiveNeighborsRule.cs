namespace GameOfLife.Rules
{
    public class DeadCellWithThreeLiveNeighborsRule : ILifeRule
    {
        public bool ShouldHandle(bool isAlive)
        {
            return isAlive == false;
        }

        public bool ShouldLive(int numberOfNeighbors)
        {
            return numberOfNeighbors == 3;
        }
    }
}