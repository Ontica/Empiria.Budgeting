/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                            Component : Domain Layer                            *
*  Assembly : Empiria.Budgeting.Core.dll                 Pattern   : Aggregate Root                          *
*  Type     : BudgetType                                 License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Represents a budget type and serves as an aggregate root for its accounts.                     *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

namespace Empiria.Budgeting {

  /// <summary>Represents a budget type and serves as an aggregate root for its accounts.</summary>
  public class BudgetType : GeneralObject {

    #region Constructors and parsers

    protected BudgetType() {
      // Required by Empiria Framework.
    }


    static public BudgetType Parse(int id) {
      return BaseObject.ParseId<BudgetType>(id);
    }


    static public BudgetType Parse(string uid) {
      return BaseObject.ParseKey<BudgetType>(uid);
    }


    static public FixedList<BudgetType> GetList() {
      return BaseObject.GetList<BudgetType>("ObjectName", "ObjectId DESC")
                       .FindAll(x => x.Status != StateEnums.EntityStatus.Deleted)
                       .ToFixedList();
    }


    static public BudgetType Empty => BaseObject.ParseEmpty<BudgetType>();


    #endregion Constructors and parsers

  }  // class BudgetType

}  // namespace Empiria.Budgeting
