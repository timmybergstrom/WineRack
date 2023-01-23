namespace WineRack.Shared.Models;

public class BaseResponse
{
    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;
    public BaseResponse()
    {
        Success = true;
        Message = string.Empty;
    }

    public BaseResponse(bool success, string message)
    {
        Success = success;
        Message = message;
    }
}