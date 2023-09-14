using Flunt.Notifications;
using Flunt.Validations;

namespace JwtStore.Core.Contexts.AccountContext.UseCases.Create;

public static class Specification
{
    public static Contract<Notification> Ensure(Request request)
        => new Contract<Notification>()
            .Requires()
            .IsLowerThan(request.Name.Length, 160, "Name", "O nome deve ter menos de 160 caracteres")
            .IsGreaterThan(request.Name.Length, 3, "Name", "O nome deve ter mais de 3 caracteres")
            .IsLowerThan(request.Password.Length, 40, "Password", "A senha deve ter menos de 40 caracteres")
            .IsGreaterThan(request.Password.Length, 8, "Password", "A senha deve ter mais de 8 caracteres")
            .IsEmail(request.Email, "Email", "E-mail inválido");
}