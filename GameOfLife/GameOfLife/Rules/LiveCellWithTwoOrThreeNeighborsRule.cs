namespace GameOfLife.Rules
{
    public class LiveCellWithTwoOrThreeNeighborsRule
    {
        public bool ShouldLive(int numberOfNeighbors)
        {
            return numberOfNeighbors == 2 || numberOfNeighbors == 3;
        }
    }
}