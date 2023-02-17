// <copyright file="CashShopStorageAction.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.PlayerActions.CashShop;

using MUnique.OpenMU.GameLogic.Views.CashShop;

/// <summary>
/// Action to get cash shop storage info.
/// </summary>
public class CashShopStorageAction
{
    /// <summary>
    /// Get cash shop storage info.
    /// </summary>
    /// <param name="player">The player.</param>
    public async ValueTask GetStorageAsync(Player player, uint page, StorageType type)
    {
        await player.InvokeViewPlugInAsync<ICashShopStoragePlugIn>(p => p.CashShopStorageAsync(0, 0, 1, 1)).ConfigureAwait(false);
    }
}