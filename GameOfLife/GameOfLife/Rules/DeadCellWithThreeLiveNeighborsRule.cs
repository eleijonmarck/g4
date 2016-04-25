namespace GameOfLife.Rules
{
    public class DeadCellWithThreeLiveNeighborsRule
    {
        public bool ShouldLive(int numberOfNeighbors)
        {
            return numberOfNeighbors == 3;
        }
    }
}