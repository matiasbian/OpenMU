// <copyright file="CashShopOpenAction.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlayerActions.CashShop;

using MUnique.OpenMU.GameLogic.Views.CashShop;

/// <summary>
/// Action to open cash shop.
/// </summary>
public class CashShopOpenAction
{
    /// <summary>
    /// Opens the cash shop.
    /// </summary>
    /// <param name="player">The player.</param>
    public async ValueTask OpenAsync(Player player)
    {
        player.IsCashShopOpened = !player.IsCashShopOpened;
        await player.InvokeViewPlugInAsync<ICashShopOpenPlugIn>(p => p.CashShopOpenAsync(Convert.ToByte(player.IsCashShopOpened))).ConfigureAwait(false);
    }
}