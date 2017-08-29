using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace myCalc
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Exit();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            decimal CurrentAmount = 0;
            decimal[] ExchangeRates = { 1, 17.62M, 0.77M };
            //OutputTextBlock.Text = Convert.ToString(CurrentAmountTextBox.Text);
            try
            {
                CurrentAmount = Convert.ToDecimal(CurrentAmountTextBox.Text);
                decimal calculation = 0;
                var selectedindex = CurrentCountry.SelectedIndex;
                var targetindex = TargetCountry.SelectedIndex;
                if (selectedindex == 0)
                {
                    calculation = CurrentAmount * ExchangeRates[targetindex];
                    OutputTextBlock.Text = Convert.ToString(calculation);
                }
                else if (targetindex == 0)
                {
                    calculation = CurrentAmount / ExchangeRates[selectedindex];
                    OutputTextBlock.Text = Convert.ToString(calculation);
                }
                else
                {
                    calculation = CurrentAmount / ExchangeRates[selectedindex];
                    calculation = calculation * ExchangeRates[targetindex];
                    OutputTextBlock.Text = Convert.ToString(calculation);
                }
            }
            catch (Exception a)
            {
                OutputTextBlock.Text = Convert.ToString(a);
            }
        }

        private void CurrentCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var selectedindex = CurrentCountry.SelectedIndex;
        }

        private void TargetCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var targetindex = TargetCountry.SelectedIndex;
        }
    }
}
