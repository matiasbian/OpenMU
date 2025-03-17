// <copyright file="CashShopStorageHandlerPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.MessageHandler.CashShop;

using System.Runtime.InteropServices;
using MUnique.OpenMU.GameLogic;
using MUnique.OpenMU.GameLogic.PlayerActions.CashShop;
using MUnique.OpenMU.Network.Packets.ClientToServer;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Packet handler which gets the cash shop storage info (D2 05).
/// </summary>
[PlugIn("Cash Shop - Storage", "Packet handler which gets the cash shop storage info (D2 05).")]
[Guid("8934F987-2606-40B3-A557-6CA49317E99F")]
[BelongsToGroup(CashShopGroup.GroupKey)]
internal class CashShopStorageHandlerPlugIn : ISubPacketHandlerPlugIn
{
    private readonly CashShopStorageAction _cashShopStorageAction = new();
    private readonly CashShopItemAction _cashShopItemAction = new();

    /// <inheritdoc/>
    public bool IsEncryptionExpected => false;

    /// <inheritdoc/>
    public byte Key => CashShopStorage.SubCode;

    /// <inheritdoc/>
    public async ValueTask HandlePacketAsync(Player player, Memory<byte> packet)
    {
        CashShopStorage message = packet;
        await this._cashShopStorageAction.GetStorageAsync(player, message.Page, ConvertStorageType(message.StorageType)).ConfigureAwait(false);
        await this._cashShopItemAction.GetItemAsync(player).ConfigureAwait(false);
    }

    private static GameLogic.PlayerActions.CashShop.StorageType ConvertStorageType(CashShopStorageType type)
    {
        return type switch
        {
            CashShopStorageType.SafeKeeping => GameLogic.PlayerActions.CashShop.StorageType.SafeKeeping,
            CashShopStorageType.PresentBox => GameLogic.PlayerActions.CashShop.StorageType.PresentBox,
            CashShopStorageType.Total => GameLogic.PlayerActions.CashShop.StorageType.Total,
            _ => throw new ArgumentOutOfRangeException(nameof(type)),
        };
    }
}