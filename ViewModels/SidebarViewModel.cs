using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace soundboard.ViewModels;

public class SidebarViewModel : INotifyPropertyChanged
{
    private string _currentPage = string.Empty;

    public string CurrentPage
    {
        get => _currentPage;
        set
        {
            if (_currentPage != value)
            {
                _currentPage = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    

}