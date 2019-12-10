using System;
using System.Collections;
using System.Collections.Generic;
using DOPE.UI.Models;
using Newtonsoft.Json;

namespace DOPE.UI.Controls
{
	public class TreeNode
	{
		public virtual string Name { get; set; }

		public string Value { get; set; }

		public List<TreeNode> Children { get; set; }

		public static TreeHeaderNode smethod_0(GInterface0 ginterface0_0, CommandViewModel commandViewModel_0, DateTime dateTime_0, bool bool_0)
		{
			string value = "{\"loading\": \"failed\"}";
			try
			{
				value = JsonConvert.SerializeObject(ginterface0_0);
			}
			catch
			{
			}
			object object_ = JsonConvert.DeserializeObject<Dictionary<string, object>>(value);
			TreeHeaderNode treeHeaderNode = new TreeHeaderNode(commandViewModel_0, dateTime_0, bool_0);
			TreeNode.smethod_1(object_, treeHeaderNode);
			return treeHeaderNode;
		}

		private static void smethod_1(object object_0, TreeNode treeNode_0)
		{
			if (object_0 is KeyValuePair<string, object>)
			{
				KeyValuePair<string, object> keyValuePair = (KeyValuePair<string, object>)object_0;
				TreeNode treeNode = new TreeNode
				{
					Name = keyValuePair.Key,
					Value = TreeNode.smethod_2(keyValuePair.Value)
				};
				treeNode_0.Children.Add(treeNode);
				TreeNode.smethod_1(keyValuePair.Value, treeNode);
				return;
			}
			ArrayList arrayList = object_0 as ArrayList;
			if (arrayList != null)
			{
				int num = 0;
				using (IEnumerator enumerator = arrayList.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object object_ = enumerator.Current;
						TreeNode treeNode2 = new TreeNode
						{
							Name = string.Format("[{0}]", num),
							Value = ""
						};
						treeNode_0.Children.Add(treeNode2);
						TreeNode.smethod_1(object_, treeNode2);
						num++;
					}
					return;
				}
			}
			Dictionary<string, object> dictionary = object_0 as Dictionary<string, object>;
			if (dictionary != null)
			{
				foreach (KeyValuePair<string, object> keyValuePair2 in dictionary)
				{
					TreeNode.smethod_1(keyValuePair2, treeNode_0);
				}
			}
		}

		private static string smethod_2(object object_0)
		{
			if (object_0 == null)
			{
				return "null";
			}
			Type type = object_0.GetType();
			if (type.IsArray)
			{
				return "[]";
			}
			if (object_0 is ArrayList)
			{
				ArrayList arrayList = object_0 as ArrayList;
				return string.Format("[{0}]", arrayList.Count);
			}
			if (type.IsGenericType)
			{
				return "{}";
			}
			return object_0.ToString();
		}

		public TreeNode()
		{
			Class8.xDph7tozmh5WD();
			this.Children = new List<TreeNode>();
			base..ctor();
		}
	}
}
