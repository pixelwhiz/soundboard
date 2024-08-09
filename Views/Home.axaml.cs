using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace soundboard.Views;

public partial class Home : Window
{
    public Home()
    {
        InitializeComponent();
    }
    
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}