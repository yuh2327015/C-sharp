using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Diagnostics;
using System.Diagnostics;

namespace _4
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
        private void btnJoin_Click(object sender, RoutedEventArgs e)
        {
            string str = "";
            foreach (CheckBox child in spAgree.Children)
            {
                if (child.IsChecked == true)
                    str += child.Content.ToString() + "\n";
            }
            foreach (RadioButton child in spAge.Children)
            {
                if (child.IsChecked != null)
                    if (child.IsChecked.Value == true)
                        str += "나이: " + child.Content.ToString() + "\n";
            }
            foreach (RadioButton child in spJob.Children)
            {
                if (child.IsChecked !=null)
                    if(child.IsChecked.Value == true)
                    {
                        if (child.GroupName == "grpSex")
                            str += "성별: " + child.Content.ToString() + "\n";
                        else
                            str += "직업: " + child.Content.ToString() + "\n";
                    }
            }
            MessageBox.Show(str, "입력정보 확인");
        }
    }
}