using System;
using System.Windows;

namespace WzorzecWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {     
        private readonly Client _radek;

        public MainWindow()
        {
            InitializeComponent();
            _radek = new Client();


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
                    _radek.OrderCpu(eOriginCountry);
                    break;
                case "GPU":
                    _radek.OrderGpu(eOriginCountry);
                    break;
                case "MotherBoard":
                    _radek.OrderMotherBoard(eOriginCountry);
                    break;
                case "Sticker":
                    _radek.OrderSticker(eOriginCountry);                   
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(eOriginCountry), eOriginCountry, null);
            }

            var computer = _radek.CreateComputer();           
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
