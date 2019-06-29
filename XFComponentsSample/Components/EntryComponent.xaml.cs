    using System.Windows.Input;
using Xamarin.Forms;

namespace XFComponentsSample.Components
{
    public partial class EntryComponent : StackLayout
    {
        public static readonly BindableProperty TitleTextProperty = BindableProperty.Create(
            nameof(TitleText),
            typeof(string),
            typeof(EntryComponent),
            default(string),
            BindingMode.OneWay,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var view = (EntryComponent)bindable;

                view.titleLabel.Text = (string)newValue;
            }
        );

        public static readonly BindableProperty EntryTextProperty = BindableProperty.Create(
            nameof(EntryText),
            typeof(string),
            typeof(EntryComponent),
            default(string),
            BindingMode.TwoWay,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var view = (EntryComponent)bindable;

                view.entry.Text = (string)newValue;
            }
        );

        public static readonly BindableProperty ErrorTextProperty = BindableProperty.Create(
            nameof(ErrorText),
            typeof(string),
            typeof(EntryComponent),
            default(string),
            BindingMode.OneWay,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var view = (EntryComponent)bindable;

                view.errorLabel.Text = (string)newValue;
            }
        );

        public static readonly BindableProperty ErrorTextVisibilityProperty = BindableProperty.Create(
            nameof(ErrorTextVisibility),
            typeof(bool),
            typeof(EntryComponent),
            false,
            BindingMode.OneWay,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var view = (EntryComponent)bindable;

                view.errorLabel.IsVisible = (bool)newValue;
            }
        );

        public static readonly BindableProperty EntryReturnCommandProperty = BindableProperty.Create(
            nameof(EntryReturnCommand),
            typeof(ICommand),
            typeof(EntryComponent),
            default(ICommand),
            BindingMode.OneWay,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var view = (EntryComponent)bindable;

                view.entry.ReturnCommand = (ICommand)newValue;
            }
        );

        public EntryComponent()
        {
            InitializeComponent();

            this.entry.Text = this.EntryText;
            this.entry.TextChanged += this.OnEntryTextChanged;
        }

        public string TitleText
        {
            get => (string)GetValue(TitleTextProperty);
            set => SetValue(TitleTextProperty, value);
        }

        public string EntryText
        {
            get => (string)GetValue(EntryTextProperty);
            set => SetValue(EntryTextProperty, value);
        }

        public string EntryPlaceholderText
        {
            set => this.entry.Placeholder = value;
        }

        public string ErrorText
        {
            get => (string)GetValue(ErrorTextProperty);
            set => SetValue(ErrorTextProperty, value);
        }

        public  bool IsPassword
        {
            set => this.entry.IsPassword = value;
        }

        public bool? ErrorTextVisibility
        {
            get => (bool?)GetValue(ErrorTextVisibilityProperty);
            set => SetValue(ErrorTextVisibilityProperty, value);
        }

        public Keyboard EntryKeyboard
        {
            set => this.entry.Keyboard = value;
        }

        public ReturnType EntryReturnType
        {
            set => this.entry.ReturnType = value;
        }

        public ICommand EntryReturnCommand
        {
            get => (ICommand)GetValue(EntryReturnCommandProperty);
            set => SetValue(EntryReturnCommandProperty, value);
        }

        public void EntryFocused()
        {
            this.entry.Focus();
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            this.EntryText = args.NewTextValue;
        }
    }
}