using System;
using System.Collections.Generic;

namespace MarsRoverKata
{
	public interface IBiDictionary<T1, T2>
	{
		void Add(T1 item1, T2 item2);

		bool Contains(T1 item);
		bool Contains(T2 item);

		T2 Get(T1 item);
		T1 Get(T2 item);
	}

	public class BiDictionary<T1, T2> : IBiDictionary<T1, T2>
	{
		private IList<T1> _list1;
		private IList<T2> _list2;


		public BiDictionary ()
		{
			_list1 = new List<T1>();
			_list2 = new List<T2>();
		}


		public void Add(T1 item1, T2 item2)
		{
			_list1.Add(item1);
			_list2.Add(item2);
		}


		public bool Contains(T1 item)
		{
			return _list1.Contains(item);
		}


		public bool Contains(T2 item)
		{
			return _list2.Contains(item);
		}

		public T2 Get(T1 item)
		{
			if(!Contains(item))
				throw new Exception("Item not found in BiDictionary");

			int index = _list1.IndexOf(item);
			return _list2[index];
		}

		public T1 Get(T2 item)
		{
			if(!Contains(item))
				throw new Exception("Item not found in BiDictionary");

			int index = _list2.IndexOf(item);
			return _list1[index];
		}

	}
}

