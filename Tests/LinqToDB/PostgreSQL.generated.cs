﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;

using LinqToDB;
using LinqToDB.Mapping;

namespace PostreSQLDataContext
{
	/// <summary>
	/// Database       : TestData
	/// Data Source    : DBHost
	/// Server Version : 9.2.1
	/// </summary>
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<_testsamename>      _testsamename        { get { return this.GetTable<_testsamename>(); } }
		public ITable<alltype>            alltypes             { get { return this.GetTable<alltype>(); } }
		public ITable<Child>              Children             { get { return this.GetTable<Child>(); } }
		public ITable<Doctor>             Doctors              { get { return this.GetTable<Doctor>(); } }
		public ITable<entity>             entities             { get { return this.GetTable<entity>(); } }
		public ITable<GrandChild>         GrandChildren        { get { return this.GetTable<GrandChild>(); } }
		public ITable<LinqDataType>       LinqDataTypes        { get { return this.GetTable<LinqDataType>(); } }
		public ITable<Parent>             Parents              { get { return this.GetTable<Parent>(); } }
		public ITable<Patient>            Patients             { get { return this.GetTable<Patient>(); } }
		public ITable<Person>             People               { get { return this.GetTable<Person>(); } }
		public ITable<SequenceTest1>      SequenceTest1        { get { return this.GetTable<SequenceTest1>(); } }
		public ITable<SequenceTest2>      SequenceTest2        { get { return this.GetTable<SequenceTest2>(); } }
		public ITable<SequenceTest3>      SequenceTest3        { get { return this.GetTable<SequenceTest3>(); } }
		public ITable<TestIdentity>       TestIdentities       { get { return this.GetTable<TestIdentity>(); } }
		public ITable<testsamename>       testsamenames        { get { return this.GetTable<testsamename>(); } }
		public ITable<TestSchemaIdentity> TestSchemaIdentities { get { return this.GetTable<TestSchemaIdentity>(); } }
		public ITable<testserialidentity> testserialidentities { get { return this.GetTable<testserialidentity>(); } }
		public ITable<TestTable2>         TestTable2           { get { return this.GetTable<TestTable2>(); } }
		public ITable<TestTable3>         TestTable3           { get { return this.GetTable<TestTable3>(); } }

		public TestDataDB()
		{
			InitDataContext();
		}

		public TestDataDB(string configuration)
			: base(configuration)
		{
			InitDataContext();
		}

