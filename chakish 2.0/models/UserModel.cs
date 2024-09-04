namespace chakish_2._0.models;

public class UserModel
{
    public Guid Id { get; set; }
    public string Role { get; set; }
    public List<string> Photos { get; set; }
    public string GoogleId { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string AvatarUrl { get; set; }
}