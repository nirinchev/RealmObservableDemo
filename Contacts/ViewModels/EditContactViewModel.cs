using Realms;

namespace Contacts
{
    public class EditContactViewModel
    {
        public User User { get; }

        public EditContactViewModel(User user)
        {
            User = user;
        }
    }
}
