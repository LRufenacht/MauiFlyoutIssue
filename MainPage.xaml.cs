namespace MauiAppFlyoutBehavior;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();


	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;

		for (var i = 0; i < 10; i++)
		{
			var shellContent = new ShellContent();

			shellContent.Title = "Test";
			shellContent.Route = "...";

			Shell.Current.Items.Add(shellContent);
		}
	}
}

