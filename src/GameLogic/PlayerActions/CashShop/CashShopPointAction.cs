// <copyright file="CashShopPointAction.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlayerActions.CashShop;

using MUnique.OpenMU.GameLogic.Views.CashShop;

/// <summary>
/// Action to get cash shop points.
/// </summary>
public class CashShopPointAction
{
    /// <summary>
    /// Get cash shop points.
    /// </summary>
    /// <param name="player">The player.</param>
    public async ValueTask GetPointAsync(Player player)
    {
        var account = player.Account;

        if (account is not null)
        {
            await player.InvokeViewPlugInAsync<ICashShopPointPlugIn>(p => p.CashShopPointAsync(0, account.WCoinC, account.WCoinC, account.WCoinP, account.WCoinP, account.GoblinCoin)).ConfigureAwait(false);
        }
        else
        {
            await player.InvokeViewPlugInAsync<ICashShopPointPlugIn>(p => p.CashShopPointAsync(0, 0, 0, 0, 0, 0)).ConfigureAwait(false);
        }
    }
}