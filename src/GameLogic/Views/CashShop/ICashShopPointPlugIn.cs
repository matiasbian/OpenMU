// <copyright file="ICashShopPointPlugIn.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

namespace MUnique.OpenMU.GameLogic.Views.CashShop;

/// <summary>
/// Interface of a view whose implementation informs about the get cash shop points.
/// </summary>
public interface ICashShopPointPlugIn : IViewPlugIn
{
    /// <summary>
    /// Get cash shop points.
    /// </summary>
    /// <param name="viewType">The view type.</param>
    /// <param name="totalCash">The total cash.</param>
    /// <param name="cashCredit">The cash credit.</param>
    /// <param name="cashPrepaid">The cash prepaid.</param>
    /// <param name="totalPoint">The total point.</param>
    /// <param name="totalMileage">The total mileage.</param>
    ValueTask CashShopPointAsync(byte viewType, double totalCash, double cashCredit, double cashPrepaid, double totalPoint, double totalMileage);
}