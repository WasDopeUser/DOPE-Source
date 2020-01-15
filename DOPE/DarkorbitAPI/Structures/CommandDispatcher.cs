using System;
using System.Collections.Concurrent;

namespace DarkorbitAPI.Structures
{
	public class CommandDispatcher
	{
		public void method_0(GInterface0 ginterface0_0)
		{
			short id = ginterface0_0.Id;
			MulticastDelegate multicastDelegate;
			if (this.Handlers.TryGetValue(id, out multicastDelegate))
			{
				multicastDelegate.DynamicInvoke(new object[]
				{
					ginterface0_0
				});
			}
		}

		public void method_1<NYIkVxcziLTnYHlw7Xr>(Action<NYIkVxcziLTnYHlw7Xr> action_0) where NYIkVxcziLTnYHlw7Xr : class, GInterface0
		{
			CommandDispatcher.<>c__DisplayClass2_0<NYIkVxcziLTnYHlw7Xr> CS$<>8__locals1 = new CommandDispatcher.<>c__DisplayClass2_0<NYIkVxcziLTnYHlw7Xr>();
			CS$<>8__locals1.action = action_0;
			short id = ((NYIkVxcziLTnYHlw7Xr)((object)GClass85.smethod_0(typeof(NYIkVxcziLTnYHlw7Xr)))).Id;
			this.Handlers.AddOrUpdate(id, CS$<>8__locals1.action, new Func<short, MulticastDelegate, MulticastDelegate>(CS$<>8__locals1.method_0));
		}

		public void Off<T>(Action<T> action) where T : class, GInterface0
		{
			short id = ((T)((object)GClass85.smethod_0(typeof(T)))).Id;
			MulticastDelegate multicastDelegate;
			if (this.Handlers.TryGetValue(id, out multicastDelegate))
			{
				this.Handlers.TryUpdate(id, (MulticastDelegate)Delegate.RemoveAll(multicastDelegate, action), multicastDelegate);
			}
		}

		public CommandDispatcher()
		{
			Class13.nIxas2ezryi9b();
			this.Handlers = new ConcurrentDictionary<short, MulticastDelegate>();
			base..ctor();
		}

		public readonly ConcurrentDictionary<short, MulticastDelegate> Handlers;
	}
}
