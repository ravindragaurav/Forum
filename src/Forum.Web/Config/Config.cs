using Forum.Domain.Config;

namespace Forum.Web.Config
{
    public class Config : IConfig
    {
        public string GetConnectionString()
        {
            return "Data Source = GAURAV\\SQL; Initial Catalog = Forum; Integrated Security = True";

            // return "Data Source = (LocalDb)\\MSSQLLocalDb; Initial Catalog = Forum; Integrated Security = True";
        }

        public int GetConnectionTimeout()
        {
            return 900;
        }
    }
}
