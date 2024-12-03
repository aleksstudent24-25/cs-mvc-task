using System.ComponentModel.Design;

namespace cs_mvc;

class Program
{
    static void Main(string[] args)
    {
        Model model = new Model("Jane Doe", 72);
        View view = new View();

        Controller controller = new Controller(model, view);

        controller.ShowModel();

        controller.UpdateDays();

        controller.ShowModel();

        Console.ReadLine();
    }
}
