public class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void UpdateName()
    {
        _view.DisplayMessage("Enter the new name:");
        string? newName = Console.ReadLine();
        _model.Name = newName;
    }

    public void UpdateDays()
    {
        _view.DisplayMessage("Enter how many days you want to add to your non skittles journey:");
        if (int.TryParse(Console.ReadLine(), out int days))
        {
            _model.DaysWithoutSkittles += days;
        }
        else
        {
            _view.DisplayMessage("Invalid input. The amount of days must be a number");
        }
    }

    public void ShowModel()
    {
        _view.Display(_model);
    }
}