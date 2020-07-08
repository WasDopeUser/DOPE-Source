using System;
using System.Collections.Generic;
using System.Linq;

namespace DarkorbitAPI.CommonStructures
{
	public class Vector<T> : List<T>
	{
		public int Length
		{
			get
			{
				return base.Count;
			}
		}

		public int method_0(T pnpeaX5MXm3pdnBeHeb)
		{
			base.Add(pnpeaX5MXm3pdnBeHeb);
			return 1;
		}

		public Vector()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		public Vector(int int_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
			for (int i = 0; i < int_0; i++)
			{
				base.Add(default(T));
			}
		}

		public Vector(Vector<T> vector_0)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
			for (int i = 0; i < vector_0.Length; i++)
			{
				base.Add(vector_0[i]);
			}
		}

		public T method_1()
		{
			T result = this.Last<T>();
			base.RemoveAt(base.Count - 1);
			return result;
		}

		public T this[uint uint_0]
		{
			get
			{
				return base[(int)uint_0];
			}
			set
			{
				base[(int)uint_0] = value;
			}
		}
	}
}
