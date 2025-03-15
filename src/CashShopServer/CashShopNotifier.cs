// <copyright file="CashShopNotifier.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.CashShopServer;

using MUnique.OpenMU.Interfaces;

/// <summary>
/// An implementation of a <see cref="ICashShopNotifier"/> which forwards the calls to the available game server instances.
/// </summary>
public class CashShopNotifier : ICashShopNotifier
{
    private readonly IDictionary<int, IGameServer> _gameServers;

    /// <summary>
    /// Initializes a new instance of the <see cref="CashShopNotifier"/> class.
    /// </summary>
    /// <param name="gameServers">The game servers.</param>
    public CashShopNotifier(IDictionary<int, IGameServer> gameServers)
    {
        this._gameServers = gameServers;
    }


    /// <inheritdoc />
    public async ValueTask InitializeCashShopAsync(int serverId, string playerName)
    {
        if (this._gameServers.TryGetValue(serverId, out var gameServer))
        {
            await gameServer.InitializeCashShopAsync(playerName).ConfigureAwait(false);
        }
    }
}