// <copyright file="CashShopBannerPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.RemoteView.CashShop;

using System.Runtime.InteropServices;
using MUnique.OpenMU.GameLogic.Views.CashShop;
using MUnique.OpenMU.Network.Packets.ServerToClient;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// The default implementation of the <see cref="CashShopBannerPlugIn"/> which is forwarding everything to the game client with specific data packets.
/// </summary>
[PlugIn("CashShopBannerPlugIn", "The default implementation of the ICashShopBannerPlugIn which is forwarding everything to the game client with specific data packets.")]
[Guid("22D08324-9413-4D08-A9A1-AC4529F7ABD7")]
public class CashShopBannerPlugIn : ICashShopBannerPlugIn
{
    private readonly RemotePlayer _player;

    /// <summary>
    /// Initializes a new instance of the <see cref="CashShopBannerPlugIn"/> class.
    /// </summary>
    /// <param name="player">The player.</param>
    public CashShopBannerPlugIn(RemotePlayer player) => this._player = player;

    /// <inheritdoc/>
    public ValueTask CashShopBannerAsync(ushort zone, ushort year, ushort yearId)
    {
        return this._player.Connection.SendCashShopBannerAsync(zone, year, yearId);
    }
}