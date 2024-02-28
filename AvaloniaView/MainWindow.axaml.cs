using Avalonia.Controls;
using LAB2;

namespace AvaloniaView
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new Note();
        }
    }
}