// <copyright file="ICashShopItemPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.Views.CashShop;

/// <summary>
/// Interface of a view whose implementation informs about the get cash shop storage items.
/// </summary>
public interface ICashShopItemPlugIn : IViewPlugIn
{
    /// <summary>
    /// Get cash shop storage items.
    /// </summary>
    /// <param name="storageIndex">Storage index.</param>
    /// <param name="itemSeq">Item seq.</param>
    /// <param name="storageGroupCode">Storage group code.</param>
    /// <param name="productSeq">Product seq.</param>
    /// <param name="priceSeq">Price seq.</param>
    /// <param name="cashPoint">Cash point.</param>
    /// <param name="itemType">Item type.</param>
    ValueTask CashShopItemAsync(uint storageIndex, uint itemSeq, uint storageGroupCode, uint productSeq, uint priceSeq, ulong cashPoint, byte itemType);
}