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
            ContadorTextBlock.Text = PrincipalTextBox.Text.Length.ToString() + "/140";

            if (PrincipalTextBox.Text.Length == 140)
            {
                PrincipalTextBox.IsReadOnly = true;
            }
        }
    }
}
