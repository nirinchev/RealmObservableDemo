using Xamarin.Forms;

namespace Contacts
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage()
        {
            InitializeComponent();
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Handled here, because that's the only way to deselect an item in XF :(
            ((ListView)sender).SelectedItem = null;
            if (e.SelectedItem != null)
            {
                ((ContactsViewModel)BindingContext).AddOrUpdateUserCommand.Execute(e.SelectedItem);
            }
        }
    }
}
