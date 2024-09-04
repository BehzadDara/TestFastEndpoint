namespace TestFastEndpoint.CreateUser;

public class CreateUserResponse
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public int Age { get; set; }
}
