using FluentAssertions;
using GameOfLife.Rules;
using NUnit.Framework;

namespace GameOfLife.Tests.Game_of_life_rules_tests
{
    //rules
    //Any live cell with fewer than two live neighbours dies, as if caused by under-population.
    //Any live cell with two or three live neighbours lives on to the next generation.
    //Any live cell with more than three live neighbours dies, as if by over-population.
    //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

    [TestFixture]
    public class When_cell_split
    {
        //Any live cell with fewer than two live neighbours dies, as if caused by under-population.
        [Test]
        public void Cell_with_fewer_than_two_neighbours()
        {
            var cellRule = new LiveCellWithFewerThanTwoNeighborsRule();
            cellRule.ShouldLive(1).Should().BeFalse();
        }

        //Any live cell with two or three live neighbours lives on to the next generation.
        [Test]
        [TestCase(2)]
        [TestCase(3)]
        public void Cell_with_two_or_three_live_neighbors(int numberOfNeighbors)
        {
            var cellRule = new LiveCellWithTwoOrThreeNeighborsRule();
            cellRule.ShouldLive(numberOfNeighbors).Should().BeTrue();
        }

        //Any live cell with more than three live neighbours dies, as if by over-population.
        [Test]
        public void Cell_with_more_than_three_live_neighbors()
        {
            var cellRule = new LiveCellWithMoreThanThreeLiveNeighborsRule();
            cellRule.ShouldLive(4).Should().BeFalse();
        }

    //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
        [Test]
        public void Dead_cell_with_three_live_neighbors()
        {
            var cellRule = new DeadCellWithThreeLiveNeighborsRule();
            cellRule.ShouldLive(3).Should().BeTrue();
        }
    }
}
