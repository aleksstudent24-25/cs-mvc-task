public class Model {
    public string? Name { get; set; }
    public int? DaysWithoutSkittles { get; set; }

    public Model(string name, int days) {
        Name = name;
        DaysWithoutSkittles = days;
    }

    public override string ToString()
    {
        return $"Hi I'm {Name} and I've gone {DaysWithoutSkittles} days without eating a single skittle!";
    }
}