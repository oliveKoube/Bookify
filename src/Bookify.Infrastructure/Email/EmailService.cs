using Bookify.Application.Abstractions.Email;
using FluentEmail.Core;

namespace Bookify.Infrastructure.Email;

internal sealed class EmailService(IFluentEmail fluentEmail) : IEmailService
{
    private readonly IFluentEmail _fluentEmail = fluentEmail;
    public async Task SendAsync(Domain.Users.Email recipient, string subject, string body)
    {
        await _fluentEmail
            .To(recipient.Value)
            .Subject(subject)
            .Body(body)
            .SendAsync();
    }
}
