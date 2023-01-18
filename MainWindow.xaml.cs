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

		private void onClickBtnContactAdd(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(txtContactName.Text))
				return;

			if (lstNames.Items.Contains(txtContactName.Text))
				return;

			lstNames.Items.Add(txtName.Text);
			txtName.Clear();
		}
	}
}
