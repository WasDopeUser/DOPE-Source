using System;
using System.ComponentModel;

namespace DOPE.UI.Controls
{
	public class SimpleTreeHeader : SimpleTreeNode, INotifyPropertyChanged
	{
		public SimpleTreeHeader()
		{
			Class13.tMHx78BzgCM8j();
			base..ctor();
		}

		private static SimpleTreeNode smethod_0(string string_0, object object_0)
		{
			SimpleTreeNode simpleTreeNode = new SimpleTreeNode();
			simpleTreeNode.Name = string_0;
			string value;
			if (object_0 != null)
			{
				if ((value = object_0.ToString()) != null)
				{
					goto IL_22;
				}
			}
			value = "null";
			IL_22:
			simpleTreeNode.Value = value;
			return simpleTreeNode;
		}
	}
}
