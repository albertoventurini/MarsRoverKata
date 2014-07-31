using System;
using NUnit.Framework;

namespace MarsRoverKata.Test
{
	[TestFixture]
	public class AngleMapperTest
	{
		private IAngleMapper _mapper;


		[SetUp]
		public void Setup()
		{
			_mapper = new AngleMapper();
		}


		[Test]
		public void CharToInt_N_to_90()
		{
			var result = _mapper.CharToInt('N');

			Assert.AreEqual(90, result);
		}


		[Test]
		public void CharToInt_S_to_270()
		{
			var result = _mapper.CharToInt('S');

			Assert.AreEqual(270, result);
		}


		[Test]
		public void CharToInt_E_to_0()
		{
			var result = _mapper.CharToInt('E');

			Assert.AreEqual(0, result);
		}


		[Test]
		public void CharToInt_W_to_180()
		{
			var result = _mapper.CharToInt('W');

			Assert.AreEqual(180, result);
		}


		[Test]
		public void CharToInt_unknown_direction_throws_exception()
		{
			Assert.Throws<Exception>(() => _mapper.CharToInt('Y'));
		}


		[Test]
		public void IntToChar_0_to_E()
		{
			var result = _mapper.IntToChar(0);

			Assert.AreEqual('E', result);
		}


		[Test]
		public void IntToChar_90_to_N()
		{
			var result = _mapper.IntToChar(90);

			Assert.AreEqual('N', result);
		}


		[Test]
		public void IntToChar_should_support_angles_above_360()
		{
			var result = _mapper.IntToChar(360);

			Assert.AreEqual('E', result);
		}


		[Test]
		public void IntToChar_should_support_angles_below_0()
		{
			var result = _mapper.IntToChar(-90);

			Assert.AreEqual('S', result);
		}

	}
}

