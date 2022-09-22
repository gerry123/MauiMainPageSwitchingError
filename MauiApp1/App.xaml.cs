namespace MauiApp1;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        SetMainPage(typeof(MainPage));
    }

    // https://github.com/dotnet/maui/issues/2517
    public void SetMainPage(Type MainPageType)
    {
        Page page = new NotFoundPage();
        MainPage = page;
        if (MainPageType == typeof(MainPage))
        {
            page = new MainPage(this);
        }
        if (MainPageType == typeof(NewMainPage))
        {
            page = new NewMainPage(this);
        }
        // ok
        //MainPage = page;
        // does not work on android, windows is ok
        MainPage = new NavigationPage(page);
    }

    public string GetNavStackAsText()
    {
        string result = "null";
        if (MainPage != null)
        {
            result = "";
            var existingPages = MainPage.Navigation.NavigationStack.ToList();
            if (existingPages.Count == 0)
            {
                result = "empty";
            }
            foreach (var page in existingPages)
            {
                result = result + page.Id.ToString() + "\n";
            }
        }
        return result;
    }
}
