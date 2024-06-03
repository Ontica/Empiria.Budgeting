/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Procesess                           Component : Domain Layer                            *
*  Assembly : Empiria.Budgeting.Processes.dll            Pattern   : Infomation Holder                       *
*  Type     : BudgetingRequest                           License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Represents a budgeting request.                                                                *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Parties;

using Empiria.OnePoint.Requests;
using Empiria.OnePoint.Requests.Adapters;

namespace Empiria.Budgeting.Processes {

  /// <summary>Represents a budgeting request.</summary>
  public class BudgetingRequest : Request {

    protected BudgetingRequest(RequestType powertype) : base(powertype) {
      // Required by Empiria Framework for all partitioned types.
    }

    #region Properties

    public Budget Budget {
      get {
        return base.ExtensionData.Get<Budget>("budgetId");
      }
      private set {
        base.ExtensionData.Set("budgetId", value.Id);
      }
    }

    #endregion Properties

    protected override void Update(RequestFieldsDto fields) {
      base.Update(fields);

      this.UniqueID = $"GPCP-{DateTime.Today.Year}-00001";
      this.ControlID = $"{DateTime.Today.Year}-00001";
      this.Budget = Budget.Parse(fields.RequestTypeFields.Find(x => x.Field == "budget").Value);
      this.Requester = Person.Parse(ExecutionServer.CurrentUserId);
      this.RequesterName = this.Requester.Name;
      this.Description = this.RequestType.DisplayName;
    }

  }  // class BudgetingRequest

}  // namespace Empiria.Budgeting.Processes
