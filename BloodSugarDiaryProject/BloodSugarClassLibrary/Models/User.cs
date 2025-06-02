using BloodSugarClassLibrary.Models;

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public virtual Patient? Patient { get; set; }
    public virtual List<Measurements> Measurements { get; set; } = new List<Measurements>();

    public User(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public User() { }
}