/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                            Component : Use cases Layer                         *
*  Assembly : Empiria.Budgeting.Core.dll                 Pattern   : Use case interactor class               *
*  Type     : BudgetAccountsUseCases                     License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Use cases for budget accounts searching and retriving.                                         *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Services;

namespace Empiria.Budgeting.UseCases {

  /// <summary>Use cases for budget accounts searching and retriving.</summary>
  public class BudgetAccountsUseCases : UseCase {

    #region Constructors and parsers

    protected BudgetAccountsUseCases() {
      // no-op
    }

    static public BudgetAccountsUseCases UseCaseInteractor() {
      return UseCase.CreateInstance<BudgetAccountsUseCases>();
    }

    #endregion Constructors and parsers

    #region Use cases

    public FixedList<NamedEntityDto> BudgetTypesList() {
      FixedList<BudgetType> budgetTypes = BudgetType.GetList();

      return budgetTypes.MapToNamedEntityList();
    }

    #endregion Use cases

  }  // class BudgetAccountsUseCases

}  // namespace Empiria.Budgeting.UseCases
