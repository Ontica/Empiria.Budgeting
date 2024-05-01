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
        UID = budgetType.Name,
        Name = budgetType.DisplayName,
        SegmentTypes = Map(budgetType.SegmentTypes)
      };
    }

    #region Helpers

    static private FixedList<BudgetSegmentTypeDto> Map(FixedList<BudgetSegmentType> segmentTypes) {
      return segmentTypes.Select(x => Map(x)).ToFixedList();
    }


    static private BudgetSegmentTypeDto Map(BudgetSegmentType segmentType) {
      var dto = MapWithoutStructure(segmentType);

      if (!segmentType.ParentSegmentType.IsEmptyInstance) {
        dto.ParentSegmentType = MapWithoutStructure(segmentType.ParentSegmentType);
        dto.ParentSegmentType.Name = segmentType.ParentSegmentType.AsParentName;
      }

      if (!segmentType.ChildrenSegmentType.IsEmptyInstance) {
        dto.ChildrenSegmentType = MapWithoutStructure(segmentType.ChildrenSegmentType);
        dto.ChildrenSegmentType.Name = segmentType.ChildrenSegmentType.AsChildrenName;
      }

      return dto;
    }

    static internal BudgetSegmentTypeDto MapWithoutStructure(BudgetSegmentType segmentType) {
      return new BudgetSegmentTypeDto {
        UID = segmentType.UID,
        Name = segmentType.DisplayName
      };
    }

    #endregion Helpers

  }  // class BudgetTypesMapper

}  // namespace Empiria.Budgeting.Adapters
