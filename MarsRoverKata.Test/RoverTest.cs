using System;
using NUnit.Framework;

namespace MarsRoverKata.Test
{
	[TestFixture]
	public class RoverTest
	{
		[TestCase('N', 0, 1)]
		[TestCase('S', 0, -1)]
		[TestCase('E', 1, 0)]
		[TestCase('W', -1, 0)]
		public void ReceiveCommands_f_advance_by_1(char direction, int finalX, int finalY)
		{
			IRover rover = BuildRover(direction);

			rover.ReceiveCommands ("f");

			Assert.AreEqual (finalX, rover.Position.X);
			Assert.AreEqual (finalY, rover.Position.Y);
		}


		// ReceiveCommands_f_should_use_method_Forward_of_CoordinateMover()


		[TestCase('N', 0, 2)]
		[TestCase('S', 0, -2)]
		[TestCase('E', 2, 0)]
		[TestCase('W', -2, 0)]
		public void ReceiveCommands_ff_advance_by_2(char direction, int finalX, int finalY)
		{
			IRover rover = BuildRover(direction);

			rover.ReceiveCommands ("ff");

			Assert.AreEqual (finalX, rover.Position.X);
			Assert.AreEqual (finalY, rover.Position.Y);
		}


		[TestCase('N', 0, -1)]
		[TestCase('S', 0, 1)]
		[TestCase('E', -1, 0)]
		[TestCase('W', 1, 0)]
		public void ReceiveCommands_b_recede_by_1(char direction, int finalX, int finalY)
		{
			IRover rover = BuildRover(direction);

			rover.ReceiveCommands ("b");

			Assert.AreEqual (finalX, rover.Position.X);
			Assert.AreEqual (finalY, rover.Position.Y);
		}


		/*
		[Test]
		public void ReceiveCommands_r_should_decrease_angle_by_90()
		{
			IRover rover = BuildRover('N');
			double initialAngle = rover.Angle;

			rover.ReceiveCommands ("r");

			Assert.AreEqual (initialAngle - 90, rover.Angle);
		}*/


		private IRover BuildRover(char direction)
		{
			return new Rover(0, 0, direction);
		}


	}
}

