using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.Dashboard.Management.v2.Classes
{
	public class JobType
	{
		public string SectionTitle { get; set; }
		public string Name { get; set; }
		public Type Type { get; set; }

		public JobType()
		{
		}

		public JobType(string sectionTitle, string name, Type jobType)
		{
			SectionTitle = sectionTitle;
			Name = name;
			Type = jobType;
		}
	}
}
