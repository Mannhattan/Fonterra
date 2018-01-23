using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace FONTERRA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> fonts_list = new List<string>();
        public int centerPos = 3;

        public MainWindow()
        {
            InitializeComponent();
            LoadFonts(centerPos);
        }

        #region Interface_UX
        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void LABEL_exit_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void opacity_MouseEnter(object sender, MouseEventArgs e)
        {
            Label lb = (Label)sender;
            lb.Opacity = 0.5;
            //lb.FontSize = 14;
        }

        private void opacity_MouseLeave(object sender, MouseEventArgs e)
        {
            Label lb = (Label)sender;
            lb.Opacity = 1.0;
            //lb.FontSize = 12;
        }

        private void LABEL_white_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Font_preview.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            LABEL_exit.Foreground= new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            Main_bar.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            label2.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));

            Light_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            Light_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            Regular_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            Regular_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            Medium_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            Medium_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            Bold_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            Bold_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
        }

        private void LABEL_black_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            Font_preview.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            LABEL_exit.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Main_bar.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 0, 0));
            label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            label2.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));

            Light_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Light_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Regular_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Regular_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Medium_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Medium_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Bold_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Bold_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
        }

        private void LABEL_gray_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 35, 43, 56));
            Font_preview.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            LABEL_exit.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Main_bar.Fill = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 35, 43, 56));
            label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            label2.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));

            Light_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Light_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Regular_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Regular_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Medium_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Medium_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Bold_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
            Bold_italic_label.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 255, 255, 255));
        }
        #endregion

        public void LoadFonts(int center)
        {
            fonts_list.Clear();
            Font_combobox.Items.Clear();
            foreach(System.Drawing.FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts_list.Add(font.Name.ToString());
                Font_combobox.Items.Add(font.Name.ToString());
            }
        }

        private void Font_combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Font_preview.FontFamily = new System.Windows.Media.FontFamily(fonts_list.ElementAt<string>(Font_combobox.SelectedIndex));

            Light_label.FontFamily = new System.Windows.Media.FontFamily(fonts_list.ElementAt<string>(Font_combobox.SelectedIndex));
            Light_italic_label.FontFamily = new System.Windows.Media.FontFamily(fonts_list.ElementAt<string>(Font_combobox.SelectedIndex));
            Regular_label.FontFamily = new System.Windows.Media.FontFamily(fonts_list.ElementAt<string>(Font_combobox.SelectedIndex));
            Regular_italic_label.FontFamily = new System.Windows.Media.FontFamily(fonts_list.ElementAt<string>(Font_combobox.SelectedIndex));
            Medium_label.FontFamily = new System.Windows.Media.FontFamily(fonts_list.ElementAt<string>(Font_combobox.SelectedIndex));
            Medium_italic_label.FontFamily = new System.Windows.Media.FontFamily(fonts_list.ElementAt<string>(Font_combobox.SelectedIndex));
            Bold_label.FontFamily = new System.Windows.Media.FontFamily(fonts_list.ElementAt<string>(Font_combobox.SelectedIndex));
            Bold_italic_label.FontFamily = new System.Windows.Media.FontFamily(fonts_list.ElementAt<string>(Font_combobox.SelectedIndex));
        }
    }
}
