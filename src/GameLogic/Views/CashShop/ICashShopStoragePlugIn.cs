// <copyright file="ICashShopStoragePlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.Views.CashShop;

/// <summary>
/// Interface of a view whose implementation informs about the get storage info.
/// </summary>
public interface ICashShopStoragePlugIn : IViewPlugIn
{
    /// <summary>
    /// Get storage info.
    /// </summary>
    /// <param name="totalItemCount">Total item count.</param>
    /// <param name="currentItemCount">Current page item count.</param>
    /// <param name="pageIndex">Page index.</param>
    /// <param name="totalPage">Total page.</param>
    ValueTask CashShopStorageAsync(ushort totalItemCount, ushort currentItemCount, ushort pageIndex, ushort totalPage);
}