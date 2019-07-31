using Prism.Commands;
using Prism.Navigation;
using PrismMasterDetail.Views;

namespace PrismMasterDetail.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public DelegateCommand<MasterItem> ItemTappedCommand { get; set; }

        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
            ItemTappedCommand = new DelegateCommand<MasterItem>(ItemTapped);
        }

        private async void ItemTapped(MasterItem masterItem)
        {
            if (masterItem.Title.Equals("Account"))
            {
                if (_isLogged)
                {
                    await _navigationService.NavigateAsync("NavigationPage/AccountPage");
                }
                else
                {
                    await _navigationService.NavigateAsync("NavigationPage/SignInPage", useModalNavigation:true);
                }
            }
            else
            {
                await _navigationService.NavigateAsync("NavigationPage/" + masterItem.Path);
            }
        }
    }
}