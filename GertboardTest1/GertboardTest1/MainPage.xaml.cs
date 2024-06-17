using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Gpio;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GertboardTest1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Tick += Timer_Tick;
            InitGpio();
            if (led1 != null)
            {
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, object e)
        {
            led1.Write(GpioPinValue.High);
            Task.Delay(i).Wait();

            led2.Write(GpioPinValue.High);
            led1.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led3.Write(GpioPinValue.High);
            led2.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led4.Write(GpioPinValue.High);
            led3.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led5.Write(GpioPinValue.High);
            led4.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led6.Write(GpioPinValue.High);
            led5.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led7.Write(GpioPinValue.High);
            led6.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led8.Write(GpioPinValue.High);
            led7.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led9.Write(GpioPinValue.High);
            led8.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led10.Write(GpioPinValue.High);
            led9.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led11.Write(GpioPinValue.High);
            led10.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led12.Write(GpioPinValue.High);
            led11.Write(GpioPinValue.Low);
            Task.Delay(i).Wait();

            led12.Write(GpioPinValue.Low);
            if (i > 100)
            {
                i = i - 5;
            }
        }

        private void InitGpio()
        {
            var gpio = GpioController.GetDefault();

            led1 = gpio.OpenPin(LED1);
            led2 = gpio.OpenPin(LED2);
            led3 = gpio.OpenPin(LED3);
            led4 = gpio.OpenPin(LED4);
            led5 = gpio.OpenPin(LED5);
            led6 = gpio.OpenPin(LED6);
            led7 = gpio.OpenPin(LED7);
            led8 = gpio.OpenPin(LED8);
            led9 = gpio.OpenPin(LED9);
            led10 = gpio.OpenPin(LED10);
            led11 = gpio.OpenPin(LED11);
            led12 = gpio.OpenPin(LED12);

            led1.Write(GpioPinValue.Low);
            led1.SetDriveMode(GpioPinDriveMode.Output);

            led2.Write(GpioPinValue.Low);
            led2.SetDriveMode(GpioPinDriveMode.Output);

            led3.Write(GpioPinValue.Low);
            led3.SetDriveMode(GpioPinDriveMode.Output);

            led4.Write(GpioPinValue.Low);
            led4.SetDriveMode(GpioPinDriveMode.Output);

            led5.Write(GpioPinValue.Low);
            led5.SetDriveMode(GpioPinDriveMode.Output);

            led6.Write(GpioPinValue.Low);
            led6.SetDriveMode(GpioPinDriveMode.Output);

            led7.Write(GpioPinValue.Low);
            led7.SetDriveMode(GpioPinDriveMode.Output);

            led8.Write(GpioPinValue.Low);
            led8.SetDriveMode(GpioPinDriveMode.Output);

            led9.Write(GpioPinValue.Low);
            led9.SetDriveMode(GpioPinDriveMode.Output);

            led10.Write(GpioPinValue.Low);
            led10.SetDriveMode(GpioPinDriveMode.Output);

            led11.Write(GpioPinValue.Low);
            led11.SetDriveMode(GpioPinDriveMode.Output);

            led12.Write(GpioPinValue.Low);
            led12.SetDriveMode(GpioPinDriveMode.Output);


        }
        private int LED1 = 7;
        private int LED2 = 8;
        private int LED3 = 9;
        private int LED4 = 10;
        private int LED5 = 11;
        private int LED6 = 17;
        private int LED7 = 18;
        private int LED8 = 27;
        private int LED9 = 22;
        private int LED10 = 23;
        private int LED11 = 24;
        private int LED12 = 25;
        private int i = 500;
        private GpioPin led1;
        private GpioPin led2;
        private GpioPin led3;
        private GpioPin led4;
        private GpioPin led5;
        private GpioPin led6;
        private GpioPin led7;
        private GpioPin led8;
        private GpioPin led9;
        private GpioPin led10;
        private GpioPin led11;
        private GpioPin led12;
        private GpioPinValue led1Value = GpioPinValue.Low;
        private GpioPinValue led2Value = GpioPinValue.Low;
        private GpioPinValue led3Value = GpioPinValue.Low;
        private GpioPinValue led4Value = GpioPinValue.Low;
        private GpioPinValue led5Value = GpioPinValue.Low;
        private GpioPinValue led6Value = GpioPinValue.Low;
        private GpioPinValue led7Value = GpioPinValue.Low;
        private GpioPinValue led8Value = GpioPinValue.Low;
        private GpioPinValue led9Value = GpioPinValue.Low;
        private GpioPinValue led10Value = GpioPinValue.Low;
        private GpioPinValue led11Value = GpioPinValue.Low;
        private GpioPinValue led12Value = GpioPinValue.Low;
        private DispatcherTimer timer;
    }
    
}
