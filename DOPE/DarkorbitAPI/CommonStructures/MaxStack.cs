﻿using System;
using System.Collections.Generic;

namespace DarkorbitAPI.CommonStructures
{
	public class MaxStack<T> : LinkedList<T>
	{
		public int Limit { get; set; }

		public MaxStack(int int_0 = 1000)
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
			this.Limit = int_0;
		}

		public void method_0(T Ouw90M5rxKm07snR4TM)
		{
			base.AddLast(Ouw90M5rxKm07snR4TM);
			if (base.Count > this.Limit)
			{
				base.RemoveFirst();
			}
		}

		public T method_1()
		{
			T value = base.Last.Value;
			base.RemoveLast();
			return value;
		}

		public T method_2()
		{
			if (base.Count == 0)
			{
				return default(T);
			}
			return base.Last.Value;
		}

		public T method_3()
		{
			if (base.Count == 0)
			{
				return default(T);
			}
			return base.First.Value;
		}
	}
}
