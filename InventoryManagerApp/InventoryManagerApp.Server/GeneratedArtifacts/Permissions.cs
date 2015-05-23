﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    /// <summary>
    /// Defines the names of the application permissions.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static class Permissions
    {
        /// <summary>
        /// Provides the ability to manage security for the application.
        /// </summary>
        public const string SecurityAdministration = global::Microsoft.LightSwitch.Security.ApplicationPermissions.SecurityAdministration;
        /// <summary>
        /// Can Edit Customers
        /// </summary>
        public const string CanEditCustomers = "LightSwitchApplication:CanEditCustomers";
        /// <summary>
        /// Can Edit Employees
        /// </summary>
        public const string CanEditEmployees = "LightSwitchApplication:CanEditEmployees";
        /// <summary>
        /// Can Edit Order Details
        /// </summary>
        public const string CanEditOrderDetails = "LightSwitchApplication:CanEditOrderDetails";
        /// <summary>
        /// Can Edit Orders
        /// </summary>
        public const string CanEditOrders = "LightSwitchApplication:CanEditOrders";
        /// <summary>
        /// Can Edit Product Categories
        /// </summary>
        public const string CanEditProductCategories = "LightSwitchApplication:CanEditProductCategories";
        /// <summary>
        /// Can Edit Products
        /// </summary>
        public const string CanEditProducts = "LightSwitchApplication:CanEditProducts";
        /// <summary>
        /// Can Edit Purchase Order Details
        /// </summary>
        public const string CanEditPurchaseOrderDetails = "LightSwitchApplication:CanEditPurchaseOrderDetails";
        /// <summary>
        /// Can Edit Purchase Orders
        /// </summary>
        public const string CanEditPurchaseOrders = "LightSwitchApplication:CanEditPurchaseOrders";
        /// <summary>
        /// Can Edit Shipping Methods
        /// </summary>
        public const string CanEditShippingMethods = "LightSwitchApplication:CanEditShippingMethods";
        /// <summary>
        /// Can Edit Stock Check Details
        /// </summary>
        public const string CanEditStockCheckDetails = "LightSwitchApplication:CanEditStockCheckDetails";
        /// <summary>
        /// Can Edit Stock Checks
        /// </summary>
        public const string CanEditStockChecks = "LightSwitchApplication:CanEditStockChecks";
        /// <summary>
        /// Can Edit Suppliers
        /// </summary>
        public const string CanEditSuppliers = "LightSwitchApplication:CanEditSuppliers";
        /// <summary>
        /// Can Edit Product Subscribers
        /// </summary>
        public const string CanEditProductSubscribers = "LightSwitchApplication:CanEditProductSubscribers";

        /// <summary>
        /// Gets all permissions defined for the application.  This includes system and user-defined permissions.
        /// </summary>
        public static global::System.Collections.ObjectModel.ReadOnlyCollection<string> AllPermissions { get { return global::Microsoft.LightSwitch.Security.ApplicationPermissions.AllPermissions; } }
    }
}
