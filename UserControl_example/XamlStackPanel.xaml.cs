using System.Windows;
using System.Windows.Controls;

namespace CMPARK.XamlExam
{
    public partial class XamlStackPanel: StackPanel
    {
        public XamlStackPanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("StackPanel Button was clicked!");
        }
    }
}
