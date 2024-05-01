/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                            Component : Data Layer                              *
*  Assembly : Empiria.Budgeting.Core.dll                 Pattern   : Data Service                            *
*  Type     : BudgetSegmentItemsDataService              License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Provides data access services for budget segment items.                                        *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Data;

namespace Empiria.Budgeting.Data {

  /// <summary>Provides data access services for budget segment items.</summary>
  static internal class BudgetSegmentItemsDataService {

    static internal FixedList<BudgetSegmentItem> SegmentItems(BudgetSegmentType segmentType) {
      var sql = "SELECT * FROM BDG_SEGMENT_ITEMS " +
                $"WHERE BDG_SEGMENT_TYPE_ID = {segmentType.Id} " +
                $"ORDER BY BDG_SEGMENT_ITEM_CODE";

      var dataOperation = DataOperation.Parse(sql);

      return DataReader.GetFixedList<BudgetSegmentItem>(dataOperation);
    }

  }  // class BudgetSegmentItemsDataService

}  // namespace Empiria.Budgeting.Data
