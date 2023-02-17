// <copyright file="ICashShopNotifier.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.CashShopServer;

/// <summary>
/// Interface for a class which notifies a player about changes in the cash shop system.
/// </summary>
public interface ICashShopNotifier
{
    /// <summary>
    /// Initializes the cash shop for a connected player.
    /// </summary>
    /// <param name="serverId">The server identifier.</param>
    /// <param name="playerName">The player name.</param>
    ValueTask InitializeCashShopAsync(int serverId, string playerName);
}