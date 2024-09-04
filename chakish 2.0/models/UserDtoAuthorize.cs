namespace chakish_2._0.models;

public class UserDtoAuthorize(string username, string password)
{
    public string Username { get; set; } = username;
    public string Password { get; set; } = password;
}