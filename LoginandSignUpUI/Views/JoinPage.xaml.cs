namespace LoginandSignUpUI.Views;

public partial class JoinPage : ContentPage
{
	public JoinPage()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		await Navigation.PushModalAsync(new Views.CreateAccountPage()); 
    }
}
