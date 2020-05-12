using System.Windows;
using System.Windows.Media;
using System.Text.RegularExpressions;


namespace oop_lab11_part2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonPassportNumber_Click(object sender, RoutedEventArgs e)
        {
            string pattern = @"\S{2} \d{7}";


            string str = textBoxPassportNumber.Text;

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                labelCheckPassportNumber.Content = "ОК";
                labelCheckPassportNumber.Foreground = Brushes.Green;

            }
            else
            {
                labelCheckPassportNumber.Content = "ПОМИЛКА";
                labelCheckPassportNumber.Foreground = Brushes.Red;
            }
        }

        private void buttonPhoneNumber_Click(object sender, RoutedEventArgs e)
        {
            string pattern = @"38\d{10}";

            string str = textBoxPhoneNumber.Text;

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                labelCheckPhoneNumber.Content = "ОК";
                labelCheckPhoneNumber.Foreground = Brushes.Green;

            }
            else
            {
                labelCheckPhoneNumber.Content = "ПОМИЛКА";
                labelCheckPhoneNumber.Foreground = Brushes.Red;
            }
        }

        private void buttonIntervalNumber_Click(object sender, RoutedEventArgs e)
        {
            string pattern = @"[10311-89645]{5}";


            string str = textBoxIntervalNumber.Text;

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                labelCheckIntervalNumber.Content = "ОК";
                labelCheckIntervalNumber.Foreground = Brushes.Green;

            }
            else
            {
                labelCheckIntervalNumber.Content = "ПОМИЛКА";
                labelCheckIntervalNumber.Foreground = Brushes.Red;
            }
        }

        private void buttonUkrainianName_Click(object sender, RoutedEventArgs e)
        {
            string pattern = "[А-Я][а-я]{3}";


            string str = textBoxUkrainianName.Text;

            if (Regex.IsMatch(str, pattern))
            {
                labelCheckUkrainianName.Content = "ОК";
                labelCheckUkrainianName.Foreground = Brushes.Green;

            }
            else
            {
                labelCheckUkrainianName.Content = "ПОМИЛКА";
                labelCheckUkrainianName.Foreground = Brushes.Red;
            }
        }

        private void buttonTime_Click(object sender, RoutedEventArgs e)
        {
            string pattern = "[0-23]{2}:[0-59]{2}";


            string str = textBoxTime.Text;

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                labelCheckTime.Content = "ОК";
                labelCheckTime.Foreground = Brushes.Green;

            }
            else
            {
                labelCheckTime.Content = "ПОМИЛКА";
                labelCheckTime.Foreground = Brushes.Red;
            }
        }

        private void buttonEmail_Click(object sender, RoutedEventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";


            string str = textBoxEmail.Text;

            if (Regex.IsMatch(str, pattern, RegexOptions.IgnoreCase))
            {
                labelCheckEmail.Content = "ОК";
                labelCheckEmail.Foreground = Brushes.Green;

            }
            else
            {
                labelCheckEmail.Content = "ПОМИЛКА";
                labelCheckEmail.Foreground = Brushes.Red;
            }
        }
    }
}
