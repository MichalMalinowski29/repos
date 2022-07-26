using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace projekt
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        static public int[,] data;
        public string message;
        public int pom;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateMatrix(object sender, RoutedEventArgs e)
        {
            int MatrixSide = Int32.Parse(side.Text);

            if (MatrixSide <= 10 && MatrixSide > 0)
            {
                message = "";
                data = new int[MatrixSide, MatrixSide];

                for (int i = 0; i < MatrixSide; i++)
                {
                    for (int j = 0; j < MatrixSide; j++)
                    {
                        data[i, j] = j + i;
                        message += (j + i).ToString() + " ";
                    }
                    message += "\n";
                }
                SetVisible();
            }
            else
            {
                MessageBox.Show("Proszę podać cyfrę pomiędzy 0 i 10");
            }
        }

        private void CountRow(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int countColumn = Int32.Parse(rowCount.Text);
            for (int i = 0; i < Int32.Parse(side.Text); i++)
            {
                a += MainWindow.data[countColumn, i];
            }
            MessageBox.Show("Suma pól w podanym wierszu wynosi: " + a.ToString());
        }

        private void CountColumn(object sender, RoutedEventArgs e)
        {
            int a = 0;
            int countColumn = Int32.Parse(columnCount.Text);
            for (int i = 0; i < Int32.Parse(side.Text); i++)
            {
                a += MainWindow.data[i, countColumn];
            }
            MessageBox.Show("Suma pól w kolumnie wynosi: " + a.ToString());
        }

        private void CountDiagonal(object sender, RoutedEventArgs e)
        {
            int a = 0;
            for (int i = 0; i < Int32.Parse(side.Text); i++)
            {
                a += MainWindow.data[i, i];
            }
            MessageBox.Show("Suma przekątnej: " + a.ToString());
        }

        private void ChooseFileToSave (object sender, RoutedEventArgs e)
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

        private void SaveToFile(object sender, RoutedEventArgs e)
        {
            string pathSaveTo = pathSF.Text;
            File.WriteAllText(pathSaveTo, message);
        }

        private void ChooseFileToRead (object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog FormDialog = new Microsoft.Win32.OpenFileDialog();
            FormDialog.DefaultExt = ".txt";
            FormDialog.Filter = "Text files (*.txt)|*.txt";
            Nullable<bool> result = FormDialog.ShowDialog();
            if (result == true)
            {
                string filename = FormDialog.FileName;
                pathSF2.Text = filename;
            }
        }

        private void SetMatrix(object sender, RoutedEventArgs e)
        {
            var path = pathSF2.Text;
            string FileWithoutNewlines = File.ReadAllText(path, Encoding.UTF8).Replace(Environment.NewLine, " ");
            string[] content = FileWithoutNewlines.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int MatrixSide = Int32.Parse(side.Text);
            int IterationCount = 0;

            if (MatrixSide <= 10 && MatrixSide > 0)
            {
                message = "";
                data = new int[MatrixSide, MatrixSide];

                for (int i = 0; i < MatrixSide; i++)
                {
                    for (int j = 0; j < MatrixSide; j++)
                    {
                        data[i, j] = Int32.Parse(content[IterationCount]);
                        message += content[IterationCount] + " ";
                        IterationCount++;
                    }
                    message += "\n";
                }
                SetVisible();
            }
            else
            {
                Environment.Exit(1);
            }
        }

        public void SetVisible()
        {
            RowCountLabel.Visibility = Visibility.Visible;
            ColumnCountLabel.Visibility = Visibility.Visible;
            CountDiagonalButton.Visibility = Visibility.Visible;
            CountRowButton.Visibility = Visibility.Visible;
            CountColumnButton.Visibility = Visibility.Visible;
            SaveToFileLabel.Visibility = Visibility.Visible;
            SaveToFileButton.Visibility = Visibility.Visible;
            SaveToFileSubmitButton.Visibility = Visibility.Visible;
            rowCount.Visibility = Visibility.Visible;
            columnCount.Visibility = Visibility.Visible;
            ShowMatrixButton.Visibility = Visibility.Visible;   
        }

        private void CreateMatrixFromValues(object sender, RoutedEventArgs e)
        {
            int MatrixSide = Int32.Parse(side.Text);

            if (MatrixSide <= 10 && MatrixSide > 0)
            {
                message = "";
                data = new int[MatrixSide, MatrixSide];

                for (int i = 0; i < MatrixSide; i++)
                {
                    for (int j = 0; j < MatrixSide; j++)
                    {
                        string InputMessage = $"Podaj kolejną wartość którą chcesz dodać do macierzy. Podana wartość znajdzie się na indeksie: {i}, {j}";
                        string input = Microsoft.VisualBasic.Interaction.InputBox(InputMessage, "Title", "");

                        data[i, j] = Int32.Parse(input);
                        message += input + " ";
                    }
                    message += "\n";
                }
                SetVisible();
            }
            else
            {
                Environment.Exit(1);
            }
        }

        private void ShowMatrix(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(message);
        }
        
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
            {
                Regex regex = new Regex("[^0-9]+");
                e.Handled = regex.IsMatch(e.Text);
            }
        }
}
