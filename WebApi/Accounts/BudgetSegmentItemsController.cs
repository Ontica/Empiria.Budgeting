/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                              Component : Web Api                               *
*  Assembly : Empiria.Budgeting.WebApi.dll                 Pattern   : Web api Controller                    *
*  Type     : BudgetSegmentItemsController                 License   : Please read LICENSE.txt file          *
*                                                                                                            *
*  Summary  : Web API used to retrive and update budget segment items.                                       *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System.Web.Http;

using Empiria.WebApi;

using Empiria.Budgeting.Adapters;
using Empiria.Budgeting.UseCases;

namespace Empiria.Budgeting.WebApi {

  /// <summary>Web API used to retrive and update budget segment items.</summary>
  public class BudgetSegmentItemsController : WebApiController {

    #region Web Apis

    [HttpGet]
    [Route("v2/budgeting/budget-segment-items/{segmentTypeUID}")]
    public CollectionModel GetBudgetSegmentItems([FromUri] string segmentTypeUID) {

      base.SetOperation($"Se leyeron los elementos de un segmento.");

      using (var usecases = BudgetSegmentItemsUseCases.UseCaseInteractor()) {
        FixedList<BudgetSegmentItemDto> segmentItems = usecases.BudgetSegmentItems(segmentTypeUID);

        return new CollectionModel(base.Request, segmentItems);
      }
    }

    #endregion Web Apis

  }  // class BudgetSegmentItemsController

}  // namespace Empiria.Budgeting.WebApi
