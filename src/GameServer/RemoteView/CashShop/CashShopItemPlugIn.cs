// <copyright file="CashShopItemPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.RemoteView.CashShop;

using System.Runtime.InteropServices;
using MUnique.OpenMU.GameLogic.Views.CashShop;
using MUnique.OpenMU.Network.Packets.ServerToClient;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// The default implementation of the <see cref="CashShopItemPlugIn"/> which is forwarding everything to the game client with specific data packets.
/// </summary>
[PlugIn("CashShopItemPlugIn", "The default implementation of the ICashShopItemPlugIn which is forwarding everything to the game client with specific data packets.")]
[Guid("FC105264-BC5E-43A3-9C8F-DABCA129BCB0")]
public class CashShopItemPlugIn : ICashShopItemPlugIn
{
    private readonly RemotePlayer _player;

    /// <summary>
    /// Initializes a new instance of the <see cref="CashShopItemPlugIn"/> class.
    /// </summary>
    /// <param name="player">The player.</param>
    public CashShopItemPlugIn(RemotePlayer player) => this._player = player;

    /// <inheritdoc/>
    public ValueTask CashShopItemAsync(uint storageIndex, uint itemSeq, uint storageGroupCode, uint productSeq, uint priceSeq, ulong cashPoint, byte itemType)
    {
        return this._player.Connection.SendCashShopItemAsync(storageIndex, itemSeq, storageGroupCode, productSeq, priceSeq, cashPoint, itemType);
    }
}