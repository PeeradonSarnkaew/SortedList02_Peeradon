using System;
using System.Collections;
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

namespace sortedList_Peeradon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void ADD(object sender, RoutedEventArgs e)
        {
            sortedList.Add(int.Parse(keyBox.Text), valueBox.Text);
            ICollection iCollection = sortedList.Keys;
            string z = "";
            foreach(int i in iCollection)
            {
                z+=(sortedList[i].ToString())+"\n";
            }
            MessageBox.Show(z);
        }
        
    }
}
