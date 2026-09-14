using Microsoft.Maui.Controls;

namespace MauiLoginPageforMath;

public partial class ResultPage : ContentPage
{
    public ResultPage(double firstValue, double secondValue, string operation)
    {
        InitializeComponent();

        string resultMessage = $"The numbers entered are {firstValue} and {secondValue}.\n";

        if (operation == "Addition")
        {
            resultMessage += $"The sum of the numbers is {firstValue + secondValue}.";
        }
        else if (operation == "Subtraction")
        {
            resultMessage += $"The difference of the numbers is {firstValue - secondValue}.";
        }

        ResultMessageLabel.Text = resultMessage;
    }

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}