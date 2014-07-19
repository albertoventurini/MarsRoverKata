using System;

namespace MarsRoverKata
{
	public interface ICoordinateMover
	{
		void Forward(Coordinates coordinates);
		void Backward(Coordinates coordinates);
		void TurnRight(Coordinates coordinates);
		void TurnLeft(Coordinates coordinates);
	}


	public class CoordinateMover : ICoordinateMover
	{
		private AngleMapper _angleMapper;


		public CoordinateMover()
		{
			_angleMapper = new AngleMapper();
		}


		public void Forward(Coordinates coordinates)
		{
			Move(coordinates, 1);
		}


		public void Backward(Coordinates coordinates)
		{
			Move(coordinates, -1);
		}


		private void Move(Coordinates coordinates, int coefficient)
		{
			int angle = _angleMapper.CharToInt(coordinates.Direction);
			double radAngle = angle * Math.PI / 180.0;

			coordinates.X += (int) Math.Cos(radAngle) * coefficient;
			coordinates.Y += (int) Math.Sin(radAngle) * coefficient;
		}


		public void TurnRight(Coordinates coordinates)
		{
			int angle = _angleMapper.CharToInt(coordinates.Direction);
			angle -= 90;
			coordinates.Direction = _angleMapper.IntToChar(angle);
		}


		public void TurnLeft(Coordinates coordinates)
		{
			int angle = _angleMapper.CharToInt(coordinates.Direction);
			angle += 90;
			coordinates.Direction = _angleMapper.IntToChar(angle);
		}
	}
}

