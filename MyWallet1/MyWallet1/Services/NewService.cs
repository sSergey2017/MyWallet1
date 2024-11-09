using MyWallet1.Interfaces;

namespace MyWallet1.Services
{
    public class NewService : INewService
    {
        public string GetMessage()
        {
            return "I am new service";
        }
    }

}
