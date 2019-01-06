namespace Forum.Domain.Config
{
    public interface IConfig
    {
        string GetConnectionString();
        int GetConnectionTimeout();
    }
}
