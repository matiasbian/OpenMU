// <copyright file="ICashShopOpenPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.Views.CashShop;

/// <summary>
/// Interface of a view whose implementation informs about the open the cash shop.
/// </summary>
public interface ICashShopOpenPlugIn : IViewPlugIn
{
    /// <summary>
    /// Open cash shop.
    /// </summary>
    /// <param name="result">Result.</param>
    ValueTask CashShopOpenAsync(byte result);
}