
namespace InventoryManagement.Framework
{
    public interface IPermissionExposer
    {
        Dictionary<string, List<PermissionDTO>> Expose();
    }
}
