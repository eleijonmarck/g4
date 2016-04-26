using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace GameOfLife.Tests
{
    [TestFixture]
    public class When_a_game_of_life_is_created
    {
        private GameOfLife _gameOfLife;

        [SetUp]
        public void SetUp()
        {
            _gameOfLife = new GameOfLife(4, 8);
        }

        [Test]
        public void It_should_be_able_to_set_living_cells()
        {
            _gameOfLife.SetLivingCell(1,2);
            _gameOfLife.Cells[1, 2].IsAlive.Should().BeTrue();
        }

        [Test]
        public void It_should_be_able_to_count_living_neighbors()
        {
            _gameOfLife.SetLivingCell(2, 3);
            _gameOfLife.SetLivingCell(2, 4);
            _gameOfLife.SetLivingCell(1, 2);
            _gameOfLife.SetLivingCell(1, 3);
            _gameOfLife.CountLivingNeighbors(2, 3).Should().Be(3);
        }

        [Test]
        public void The_game_should_correctely_count_corners()
        {
            _gameOfLife.SetLivingCell(0, 0);
            _gameOfLife.SetLivingCell(0, 1);
            _gameOfLife.SetLivingCell(1, 1);

            _gameOfLife.CountLivingNeighbors(0, 0).Should().Be(2);
        }

        [Test]
        public void Next_generation_should_be_split_according_to_rules()
        {
            _gameOfLife.SetLivingCell(1, 4);
            _gameOfLife.SetLivingCell(2, 3);
            _gameOfLife.SetLivingCell(2, 4);

            _gameOfLife.ComputeNextGeneration();

            _gameOfLife.Cells[1, 3].IsAlive.Should().BeTrue();
            _gameOfLife.Cells[1, 4].IsAlive.Should().BeTrue();
            _gameOfLife.Cells[2, 3].IsAlive.Should().BeTrue();
            _gameOfLife.Cells[2, 4].IsAlive.Should().BeTrue();
        }
    }
}

    //public class GameOfLife()
    //{
    //    private Cells _cells;

    //    public GameOfLife()
    //    {
    //    Init();
    //    }

    //    private void Init()
    //    {
    //        CreateCells();
    //    }

    //    private void CreateCells()
    //    {
    //    }
    //    public class Cells()
    //    {
    //        public Cells()
    //        {
    //            _cell = new Cell();
    //        }

    //        public class Cell()
    //        {
    //            private int _x_position;
    //            private int _y_position;
    //            public Cell()
    //            {
    //                _x_position;
    //                _y_position;
    //            }

    //            public Cell SetPositionOfCell(int Xposition, int Yposition)
    //            {
                    
    //            }
    //        }
    //    }