		partial void InitDataContext();
	}

	[Table(Schema="public", Name="testsamename")]
	public partial class _testsamename
	{
		[PrimaryKey, Identity] public int id { get; set; } // integer
	}

	[Table(Schema="public", Name="alltypes")]
	public partial class alltype
	{
		[PrimaryKey, Identity] public int             id                  { get; set; } // integer
		[Column,     Nullable] public long?           bigintdatatype      { get; set; } // bigint
		[Column,     Nullable] public decimal?        numericdatatype     { get; set; } // numeric
		[Column,     Nullable] public short?          smallintdatatype    { get; set; } // smallint
		[Column,     Nullable] public int?            intdatatype         { get; set; } // integer
		[Column,     Nullable] public decimal?        moneydatatype       { get; set; } // money
		[Column,     Nullable] public double?         doubledatatype      { get; set; } // double precision
		[Column,     Nullable] public float?          realdatatype        { get; set; } // real
		[Column,     Nullable] public DateTime?       timestampdatatype   { get; set; } // timestamp (6) without time zone
		[Column,     Nullable] public DateTimeOffset? timestamptzdatatype { get; set; } // timestamp (6) with time zone
		[Column,     Nullable] public DateTime?       datedatatype        { get; set; } // date
		[Column,     Nullable] public object          timedatatype        { get; set; } // time without time zone(6)
		[Column,     Nullable] public object          timetzdatatype      { get; set; } // time with time zone(6)
		[Column,     Nullable] public object          intervaldatatype    { get; set; } // interval(6)
		[Column,     Nullable] public char?           chardatatype        { get; set; } // character(1)
		[Column,     Nullable] public string          varchardatatype     { get; set; } // character varying(20)
		[Column,     Nullable] public string          textdatatype        { get; set; } // text
		[Column,     Nullable] public byte[]          binarydatatype      { get; set; } // bytea
		[Column,     Nullable] public Guid?           uuiddatatype        { get; set; } // uuid
		[Column,     Nullable] public object          bitdatatype         { get; set; } // bit(3)
		[Column,     Nullable] public bool?           booleandatatype     { get; set; } // boolean
		[Column,     Nullable] public object          colordatatype       { get; set; } // USER-DEFINED
		[Column,     Nullable] public object          pointdatatype       { get; set; } // point
		[Column,     Nullable] public object          lsegdatatype        { get; set; } // lseg
		[Column,     Nullable] public object          boxdatatype         { get; set; } // box
		[Column,     Nullable] public object          pathdatatype        { get; set; } // path
		[Column,     Nullable] public object          polygondatatype     { get; set; } // polygon
		[Column,     Nullable] public object          circledatatype      { get; set; } // circle
		[Column,     Nullable] public object          inetdatatype        { get; set; } // inet
		[Column,     Nullable] public object          macaddrdatatype     { get; set; } // macaddr
		[Column,     Nullable] public string          xmldatatype         { get; set; } // xml
	}

	[Table(Schema="public", Name="Child")]
	public partial class Child
	{
		[Column, Nullable] public int? ParentID { get; set; } // integer
		[Column, Nullable] public int? ChildID  { get; set; } // integer
	}

	[Table(Schema="public", Name="Doctor")]
	public partial class Doctor
	{
		[Column, NotNull] public int    PersonID { get; set; } // integer
		[Column, NotNull] public string Taxonomy { get; set; } // character varying(50)

		#region Associations

		/// <summary>
		/// Doctor_PersonID_fkey
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, KeyName="Doctor_PersonID_fkey", BackReferenceName="DoctorPersonIDfkeys")]
		public Person PersonIDfkey { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="entity")]
	public partial class entity
	{
		[Column, NotNull] public string the_name { get; set; } // character varying(255)
	}

	[Table(Schema="public", Name="GrandChild")]
	public partial class GrandChild
	{
		[Column, Nullable] public int? ParentID     { get; set; } // integer
		[Column, Nullable] public int? ChildID      { get; set; } // integer
		[Column, Nullable] public int? GrandChildID { get; set; } // integer
	}

	[Table(Schema="public", Name="LinqDataTypes")]
	public partial class LinqDataType
	{
		[Column, Nullable] public int?      ID             { get; set; } // integer
		[Column, Nullable] public decimal?  MoneyValue     { get; set; } // numeric(10,4)
		[Column, Nullable] public DateTime? DateTimeValue  { get; set; } // timestamp (6) without time zone
		[Column, Nullable] public DateTime? DateTimeValue2 { get; set; } // timestamp (6) without time zone
		[Column, Nullable] public bool?     BoolValue      { get; set; } // boolean
		[Column, Nullable] public Guid?     GuidValue      { get; set; } // uuid
		[Column, Nullable] public byte[]    BinaryValue    { get; set; } // bytea
		[Column, Nullable] public short?    SmallIntValue  { get; set; } // smallint
		[Column, Nullable] public int?      IntValue       { get; set; } // integer
		[Column, Nullable] public long?     BigIntValue    { get; set; } // bigint
	}

	[Table(Schema="public", Name="Parent")]
	public partial class Parent
	{
		[Column, Nullable] public int? ParentID { get; set; } // integer
		[Column, Nullable] public int? Value1   { get; set; } // integer
	}

	[Table(Schema="public", Name="Patient")]
	public partial class Patient
	{
		[Column, NotNull] public int    PersonID  { get; set; } // integer
		[Column, NotNull] public string Diagnosis { get; set; } // character varying(256)

		#region Associations

		/// <summary>
		/// Patient_PersonID_fkey
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=false, KeyName="Patient_PersonID_fkey", BackReferenceName="PatientPersonIDfkeys")]
		public Person PersonIDfkey { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="Person")]
	public partial class Person
	{
		[PrimaryKey, Identity   ] public int    PersonID   { get; set; } // integer
		[Column,     NotNull    ] public string FirstName  { get; set; } // character varying(50)
		[Column,     NotNull    ] public string LastName   { get; set; } // character varying(50)
		[Column,        Nullable] public string MiddleName { get; set; } // character varying(50)
		[Column,     NotNull    ] public char   Gender     { get; set; } // character(1)

		#region Associations

		/// <summary>
		/// Doctor_PersonID_fkey_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Doctor> DoctorPersonIDfkeys { get; set; }

		/// <summary>
		/// Patient_PersonID_fkey_BackReference
		/// </summary>
		[Association(ThisKey="PersonID", OtherKey="PersonID", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<Patient> PatientPersonIDfkeys { get; set; }

		#endregion
	}

	[Table(Schema="public", Name="SequenceTest1")]
	public partial class SequenceTest1
	{
		[PrimaryKey, NotNull    ] public int    ID    { get; set; } // integer
		[Column,        Nullable] public string Value { get; set; } // character varying(50)
	}

	[Table(Schema="public", Name="SequenceTest2")]
	public partial class SequenceTest2
	{
		[PrimaryKey, Identity] public int    ID    { get; set; } // integer
		[Column,     Nullable] public string Value { get; set; } // character varying(50)
	}

	[Table(Schema="public", Name="SequenceTest3")]
	public partial class SequenceTest3
	{
		[PrimaryKey, Identity] public int    ID    { get; set; } // integer
		[Column,     Nullable] public string Value { get; set; } // character varying(50)
	}

	[Table(Schema="public", Name="TestIdentity")]
	public partial class TestIdentity
	{
		[PrimaryKey, Identity] public int ID { get; set; } // integer
	}

	[Table(Schema="test_schema", Name="testsamename")]
	public partial class testsamename
	{
		[PrimaryKey, Identity] public int id { get; set; } // integer
	}

	[Table(Schema="test_schema", Name="TestSchemaIdentity")]
	public partial class TestSchemaIdentity
	{
		[PrimaryKey, Identity] public int ID { get; set; } // integer
	}

	[Table(Schema="test_schema", Name="testserialidentity")]
	public partial class testserialidentity
	{
		[PrimaryKey, Identity] public int ID { get; set; } // integer
	}

	[Table(Schema="public", Name="TestTable2")]
	public partial class TestTable2
	{
		[PrimaryKey, Identity   ] public int       ID          { get; set; } // integer
		[Column,     NotNull    ] public string    Name        { get; set; } // character varying(50)
		[Column,        Nullable] public string    Description { get; set; } // character varying(250)
		[Column,        Nullable] public DateTime? CreatedOn   { get; set; } // timestamp (6) without time zone
	}

	[Table(Schema="public", Name="TestTable3")]
	public partial class TestTable3
	{
		[PrimaryKey, NotNull] public int    ID   { get; set; } // integer
		[Column,     NotNull] public string Name { get; set; } // character varying(50)
	}

	public static partial class TableExtensions
	{
		public static _testsamename Find(this ITable<_testsamename> table, int id)
		{
			return table.FirstOrDefault(t =>
				t.id == id);
		}

		public static alltype Find(this ITable<alltype> table, int id)
		{
			return table.FirstOrDefault(t =>
				t.id == id);
		}

		public static Person Find(this ITable<Person> table, int PersonID)
		{
			return table.FirstOrDefault(t =>
				t.PersonID == PersonID);
		}

		public static SequenceTest1 Find(this ITable<SequenceTest1> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static SequenceTest2 Find(this ITable<SequenceTest2> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static SequenceTest3 Find(this ITable<SequenceTest3> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestIdentity Find(this ITable<TestIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static testsamename Find(this ITable<testsamename> table, int id)
		{
			return table.FirstOrDefault(t =>
				t.id == id);
		}

		public static TestSchemaIdentity Find(this ITable<TestSchemaIdentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static testserialidentity Find(this ITable<testserialidentity> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestTable2 Find(this ITable<TestTable2> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TestTable3 Find(this ITable<TestTable3> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}
	}
}
