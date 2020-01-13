using System;
using System.Runtime.Serialization;
using Ace.Networking;
using DarkorbitAPI.CommonStructures;
using DOPE.Common.Models;
using ProtoBuf.Meta;

namespace DOPE.Common.Packets
{
	public class DopeProtocol : ProtocolConfiguration
	{
		static DopeProtocol()
		{
			RuntimeTypeModel.Default[typeof(TimeTableDayEntry)][1].SupportNull = true;
			RuntimeTypeModel.Default[typeof(VolatileData)][2].SupportNull = true;
			RuntimeTypeModel.Default[typeof(DateTimeOffset)].SetSurrogate(typeof(DateTimeOffsetSurrogate));
		}

		public DopeProtocol()
		{
			base.ReadAsync = true;
		}

		protected override void Initialize()
		{
			base.Initialize();
			base.Serializer.TypeResolver.RegisterAssembly(typeof(DopeProtocol).Assembly, new Type[]
			{
				typeof(DataContractAttribute)
			});
			base.Serializer.TypeResolver.RegisterAssembly(typeof(DollConfig).Assembly, new Type[]
			{
				typeof(DataContractAttribute)
			});
			base.CustomOutcomingMessageQueue = null;
		}

		public new static DopeProtocol Instance = new DopeProtocol();
	}
}
