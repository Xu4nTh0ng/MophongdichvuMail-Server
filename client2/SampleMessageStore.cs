using SmtpServer;
using SmtpServer.Protocol;
using SmtpServer.Storage;
using System.Buffers;


public class SampleMessageStore : MessageStore
{
    static public MimeKit.MimeMessage message2;
    public override async Task<SmtpResponse> SaveAsync(ISessionContext context, IMessageTransaction transaction, ReadOnlySequence<byte> buffer, CancellationToken cancellationToken)
    {
        await using var stream = new MemoryStream();

        var position = buffer.GetPosition(0);
        while (buffer.TryGet(ref position, out var memory))
        {
            await stream.WriteAsync(memory, cancellationToken);
        }

        stream.Position = 0;

        var message = await MimeKit.MimeMessage.LoadAsync(stream, cancellationToken);
        message2 = message;
        Console.WriteLine(message);
        
        

        return SmtpResponse.Ok;
    }
}