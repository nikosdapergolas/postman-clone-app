namespace PostmanCloneUI;
public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private async void callApi_Click(object sender, EventArgs e)
    {
        // Validate the API Url


        try
        {
            systemStatus.Text = "Calling API...";

            // Sample code - Replace with actual API call
            await Task.Delay(2000);

            systemStatus.Text = "Ready";
        }
        catch (Exception ex)
        {
            resultsText.Text = "Error: " + ex.Message;
            systemStatus.Text = "Error";
        }
    }
}
