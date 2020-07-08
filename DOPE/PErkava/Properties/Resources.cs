using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace PErkava.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
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
				if (Resources.AfHwdagYehW == null)
				{
					Resources.AfHwdagYehW = new ResourceManager("PErkava.Properties.Resources", typeof(Resources).Assembly);
				}
				return Resources.AfHwdagYehW;
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

		public static byte[] payload
		{
			get
			{
				return (byte[])Resources.ResourceManager.GetObject("payload", Resources.cultureInfo_0);
			}
		}

		public static Bitmap poweroff
		{
			get
			{
				return (Bitmap)Resources.ResourceManager.GetObject("poweroff", Resources.cultureInfo_0);
			}
		}

		private static ResourceManager AfHwdagYehW;

		private static CultureInfo cultureInfo_0;
	}
}
