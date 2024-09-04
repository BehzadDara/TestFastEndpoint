using FastEndpoints;

namespace TestFastEndpoint.CreateUser;

public class CreateUserEndpoint : Endpoint<CreateUserRequest, CreateUserResponse>
{
    public override void Configure()
    {
        Verbs(Http.POST);
        Routes("/user");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateUserRequest req, CancellationToken cancellationToken)
    {
        var response = new CreateUserResponse
        {
            Id = Guid.NewGuid(),
            Name = req.Name,
            Age = req.Age
        };

        await SendAsync(response, StatusCodes.Status200OK, cancellationToken);
    }
}