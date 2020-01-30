using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Ace.Networking.Entanglement.Reflection;
using Ace.Networking.Extensions;
using NLog;

public static class GClass82
{
	[CompilerGenerated]
	public static Dictionary<int, LinkedList<GClass82.GClass83>> smethod_0()
	{
		return GClass82.dictionary_0;
	}

	[CompilerGenerated]
	private static void smethod_1(Dictionary<int, LinkedList<GClass82.GClass83>> dictionary_1)
	{
		GClass82.dictionary_0 = dictionary_1;
	}

	public static void smethod_2()
	{
		if (GClass82.bool_0)
		{
			return;
		}
		GClass82.bool_0 = true;
		GClass82.smethod_1(new Dictionary<int, LinkedList<GClass82.GClass83>>());
		Logger logger = LogManager.GetLogger("Base-Net-Handlers");
		logger.Info("Discovering packet handlers...");
		int num = 0;
		foreach (Type type in typeof(GClass82).Assembly.GetTypes())
		{
			if (typeof(GInterface4).IsAssignableFrom(type))
			{
				GInterface4 ginterface = GClass85.smethod_0(type) as GInterface4;
				if (ginterface != null)
				{
					foreach (MethodInfo methodInfo in type.GetMethods(BindingFlags.Instance | BindingFlags.Public))
					{
						ParameterInfo parameterInfo = methodInfo.GetParameters().SingleOrDefault<ParameterInfo>();
						int num2;
						if (parameterInfo != null && typeof(GInterface0).IsAssignableFrom(parameterInfo.ParameterType) && GClass86.smethod_0(parameterInfo.ParameterType, out num2))
						{
							IDictionary<int, LinkedList<GClass82.GClass83>> d = GClass82.dictionary_0;
							int key = num2;
							GClass82.GClass83 gclass = new GClass82.GClass83();
							gclass.method_3(ginterface);
							gclass.method_1(DelegateHelper.ConstructDelegateCallVoid(methodInfo, type));
							d.Append(key, gclass);
							num++;
						}
					}
				}
			}
		}
		logger.Info("Found {count} packet handlers", num);
	}

	public static void smethod_3(GInterface0 ginterface0_0)
	{
		Logger logger = LogManager.GetLogger("Base-Net-Handlers");
		LinkedList<GClass82.GClass83> linkedList;
		if (!GClass82.dictionary_0.TryGetValue((int)ginterface0_0.Id, out linkedList))
		{
			return;
		}
		if (logger.IsTraceEnabled)
		{
			logger.Trace<string, short>("Executing command {commandName} ({id})", ginterface0_0.GetType().Name, ginterface0_0.Id);
		}
		foreach (GClass82.GClass83 gclass in linkedList)
		{
			try
			{
				gclass.method_4(ginterface0_0);
			}
			catch
			{
			}
		}
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass82()
	{
		Class13.Gj4N3WdzaR1LY();
	}

	[CompilerGenerated]
	private static Dictionary<int, LinkedList<GClass82.GClass83>> dictionary_0;

	private static volatile bool bool_0;

	public delegate void GDelegate4(GInterface0 cmd);

	public class GClass83
	{
		[CompilerGenerated]
		public Action<object, object[]> method_0()
		{
			return this.action_0;
		}

		[CompilerGenerated]
		public void method_1(Action<object, object[]> action_1)
		{
			this.action_0 = action_1;
		}

		[CompilerGenerated]
		public GInterface4 method_2()
		{
			return this.ginterface4_0;
		}

		[CompilerGenerated]
		public void method_3(GInterface4 ginterface4_1)
		{
			this.ginterface4_0 = ginterface4_1;
		}

		public void method_4(GInterface0 ginterface0_0)
		{
			this.method_0()(this.method_2(), new object[]
			{
				ginterface0_0
			});
		}

		public GClass83()
		{
			Class13.Gj4N3WdzaR1LY();
			base..ctor();
		}

		[CompilerGenerated]
		private Action<object, object[]> action_0;

		[CompilerGenerated]
		private GInterface4 ginterface4_0;
	}
}
