namespace FitnessApp.Data;

public class Workout
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Desc { get; set; } = "";
    public int Time { get; set; } // в минутах
}