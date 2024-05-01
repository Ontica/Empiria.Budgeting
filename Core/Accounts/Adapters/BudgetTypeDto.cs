/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                            Component : Adapters Layer                          *
*  Assembly : Empiria.Budgeting.Core.dll                 Pattern   : Output DTO                              *
*  Type     : BudgetTypeDto                              License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Output DTO for BudgetType instances.                                                           *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/

namespace Empiria.Budgeting.Adapters {

  /// <summary>Output DTO for BudgetType instances.</summary>
  public class BudgetTypeDto {

    public string UID {
      get; internal set;
    }

    public string Name {
      get; internal set;
    }

    public FixedList<BudgetSegmentTypeDto> SegmentTypes {
      get; internal set;
    }

  }  // class BudgetTypeDto



  /// <summary>Output DTO for BudgetSegmentType instances.</summary>
  public class BudgetSegmentTypeDto {

    public string UID {
      get; internal set;
    }

    public string Name {
      get; internal set;
    }

    public BudgetSegmentTypeDto ParentSegmentType {
      get; internal set;
    }

    public BudgetSegmentTypeDto ChildrenSegmentType {
      get; internal set;
    }

  }  // class BudgetSegmentTypeDto

}  // namespace Empiria.Budgeting.Adapters
