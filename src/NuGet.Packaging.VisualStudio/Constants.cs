﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuGet.Packaging.VisualStudio
{
	class Constants
	{
		/// <summary>
		/// The file extension of this project type.  No preceding period.
		/// </summary>
		public const string ProjectExtension = "nuproj";
		public const string ProjectFileExtension = "." + ProjectExtension;

		public const string Language = "NuGet.Packaging";

		public class Platforms
		{
			public const string IOS = "Xamarin.iOS";
			public const string Android = "Xamarin.Android";
		}

		public class Templates
		{
			public const string IOS = "Xamarin.iOS.Library";
			public const string Android = "Xamarin.Android.ClassLibrary";
			public const string NuGetPackage = "NuGet.Packaging.VisualStudio.Package";
			public const string SharedProject = "Microsoft.CS.SharedProject";
		}
	}
}
