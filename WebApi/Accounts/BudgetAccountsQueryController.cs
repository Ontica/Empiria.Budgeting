/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                              Component : Web Api                               *
*  Assembly : Empiria.Budgeting.WebApi.dll                 Pattern   : Query Controller                      *
*  Type     : BudgetAccountsQueryController                License   : Please read LICENSE.txt file          *
*                                                                                                            *
*  Summary  : Query web API used to retrive budget accounts.                                                 *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System.Web.Http;

using Empiria.WebApi;

using Empiria.Budgeting.UseCases;

namespace Empiria.Budgeting.WebApi {

  /// <summary>Query web API used to retrive budget accounts.</summary>
  public class BudgetAccountsQueryController : WebApiController {

    #region Web Apis

    [HttpGet]
    [Route("v2/budgeting/budget-types")]
    public CollectionModel GetBudgetTypes() {

      base.SetOperation($"Se leyó la lista de tipos de presupuestos.");

      using (var usecases = BudgetAccountsUseCases.UseCaseInteractor()) {
        FixedList<NamedEntityDto> list = usecases.BudgetTypesList();

        return new CollectionModel(base.Request, list);
      }
    }


    #endregion Web Apis

  }  // class BudgetAccountsQueryController

}  // namespace Empiria.Budgeting.WebApi
