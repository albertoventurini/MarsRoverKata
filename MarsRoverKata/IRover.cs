using System;

namespace MarsRoverKata
{
	public interface IRover
	{
		Coordinates Position { get; set; }
		void ReceiveCommands(string commands);
	}
}

