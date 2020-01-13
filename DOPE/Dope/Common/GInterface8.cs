using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;

namespace Dope.Common
{
	[Guid("47C49A79-0412-44F6-81AD-83B365ED9084")]
	public interface GInterface8 : INotifyPropertyChanged
	{
		string Type { get; }

		string Version { get; }

		Task<List<string>> GetAvailableBots();

		Task<AccountSettings> CreateNewBot(string username, string password, string server, string userAgent);

		Task Init(List<AccountSettings> accounts, List<BotProfile> profiles);

		Task<List<BotProfile>> GetBotProfiles();

		Task<bool> UpdateBotProfile(BotProfile profile);

		Task<bool> UpdateAccount(AccountSettings account);

		Task<AccountSettings> GetAccount(string botId);

		Task<bool> DeleteBotProfile(string profileName);

		Task<bool> DeleteAccount(string botId);

		Task<List<BasicBotStateInfo>> GetBasicBotStateInfos(CancellationToken? token = null);

		Task<BotStats> GetBotStats(string id);

		Task<bool> StartBot(string id);

		Task<bool> PauseBot(string id);

		Task<bool> StopBot(string id, bool disable);

		Task<bool> ForceStopBot(string id);

		Task<bool> SetBotProfile(string id, string name);

		Task Invalidate();

		Task<BotSummaryViewModel> GetBotSummary(string id);

		Task<BotDetailedViewModel> GetBotDetailedView(string id, CancellationToken? token = null);

		Task<BotDetailedViewModel> GetBotDetailedView(string id, int lastMapId, bool includeCachable, CancellationToken? token = null);

		Task OnSpacemapClicked(string botId, float x, float y, string mode);
	}
}
