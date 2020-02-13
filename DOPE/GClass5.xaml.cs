using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Security.Principal;
using System.Text;
using System.Windows;
using DOPE.Common;
using Newtonsoft.Json;
using NLog;
using NLog.Config;
using NLog.Targets;
using PErkava;

public partial class GClass5 : Application
{
	private static void smethod_0()
	{
		LogManager.Configuration = new LoggingConfiguration();
		FileTarget fileTarget = new FileTarget("file");
		fileTarget.CreateDirs = true;
		fileTarget.EnableFileDelete = true;
		fileTarget.ArchiveNumbering = ArchiveNumberingMode.DateAndSequence;
		fileTarget.MaxArchiveFiles = 10;
		fileTarget.KeepFileOpen = true;
		fileTarget.OpenFileCacheTimeout = 30;
		fileTarget.EnableArchiveFileCompression = true;
		fileTarget.AutoFlush = true;
		fileTarget.Encoding = Encoding.UTF8;
		fileTarget.ArchiveAboveSize = 1073741824L;
		string text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DOPE", "Logs").Replace("\\", "/").TrimEnd(new char[]
		{
			'/'
		});
		if (Directory.Exists(text))
		{
			try
			{
				Directory.Delete(text, true);
			}
			catch
			{
			}
		}
		LogConfig.Configure(fileTarget);
		fileTarget.FileName = text + "/${filedate}/${logcategory}/log-${botid}.txt";
		LogManager.Configuration.AddTarget("file", fileTarget);
		LogManager.ReconfigExistingLoggers();
	}

	public GClass5()
	{
		GClass5.smethod_0();
		this.logger_0 = LogManager.GetLogger("DOPE");
		this.logger_0.Info("Loading DOPE {arch} {version} on {architecture} ({os})", new object[]
		{
			GClass859.twhoiCoyXfL() ? "x86" : "x64",
			Constants.VersionString,
			Environment.Is64BitOperatingSystem ? "x64" : "x86",
			Environment.OSVersion.VersionString
		});
		AppDomain.CurrentDomain.FirstChanceException += this.method_0;
		AppDomain.CurrentDomain.UnhandledException += this.qAhoYvbsNa;
		base.ShutdownMode = ShutdownMode.OnMainWindowClose;
		GClass82.smethod_2();
		bool flag;
		using (WindowsIdentity current = WindowsIdentity.GetCurrent())
		{
			flag = new WindowsPrincipal(current).IsInRole(WindowsBuiltInRole.Administrator);
		}
		PErkava.IsSupported = flag;
		try
		{
			PErkava.smethod_3();
		}
		catch
		{
			PErkava.IsSupported = false;
		}
		if (flag && PErkava.IsSupported)
		{
			try
			{
				GClass865 gclass = new GClass865();
				gclass.Start();
				PErkava.Host = gclass;
			}
			catch
			{
			}
		}
		this.logger_0.Info("PErkava support status: {status}", PErkava.IsSupported);
		if (PErkava.IsSupported)
		{
			this.logger_0.Info("Use legacy proxy: {proxy}", PErkava.smethod_2());
		}
		AppDomain.CurrentDomain.ProcessExit += this.method_1;
	}

	private void method_0(object sender, FirstChanceExceptionEventArgs e)
	{
		if (this.logger_0 == null)
		{
			return;
		}
		if (e.Exception is JsonSerializationException)
		{
			return;
		}
		try
		{
			Exception exception = e.Exception;
			this.logger_0.Fatal(exception, "First chance {exception}", new object[]
			{
				exception
			});
		}
		catch
		{
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		if (PErkava.IsSupported)
		{
			PErkava.smethod_3();
		}
	}

	private void qAhoYvbsNa(object sender, UnhandledExceptionEventArgs e)
	{
		if (this.logger_0 == null)
		{
			return;
		}
		try
		{
			Exception ex = e.ExceptionObject as Exception;
			if (ex != null)
			{
				this.logger_0.Fatal(ex, "Unhandled {exception}", new object[]
				{
					ex
				});
			}
		}
		catch
		{
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void method_2()
	{
		if (this.bool_0)
		{
			return;
		}
		this.bool_0 = true;
		base.StartupUri = new Uri("UI/MainWindow.xaml", UriKind.Relative);
		Uri resourceLocator = new Uri("/DOPE;V0.1.0.0;component/app.xaml", UriKind.Relative);
		Application.LoadComponent(this, resourceLocator);
	}

	private readonly Logger logger_0;

	private bool bool_0;
}
