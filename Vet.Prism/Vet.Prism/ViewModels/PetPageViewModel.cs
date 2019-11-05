using Prism.Navigation;
using Vet.Common.Models;

namespace Vet.Prism.ViewModels
{
    public class PetPageViewModel : ViewModelBase
    {
        private PetResponse _pet;
        public PetPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        public PetResponse Pet
        {
            get => _pet;
            set => SetProperty(ref _pet, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if (parameters.ContainsKey("pet"))
            {
                Pet = parameters.GetValue<PetResponse>("pet");
                Title = _pet.Name;
            }
        }
    }
}
