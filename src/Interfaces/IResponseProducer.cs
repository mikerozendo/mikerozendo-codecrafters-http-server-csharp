namespace codecrafters_http_server.src.Interfaces;

public interface IResponseProducer
{
    Task<string> ProduceResponseAsync();
}
