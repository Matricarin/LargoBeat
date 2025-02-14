using System.Windows;

namespace WPFDemo;

public partial class MainWindow : Window
{
    private DemoViewModel _viewModel;

    public MainWindow(DemoViewModel viewModel)
    {
        _viewModel = viewModel;
        DataContext = _viewModel;
        InitializeComponent();
        _viewModel.LoadData();
    }
}