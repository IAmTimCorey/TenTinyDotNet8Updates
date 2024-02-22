using Microsoft.Win32;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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

            Icon icon = SystemIcons.GetStockIcon(StockIconId.DriveRemovable);
            ImageSource iconBitmapSource;

            using (MemoryStream iconStream = new MemoryStream())
            {
                // Save the icon to a memory stream
                icon.Save(iconStream);
                iconStream.Position = 0;

                // Create a BitmapDecoder to read the icon stream
                BitmapDecoder decoder = BitmapDecoder.Create(iconStream, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnLoad);

                // Return the first frame of the icon as a BitmapSource
                iconBitmapSource = decoder.Frames[0];
            }

            buttonIcon.Source = iconBitmapSource;
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