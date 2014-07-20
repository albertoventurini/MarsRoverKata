using System;
using NUnit.Framework;

namespace MarsRoverKata.Test
{
	[TestFixture]
	public class AcceptanceTest
	{
		[Test]
		public void Commands_ffrff_should_end_up_at_2_2()
		{
			ICoordinateMover mover = new CoordinateMover();
			ICommandRunner runner = new CommandRunner();
			IRover rover = new Rover(mover, runner);
			rover.Position = new Coordinates(0, 0, 'N');

			rover.ReceiveCommands("ffrff");

			Assert.AreEqual(2, rover.Position.X);
			Assert.AreEqual(2, rover.Position.Y);
		}


	}
}

