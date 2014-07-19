using System;

namespace MarsRoverKata
{
	public interface IRover
	{
		Coordinates Position { get; }
		void ReceiveCommands(string commandString);
	}
}

