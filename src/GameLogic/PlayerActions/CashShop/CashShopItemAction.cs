// <copyright file="CashShopItemAction.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlayerActions.CashShop;

using MUnique.OpenMU.GameLogic.Views.CashShop;

/// <summary>
/// Action to get cash shop storage items.
/// </summary>
public class CashShopItemAction
{
    /// <summary>
    /// Get cash shop storage items.
    /// </summary>
    /// <param name="player">The player.</param>
    public async ValueTask GetItemAsync(Player player)
    {
        await player.InvokeViewPlugInAsync<ICashShopItemPlugIn>(p => p.CashShopItemAsync(0, 0, 0, 0, 0, 0, 0)).ConfigureAwait(false);
    }
}