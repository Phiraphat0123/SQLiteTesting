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

namespace DataAccess_insert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
   
    public partial class MainWindow : Window
    {
         
        public MainWindow()
        {
            InitializeComponent();
            DataAccess.InitializeDatabase();
        }

       

        private void add_Click(object sender, RoutedEventArgs e)
        { string id = txtbUId.Text;
            string name = txtBName.Text;
            Boolean check = false;
            
            
            DataAccess.AddData(id,name);
            txtBName.Text = "";
            txtbUId.Text = "";
        }

        private void show_Click(object sender, RoutedEventArgs e)
        {
            string Data = "";
            foreach (string data in DataAccess.GetData()) {
                Data = Data + "" + data + '\n';
            }
            
            MessageBox.Show(Data);
        }
    }
}
