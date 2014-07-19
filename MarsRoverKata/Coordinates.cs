using System;

namespace MarsRoverKata
{

	public class Coordinates
	{
		public int X { get; set; }
		public int Y { get; set; }
		public char Direction { get; set; }

		public Coordinates(int x, int y, char direction)
		{
			X = x;
			Y = y;
			Direction = direction;
		}
	}
}

