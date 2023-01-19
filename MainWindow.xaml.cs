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
using WpfContact.Models;

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
			if (!ValidateForm())
				return;

			Contact contact = new(txtContactName.Text, txtContactPhone.Text);
			if (!contact.isValid())
			{
				MessageBox.Show("This contact is invalid");
				return;
			}

			if (lstNames.Items.Contains(contact.ToString()))
			{
				MessageBox.Show("This contact already exist");
				return;
			}

			lstNames.Items.Add(contact.ToString());

			txtContactName.Clear();
			txtContactPhone.Clear();
		}

		/// <summary>
		/// Test if the posted field are valid.
		/// </summary>
		private bool ValidateForm()
		{
			if (string.IsNullOrEmpty(txtContactName.Text))
			{
				MessageBox.Show("Please enter a name for the contact");
				return false;
			}

			if (string.IsNullOrEmpty(txtContactPhone.Text))
			{
				MessageBox.Show("Please enter a phone number for the contact");
				return false;
			}

			return true;
		}
	}
}
