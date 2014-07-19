using System;
using System.Collections.Generic;

namespace MarsRoverKata
{
	public interface IAngleMapper
	{
		int CharToInt(char direction);
		char IntToChar(int angle);
	}


	public class AngleMapper : IAngleMapper
	{
		private IBiDictionary<char, int> _biDictionary;


		public AngleMapper()
		{
			_biDictionary = new BiDictionary<char, int>();
			_biDictionary.Add('N', 90);
			_biDictionary.Add('S', 270);
			_biDictionary.Add('E', 0);
			_biDictionary.Add('W', 180);
		}


		public int CharToInt(char direction)
		{
			return _biDictionary.Get(direction);
		}


		public char IntToChar(int angle)
		{
			return _biDictionary.Get(NormalizeAngle(angle));
		}


		private int NormalizeAngle(int angle)
		{
			int result = angle % 360;
			if(result < 0)
				result += 360;

			return result;
		}
	}
}

