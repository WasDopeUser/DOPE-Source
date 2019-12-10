using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;

namespace DOPE.Common
{
	[Guid("CC51F178-9BB4-4E5D-B198-AAF0E24CE2F3")]
	public interface IBotController : INotifyPropertyChanged
	{
		string BotId { get; }

		Task<BotProfile> GetCurrentBotProfile();

		Task<MapProfile> GetCurrentMapProfile();

		Task<bool> SetCurrentBotProfile(string profileName);

		Task<BotStats> GetStats();

		Task<bool> Start();

		Task<bool> Pause();

		Task<bool> Stop();

		Task<bool> ForceStop();

		Task<BasicBotStateInfo> GetBasicBotStateInfo();
	}
}
