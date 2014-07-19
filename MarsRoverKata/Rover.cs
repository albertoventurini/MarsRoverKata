using System;

namespace MarsRoverKata
{
	public class Rover : IRover
	{
		public Coordinates Position { get; private set; }

		private ICoordinateMover _mover;


		public Rover(Coordinates initPosition)
		{
			Position = initPosition;
			_mover = new CoordinateMover();
		}


		public Rover(int x, int y, char direction)
			: this(new Coordinates(x, y, direction))
		{
		}


		public void ReceiveCommands(string commandString)
		{
			foreach (char c in commandString)
			{
				if (c == 'f')
					MoveForward();
				else if (c == 'b')
					MoveBackward();
				else if (c == 'r')
					TurnRight();
			}
		}


		private void TurnRight()
		{

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

