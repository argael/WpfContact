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

namespace WpfContact
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void OnClickBtnContactAdd(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtContactName.Text))
			{
				MessageBox.Show("Please enter a name for the contact");
				return;
			}
				

			if (string.IsNullOrEmpty(txtContactPhone.Text))
			{
				MessageBox.Show("Please enter a phone number for the contact");
				return;
			}
				

			string contact = $"{txtContactName.Text.Trim()} ({txtContactPhone.Text.Trim()})";

			if (lstNames.Items.Contains(contact))
			{
				MessageBox.Show("This contact already exist");
				return;
			}

			lstNames.Items.Add(contact);

			txtContactName.Clear();
			txtContactPhone.Clear();
		}
	}
}
