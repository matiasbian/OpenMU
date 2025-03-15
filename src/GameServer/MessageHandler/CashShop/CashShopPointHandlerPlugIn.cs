// <copyright file="CashShopPointHandlerPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.MessageHandler.CashShop;

using System.Runtime.InteropServices;
using MUnique.OpenMU.GameLogic;
using MUnique.OpenMU.GameLogic.PlayerActions.CashShop;
using MUnique.OpenMU.Network.Packets.ClientToServer;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Packet handler which gets the cash shop points (D2 01).
/// </summary>
[PlugIn("Cash Shop - Point", "Packet handler which gets the cash shop points (D2 01).")]
[Guid("359CFCBB-F05D-441D-92FE-6E98E38A21D3")]
[BelongsToGroup(CashShopGroup.GroupKey)]
internal class CashShopPointHandlerPlugIn : ISubPacketHandlerPlugIn
{
    private readonly CashShopPointAction _cashShopPointAction = new();

    /// <inheritdoc/>
    public bool IsEncryptionExpected => false;

    /// <inheritdoc/>
    public byte Key => CashShopPoint.SubCode;

    /// <inheritdoc/>
    public async ValueTask HandlePacketAsync(Player player, Memory<byte> packet)
    {
        await this._cashShopPointAction.GetPointAsync(player).ConfigureAwait(false);
    }
}