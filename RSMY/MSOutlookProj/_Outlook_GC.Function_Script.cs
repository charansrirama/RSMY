using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Dynamic.Script_8D559B35648E8E8
{
	// Script generated by Pega Robotics Studio 8.0.1072.0
	// Please use caution when modifying class name, namespace or attributes
	[OpenSpan.TypeManagement.DynamicTypeAttribute()]
	[OpenSpan.Design.ComponentIdentityAttribute("Script-8D559B35648E8E8")]
	public sealed class Script
	{
		public string getThisDay()
		{
			// Add your code here...
			DateTime thisDay = DateTime.Today;
			return thisDay.ToString("d");
		}
	}
}