using Xamarin.Forms;

namespace Contacts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var contactsPage = new ContactsPage
            {
                BindingContext = new ContactsViewModel()
            };

            MainPage = new NavigationPage(contactsPage);

            Resources = new ResourceDictionary
            {
                ["BooleanToStarConverter"] = new BooleanToStarConverter()
            };
        }
    }
}