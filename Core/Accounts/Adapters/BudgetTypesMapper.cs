/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                            Component : Adapters Layer                          *
*  Assembly : Empiria.Budgeting.Core.dll                 Pattern   : Mapping class                           *
*  Type     : BudgetTypesMapper                          License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Maps BudgetType instances to data transfer objects.                                            *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

namespace Empiria.Budgeting.Adapters {

  /// <summary>Maps BudgetType instances to data transfer objects.</summary>
  static internal class BudgetTypesMapper {

    static internal FixedList<BudgetTypeDto> Map(FixedList<BudgetType> budgetTypes) {
      return budgetTypes.Select(x => Map(x)).ToFixedList();
    }

    static internal BudgetTypeDto Map(BudgetType budgetType) {
      return new BudgetTypeDto {
        UID = budgetType.UID,
        Name = budgetType.Name,
        SegmentTypes = Map(budgetType.SegmentTypes)
      };
    }

    #region Helpers

    static private FixedList<BudgetSegmentTypeDto> Map(FixedList<BudgetSegmentType> segmentTypes) {
      return segmentTypes.Select(x => Map(x)).ToFixedList();
    }


    static private BudgetSegmentTypeDto Map(BudgetSegmentType segmentType) {
      return new BudgetSegmentTypeDto {
        UID = segmentType.UID,
        Name = segmentType.DisplayName
      };
    }

    #endregion Helpers

  }  // class BudgetTypesMapper

}  // namespace Empiria.Budgeting.Adapters
