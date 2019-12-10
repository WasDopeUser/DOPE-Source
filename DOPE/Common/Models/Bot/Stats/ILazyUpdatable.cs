using System;

namespace DOPE.Common.Models.Bot.Stats
{
	public interface ILazyUpdatable
	{
		void Update(object source);

		Type GetSourceType();
	}
}
