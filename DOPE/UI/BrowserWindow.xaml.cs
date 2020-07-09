using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using DarkorbitAPI;
using Microsoft.CSharp.RuntimeBinder;

namespace DOPE.UI
{
	public partial class BrowserWindow : Window, INotifyPropertyChanged
	{
		[DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
		private static extern int UrlMkSetSessionOption(int int_0, string string_0, int int_1, int int_2);

		public DarkOrbitWebAPI Web
		{
			[CompilerGenerated]
			get
			{
				return this.<Web>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (object.Equals(this.<Web>k__BackingField, value))
				{
					return;
				}
				this.<Web>k__BackingField = value;
				this.method_3(<>PropertyChangedEventArgs.UserAgent);
				this.method_3(<>PropertyChangedEventArgs.Server);
				this.method_3(<>PropertyChangedEventArgs.Web);
			}
		}

		public string UserAgent
		{
			get
			{
				return this.Web.UserAgent;
			}
		}

		public string Server
		{
			get
			{
				return this.Web.Server;
			}
		}

		public void method_0()
		{
			BrowserWindow.UrlMkSetSessionOption(268435457, this.UserAgent, this.UserAgent.Length, 0);
		}

		public BrowserWindow(DarkOrbitWebAPI darkOrbitWebAPI_0)
		{
			Class13.lOBHd9Nzn7x2T();
			this.PropertyChanged = new PropertyChangedEventHandler(BrowserWindow.<>c.<>9.method_0);
			base..ctor();
			this.InitializeComponent();
			this.Web = darkOrbitWebAPI_0;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private static void smethod_0()
		{
			int num = 3;
			if (!BrowserWindow.InternetSetOption(IntPtr.Zero, 81, ref num, 4))
			{
				throw Marshal.GetExceptionForHR(Marshal.GetHRForLastWin32Error());
			}
		}

		[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool InternetSetOption(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

		private void method_1(object sender, RoutedEventArgs e)
		{
			BrowserWindow.smethod_0();
			this.method_0();
			object arg = this.Browser.GetType().InvokeMember("ActiveXInstance", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetProperty, null, this.Browser, new object[0]);
			if (BrowserWindow.<>o__19.<>p__0 == null)
			{
				BrowserWindow.<>o__19.<>p__0 = CallSite<Func<CallSite, object, bool, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.SetMember(CSharpBinderFlags.None, "Silent", typeof(BrowserWindow), new CSharpArgumentInfo[]
				{
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null),
					CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, null)
				}));
			}
			BrowserWindow.<>o__19.<>p__0.Target(BrowserWindow.<>o__19.<>p__0, arg, true);
			Uri uri = new Uri("https://" + this.Server + ".darkorbit.com");
			foreach (object obj in this.Web.Cookies.GetCookies(uri))
			{
				Cookie cookie = (Cookie)obj;
				Application.SetCookie(uri, cookie.Name + "=" + cookie.Value);
			}
			this.Browser.Navigate(GClass880.smethod_1(this.Server, null) ?? "");
		}

		private void method_2(object sender, EventArgs e)
		{
			this.Browser.Dispose();
		}

		[GeneratedCode("PropertyChanged.Fody", "3.2.3.0")]
		[DebuggerNonUserCode]
		protected void method_3(PropertyChangedEventArgs propertyChangedEventArgs_0)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, propertyChangedEventArgs_0);
			}
		}
	}
}
