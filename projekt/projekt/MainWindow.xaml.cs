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
using System.Text.RegularExpressions;

namespace projekt
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static public int[,] data;
        public string msg;
        public int pom;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int pom = Int32.Parse(side.Text);

            if (pom <= 10 && pom > 0)
            {
                msg = "";

                data = new int[pom, pom];

                for (int i = 0; i < pom; i++)
                {
                    for (int j = 0; j < pom; j++)
                    {
                        data[i, j] = j + i;
                        msg += (j + i).ToString() + " ";
                    }
                    msg += "\n";
                }
                setVisible();
            }
            else
            {
                MessageBox.Show("Proszę podać cyfrę pomiędzy 0 i 10");
            }
        }

        private void Count_row(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int countColumn = Int32.Parse(rowCount.Text);
            for (int i = 0; i < Int32.Parse(side.Text); i++)
            {
                a += MainWindow.data[countColumn, i];
            }
            MessageBox.Show("Suma pól w podanym wierszu wynosi: " + a.ToString());
        }

        private void Count_column(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int countColumn = Int32.Parse(columnCount.Text);
            for (int i = 0; i < Int32.Parse(side.Text); i++)
            {
                a += MainWindow.data[i, countColumn];
            }
            MessageBox.Show("Suma pól w kolumnie wynosi: " + a.ToString());
        }

        private void count_diagonal(object sender, RoutedEventArgs e)
        {
            int a = 0;
            for (int i = 0; i < Int32.Parse(side.Text); i++)
            {
                a += MainWindow.data[i, i];
            }
            MessageBox.Show("Suma przekątnej: " + a.ToString());
        }

        private void chooseFile(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (*.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                pathSF.Text = filename;
            }
        }

        private void saveToFile(object sender, RoutedEventArgs e)
        {
            string pathSaveTo = pathSF.Text;
            File.WriteAllText(pathSaveTo, msg);
        }

        private void chooseFile2(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".txt";
            dlg.Filter = "Text files (*.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string filename = dlg.FileName;
                pathSF2.Text = filename;
            }
        }

        private void setMatrice(object sender, RoutedEventArgs e)
        {
            var path = pathSF2.Text;
            string content = Regex.Replace(File.ReadAllText(path, Encoding.UTF8), @"\s", "");
            int pom = Int32.Parse(side.Text);
            int pom2 = 0;

            if (pom <= 10 && pom > 0)
            {
                msg = "";

                data = new int[pom, pom];

                for (int i = 0; i < pom; i++)
                {
                    for (int j = 0; j < pom; j++)
                    {
                        data[i, j] = Int32.Parse(content.ElementAt(pom2).ToString());
                        msg += content.ElementAt(pom2).ToString() + " ";
                        pom2++;
                    }
                    msg += "\n";
                }

                setVisible();

            }
            else
            {
                System.Environment.Exit(1);
            }

            for (int i = 0; i < pom; i++)
            {
                for (int j = 0; j < pom; j++)
                {
                    MessageBox.Show(data[i, j].ToString());
                }
            }
        }

        public void setVisible()
        {
            a1.Visibility = Visibility.Visible;
            a2.Visibility = Visibility.Visible;
            a3.Visibility = Visibility.Visible;
            a4.Visibility = Visibility.Visible;
            a5.Visibility = Visibility.Visible;
            a6.Visibility = Visibility.Visible;
            a7.Visibility = Visibility.Visible;
            a8.Visibility = Visibility.Visible;
            rowCount.Visibility = Visibility.Visible;
            columnCount.Visibility = Visibility.Visible;
            pathSF.Visibility = Visibility.Visible;
        }

        private void createMatriceFromValues(object sender, RoutedEventArgs e)
        {
            var path = matriceValues.Text;
            string content = Regex.Replace(path, @"\s", "");
            int pom = Int32.Parse(side.Text);
            int pom2 = 0;

            if (pom <= 10 && pom > 0)
            {
                msg = "";

                data = new int[pom, pom];

                for (int i = 0; i < pom; i++)
                {
                    for (int j = 0; j < pom; j++)
                    {
                       data[i, j] = Int32.Parse(content.ElementAt(pom2).ToString());
                       msg += content.ElementAt(pom2).ToString() + " ";
                       pom2++;
                    }
                    msg += "\n";
                }

                setVisible();

            }
            else
            {
                System.Environment.Exit(1);
            }

            for (int i = 0; i < pom; i++)
            {
                for (int j = 0; j < pom; j++)
                {
                    MessageBox.Show(data[i, j].ToString());
                }
            }
        }
    }
}
