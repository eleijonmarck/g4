using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            _gameOfLife = new GameOfLife();
        }

        [Test]
        public void It_should_be_able_to_set_living_cells()
        {
            _gameOfLife.SetLivingCells();
            _gameOfLife.Cells().IsAlive().Should.BeTrue();
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
