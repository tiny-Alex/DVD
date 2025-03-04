﻿using System;
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
using System.Drawing;
using QRCoder;

namespace DVD.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageQr.xaml
    /// </summary>
    public partial class PageQr : Page
    {
        public PageQr()
        {
            InitializeComponent();
        }

        private void CreateQrBtn_Click(object sender, RoutedEventArgs e)
        {
            string soucer_x1 = "https://static10.tgstat.ru/channels/_0/22/223074ca5ddcf3796c3a812ad14e5bda.jpg";
            QRCoder.QRCodeGenerator qr = new QRCoder.QRCodeGenerator();
            QRCoder.QRCodeData data = qr.CreateQrCode(soucer_x1, QRCoder.QRCodeGenerator.ECCLevel.L);
            QRCoder.QRCode code = new QRCoder.QRCode(data);
            Bitmap bitmap = code.GetGraphic(100);
            using (MemoryStream memory = new MemoryStream()) 
            {
                bitmap.Save(memory,System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                ImageQr.Source=bitmapImage;
              
            }

        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AutorizationPage());
        }
    }
}
