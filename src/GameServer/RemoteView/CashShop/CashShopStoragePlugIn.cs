// <copyright file="CashShopStoragePlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.RemoteView.CashShop;

using System.Runtime.InteropServices;
using MUnique.OpenMU.GameLogic.Views.CashShop;
using MUnique.OpenMU.Network.Packets.ServerToClient;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// The default implementation of the <see cref="CashShopStoragePlugIn"/> which is forwarding everything to the game client with specific data packets.
/// </summary>
[PlugIn("CashShopStoragePlugIn", "The default implementation of the ICashShopStoragePlugIn which is forwarding everything to the game client with specific data packets.")]
[Guid("70BD83B1-9C23-4205-A08F-2582DEBD877E")]
public class CashShopStoragePlugIn : ICashShopStoragePlugIn
{
    private readonly RemotePlayer _player;

    /// <summary>
    /// Initializes a new instance of the <see cref="CashShopStoragePlugIn"/> class.
    /// </summary>
    /// <param name="player">The player.</param>
    public CashShopStoragePlugIn(RemotePlayer player) => this._player = player;

    /// <inheritdoc/>
    public ValueTask CashShopStorageAsync(ushort totalItemCount, ushort currentItemCount, ushort pageIndex, ushort totalPage)
    {
        return this._player.Connection.SendCashShopStorageAsync(totalItemCount, currentItemCount, pageIndex, totalPage);
    }
}