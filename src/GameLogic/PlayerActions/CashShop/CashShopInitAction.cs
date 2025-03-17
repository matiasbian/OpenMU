// <copyright file="CashShopInitAction.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlayerActions.CashShop;

using MUnique.OpenMU.GameLogic.Views.CashShop;

/// <summary>
/// Action to init cash shop.
/// </summary>
public class CashShopInitAction
{
    /// <summary>
    /// Init the cash shop.
    /// </summary>
    /// <param name="player">The player.</param>
    public async ValueTask InitAsync(Player player)
    {
        await player.InvokeViewPlugInAsync<ICashShopInitPlugIn>(p => p.CashShopInitAsync()).ConfigureAwait(false);
    }
}