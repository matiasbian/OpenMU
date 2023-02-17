// <copyright file="CashShopGroup.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameServer.MessageHandler.CashShop;

using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using MUnique.OpenMU.PlugIns;

/// <summary>
/// Packet group handler for cash shop packets (0xD2).
/// </summary>
[PlugIn("Cash Shop Group", "Packet group handler for cash shop packets (0xD2).")]
[Guid("C1F06E6C-EDED-4240-B849-B4C0FCA63EFF")]
internal class CashShopGroup : GroupPacketHandlerPlugIn
{
    /// <summary>
    /// The group key.
    /// </summary>
    internal const byte GroupKey = 0xD2;

    /// <summary>
    /// Initializes a new instance of the <see cref="CashShopGroup" /> class.
    /// </summary>
    /// <param name="clientVersionProvider">The client version provider.</param>
    /// <param name="manager">The manager.</param>
    /// <param name="loggerFactory">The logger factory.</param>
    public CashShopGroup(IClientVersionProvider clientVersionProvider, PlugInManager manager, ILoggerFactory loggerFactory)
        : base(clientVersionProvider, manager, loggerFactory)
    {
    }

    /// <inheritdoc />
    public override byte Key => GroupKey;

    /// <inheritdoc />
    public override bool IsEncryptionExpected => false;
}