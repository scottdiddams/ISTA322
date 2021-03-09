using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Indexers
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private PhoneBook phoneBook = new PhoneBook();

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void findByNameClick(object sender, RoutedEventArgs e)
        {
            string text = name.Text;    //assigns the textbox input to text string
            if (!String.IsNullOrEmpty(text))    //ensures text box entry is not null/empty
            {
                Name personsName = new Name(text); //assigns textbox entry to Name personsName
                PhoneNumber personsPhoneNumber = this.phoneBook[personsName];
                phoneNumber.Text =  //Output textbox
                    String.IsNullOrEmpty(personsPhoneNumber.Text) ?
                    "Not Found" : personsPhoneNumber.Text; 
                //if personsName is in the phonebook, gives you the phone number, if not - "not found"
            }
        }

        private void findByPhoneNumberClick(object sender, RoutedEventArgs e)
        {
            string text = phoneNumber.Text;
            if (!String.IsNullOrEmpty(text))
            {
                PhoneNumber personsPhoneNumber = new PhoneNumber(text);
                Name personsName = this.phoneBook[personsPhoneNumber];
                name.Text = String.IsNullOrEmpty(personsName.Text) ?
                  "Not Found" : personsName.Text;
            //find a name based on a phone number
            }
        }

        private void addClick(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(name.Text) && !String.IsNullOrEmpty(phoneNumber.Text))
            {
                phoneBook.Add(new Name(name.Text),
                              new PhoneNumber(phoneNumber.Text));
                name.Text = "";
                phoneNumber.Text = "";
            }
        }
    }
}
