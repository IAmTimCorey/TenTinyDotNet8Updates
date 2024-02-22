using Microsoft.Win32;
using System.Windows;

namespace WpfDemo
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

        private void OpenFolder_Click(object sender, RoutedEventArgs e)
        {
            OpenFolderDialog dialog = new()
            {
                Title = "Select a folder",
                InitialDirectory = @"C:\Demos",
                AddToRecent = false,
                RootDirectory = @"C:\Demos"
            };

            if (dialog.ShowDialog() == true)
            {
                MessageBox.Show($"You selected {dialog.FolderName}");
            }
        }
    }
}