namespace Registr;

public partial class MainPage : ContentPage
{
    public MainPage() => InitializeComponent();
    
    private void OnConfirmClicked(object sender, EventArgs e)
    {
        var email = EmailEntry.Text;
        var password = PasswordEntry.Text;

        // TODO: Додати логіку реєстрації
        DisplayAlert("Інфо", $"Email: {email}\nPassword: {password}", "OK");
    }

    private void OnGoogleLoginClicked(object sender, EventArgs e)
    {
        // TODO: Авторизація через Google
        DisplayAlert("Google", "Google авторизація", "OK");
    }

    private void OnFacebookLoginClicked(object sender, EventArgs e)
    {
        // TODO: Авторизація через Facebook
        DisplayAlert("Facebook", "Facebook авторизація", "OK");
    }
}
