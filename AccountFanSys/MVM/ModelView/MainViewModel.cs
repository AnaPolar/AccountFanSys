using AccountFanSys.Core;

namespace AccountFanSys.MVM.ModelView;

public class MainViewModel : ObservableObject
{
    public RelayCommand HomeViewCommand { get; set; }
    public RelayCommand AccountViewCommand { get; set; }
    public RelayCommand CatalogViewCommand { get; set; }
    
    public HomeViewModel HomeVm { get; set; }
    public AccountViewModel AccountVm { get; set; }
    public CatalogViewModel CatalogVm { get; set; }
    
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
        CatalogVm = new CatalogViewModel();
        
        CurrentView = HomeVm;

        HomeViewCommand = new RelayCommand(o =>
        {
            CurrentView = HomeVm;
        });
        
        AccountViewCommand = new RelayCommand(o =>
        {
            CurrentView = AccountVm;
        });
        
        CatalogViewCommand = new RelayCommand(o =>
        {
            CurrentView = CatalogVm;
        });
    }
}