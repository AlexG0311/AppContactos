using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PContactos.Model // Asegúrate de usar el espacio de nombres correcto
{

    public class ContactItem
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactPicture { get; set; }

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
