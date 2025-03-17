﻿// <copyright file="CashShopOpenHandlerPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.MessageHandler.CashShop;

using System.Runtime.InteropServices;
using MUnique.OpenMU.GameLogic;
using MUnique.OpenMU.GameLogic.PlayerActions.CashShop;
using MUnique.OpenMU.Network.Packets.ClientToServer;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Packet handler which opens the cash shop (D2 02).
/// </summary>
[PlugIn("Cash Shop - Open", "Packet handler which opens the cash shop (D2 02).")]
[Guid("2EE11F01-9590-49A8-88FD-410404DE9AB7")]
[BelongsToGroup(CashShopGroup.GroupKey)]
internal class CashShopOpenHandlerPlugIn : ISubPacketHandlerPlugIn
{
    private readonly CashShopOpenAction _cashShopOpenAction = new();

    /// <inheritdoc/>
    public bool IsEncryptionExpected => false;

    /// <inheritdoc/>
    public byte Key => CashShopOpen.SubCode;

    /// <inheritdoc/>
    public async ValueTask HandlePacketAsync(Player player, Memory<byte> packet)
    {
        await this._cashShopOpenAction.OpenAsync(player).ConfigureAwait(false);
    }
}