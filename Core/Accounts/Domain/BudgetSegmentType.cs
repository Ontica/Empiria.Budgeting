/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                            Component : Domain Layer                            *
*  Assembly : Empiria.Budgeting.Core.dll                 Pattern   : Power type                              *
*  Type     : BudgetSegmentType                          License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Power type that describes a budget segment partitioned type.                                   *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Ontology;

namespace Empiria.Budgeting {

  /// <summary>Power type that describes a budget segment partitioned type.</summary>
  [Powertype(typeof(BudgetSegment))]
  public sealed class BudgetSegmentType : Powertype {

    #region Constructors and parsers

    private BudgetSegmentType() {
      // Empiria powertype types always have this constructor.
    }

    static public new BudgetSegmentType Parse(int typeId) {
      return ObjectTypeInfo.Parse<BudgetSegmentType>(typeId);
    }

    static public new BudgetSegmentType Parse(string typeName) {
      return BudgetAccountType.Parse<BudgetSegmentType>(typeName);
    }

    #endregion Constructors and parsers

  } // class BudgetSegmentType

} // namespace Empiria.Budgeting
