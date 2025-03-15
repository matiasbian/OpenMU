// <copyright file="ICashShopSubscriber.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.Interfaces;

/// <summary>
/// Interface for an object which subscribes for changes in the cash shop system.
/// </summary>
public interface ICashShopSubscriber
{
    /// <summary>
    /// Initializes the cash shop.
    /// </summary>
    /// <param name="playerName">The player name.</param>
    ValueTask InitializeCashShopAsync(string playerName);
}