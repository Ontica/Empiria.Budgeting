/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Accounts Chart                             Component : Test cases                              *
*  Assembly : Empiria.FinancialAccounting.Tests.dll      Pattern   : Use cases tests                         *
*  Type     : AccountsChartUseCasesTests                 License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Test cases for retrieving accounts from the accounts chart.                                    *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using Xunit;

using Empiria.Budgeting.Transactions;

namespace Empiria.Tests.Budgeting.Transactions {

  /// <summary>Test cases for retrieving accounts from the accounts chart.</summary>
  public class BudgetTransactionTypeTests {

    #region Facts

    [Fact]
    public void Should_Read_Empty_Budget_TransactionType() {
      var sut = BudgetTransactionType.Empty;

      Assert.NotNull(sut);
    }


    [Fact]
    public void Should_Read_All_Budget_Transaction_Types() {
      var sut = BaseObject.GetList<BudgetTransactionType>();

      Assert.NotNull(sut);
      Assert.NotEmpty(sut);
    }

    #endregion Facts

  }  // class BudgetTransactionTypeTests

}  // namespace Empiria.Tests.Budgeting.Transactions
