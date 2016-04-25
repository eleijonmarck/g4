namespace GameOfLife.Rules
{
    public class LiveCellWithFewerThanTwoNeighborsRule
    {
        public bool ShouldLive(int numberOfNeighbors)
        {
            return numberOfNeighbors >= 2;
        }
    }
}