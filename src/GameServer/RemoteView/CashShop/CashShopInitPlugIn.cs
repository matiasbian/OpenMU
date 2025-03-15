// <copyright file="CashShopInitPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.RemoteView.CashShop;

using System.Runtime.InteropServices;
using MUnique.OpenMU.GameLogic.Views.CashShop;
using MUnique.OpenMU.Network.Packets.ServerToClient;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// The default implementation of the <see cref="CashShopInitPlugIn"/> which is forwarding everything to the game client with specific data packets.
/// </summary>
[PlugIn("CashShopInitPlugIn", "The default implementation of the ICashShopInitPlugIn which is forwarding everything to the game client with specific data packets.")]
[Guid("A58A5E86-6133-487A-9206-787BB03EED24")]
public class CashShopInitPlugIn : ICashShopInitPlugIn
{
    private readonly RemotePlayer _player;

    /// <summary>
    /// Initializes a new instance of the <see cref="CashShopInitPlugIn"/> class.
    /// </summary>
    /// <param name="player">The player.</param>
    public CashShopInitPlugIn(RemotePlayer player) => this._player = player;

    /// <inheritdoc/>
    public ValueTask CashShopInitAsync()
    {
        return this._player.Connection.SendCashShopInitAsync();
    }
}