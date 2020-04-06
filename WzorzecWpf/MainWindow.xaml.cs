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


namespace WzorzecWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {     
        private Client radek;

        public MainWindow()
        {
            InitializeComponent();
            radek = new Client();


        }

        private void TurnOff_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
       
        private void Controller(EOriginCountry eOriginCountry,string phrase)
        {
            switch (phrase)
            {
                case "CPU":
                    radek.OrderCPU(eOriginCountry);
                    break;
                case "GPU":
                    radek.OrderGPU(eOriginCountry);
                    break;
                case "MotherBoard":
                    radek.OrderMotherBoard(eOriginCountry);
                    break;
                case "Sticker":
                    radek.OrderSticker(eOriginCountry);                   
                    break;
            }
            var computer = radek.CreateComputer();           
            Summary.Text = computer.ToString();
            Sum.Text = computer.Price();


        }

        private void CPUorigin1_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.Poland, "CPU");
        }

        private void CPUorigin2_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.China, "CPU");
        }

        private void CPUorigin3_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.Germany, "CPU");
        }


        private void GPUorigin1_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.Poland, "GPU");
        }
        private void GPUorigin2_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.China, "GPU");
        }
        private void GPUorigin3_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.Germany, "GPU");
        }


        private void MotherBoardorigin1_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.Poland, "MotherBoard");
        }

        private void MotherBoardorigin2_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.China, "MotherBoard");
        }

        private void MotherBoardorigin3_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.Germany,"MotherBoard");
        }


        private void Stickerorigin1_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.Poland, "Sticker");
        }

        private void Stickerorigin2_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.China, "Sticker");
        }

        private void Stickerorigin3_OnSelected(object sender, RoutedEventArgs e)
        {
            Controller(EOriginCountry.Germany, "Sticker");
        }
    }
}
