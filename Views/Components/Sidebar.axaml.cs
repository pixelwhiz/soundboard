using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using soundboard.ViewModels;

namespace soundboard.Views.Components;

public partial class Sidebar : UserControl
{
    public Sidebar()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
        DataContext = new SidebarViewModel();
    }
}