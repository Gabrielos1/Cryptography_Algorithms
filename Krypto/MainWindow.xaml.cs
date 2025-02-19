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

namespace Krypto
{
    public partial class MainWindow : Window
    {
        private readonly KryptographyService kryptographyService = new KryptographyService();

        public MainWindow()
        {
            InitializeComponent();
        }

        #region ZADANIE 1
        private void Encode_RailFance(object sender, RoutedEventArgs e)
        {
            string input = RailFence_Input.Text.ToString();
            int key = int.Parse(RailFence_Key.Text);

            RailFence_Output.Text = kryptographyService.RailFenceEncode(input, key);
        }

        private void Decode_RailFance(object sender, RoutedEventArgs e)
        {
            string input = RailFence_Input.Text.ToString();
            int key = int.Parse(RailFence_Key.Text);

            RailFence_Output.Text = kryptographyService.RailFenceDecode(input, key);
        }
        #endregion

        #region ZADANIE 2
        private void Encode_A2(object sender, RoutedEventArgs e)
        {
            string input = A2_Input.Text.ToString();

            A2_Output.Text = kryptographyService.MatrixShift2AEncode(input);
        }

        private void Decode_A2(object sender, RoutedEventArgs e)
        {
            string input = A2_Input.Text.ToString();

            A2_Output.Text = kryptographyService.MatrixShift2ADecode(input);
        }
        #endregion

        #region ZADANIE 3
        #region 2B
        private void Encode_B2(object sender, RoutedEventArgs e)
        {
            string input = B2_Input.Text.ToString();
            string key = B2_Key.Text.ToString();

            B2_Output.Text = kryptographyService.MatrixShift2BEncode(input, key);
        }

        private void Decode_B2(object sender, RoutedEventArgs e)
        {
            string input = B2_Input.Text.ToString();
            string key = B2_Key.Text.ToString();

            B2_Output.Text = kryptographyService.MatrixShift2BDecode(input, key);
        }
        #endregion

        #region 2C
        private void Encode_C2(object sender, RoutedEventArgs e)
        {
            string input = C2_Input.Text.ToString();
            string key = C2_Key.Text.ToString();

            C2_Output.Text = kryptographyService.MatrixShift2CEncode(input, key);
        }

        private void Decode_C2(object sender, RoutedEventArgs e)
        {
            string input = C2_Input.Text.ToString();
            string key = C2_Key.Text.ToString();

            C2_Output.Text = kryptographyService.MatrixShift2CDecode(input, key);
        }
        #endregion
        #endregion

        #region ZADANIE 4
        private void Encode_B3(object sender, RoutedEventArgs e)
        {
            string input = B3_Input.Text.ToString();
            int K1 = int.Parse(B3_A.Text);
            int K0 = int.Parse(B3_B.Text);

            B3_Output.Text = kryptographyService.CaesarEncode(input, K1, K0);
        }

        private void Decode_B3(object sender, RoutedEventArgs e)
        {
            string input = B3_Input.Text.ToString();
            int K1 = int.Parse(B3_A.Text);
            int K0 = int.Parse(B3_B.Text);

            B3_Output.Text = kryptographyService.CaesarDecode(input, K1, K0);
        }
        #endregion

        #region ZADANIE 5
        private void Encode_Vigenere(object sender, RoutedEventArgs e)
        {
            string input = Vigenere_Input.Text.ToString();
            string key = Vigenere_Key.Text.ToString();

            Vigenere_Output.Text = kryptographyService.VigenereEncode(input, key);
        }

        private void Decode_Vigenere(object sender, RoutedEventArgs e)
        {
            string input = Vigenere_Input.Text.ToString();
            string key = Vigenere_Key.Text.ToString();

            Vigenere_Output.Text = kryptographyService.VigenereDecode(input, key);
        }
        #endregion
    }
}
