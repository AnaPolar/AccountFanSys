using AccountFanSys.Core;

namespace AccountFanSys.MVM.ModelView;

public class MainViewModel : ObservableObject
{
    public RelayCommand HomeViewCommand { get; set; }
    public RelayCommand AccountViewCommand { get; set; }
    
    public HomeViewModel HomeVm { get; set; }
    public AccountViewModel AccountVm { get; set; }
    
    private object _currentView;
    
    public object CurrentView
    {
        get { return _currentView; }
        set
        {
            _currentView = value; 
            OnPropertyChanged();
        }
    }
    
    public MainViewModel()
    {
        HomeVm = new HomeViewModel();
        AccountVm = new AccountViewModel();
        
        CurrentView = HomeVm;

        HomeViewCommand = new RelayCommand(o =>
        {
            CurrentView = HomeVm;
        });
        
        AccountViewCommand = new RelayCommand(o =>
        {
            CurrentView = AccountVm;
        });
    }
}