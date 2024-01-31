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
using Aspose.Slides.Theme;
using MaterialDesignThemes.Wpf;
using Theme = Aspose.Slides.Theme.Theme;
using MaterialDesignThemes.Wpf.Themes;

namespace Login_WPF
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
        public bool IsDarkTheme { get; set; }

        private readonly PaletteHelper paletteHelper = new PaletteHelper();

        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            //ITheme theme = (ITheme)paletteHelper.GetTheme();

            //if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            //{
            //    IsDarkTheme = false;
            //    theme.SetBaseTheme(Theme.Light);

            //}
            //else
            //{
            //    IsDarkTheme = true;
            //    theme.SetBaseTheme(Theme.Dark);
            //}

            //paletteHelper.SetTheme((MaterialDesignThemes.Wpf.Theme)theme);
        }



        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        //{
        //    base.OnMouseLeftButtonDown(e);
        //    DragMove();
        //}
    }
}
