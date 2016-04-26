using System.Collections.Generic;
using FluentAssertions;
using GameOfLife.Rules;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class A_cell_has_come_alive
    {
        [Test]
        public void Cell_should_abide_to_the_life_rules(
            bool isAliveFromStart,
            int numberOfNeighbors,
            bool isAliveAfterSplit)
        {
            var lifeRules = new List<ILifeRule>()
            {
                new LiveCellWithFewerThanTwoNeighborsRule(),
                new LiveCellWithMoreThanThreeLiveNeighborsRule(),
                new LiveCellWithTwoOrThreeNeighborsRule(),
                new DeadCellWithThreeLiveNeighborsRule()
            };

            var cell = new Cell(lifeRules, isAliveAfterSplit);
            var splitCell = cell.Split(numberOfNeighbors);
            splitCell.IsAlive.Should().Be(isAliveAfterSplit);
        }

    }
}
