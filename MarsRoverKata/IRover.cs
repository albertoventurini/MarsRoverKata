using System;

namespace MarsRoverKata
{
	public interface IRover
	{
		Coordinates Position { get; }
		void Initialize(Coordinates initialPosition);
		void ReceiveCommands(string commands);
	}
}

