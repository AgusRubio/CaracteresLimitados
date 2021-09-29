using System;
using System.Windows;
using System.Windows.Controls;

namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CaracteresTextBlock.Text = TextBox.Text.Length.ToString() + "/140";

            if (TextBox.Text.Length == 140)
            {
                TextBox.IsReadOnly = true;
            }
        }
    }
}
