using System;
using NUnit.Framework;

namespace MarsRoverKata.Test
{
	[TestFixture]
	public class BiDictionaryTest
	{
		private IBiDictionary<char, int> _biDictionary;

		[SetUp]
		public void Setup()
		{
			_biDictionary = new BiDictionary<char, int>();
		}


		[Test]
		public void Add_then_Contains_should_return_true()
		{
			_biDictionary.Add('N', 90);

			Assert.True(_biDictionary.Contains('N'));
			Assert.True(_biDictionary.Contains(90));
		}


		[Test]
		public void Add_then_Get_T1_should_return_the_item()
		{
			_biDictionary.Add('N', 90);

			var item = _biDictionary.Get('N');

			Assert.AreEqual(90, item);
		}


		[Test]
		public void Add_then_Get_T2_should_return_the_item()
		{
			_biDictionary.Add('N', 90);

			var item = _biDictionary.Get(90);

			Assert.AreEqual('N', item);
		}


		[Test]
		[ExpectedException(typeof(Exception))]
		public void Get_with_no_item_throws_exception()
		{
			_biDictionary.Add('N', 90);

			_biDictionary.Get(0);
		}

	}
}

