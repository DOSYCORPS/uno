﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Resources;

namespace Uno.UI.Tests.App.Views
{
	public class MyResourceLoader : CustomXamlResourceLoader
	{
		protected override object GetResource(string resourceId, string objectType, string propertyName, string propertyType)
		{
			switch (resourceId)
			{
				case "TapestryHereOnMySkin":
					return "Map of the victories I win";
				default:
					throw new ArgumentException();
			}
		}
	}
}