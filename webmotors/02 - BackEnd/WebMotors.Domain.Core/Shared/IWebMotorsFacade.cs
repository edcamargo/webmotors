namespace WebMotors.Domain.Core.Shared
{
    public interface IWebMotorsFacade
    {
        object? GetMake();
        object? GetModel(int makeId);
        object? GetVersion(int modelId);
        object? GetVehicles(int page);
    }
}
