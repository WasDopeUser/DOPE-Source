using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DarkorbitAPI.Licensing;
using DOPE.Common.Models;

namespace DOPE.Common
{
	[Guid("26C0D2BF-ECE6-43CD-B72A-4770767A902C")]
	public interface IDopeService : ICoreDopeService
	{
		Task ReportAggressor(int userId);

		Task<bool> IsAggressor(int userId);

		Task<DopeServiceStatus> GetServiceStatus();

		Task UpdateVolatile(string botId, VolatileData data);
	}
}
