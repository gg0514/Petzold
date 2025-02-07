using System.Windows;
using System.Windows.Controls;

namespace CMPARK.XamlExam
{
    public partial class XamlButton : Button
    {
        public XamlButton()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello, World!");
        }
    }
}
