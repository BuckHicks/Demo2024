namespace Demo2024.Biz.Commons.Models;

public class CloseWindowMessage
{
    public CloseWindowMessage(ObservableObject dataContext)
    {
        DataContext = dataContext;
    }

    public ObservableObject DataContext { get; set; }
}
