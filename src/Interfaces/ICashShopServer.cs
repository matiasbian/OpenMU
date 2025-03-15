// -----------------------------------------------------------------------
// <copyright file="ICashShopServer.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>
// -----------------------------------------------------------------------

namespace MUnique.OpenMU.Interfaces;

/// <summary>
/// The cash shop server interface.
/// </summary>
public interface ICashShopServer
{
    /// <summary>
    /// Is called when a player entered the game.
    /// It will cause a response with <see cref="ICashShopSubscriber.InitializeCashShopAsync"/>.
    /// </summary>
    /// <param name="serverId">The server identifier.</param>
    /// <param name="characterId">The character identifier.</param>
    /// <param name="characterName">Name of the character.</param>
    ValueTask PlayerEnteredGameAsync(byte serverId, Guid characterId, string characterName);
}