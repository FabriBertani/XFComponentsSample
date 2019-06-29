using Xamarin.Forms;

namespace XFComponentsSample
{
    public partial class PageWithoutComponents : ContentPage
    {
        public PageWithoutComponents()
        {
            InitializeComponent();

            this.username.ReturnCommand = new Command(() => this.EntryCompleted(this.firstname));
            this.firstname.ReturnCommand = new Command(() => this.EntryCompleted(this.lastname));
            this.lastname.ReturnCommand = new Command(() => this.EntryCompleted(this.email));
            this.email.ReturnCommand = new Command(() => this.EntryCompleted(this.password));
        }

        private void EntryCompleted(Entry entry)
        {
            entry.Focus();
        }

        private void HandleButtonClicked(object sender, System.EventArgs e)
        {
            this.CheckIfEntryIsEmpty(this.username, this.usernameError);
            this.CheckIfEntryIsEmpty(this.firstname, this.firstnameError);
            this.CheckIfEntryIsEmpty(this.lastname, this.lastnameError);
            this.CheckIfEntryIsEmpty(this.email, this.emailError);
            this.CheckIfEntryIsEmpty(this.password, this.passwordError);
        }

        private void CheckIfEntryIsEmpty(Entry entryToChecl, Label errorLabel)
        {
            errorLabel.IsVisible = string.IsNullOrEmpty(entryToChecl.Text);
        }
    }
}