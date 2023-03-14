using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Preferences
{
	internal class UISettings:ConfigurationSection
	{
		[ConfigurationProperty("language",DefaultValue ="English")]
		public string Language
		{
			get { return (string)this["language"]; }
			set { this["language"] = value; }
		}



		[ConfigurationProperty("theme", DefaultValue = "Light")]
		public string Theme
		{
			get { return (string)this["theme"]; }
			set { this["theme"] = value; }
		}

		[ConfigurationProperty("currency", DefaultValue = "$")]
		public string Currency
		{
			get { return (string)this["currency"]; }
			set { this["currency"] = value; }
		}

		[ConfigurationProperty("fontsize", DefaultValue = 8)]
		[IntegerValidator(MaxValue =100 , MinValue =5)]
		public int FontSize
		{
			get { return (int)this["fontsize"]; }
			set { this["fontsize"] = value; }
		}


	}
}
