using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Input;

namespace eShop_mobile.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    [ObservableProperty]
    public string _email;

    [ObservableProperty]        
    public string _password;

    public ICommand _togglePasswordVisibilityCommand { get; }

    public LoginViewModel()
    {
        _togglePasswordVisibilityCommand = new Command(TogglePasswordVisibility);
        _isPasswordVisible = false;
    }

    public bool _isPasswordVisible
    {
        get => _isPasswordVisible;
        set
        {
            _isPasswordVisible = value;
            OnPropertyChanged();
        }
    }

    private void TogglePasswordVisibility()
    {
        _isPasswordVisible = true;
    }
}
