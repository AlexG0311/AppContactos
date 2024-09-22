using System;
using System.Collections.Generic;
using System.ComponentModel; // Necesario para INotifyPropertyChanged
using System.Runtime.CompilerServices; // Necesario para CallerMemberName
using System.Text;

namespace PContactos.Model
{
    public class ContactItem : INotifyPropertyChanged
    {
        private string name;
        private string occupation;
        private string phoneNumber;
        private string address;
        private string email;
        private string contactPicture;

        // Propiedades con notificación de cambios
        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Occupation
        {
            get => occupation;
            set
            {
                if (occupation != value)
                {
                    occupation = value;
                    OnPropertyChanged();
                }
            }
        }

        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (phoneNumber != value)
                {
                    phoneNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Address
        {
            get => address;
            set
            {
                if (address != value)
                {
                    address = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged();
                }
            }
        }

        public string ContactPicture
        {
            get => contactPicture;
            set
            {
                if (contactPicture != value)
                {
                    contactPicture = value;
                    OnPropertyChanged();
                }
            }
        }

        // Evento para notificar cuando una propiedad cambia
        public event PropertyChangedEventHandler PropertyChanged;

        // Método que notifica a la UI de los cambios
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Constructor por defecto
        public ContactItem() { }

        // Constructor con parámetros (opcional)
        public ContactItem(string name, string occupation, string phoneNumber, string address, string email, string contactPicture)
        {
            Name = name;
            Occupation = occupation;
            PhoneNumber = phoneNumber;
            Address = address;
            Email = email;
            ContactPicture = contactPicture;
        }
    }
}
