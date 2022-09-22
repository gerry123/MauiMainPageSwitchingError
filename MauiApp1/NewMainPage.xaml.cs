namespace MauiApp1;

public partial class NewMainPage : ContentPage
{
    private MauiApp1.App FApp;
    public NewMainPage(MauiApp1.App App)
    {
        FApp = App;
        InitializeComponent();
    }

    private void OnSetOrgMainPageClicked(object sender, EventArgs e)
    {
        FApp.SetMainPage(typeof(MainPage));
    }

    private void OnGetNavStackBtnClicked(object sender, EventArgs e)
    {
        laNavStack.Text = FApp.GetNavStackAsText();
    }

}