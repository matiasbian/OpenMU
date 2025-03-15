// <copyright file="CashShopPointPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.RemoteView.CashShop;

using System.Runtime.InteropServices;
using MUnique.OpenMU.GameLogic.Views.CashShop;
using MUnique.OpenMU.Network.Packets.ServerToClient;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// The default implementation of the <see cref="ICashShopPointPlugIn"/> which is forwarding everything to the game client with specific data packets.
/// </summary>
[PlugIn("CashShopPointPlugIn", "The default implementation of the ICashShopPointPlugIn which is forwarding everything to the game client with specific data packets.")]
[Guid("FB2D5D76-9BD1-446F-B369-A6C2414BE3AC")]
public class CashShopPointPlugIn : ICashShopPointPlugIn
{
    private readonly RemotePlayer _player;

    /// <summary>
    /// Initializes a new instance of the <see cref="CashShopPointPlugIn"/> class.
    /// </summary>
    /// <param name="player">The player.</param>
    public CashShopPointPlugIn(RemotePlayer player) => this._player = player;

    /// <inheritdoc/>
    public ValueTask CashShopPointAsync(byte viewType, double totalCash, double cashCredit, double cashPrepaid, double totalPoint, double totalMileage)
    {
        return this._player.Connection.SendCashShopPointAsync(viewType, totalCash, cashCredit, cashPrepaid, totalPoint, totalMileage);
    }
}