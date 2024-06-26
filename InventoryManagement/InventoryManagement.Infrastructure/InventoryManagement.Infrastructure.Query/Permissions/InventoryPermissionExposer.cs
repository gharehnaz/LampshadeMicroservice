﻿using InventoryManagement.Framework;

namespace InventoryManagement.Infrastructure.Query.Permissions
{
    public class InventoryPermissionExposer : IPermissionExposer
    {
        public Dictionary<string, List<PermissionDTO>> Expose()
        {
            return new Dictionary<string, List<PermissionDTO>>
            {
                {
                    "Inventory", new List<PermissionDTO>
                    {
                        new PermissionDTO(InventoryPermissions.ListInventory, "ListInventory"),
                        new PermissionDTO(InventoryPermissions.SearchInventory, "SearchInventory"),
                        new PermissionDTO(InventoryPermissions.CreateInventory, "CreateInventory"),
                        new PermissionDTO(InventoryPermissions.EditInventory, "EditInventory"),
                        new PermissionDTO(InventoryPermissions.Increase, "Increase"),
                        new PermissionDTO(InventoryPermissions.Reduce, "Reduce"),
                        new PermissionDTO(InventoryPermissions.OperationLog, "OperationLog")
                    }
                }
            };
        }
    }
}
