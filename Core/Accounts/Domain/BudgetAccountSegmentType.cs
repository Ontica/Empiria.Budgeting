/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                            Component : Domain Layer                            *
*  Assembly : Empiria.Budgeting.Core.dll                 Pattern   : Power type                              *
*  Type     : BudgetAccountSegmentType                   License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Power type that describes a budget account segment.                                            *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Ontology;

namespace Empiria.Budgeting {

  /// <summary>Power type that describes a budget account segment.</summary>
  [Powertype(typeof(BudgetAccountSegment))]
  public sealed class BudgetAccountSegmentType : Powertype {

    #region Constructors and parsers

    private BudgetAccountSegmentType() {
      // Empiria powertype types always have this constructor.
    }

    static public new BudgetAccountSegmentType Parse(int typeId) {
      return ObjectTypeInfo.Parse<BudgetAccountSegmentType>(typeId);
    }

    static public new BudgetAccountSegmentType Parse(string typeName) {
      return BudgetAccountType.Parse<BudgetAccountSegmentType>(typeName);
    }

    #endregion Constructors and parsers

  } // class BudgetAccountSegmentType

} // namespace Empiria.Budgeting
