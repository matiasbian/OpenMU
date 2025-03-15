﻿// <copyright file="ICashShopInitPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.Views.CashShop;

/// <summary>
/// Interface of a view whose implementation informs about the init the cash shop.
/// </summary>
public interface ICashShopInitPlugIn : IViewPlugIn
{
    /// <summary>
    /// Init cash shop.
    /// </summary>
    ValueTask CashShopInitAsync();
}