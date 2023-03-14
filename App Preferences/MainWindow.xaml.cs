using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using System.Configuration;


namespace App_Preferences
{
	public partial class MainWindow : Window
	{
		Configuration AppConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

		string[] Themes = new string[] { "Dark", "Light" };
		string[] Languages = new string[] { "English", "Chinese" };

		public MainWindow()
		{
			InitializeComponent();

			LanguageCombobox.ItemsSource = Languages;
			ThemesCombobox.ItemsSource = Themes;


			if (AppConfig.Sections["UISettings"] is null)
			{
				AppConfig.Sections.Add("UISettings", new UISettings());
					
			}


			var UISettingSection = AppConfig.GetSection("UISettings");


			this.DataContext = UISettingSection;



		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			AppConfig.Save();
		}
	}
}
