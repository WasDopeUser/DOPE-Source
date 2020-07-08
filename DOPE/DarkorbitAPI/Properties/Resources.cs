using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DarkorbitAPI.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	public class Resources
	{
		internal Resources()
		{
			Class13.xnk8ImWzpOt04();
			base..ctor();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceManager_0 == null)
				{
					Resources.resourceManager_0 = new ResourceManager("DarkorbitAPI.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceManager_0;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture
		{
			get
			{
				return Resources.cultureInfo_0;
			}
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		public static string maps_config
		{
			get
			{
				return Resources.ResourceManager.GetString("maps_config", Resources.cultureInfo_0);
			}
		}

		private static ResourceManager resourceManager_0;

		private static CultureInfo cultureInfo_0;
	}
}
