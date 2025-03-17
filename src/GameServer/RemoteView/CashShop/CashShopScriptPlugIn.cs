// <copyright file="CashShopScriptPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.RemoteView.CashShop;

using System.Runtime.InteropServices;
using MUnique.OpenMU.GameLogic.Views.CashShop;
using MUnique.OpenMU.Network.Packets.ServerToClient;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// The default implementation of the <see cref="CashShopScriptPlugIn"/> which is forwarding everything to the game client with specific data packets.
/// </summary>
[PlugIn("CashShopScriptPlugIn", "The default implementation of the ICashShopScriptPlugIn which is forwarding everything to the game client with specific data packets.")]
[Guid("D33C798F-E725-4326-AADA-5CB0B2909AAA")]
public class CashShopScriptPlugIn : ICashShopScriptPlugIn
{
    private readonly RemotePlayer _player;

    /// <summary>
    /// Initializes a new instance of the <see cref="CashShopScriptPlugIn"/> class.
    /// </summary>
    /// <param name="player">The player.</param>
    public CashShopScriptPlugIn(RemotePlayer player) => this._player = player;

    /// <inheritdoc/>
    public ValueTask CashShopScriptAsync(ushort zone, ushort year, ushort yearId)
    {
        return this._player.Connection.SendCashShopScriptAsync(zone, year, yearId);
    }
}