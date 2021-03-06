﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PropertyPageBase;

namespace NuGet.Packaging.VisualStudio
{
	public partial class NuSpecPropertyPageView : PropertyPageBase.PageView
	{
		PropertyPageBase.PropertyControlTable propertyControlTable;

		/// <summary>
		/// This is the runtime constructor
		/// </summary>
		/// <param name="site">Site for the page</param>
		public NuSpecPropertyPageView(PropertyPageBase.IPageViewSite site)
			: base(site)
		{
			InitializeComponent();
		}

		/// <summary>
		/// This constructor is only to enable winform designers
		/// </summary>
		public NuSpecPropertyPageView()
		{
			InitializeComponent();
		}

		protected override PropertyControlTable PropertyControlTable
		{
			get
			{
				if (propertyControlTable == null)
				{
					propertyControlTable = new PropertyPageBase.PropertyControlTable();

					//Check the Name property to ensure that we've Initialized this component.
					if (string.IsNullOrEmpty(this.Name))
					{
						InitializeComponent();
					}

					propertyControlTable.Add("Authors", textBoxAuthors);
					propertyControlTable.Add("Copyright", textBoxCopyright);
					propertyControlTable.Add("Description", textBoxDescription);
					propertyControlTable.Add("Id", textBoxId);
					propertyControlTable.Add("LicenseUrl", textBoxLicenseUrl);
					propertyControlTable.Add("Owners", textBoxOwners);
					propertyControlTable.Add("ProjectUrl", textBoxProjectUrl);
					propertyControlTable.Add("Summary", textBoxSummary);
					propertyControlTable.Add("Tags", textBoxTags);
					propertyControlTable.Add("Title", textBoxTitle);
					propertyControlTable.Add("Version", textBoxVersion);
				}

				return propertyControlTable;
			}
		}
	}
}
