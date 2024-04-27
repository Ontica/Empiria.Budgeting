/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                            Component : Domain Layer                            *
*  Assembly : Empiria.Budgeting.Core.dll                 Pattern   : Partitioned Type                        *
*  Type     : BudgetSegment                              License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Partitioned type of BudgetSegmentType that represents a budget segment. Budget segments can    *
*             be functional or administrative areas, development programs, projects of any kind, budget      *
*             concepts or units, activities, financial sources, geographic regions, etcetera.                *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Contacts;
using Empiria.Json;
using Empiria.Ontology;
using Empiria.StateEnums;

namespace Empiria.Budgeting {

  /// <summary>Partitioned type of BudgetSegmentType that represents a budget segment. Budget segments
  /// can be functional or administrative areas, development programs, projects of any kind, budget
  /// concepts or units, activities, financial sources, geographic regions, etcetera.</summary>
  [PartitionedType(typeof(BudgetSegmentType))]
  public class BudgetSegment : BaseObject {

    #region Constructors and parsers

    protected BudgetSegment(BudgetSegmentType powertype) : base(powertype) {
      // Required by Empiria Framework for all partitioned types.
    }

    static public BudgetSegment Parse(int id) => BaseObject.ParseId<BudgetSegment>(id);

    static public BudgetSegment Parse(string uid) => BaseObject.ParseKey<BudgetSegment>(uid);

    static public BudgetSegment Empty => BaseObject.ParseEmpty<BudgetSegment>();

    #endregion Constructors and parsers

    #region Properties

    public BudgetSegmentType BudgetSegmentType {
      get {
        return (BudgetSegmentType) base.GetEmpiriaType();
      }
    }


    [DataField("BDG_SEGMENT_CODE")]
    public string Code {
      get; private set;
    }


    [DataField("BDG_SEGMENT_NAME")]
    public string Name {
      get; private set;
    }


    [DataField("BDG_SEGMENT_DESCRIPTION")]
    public string Description {
      get; private set;
    }


    [DataField("BDG_SEGMENT_EXT_DATA")]
    private JsonObject ExtData {
      get; set;
    } = new JsonObject();


    [DataField("BDG_SEGMENT_START_DATE")]
    public DateTime StartDate {
      get; private set;
    }


    [DataField("BDG_SEGMENT_END_DATE")]
    public DateTime EndDate {
      get; private set;
    }


    [DataField("BDG_SEGMENT_EXT_OBJECT_REF_ID")]
    public int ExternalObjectReferenceId {
      get; private set;
    }


    internal protected virtual string Keywords {
      get {
        return EmpiriaString.BuildKeywords(this.Code, this.Name, this.Description);
      }
    }


    [DataField("BDG_SEGMENT_POSTED_BY_ID")]
    public Person PostedById {
      get; private set;
    }


    [DataField("BDG_SEGMENT_POSTING_TIME")]
    public DateTime PostingTime {
      get; private set;
    }


    [DataField("BDG_SEGMENT_STATUS", Default = EntityStatus.Active)]
    public EntityStatus Status {
      get; private set;
    }

    #endregion Properties

  } // class BudgetSegment

} // namespace Empiria.Budgeting
