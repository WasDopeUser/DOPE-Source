using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.CSharp.RuntimeBinder;

namespace DOPE.UI
{
	public partial class BrowserWindow : Window, INotifyPropertyChanged
	{
		[DllImport("urlmon.dll", CharSet = CharSet.Ansi)]
		private static extern int UrlMkSetSessionOption(int int_0, string string_0, int int_1, int int_2);

		public string Sid
		{
			[CompilerGenerated]
			get
			{
				return this.<Sid>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Sid>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Sid>k__BackingField = value;
				this.method_3(<>PropertyChangedEventArgs.Sid);
			}
		}

		public string Server
		{
			[CompilerGenerated]
			get
			{
				return this.<Server>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<Server>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<Server>k__BackingField = value;
				this.method_3(<>PropertyChangedEventArgs.Server);
			}
		}

		public string UserAgent
		{
			[CompilerGenerated]
			get
			{
				return this.<UserAgent>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (string.Equals(this.<UserAgent>k__BackingField, value, StringComparison.Ordinal))
				{
					return;
				}
				this.<UserAgent>k__BackingField = value;
				this.method_3(<>PropertyChangedEventArgs.UserAgent);
			}
		}

		public void method_0()
		{
			BrowserWindow.UrlMkSetSessionOption(268435457, this.UserAgent, this.UserAgent.Length, 0);
		}

		public BrowserWindow(string string_0, string string_1, string string_2)
		{
			Class13.igxcIukzfpare();
			this.PropertyChanged = new PropertyChangedEventHandler(BrowserWindow.<>c.<>9.method_0);
			base..ctor();
			this.InitializeComponent();
			this.Sid = string_1;
			this.Server = string_2;
			this.UserAgent = (string_0 ?? "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.106 Safari/537.36");
		}

		public event PropertyChangedEventHandler PropertyChanged;

		private void method_1(object sender, RoutedEventArgs e)
		{
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
			Application.SetCookie(new Uri("https://" + this.Server + ".darkorbit.com"), "dosid=" + this.Sid);
			this.Browser.Navigate(GClass814.smethod_1(this.Server, null) ?? "");
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
