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

using MahApps.Metro.Controls;

namespace Material_Design_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        class Calculation_Variables
        {
            public static string Current_Calculation = "";

            public static int Element_1 = 0;
            public static int Element_2 = 0;

            public static bool Has_Decimal = false;
            public static bool Has_Subtraction = false;
            public static bool Has_Multiplication = false;
            public static bool Has_Division = false;
            public static bool Has_Addition = false;
        }

        public MainWindow()
        {
            InitializeComponent();
            Calculation_Display();
        }

        public async void Calculation_Display()
        {
            Calculation.Text = Calculation_Variables.Current_Calculation;
            switch (Calculation.Text.Length)
            {
                case 10:
                    for (int Timer = 0; Timer <= 20; Timer++)
                    {
                        double New_Size = Calculation.FontSize - 0.5;
                        Calculation.FontSize = New_Size;
                        await Task.Delay(1);
                    }
                    break;

                case 12:
                    for (int Timer = 0; Timer <= 10; Timer++)
                    {
                        double New_Size = Calculation.FontSize - 0.5;
                        Calculation.FontSize = New_Size;
                        await Task.Delay(1);
                    }
                    break;

                case 14:
                    for (int Timer = 0; Timer <= 20; Timer++)
                    {
                        double New_Size = Calculation.FontSize - 0.5;
                        Calculation.FontSize = New_Size;
                        await Task.Delay(1);
                    }
                    break;
            }


        }

        #region Numpad
        private void Numpad_0_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Current_Calculation += "0";
            Calculation_Display();
        }

        private void Numpad_1_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Current_Calculation += "1";
            Calculation_Display();
        }

        private void Numpad_2_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Current_Calculation += "2";
            Calculation_Display();
        }

        private void Numpad_3_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Current_Calculation += "3";
            Calculation_Display();
        }

        private void Numpad_4_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Current_Calculation += "4";
            Calculation_Display();
        }

        private void Numpad_5_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Current_Calculation += "5";
            Calculation_Display();
        }

        private void Numpad_6_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Current_Calculation += "6";
            Calculation_Display();
        }

        private void Numpad_7_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Current_Calculation += "7";
            Calculation_Display();
        }

        private void Numpad_8_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Current_Calculation += "8";
            Calculation_Display();
        }

        private void Numpad_9_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Current_Calculation += "9";
            Calculation_Display();
        }

        private void Numpad_Decimal_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Has_Decimal = true;
            Calculation_Variables.Current_Calculation += ".";
            Calculation_Display();
        }

        private void Numpad_Sum_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Functionpad
        private async void Functionpad_Delete_Click(object sender, RoutedEventArgs e)
        {
            if (Calculation_Variables.Current_Calculation.Length > 0)
            {
                Calculation_Variables.Current_Calculation = Calculation_Variables.Current_Calculation.Remove(Calculation_Variables.Current_Calculation.Length - 1);
                Calculation.Text = Calculation_Variables.Current_Calculation;

                switch (Calculation.Text.Length)
                {
                    case 9:
                        for (int Timer = 0; Timer <= 20; Timer++)
                        {
                            double New_Size = Calculation.FontSize + 0.5;
                            Calculation.FontSize = New_Size;
                            await Task.Delay(1);
                        }
                        break;

                    case 11:
                        for (int Timer = 0; Timer <= 10; Timer++)
                        {
                            double New_Size = Calculation.FontSize + 0.5;
                            Calculation.FontSize = New_Size;
                            await Task.Delay(1);
                        }
                        break;

                    case 13:
                        for (int Timer = 0; Timer <= 20; Timer++)
                        {
                            double New_Size = Calculation.FontSize + 0.5;
                            Calculation.FontSize = New_Size;
                            await Task.Delay(1);
                        }
                        break;
                }
            }
            
        }

        private void Functionpad_Division_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Has_Division = true;
        }

        private void Functionpad_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Has_Multiplication = true;
        }

        private void Functionpad_Subtraction_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Has_Subtraction = true;
        }

        private void Functionpad_Addition_Click(object sender, RoutedEventArgs e)
        {
            Calculation_Variables.Has_Addition = true;
            Calculation_Variables.Current_Calculation += "+";
            Calculation_Display();
        }

        #endregion
    }
}
