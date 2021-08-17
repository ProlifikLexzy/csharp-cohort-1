using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // var url = @"https://m.media-amazon.com/images/M/MV5BMjhmNDA1M2UtODJlNS00MGNlLTgxZmYtMzE3NzlkMjEzYTYzXkEyXkFqcGdeQXVyMTkyNzM3NDc@._V1_SX300.jpg";

            if (string.IsNullOrWhiteSpace(this.myTextBox.Text))
                return;


            pBar.IsIndeterminate = true;

            var task = GetPhotoAsync();

            var result = task.Result;

            this.photoViewer.Source = LoadImage(result);
            pBar.IsIndeterminate = false;
        }

        public async Task<byte[]> GetPhotoAsync()
        {
            var client = new HttpClient();
           await client.SendAsync(null);

            var request = WebRequest.Create(this.myTextBox.Text);

            var buffer = await Task.Run<byte[]>(() =>
              {
                  var response = request.GetResponse();
                  Thread.Sleep(3000);
                  var stream = response.GetResponseStream();
                  var streamReader = new BinaryReader(stream);
                  Byte[] buffer = streamReader.ReadBytes(1 * 1024 * 1024 * 10);
                  return buffer;
              });

            return buffer;
        }

        private static BitmapImage LoadImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0) return null;
            var image = new BitmapImage();
            using (var mem = new MemoryStream(imageData))
            {
                mem.Position = 0;
                image.BeginInit();
                image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.UriSource = null;
                image.StreamSource = mem;
                image.EndInit();
            }
            image.Freeze();
            return image;
        }
    }
}
