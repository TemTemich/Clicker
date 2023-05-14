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
using System.IO;

namespace Deez_nuts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path_changeable = "";
        private string HaveText(string path)
        {
            string txt = "";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
                txt = System.Text.Encoding.Default.GetString(array);
            }

            return txt;



            

            

        }
        private void MakeText(string path, string txt)
        {
            
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(txt);
                
                fs.Write(array, 0, array.Length);
                
                
            }
            
        }
        public MainWindow()
        {
            InitializeComponent();
            Rectangle rectangle = new();
            InfoGrid.Visibility = Visibility.Hidden;

            
            


            

            



        }
        private void Back(object sender, RoutedEventArgs e)
        {
            InfoGrid.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            path_changeable = "D:\\ABOBA\\Deez nuts\\TextFile1.txt";
            MainTxt.Content = HaveText(path_changeable);
            InfoGrid.Visibility = Visibility.Visible;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)

        {
            path_changeable = "D:\\ABOBA\\Deez nuts\\yellow_button_check.txt";
            MainTxt.Content = HaveText("D:\\ABOBA\\Deez nuts\\yellow_button_check.txt");
            InfoGrid.Visibility = Visibility.Visible;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            path_changeable = "D:\\ABOBA\\Deez nuts\\orange_button_check.txt";
            MainTxt.Content = HaveText(path_changeable);
            InfoGrid.Visibility = Visibility.Visible;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            path_changeable = "D:\\ABOBA\\Deez nuts\\red_button_check.txt";
            MainTxt.Content = HaveText(path_changeable);
            InfoGrid.Visibility = Visibility.Visible;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string txt = HaveText(path_changeable);
            txt += "\r\n" + InformationAdd.Text;
            MakeText(path_changeable, txt);
            /////////////////////////////////////////////////
            ////////////////////////////////
            
        }

    }
}
