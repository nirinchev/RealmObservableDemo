using System;
using Realms;

namespace Contacts
{
    public class User : RealmObject
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Name { get; set; }

        public bool IsFavorite { get; set; }

        /* Other relevant properties - phone numbers, addresses, etc. */
    }
}