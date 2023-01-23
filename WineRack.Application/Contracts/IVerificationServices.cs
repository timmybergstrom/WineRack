namespace WineRack.Application.Contracts;
public interface IVerificationServices
{
    Task<bool> VerifyActiveUserById(int userId);
}