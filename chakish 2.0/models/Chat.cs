namespace chakish_2._0.models;

public class ChatModel
{
    public Guid ChatId { get; set; }
    public List<UserModel> Users { get; set; } = new List<UserModel>();
}