using Microsoft.Maui.Controls;

namespace MauiLoginPageforMath;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnAdditionClicked(object sender, EventArgs e)
    {
        await HandleOperation("Addition");
    }

    private async void OnSubtractionClicked(object sender, EventArgs e)
    {
        await HandleOperation("Subtraction");
    }

    private async Task HandleOperation(string operation)
    {
        if (ValidateInputs(out double firstValue, out double secondValue))
        {
            // Navigate to the ResultPage with the operation and values
            await Navigation.PushAsync(new ResultPage(firstValue, secondValue, operation));
        }
        else
        {
            // Display an appropriate error message
            MessageLabel.Text = $"Please enter values for both fields to perform {operation.ToLower()}";
        }
    }

    private bool ValidateInputs(out double firstValue, out double secondValue)
    {
        firstValue = 0;
        secondValue = 0;

        // Directly return the result of the validation logic
        return double.TryParse(FirstValueEntry.Text, out firstValue) &&
               double.TryParse(SecondValueEntry.Text, out secondValue);
    }
}
