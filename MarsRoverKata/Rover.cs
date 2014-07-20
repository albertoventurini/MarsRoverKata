using System;

namespace MarsRoverKata
{
	public class Rover : IRover
	{
		public Coordinates Position { get; set; }

		private readonly ICoordinateMover _mover;
		private readonly ICommandRunner _commandRunner;


		public Rover(ICoordinateMover mover, ICommandRunner commandRunner)
		{
			_mover = mover;
			_commandRunner = commandRunner;

			SetupCommands();
		}


		private void SetupCommands()
		{
			_commandRunner.Add('f', MoveForward);
			_commandRunner.Add('b', MoveBackward);
			_commandRunner.Add('r', TurnRight);
			_commandRunner.Add('l', TurnLeft);
		}


		public void ReceiveCommands(string commands)
		{
			_commandRunner.Run(commands);
		}


		private void TurnRight()
		{
			_mover.TurnRight(Position);
		}


		private void TurnLeft()
		{
			_mover.TurnLeft(Position);
		}


		private void MoveForward()
		{
			_mover.Forward(Position);
		}


		private void MoveBackward()
		{
			_mover.Backward(Position);
		}
	}
}

