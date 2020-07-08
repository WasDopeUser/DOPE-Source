using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DOPE.Properties
{
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[CompilerGenerated]
	internal class Resources
	{
		internal Resources()
		{
			Class13.xnk8ImWzpOt04();
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
				Resources.iomcUunUtY = value;
			}
		}

		internal static byte[] Buster
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("Buster", Resources.iomcUunUtY);
			}
		}

		internal static byte[] pandora
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("pandora", Resources.iomcUunUtY);
			}
		}

		private static ResourceManager resourceManager_0;

		private static CultureInfo iomcUunUtY;
	}
}
