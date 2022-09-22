namespace MauiApp1;

public partial class MainPage : ContentPage
{
	private MauiApp1.App FApp;

	public MainPage(MauiApp1.App App)
	{
		FApp = App;	
		InitializeComponent();
    }

	private void OnSetNewMainPageBtnClicked(object sender, EventArgs e)
	{
        FApp.SetMainPage(typeof(NewMainPage));
    }

    private void OnGetNavStackBtnClicked(object sender, EventArgs e)
    {
        laNavStack.Text = FApp.GetNavStackAsText();
    }
    
}

