using System;
using NUnit.Framework;
using Moq;

namespace MarsRoverKata.Test
{
	[TestFixture]
	public class RoverTest
	{
		private IRover _rover;
		private Mock<ICoordinateMover> _mover;
		//private Mock<ICommandRunner> _commandRunner;
		private ICommandRunner _commandRunner;


		[SetUp]
		public void Setup()
		{
			_mover = new Mock<ICoordinateMover>();
			//_commandRunner = new Mock<ICommandRunner>();
			_commandRunner = new CommandRunner();

			_rover = new Rover(_mover.Object, _commandRunner);
		}


		[Test]
		public void ReceiveCommands_f_should_use_CoordinateMover_Forward()
		{
			_rover.ReceiveCommands("f");

			_mover.Verify(x => x.Forward(It.IsAny<Coordinates>()));
		}


		[Test]
		public void ReceiveCommands_b_should_use_CoordinateMover_Backward()
		{
			_rover.ReceiveCommands("b");

			_mover.Verify(x => x.Backward(It.IsAny<Coordinates>()));
		}


		[Test]
		public void ReceiveCommands_r_should_use_CoordinateMover_TurnRight()
		{
			_rover.ReceiveCommands("r");

			_mover.Verify(x => x.TurnRight(It.IsAny<Coordinates>()));
		}

		[Test]
		public void ReceiveCommands_l_should_use_CoordinateMover_TurnRight()
		{
			_rover.ReceiveCommands("l");

			_mover.Verify(x => x.TurnLeft(It.IsAny<Coordinates>()));
		}


		[Test]
		public void ReceiveCommands_should_use_CommandRunner_Run()
		{
			Mock<ICoordinateMover> mover = new Mock<ICoordinateMover>();
			Mock<ICommandRunner> runner = new Mock<ICommandRunner>();
			IRover rover = new Rover(mover.Object, runner.Object);

			rover.ReceiveCommands("flrb");

			runner.Verify(x => x.Run(It.IsAny<string>()));
		}



	}
}

