using Xamarin.Forms;
using XFComponentsSample.Components;

namespace XFComponentsSample
{
    public partial class PageWithComponents : ContentPage
    {
        public PageWithComponents()
        {
            InitializeComponent();

            this.username.EntryReturnCommand = new Command(() => this.EntryCompleted(this.firstname));
            this.firstname.EntryReturnCommand = new Command(() => this.EntryCompleted(this.lastname));
            this.lastname.EntryReturnCommand = new Command(() => this.EntryCompleted(this.email));
            this.email.EntryReturnCommand = new Command(() => this.EntryCompleted(this.password));
        }

        private void EntryCompleted(EntryComponent entryComponent)
        {
            entryComponent.EntryFocused();
        }

        private void HandleButtonClicked(object sender, System.EventArgs e)
        {
            this.CheckIfEntryIsEmpty(this.username);
            this.CheckIfEntryIsEmpty(this.firstname);
            this.CheckIfEntryIsEmpty(this.lastname);
            this.CheckIfEntryIsEmpty(this.email);
            this.CheckIfEntryIsEmpty(this.password);
        }

        private void CheckIfEntryIsEmpty(EntryComponent entryComponent)
        {
            entryComponent.ErrorTextVisibility = string.IsNullOrEmpty(entryComponent.EntryText);
       }
    }
}