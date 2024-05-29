/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Explorer                            Component : Adapters Layer                          *
*  Assembly : Empiria.Budgeting.Explorer.dll             Pattern   : Output DTO                              *
*  Type     : BudgetExplorerResultDto                    License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Output DTO with budget information.                                                            *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

namespace Empiria.Budgeting.Adapters {

  /// <summary>Output DTO with budget information.</summary>
  public class BudgetExplorerResultDto {

    public BudgetExplorerQuery Query {
      get; internal set;
    }

    //public FixedList<DataTableColumn> Columns {
    //  get; internal set;
    //}

    //public FixedList<DynamicFinancialReportEntryDto> Entries {
    //  get; internal set;
    //} = new FixedList<DynamicFinancialReportEntryDto>();


  }  // class BudgetExplorerResultDto

}  // namespace Empiria.Budgeting.Adapters
