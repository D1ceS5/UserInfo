using System;
using System.Collections.Generic;
using System.IO;
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

namespace UserInfo
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

        private void Init(object sender, RoutedEventArgs e)
        {
           string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Remove(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).LastIndexOf("\\"), Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).Length - Environment.GetFolderPath(Environment.SpecialFolder.UserProfile).LastIndexOf("\\"));
            MessageBox.Show(path);
            foreach (var item in Directory.GetDirectories(path))
            {
                UserList.Items.Add(item.Remove(0,item.LastIndexOf('\\')+1));
            }
        }

        private void slcchng(object sender, SelectionChangedEventArgs e)
        {
            if(UserList.SelectedIndex!=-1)
            {

            }
        }
    }
}
