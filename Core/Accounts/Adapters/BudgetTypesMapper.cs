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

    static private BudgetTypeDto Map(BudgetType budgetType) {
      return new BudgetTypeDto {
        UID = budgetType.UID,
        Name = budgetType.Name,
        SegmentTypes = Map(budgetType.SegmentTypes)
      };
    }


    static private FixedList<BudgetAccountSegmentTypeDto> Map(FixedList<BudgetAccountSegmentType> segmentTypes) {
      return segmentTypes.Select(x => Map(x)).ToFixedList();
    }


    static private BudgetAccountSegmentTypeDto Map(BudgetAccountSegmentType segmentType) {
      return new BudgetAccountSegmentTypeDto {
        UID = segmentType.UID,
        Name = segmentType.DisplayName
      };
    }

  }  // class BudgetTypesMapper

}  // namespace Empiria.Budgeting.Adapters
