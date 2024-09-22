using Microsoft.Maui.Controls;
using static PContactos.App;
using PContactos.Model;
using Microsoft.Maui.ApplicationModel.Communication;
using System.Collections.ObjectModel;



namespace PContactos;

public partial class PerfilContacto : ContentPage
{
    private ObservableCollection<ContactItem> contacts;
    public PerfilContacto(ObservableCollection<ContactItem> contacts)


    {
        InitializeComponent();
        this.contacts = contacts;
        // Establecer el contexto de enlace a la variable seleccionada
        BindingContext = App.selectedContact; // Aseg�rate de que esto sea correcto

        // Asignar los �conos
        Call.Text = "\uf095"; // �cono de llamada
        Message.Text = "\uf4a6"; // �cono de mensaje
        phoneIcon.Text = "\uf095"; // �cono de tel�fono
        cityIcon.Text = "\uf64f"; // �cono de ciudad
        mailIcon.Text = "\uf0e0"; // �cono de correo electr�nico

        // Cargar detalles del contacto
        LoadContactDetails();
    }

    private void LoadContactDetails()
    {
        var contact = App.selectedContact; // Obtener el contacto seleccionado
        if (contact != null)
        {
            // Asigna los valores a los elementos de la UI
            name.Text = contact.Name;
            occupation.Text = contact.Occupation;
            phoneNumber.Text = contact.PhoneNumber;
            address.Text = contact.Address;
            email.Text = contact.Email;

            // Carga la imagen si es necesario
            contactImage.Source = contact.ContactPicture; // Ajusta seg�n tu UI
        }
        else
        {
            // Maneja el caso donde no hay contacto seleccionado
            DisplayAlert("Error", "No se encontr� el contacto.", "OK");
        }
    }

    private void Deletee(object sender, EventArgs e)
    {
        contacts.Remove(App.selectedContact);

        Navigation.PopAsync();
    }


}
