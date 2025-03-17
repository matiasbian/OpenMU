namespace MUnique.OpenMU.CashShopServer;

using MUnique.OpenMU.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

/// <summary>
/// The cash shop server which.
/// </summary>
public class CashShopServer : ICashShopServer
{
    private readonly ILogger<CashShopServer> _logger;
    private readonly ICashShopNotifier _cashShopNotifier;

    /// <summary>
    /// Initializes a new instance of the <see cref="CashShopServer" /> class.
    /// </summary>
    /// <param name="cashShopNotifier">The cash shop notifier.</param>
    /// <param name="logger">The logger.</param>
    public CashShopServer(ICashShopNotifier cashShopNotifier, ILogger<CashShopServer> logger)
    {
        this._cashShopNotifier = cashShopNotifier;
        this._logger = logger;
    }

    /// <remarks>Note, that the ServerId is not filled by this implementation. The player will receive it separately when the subscription is created.</remarks>
    /// <inheritdoc/>
    public async ValueTask PlayerEnteredGameAsync(byte serverId, Guid characterId, string characterName)
    {
        try
        {
            await this._cashShopNotifier.InitializeCashShopAsync(serverId, characterName).ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            this._logger.LogError(ex, "Unexpected error when notifying about cash shop initialization. Server id {serverId}, CharacterId {characterId}, CharacterName '{characterName}'.", serverId, characterId, characterName);
        }
    }
}