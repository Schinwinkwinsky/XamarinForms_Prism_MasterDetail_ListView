using Prism.Commands;
using Prism.Navigation;

namespace PrismMasterDetail.ViewModels
{
    public class SignInViewModel : BaseViewModel
    {
        public DelegateCommand CancelCommand { get; set; }

        public SignInViewModel(INavigationService navigationService) 
            : base(navigationService)
        {
            Title = "Sign In";

            CancelCommand = new DelegateCommand(Cancel);
        }

        private async void Cancel()
        {
            await _navigationService.GoBackAsync(useModalNavigation: true);
        }
    }
}