/// Chapter No. 3		Exercise No. 1
/// File Name: Program.cs - Project 1
/// /// @author: Rossana Palma
/// Date:  September 21, 2020
///
/// Problem Statement: Write a GUI program that reads amount mortgage and calculate the monthly principal, monthly interest, monthly mortgage and the outstandings balance. Assume
/// that the annual interest is 6.39 percent. Display the results on the screen.
/// 
/// Overall Plan:
/// 1) Define variables.
/// 2) Convert text to double.
/// 3) Calculations.
/// 4) Display the resuls on the screen.
/// 
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

namespace Project1
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
            // Define variables
            double mortgageAmount, outstandingsBalance;
            double annualInterest, monthlyMortgage, monthlyInterest, monthlyPrincipal;

            // Convert text to Double
            mortgageAmount = Convert.ToDouble(mortAmount.Text);
            annualInterest = Convert.ToDouble(annualInt.Text);

            // Calculation
            monthlyInterest = mortgageAmount * ((annualInterest / 100) / 12);
            monthlyPrincipal = mortgageAmount / 12;
            monthlyMortgage = monthlyPrincipal + monthlyInterest;
            outstandingsBalance = mortgageAmount - monthlyMortgage;

            // Display output
            outBalance.Text = outstandingsBalance.ToString("c");
            annualInt.Text = annualInterest.ToString("c");
            monthMort.Text = monthlyMortgage.ToString("c");
            monthInt.Text = monthlyInterest.ToString("c");
            monthPrinc.Text = monthlyPrincipal.ToString("c");
                        
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
