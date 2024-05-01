/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                            Component : Adapters Layer                          *
*  Assembly : Empiria.Budgeting.Core.dll                 Pattern   : Mapping class                           *
*  Type     : BudgetSegmentItemMapper                    License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Mapping methods for budget segment items.                                                      *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

namespace Empiria.Budgeting.Adapters {

  /// <summary>Mapping methods for budget segment items.</summary>
  static internal class BudgetSegmentItemMapper {

    static internal FixedList<BudgetSegmentItemDto> Map(FixedList<BudgetSegmentItem> segmentValues) {
      return segmentValues.Select(x => Map(x)).ToFixedList();
    }

    static private BudgetSegmentItemDto Map(BudgetSegmentItem segmentValue) {
      return new BudgetSegmentItemDto {
        UID = segmentValue.UID,
        Code = segmentValue.Code,
        Name = segmentValue.Name,
        Description = segmentValue.Description
      };
    }
  }  // class BudgetSegmentItemMapper

}  // namespace Empiria.Budgeting.Adapters
