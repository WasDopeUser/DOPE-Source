﻿using System;
using System.Windows;
using System.Windows.Forms;
using DOPE.Common.Models.Bot.Stats;

namespace DOPE.UI.Models
{
	public class StatisticsCategoryWpf
	{
		public static void unuJhDmhdq(Window window_0, StatisticsCategory statisticsCategory_0)
		{
			string.Format("Stats_{0}", statisticsCategory_0);
		}

		public static void smethod_0(ListView listView_0, StatisticsCategory statisticsCategory_0)
		{
			listView_0.Columns.Clear();
			foreach (string text in statisticsCategory_0.ColumnNames)
			{
				listView_0.Columns.Add(text);
			}
		}

		public StatisticsCategoryWpf()
		{
			Class13.nIxas2ezryi9b();
			base..ctor();
		}
	}
}
