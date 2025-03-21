﻿// <copyright file="CashShopOpenPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.RemoteView.CashShop;

using System.Runtime.InteropServices;
using MUnique.OpenMU.GameLogic.Views.CashShop;
using MUnique.OpenMU.Network.Packets.ServerToClient;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// The default implementation of the <see cref="CashShopOpenPlugIn"/> which is forwarding everything to the game client with specific data packets.
/// </summary>
[PlugIn("CashShopOpenPlugIn", "The default implementation of the ICashShopOpenPlugIn which is forwarding everything to the game client with specific data packets.")]
[Guid("EC942F99-99D8-42A8-8566-AE358B527F20")]
public class CashShopOpenPlugIn : ICashShopOpenPlugIn
{
    private readonly RemotePlayer _player;

    /// <summary>
    /// Initializes a new instance of the <see cref="CashShopOpenPlugIn"/> class.
    /// </summary>
    /// <param name="player">The player.</param>
    public CashShopOpenPlugIn(RemotePlayer player) => this._player = player;

    /// <inheritdoc/>
    public ValueTask CashShopOpenAsync(byte result)
    {
        return this._player.Connection.SendCashShopOpenAsync(result);
    }
}