using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DOPE.Properties
{
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		internal Resources()
		{
			Class13.F93tSdiz1aNIA();
			base..ctor();
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.resourceManager_0 == null)
				{
					Resources.resourceManager_0 = new ResourceManager("DOPE.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.resourceManager_0;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		internal static byte[] Buster
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("Buster", Resources.cultureInfo_0);
			}
		}

		internal static byte[] pandora
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("pandora", Resources.cultureInfo_0);
			}
		}

		private static ResourceManager resourceManager_0;

		private static CultureInfo cultureInfo_0;
	}
}
