namespace CarService.Core.Entities;

public class Client
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public List<Vehicle> Vehicles { get; set; } = new();
}