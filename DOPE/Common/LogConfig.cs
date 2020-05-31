using System;
using System.Collections.Generic;
using System.Linq;
using NLog;
using NLog.Config;
using NLog.LayoutRenderers;
using NLog.Targets;

namespace DOPE.Common
{
	public static class LogConfig
	{
		public static void Configure(Target target)
		{
			LogConfig.StartedDate = DateTimeOffset.Now;
			LayoutRenderer.Register("botid", delegate(LogEventInfo log)
			{
				string text = log.LoggerName.Split(new char[]
				{
					'-'
				}).LastOrDefault<string>();
				if (text != null && text.Contains("_"))
				{
					return text;
				}
				return "";
			});
			LayoutRenderer.Register("realname", delegate(LogEventInfo log)
			{
				string[] array = log.LoggerName.Split(new char[]
				{
					'-'
				});
				string text = array.LastOrDefault<string>();
				if (text != null && text.Contains("_"))
				{
					return string.Join("-", array.Take(array.Length - 1));
				}
				return log.LoggerName;
			});
			LayoutRenderer.Register("logcategory", delegate(LogEventInfo log)
			{
				string text = log.LoggerName.Split(new char[]
				{
					'-'
				}).LastOrDefault<string>();
				if (text == null || !text.Contains("_"))
				{
					return "System";
				}
				return "Bot";
			});
			LayoutRenderer.Register("filedate", (LogEventInfo log) => LogConfig.StartedDate.ToString("yyyy\\-MM\\-dd HH\\.mm\\.ss"));
			LogLevel debug = LogLevel.Debug;
			foreach (KeyValuePair<string, LogLevel> keyValuePair in new Dictionary<string, LogLevel>
			{
				{
					"Core-Controller*",
					debug
				},
				{
					"Core-MainBotController*",
					debug
				},
				{
					"Core-Scheduler*",
					LogLevel.Trace
				},
				{
					"Core-Bot*",
					debug
				},
				{
					"CLI",
					LogLevel.Trace
				},
				{
					"DOPE",
					LogLevel.Trace
				},
				{
					"Core-BotScheduler*",
					LogLevel.Trace
				},
				{
					"Base-Game*",
					LogLevel.Info
				},
				{
					"Base-Map*",
					LogLevel.Trace
				},
				{
					"Core-BackgroundLogic*",
					LogLevel.Info
				},
				{
					"Base-Net-Handlers*",
					LogLevel.Info
				},
				{
					"ObjectPool-*",
					LogLevel.Info
				},
				{
					"Core-Module*",
					LogLevel.Info
				},
				{
					"Core-Behavior*",
					LogLevel.Info
				},
				{
					"Base-Net-ServerCommands*",
					LogLevel.Trace
				}
			})
			{
				LoggingRule item = new LoggingRule(keyValuePair.Key, keyValuePair.Value, target);
				LogManager.Configuration.LoggingRules.Add(item);
			}
		}

		public static DateTimeOffset StartedDate;
	}
}
