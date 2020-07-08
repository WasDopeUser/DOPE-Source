using System;
using System.IO;

namespace DarkorbitAPI.CommonStructures
{
	public class ByteArray
	{
		public ByteArray()
		{
			Class13.xnk8ImWzpOt04();
			this.Memory = new MemoryStream();
			base..ctor();
		}

		public ByteArray(MemoryStream memoryStream_0)
		{
			Class13.xnk8ImWzpOt04();
			this.Memory = new MemoryStream();
			base..ctor();
			this.Memory = memoryStream_0;
		}

		public ByteArray(ByteArray byteArray_0)
		{
			Class13.xnk8ImWzpOt04();
			this.Memory = new MemoryStream();
			base..ctor();
			byteArray_0.Memory.Position = 0L;
			byteArray_0.Memory.CopyTo(this.Memory);
			byteArray_0.Memory.Position = 0L;
		}

		public ByteArray(byte[] byte_0)
		{
			Class13.xnk8ImWzpOt04();
			this.Memory = new MemoryStream();
			base..ctor();
			this.Memory.Write(byte_0, 0, byte_0.Length);
		}

		public void Clear()
		{
			this.Memory.Position = 0L;
			this.Memory.SetLength(0L);
		}

		public int Length
		{
			get
			{
				return (int)this.Memory.Length;
			}
			set
			{
				this.Memory.SetLength((long)value);
			}
		}

		public byte this[int int_0]
		{
			get
			{
				this.Memory.Seek((long)int_0, SeekOrigin.Begin);
				return (byte)this.Memory.ReadByte();
			}
			set
			{
				this.Memory.Seek((long)int_0, SeekOrigin.Begin);
				this.Memory.WriteByte(value);
			}
		}

		public byte this[uint uint_0]
		{
			get
			{
				return this[(int)uint_0];
			}
			set
			{
				this[(int)uint_0] = value;
			}
		}

		public MemoryStream Memory;
	}
}
