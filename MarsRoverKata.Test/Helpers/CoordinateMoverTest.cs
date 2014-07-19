using System;
using NUnit.Framework;

namespace MarsRoverKata.Test
{
	public class CoordinateMoverTest
	{
		private CoordinateMover _mover;


		[SetUp]
		public void Init()
		{
			_mover = new CoordinateMover();
		}


		[Test]
		public void Forward_0_0_E_ends_in_1_0()
		{
			Coordinates coordinates = new Coordinates(0, 0, 'E');

			_mover.Forward(coordinates);

			Assert.AreEqual(1, coordinates.X);
			Assert.AreEqual(0, coordinates.Y);
		}


		[Test]
		public void Forward_0_0_N_ends_in_0_1()
		{
			Coordinates coordinates = new Coordinates(0, 0, 'N');

			_mover.Forward(coordinates);

			Assert.AreEqual(0, coordinates.X);
			Assert.AreEqual(1, coordinates.Y);
		}


		[Test]
		public void Forward_1_0_W_ends_in_0_0()
		{
			Coordinates coordinates = new Coordinates(1, 0, 'W');

			_mover.Forward(coordinates);

			Assert.AreEqual(0, coordinates.X);
			Assert.AreEqual(0, coordinates.Y);
		}


		[Test]
		public void Backward_5_5_E_ends_in_4_5()
		{
			Coordinates coordinates = new Coordinates(5, 5, 'E');

			_mover.Backward(coordinates);

			Assert.AreEqual(4, coordinates.X);
			Assert.AreEqual(5, coordinates.Y);
		}


		[Test]
		public void Backward_5_5_S_ends_in_5_6()
		{
			Coordinates coordinates = new Coordinates(5, 5, 'S');

			_mover.Backward(coordinates);

			Assert.AreEqual(5, coordinates.X);
			Assert.AreEqual(6, coordinates.Y);
		}


		[TestCase('N', 'E')]
		[TestCase('W', 'N')]
		[TestCase('S', 'W')]
		[TestCase('E', 'S')]
		public void TurnRight_should_end_with_the_correct_direction(char initialDirection, char finalDirection)
		{
			Coordinates coordinates = new Coordinates(0, 0, initialDirection);

			_mover.TurnRight(coordinates);

			Assert.AreEqual(finalDirection, coordinates.Direction);
		}


		[TestCase('N', 'W')]
		[TestCase('W', 'S')]
		[TestCase('S', 'E')]
		[TestCase('E', 'N')]
		public void TurnLeft_should_end_with_the_correct_direction(char initialDirection, char finalDirection)
		{
			Coordinates coordinates = new Coordinates(0, 0, initialDirection);

			_mover.TurnLeft(coordinates);

			Assert.AreEqual(finalDirection, coordinates.Direction);
		}
	}
}

