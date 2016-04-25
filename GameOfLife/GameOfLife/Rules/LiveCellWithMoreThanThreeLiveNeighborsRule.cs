namespace GameOfLife.Rules
{
    public class LiveCellWithMoreThanThreeLiveNeighborsRule
    {
        public bool ShouldLive(int numberOfNeighbors)
        {
            return numberOfNeighbors < 4;
        }
    }
}