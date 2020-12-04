using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaizenko.TempConv;

namespace Kaizenko.TempConv.Tests
{
    class RoverTests
    {
        Rover _rover;

        [SetUp]
        public void Setup()
        {
            _rover = new Rover();
        }

        [Test]
        public void GetDirection_WhenCheckingDirectionAndNoMovement_ExpectN()
        {
            // arrange
            
            // act
            string direction = _rover.getDirection();
            // assert
            Assert.AreEqual("N", direction);
        }

        [Test]
        public void GetLoc_WhenCheckingWithNoMovement_ExpectX0Y0()
        {
            // arrange

            // act
            int x = _rover.getXCoorindate();
            int y = _rover.getYCoordinate();
            // assert
            Assert.AreEqual(0, x);
            Assert.AreEqual(0, y);
        }

        [Test]
        public void Movement_WhenMovingFowardOnce_ExpectX1Y0()
        {
            // arrange

            // act
            _rover.moveForward(1);
            // assert
            int x = _rover.getXCoorindate();
            int y = _rover.getYCoordinate();
            Assert.AreEqual(1, x);
            Assert.AreEqual(0, y);
        }

        [Test]
        public void Movement_WhenMovingBackwardOnce_ExpectXMinus1Y0()
        {
            // arrange

            // act
            _rover.moveBackward(1);
            // assert
            int x = _rover.getXCoorindate();
            int y = _rover.getYCoordinate();
            Assert.AreEqual(-1, x);
            Assert.AreEqual(0, y);
        }

        [Test]
        public void Movement_WhenTurningLeftOnce_ExpectDirectionW()
        {
            // arrange

            // act
            _rover.turnLeft();
            // assert
            string direction = _rover.getDirection();
            Assert.AreEqual("W", direction);
        }

        [Test]
        public void Movement_WhenTurningRighttOnce_ExpectDirectionE()
        {
            // arrange

            // act
            _rover.turnRight();
            // assert
            string direction = _rover.getDirection();
            Assert.AreEqual("E", direction);
        }






    }
}
