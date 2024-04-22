/* Empiria Financial *****************************************************************************************
*                                                                                                            *
*  Module   : Budget Accounts                            Component : Domain Layer                            *
*  Assembly : Empiria.Budgeting.Core.dll                 Pattern   : Partitioned Type                        *
*  Type     : BudgetAccountSegment                       License   : Please read LICENSE.txt file            *
*                                                                                                            *
*  Summary  : Partitioned type that represents a budget account segment.                                     *
*                                                                                                            *
************************* Copyright(c) La Vía Óntica SC, Ontica LLC and contributors. All rights reserved. **/
using System;

using Empiria.Contacts;
using Empiria.Json;
using Empiria.Ontology;
using Empiria.StateEnums;

namespace Empiria.Budgeting {

  /// <summary>Partitioned type that represents a budget account segment.</summary>
  [PartitionedType(typeof(BudgetAccountSegmentType))]
  public class BudgetAccountSegment : BaseObject {

    #region Constructors and parsers

    protected BudgetAccountSegment(BudgetAccountSegmentType powertype) : base(powertype) {
      // Required by Empiria Framework for all partitioned types.
    }

    static public BudgetAccountSegment Parse(int id) => BaseObject.ParseId<BudgetAccountSegment>(id);

    static public BudgetAccountSegment Parse(string uid) => BaseObject.ParseKey<BudgetAccountSegment>(uid);

    static private BudgetAccountSegment Empty => BaseObject.ParseEmpty<BudgetAccountSegment>();

    #endregion Constructors and parsers

    #region Public properties

    public BudgetAccountSegmentType BudgetAccountSegmentType {
      get {
        return (BudgetAccountSegmentType) base.GetEmpiriaType();
      }
    }


    [DataField("BDG_ACCT_SEGMENT_CODE")]
    public string Code {
      get;
      private set;
    }


    [DataField("BDG_ACCT_SEGMENT_NAME")]
    public string Name {
      get;
      private set;
    }


    [DataField("BDG_ACCT_SEGMENT_DESCRIPTION")]
    public string Description {
      get;
      private set;
    }

    [DataField("BDG_ACCT_SEGMENT_EXT_DATA")]
    private JsonObject ExtData {
      get;
      set;
    } = new JsonObject();


    [DataField("BDG_ACCT_SEGMENT_START_DATE")]
    public DateTime StartDate {
      get;
      private set;
    }

    [DataField("BDG_ACCT_SEGMENT_END_DATE")]
    public DateTime EndDate {
      get;
      private set;
    }


    [DataField("BDG_ACCT_SEGMENT_EXT_OBJECT_REF_ID")]
    public int ExternalObjectReferenceId {
      get;
      private set;
    }


    internal protected virtual string Keywords {
      get {
        return EmpiriaString.BuildKeywords(this.Code, this.Name, this.Description);
      }
    }


    [DataField("BDG_ACCT_SEGMENT_POSTED_BY_ID")]
    public Person PostedById {
      get;
      private set;
    }


    [DataField("BDG_ACCT_SEGMENT_POSTING_TIME")]
    public DateTime PostingTime {
      get;
      private set;
    }


    [DataField("BDG_ACCT_SEGMENT_STATUS", Default = EntityStatus.Active)]
    public EntityStatus Status {
      get;
      private set;
    }

    #endregion Public properties

  } // class BudgetAccountSegment

} // namespace Empiria.Budgeting
