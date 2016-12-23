using System.Collections.Generic;
using System.Linq;
using Realms;
using Xamarin.Forms;

namespace Contacts
{
    public class ContactsViewModel
    {
        private readonly Realm _realm;

        // Even though this is IEnumerable<User>, under the hood
        // it also implements INotifyCollectionChanged
        public IEnumerable<User> Users { get; }

        public Command<User> AddOrUpdateUserCommand { get; }

        public Command<User> FavoriteUserCommand { get; }

        public ContactsViewModel()
        {
            _realm = Realm.GetInstance();
            Users = _realm.All<User>().OrderByDescending(u => u.IsFavorite)
                                      .ThenBy(u => u.Name);

            AddOrUpdateUserCommand = new Command<User>(AddOrUpdateUser);
            FavoriteUserCommand = new Command<User>(FavoriteUser);
        }

        private void AddOrUpdateUser(User user)
        {
            if (user == null)
            {
                user = new User();
                _realm.Write(() => _realm.Add(user));
            }

            var userVM = new EditContactViewModel(user);
            NavigationService.Navigate(userVM);
        }

        private void FavoriteUser(User user)
        {
            if (user != null)
            {
                _realm.Write(() => user.IsFavorite = !user.IsFavorite);
            }
        }
    }
}
