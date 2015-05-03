﻿//---------------------------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated by T4Model template for T4 (https://github.com/linq2db/t4models).
//    Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//---------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using LinqToDB;
using LinqToDB.Common;
using LinqToDB.Data;
using LinqToDB.Mapping;

namespace FirebirdDataContext
{
	/// <summary>
	/// Database       : TestData
	/// Data Source    : DBHost
	/// Server Version : WI-V2.5.1.26351 Firebird 2.5
	/// </summary>
	public partial class TestDataDB : LinqToDB.Data.DataConnection
	{
		public ITable<ALLTYPE>       ALLTYPES       { get { return this.GetTable<ALLTYPE>(); } }
		public ITable<BINARYDATA>    BINARYDATAs    { get { return this.GetTable<BINARYDATA>(); } }
		public ITable<CamelCaseName> CamelCaseNames { get { return this.GetTable<CamelCaseName>(); } }
		public ITable<CHILD>         Children       { get { return this.GetTable<CHILD>(); } }
		public ITable<DATATYPETEST>  DATATYPETESTs  { get { return this.GetTable<DATATYPETEST>(); } }
		public ITable<DOCTOR>        DOCTORs        { get { return this.GetTable<DOCTOR>(); } }
		public ITable<DUAL>          DUALs          { get { return this.GetTable<DUAL>(); } }
		public ITable<GRANDCHILD>    GRANDCHILDs    { get { return this.GetTable<GRANDCHILD>(); } }
		public ITable<LINQDATATYPE>  LINQDATATYPES  { get { return this.GetTable<LINQDATATYPE>(); } }
		public ITable<PARENT>        PARENTs        { get { return this.GetTable<PARENT>(); } }
		public ITable<PATIENT>       PATIENTs       { get { return this.GetTable<PATIENT>(); } }
		public ITable<PERSON>        People         { get { return this.GetTable<PERSON>(); } }
		public ITable<PERSONVIEW>    PERSONVIEWs    { get { return this.GetTable<PERSONVIEW>(); } }
		public ITable<SEQUENCETEST>  SEQUENCETESTs  { get { return this.GetTable<SEQUENCETEST>(); } }
		public ITable<TESTIDENTITY>  TESTIDENTITies { get { return this.GetTable<TESTIDENTITY>(); } }
		public ITable<TESTTABLE2>    TESTTABLE2     { get { return this.GetTable<TESTTABLE2>(); } }
		public ITable<TESTTABLE3>    TESTTABLE3     { get { return this.GetTable<TESTTABLE3>(); } }

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

	[Table("ALLTYPES")]
	public partial class ALLTYPE
	{
		[Column(DbType="integer",         DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),            PrimaryKey,  NotNull] public int       ID                { get; set; } // integer
		[Column(DbType="bigint",          DataType=DataType.Int64,    Length=8, Precision=0, Scale=0),               Nullable         ] public long?     BIGINTDATATYPE    { get; set; } // bigint
		[Column(DbType="smallint",        DataType=DataType.Int16,    Length=2, Precision=0, Scale=0),               Nullable         ] public short?    SMALLINTDATATYPE  { get; set; } // smallint
		[Column(DbType="decimal(18,0)",   DataType=DataType.Decimal,  Length=8, Precision=18, Scale=0),              Nullable         ] public decimal?  DECIMALDATATYPE   { get; set; } // decimal(18,0)
		[Column(DbType="integer",         DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),               Nullable         ] public int?      INTDATATYPE       { get; set; } // integer
		[Column(DbType="float",           DataType=DataType.Single,   Length=4, Precision=0, Scale=0),               Nullable         ] public float?    FLOATDATATYPE     { get; set; } // float
		[Column(DbType="float",           DataType=DataType.Single,   Length=4, Precision=0, Scale=0),               Nullable         ] public float?    REALDATATYPE      { get; set; } // float
		[Column(DbType="timestamp",       DataType=DataType.DateTime, Length=8, Precision=0, Scale=0),               Nullable         ] public DateTime? TIMESTAMPDATATYPE { get; set; } // timestamp
		[Column(DbType="char(1)",         DataType=DataType.NChar,    Length=1, Precision=0, Scale=0),               Nullable         ] public char?     CHARDATATYPE      { get; set; } // char(1)
		[Column(DbType="varchar(20)",     DataType=DataType.NVarChar, Length=20, Precision=0, Scale=0),              Nullable         ] public string    VARCHARDATATYPE   { get; set; } // varchar(20)
		[Column(DbType="blob sub_type 1", DataType=DataType.Text,     Length=int.MaxValue, Precision=0, Scale=0),    Nullable         ] public string    TEXTDATATYPE      { get; set; } // blob sub_type 1
		[Column(DbType="char(20)",        DataType=DataType.NChar,    Length=20, Precision=0, Scale=0),              Nullable         ] public string    NCHARDATATYPE     { get; set; } // char(20)
		[Column(DbType="varchar(20)",     DataType=DataType.NVarChar, Length=20, Precision=0, Scale=0),              Nullable         ] public string    NVARCHARDATATYPE  { get; set; } // varchar(20)
		[Column(DbType="blob",            DataType=DataType.Blob,     Length=int.MaxValue, Precision=0, Scale=0),    Nullable         ] public byte[]    BLOBDATATYPE      { get; set; } // blob
	}

	[Table("BINARYDATA")]
	public partial class BINARYDATA
	{
		[Column(DbType="integer", DataType=DataType.Int32, Length=4, Precision=0, Scale=0),            PrimaryKey, NotNull] public int    BINARYDATAID { get; set; } // integer
		[Column(DbType="integer", DataType=DataType.Int32, Length=4, Precision=0, Scale=0),                        NotNull] public int    STAMP        { get; set; } // integer
		[Column(DbType="blob",    DataType=DataType.Blob,  Length=int.MaxValue, Precision=0, Scale=0),             NotNull] public byte[] DATA         { get; set; } // blob
	}

	[Table("\"CamelCaseName\"")]
	public partial class CamelCaseName
	{
		[Column("\"Id\"",     DbType="integer",     DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),  PrimaryKey,  NotNull] public int    Id     { get; set; } // integer
		[Column(              DbType="varchar(20)", DataType=DataType.NVarChar, Length=20, Precision=0, Scale=0),    Nullable         ] public string NAME1  { get; set; } // varchar(20)
		[Column("\"Name2\"",  DbType="varchar(20)", DataType=DataType.NVarChar, Length=20, Precision=0, Scale=0),    Nullable         ] public string Name2  { get; set; } // varchar(20)
		[Column(              DbType="varchar(20)", DataType=DataType.NVarChar, Length=20, Precision=0, Scale=0),    Nullable         ] public string NAME3  { get; set; } // varchar(20)
		[Column("\"_NAME4\"", DbType="varchar(20)", DataType=DataType.NVarChar, Length=20, Precision=0, Scale=0),    Nullable         ] public string _NAME4 { get; set; } // varchar(20)
		[Column("\"NAME 5\"", DbType="varchar(20)", DataType=DataType.NVarChar, Length=20, Precision=0, Scale=0),    Nullable         ] public string NAME5  { get; set; } // varchar(20)
	}

	[Table("CHILD")]
	public partial class CHILD
	{
		[Column(DbType="integer", DataType=DataType.Int32, Length=4, Precision=0, Scale=0), Nullable] public int? PARENTID { get; set; } // integer
		[Column(DbType="integer", DataType=DataType.Int32, Length=4, Precision=0, Scale=0), Nullable] public int? CHILDID  { get; set; } // integer
	}

	[Table("DATATYPETEST")]
	public partial class DATATYPETEST
	{
		[Column(DbType="integer",          DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),            PrimaryKey,  NotNull] public int       DATATYPEID { get; set; } // integer
		[Column(DbType="blob",             DataType=DataType.Blob,     Length=int.MaxValue, Precision=0, Scale=0),    Nullable         ] public byte[]    BINARY_    { get; set; } // blob
		[Column(DbType="char(1)",          DataType=DataType.NChar,    Length=1, Precision=0, Scale=0),               Nullable         ] public char?     BOOLEAN_   { get; set; } // char(1)
		[Column(DbType="smallint",         DataType=DataType.Int16,    Length=2, Precision=0, Scale=0),               Nullable         ] public short?    BYTE_      { get; set; } // smallint
		[Column(DbType="blob",             DataType=DataType.Blob,     Length=int.MaxValue, Precision=0, Scale=0),    Nullable         ] public byte[]    BYTES_     { get; set; } // blob
		[Column(DbType="char(1)",          DataType=DataType.NChar,    Length=1, Precision=0, Scale=0),               Nullable         ] public char?     CHAR_      { get; set; } // char(1)
		[Column(DbType="timestamp",        DataType=DataType.DateTime, Length=8, Precision=0, Scale=0),               Nullable         ] public DateTime? DATETIME_  { get; set; } // timestamp
		[Column(DbType="decimal(10,2)",    DataType=DataType.Decimal,  Length=8, Precision=10, Scale=2),              Nullable         ] public decimal?  DECIMAL_   { get; set; } // decimal(10,2)
		[Column(DbType="double precision", DataType=DataType.Double,   Length=8, Precision=0, Scale=0),               Nullable         ] public double?   DOUBLE_    { get; set; } // double precision
		[Column(DbType="char(38)",         DataType=DataType.NChar,    Length=38, Precision=0, Scale=0),              Nullable         ] public string    GUID_      { get; set; } // char(38)
		[Column(DbType="smallint",         DataType=DataType.Int16,    Length=2, Precision=0, Scale=0),               Nullable         ] public short?    INT16_     { get; set; } // smallint
		[Column(DbType="integer",          DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),               Nullable         ] public int?      INT32_     { get; set; } // integer
		[Column(DbType="numeric(11,0)",    DataType=DataType.Decimal,  Length=8, Precision=11, Scale=0),              Nullable         ] public decimal?  INT64_     { get; set; } // numeric(11,0)
		[Column(DbType="decimal(18,4)",    DataType=DataType.Decimal,  Length=8, Precision=18, Scale=4),              Nullable         ] public decimal?  MONEY_     { get; set; } // decimal(18,4)
		[Column(DbType="smallint",         DataType=DataType.Int16,    Length=2, Precision=0, Scale=0),               Nullable         ] public short?    SBYTE_     { get; set; } // smallint
		[Column(DbType="float",            DataType=DataType.Single,   Length=4, Precision=0, Scale=0),               Nullable         ] public float?    SINGLE_    { get; set; } // float
		[Column(DbType="blob",             DataType=DataType.Blob,     Length=int.MaxValue, Precision=0, Scale=0),    Nullable         ] public byte[]    STREAM_    { get; set; } // blob
		[Column(DbType="varchar(50)",      DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0),              Nullable         ] public string    STRING_    { get; set; } // varchar(50)
		[Column(DbType="smallint",         DataType=DataType.Int16,    Length=2, Precision=0, Scale=0),               Nullable         ] public short?    UINT16_    { get; set; } // smallint
		[Column(DbType="integer",          DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),               Nullable         ] public int?      UINT32_    { get; set; } // integer
		[Column(DbType="numeric(11,0)",    DataType=DataType.Decimal,  Length=8, Precision=11, Scale=0),              Nullable         ] public decimal?  UINT64_    { get; set; } // numeric(11,0)
		[Column(DbType="char(1000)",       DataType=DataType.NChar,    Length=1000, Precision=0, Scale=0),            Nullable         ] public string    XML_       { get; set; } // char(1000)
	}

	[Table("DOCTOR")]
	public partial class DOCTOR
	{
		[Column(DbType="integer",     DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),  NotNull] public int    PERSONID { get; set; } // integer
		[Column(DbType="varchar(50)", DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0), NotNull] public string TAXONOMY { get; set; } // varchar(50)

		#region Associations

		/// <summary>
		/// FK_DOCTOR_PERSON
		/// </summary>
		[Association(ThisKey="PERSONID", OtherKey="PERSONID", CanBeNull=false, KeyName="FK_DOCTOR_PERSON", BackReferenceName="DOCTORs")]
		public PERSON PERSON { get; set; }

		#endregion
	}

	[Table("DUAL")]
	public partial class DUAL
	{
		[Column(DbType="varchar(10)", DataType=DataType.NVarChar, Length=10, Precision=0, Scale=0), Nullable] public string DUMMY { get; set; } // varchar(10)
	}

	[Table("GRANDCHILD")]
	public partial class GRANDCHILD
	{
		[Column(DbType="integer", DataType=DataType.Int32, Length=4, Precision=0, Scale=0), Nullable] public int? PARENTID     { get; set; } // integer
		[Column(DbType="integer", DataType=DataType.Int32, Length=4, Precision=0, Scale=0), Nullable] public int? CHILDID      { get; set; } // integer
		[Column(DbType="integer", DataType=DataType.Int32, Length=4, Precision=0, Scale=0), Nullable] public int? GRANDCHILDID { get; set; } // integer
	}

	[Table("LINQDATATYPES")]
	public partial class LINQDATATYPE
	{
		[Column(DbType="integer",       DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),            Nullable] public int?      ID             { get; set; } // integer
		[Column(DbType="decimal(10,4)", DataType=DataType.Decimal,  Length=8, Precision=10, Scale=4),           Nullable] public decimal?  MONEYVALUE     { get; set; } // decimal(10,4)
		[Column(DbType="timestamp",     DataType=DataType.DateTime, Length=8, Precision=0, Scale=0),            Nullable] public DateTime? DATETIMEVALUE  { get; set; } // timestamp
		[Column(DbType="timestamp",     DataType=DataType.DateTime, Length=8, Precision=0, Scale=0),            Nullable] public DateTime? DATETIMEVALUE2 { get; set; } // timestamp
		[Column(DbType="char(1)",       DataType=DataType.NChar,    Length=1, Precision=0, Scale=0),            Nullable] public char?     BOOLVALUE      { get; set; } // char(1)
		[Column(DbType="char(38)",      DataType=DataType.NChar,    Length=38, Precision=0, Scale=0),           Nullable] public string    GUIDVALUE      { get; set; } // char(38)
		[Column(DbType="blob",          DataType=DataType.Blob,     Length=int.MaxValue, Precision=0, Scale=0), Nullable] public byte[]    BINARYVALUE    { get; set; } // blob
		[Column(DbType="smallint",      DataType=DataType.Int16,    Length=2, Precision=0, Scale=0),            Nullable] public short?    SMALLINTVALUE  { get; set; } // smallint
		[Column(DbType="integer",       DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),            Nullable] public int?      INTVALUE       { get; set; } // integer
		[Column(DbType="bigint",        DataType=DataType.Int64,    Length=8, Precision=0, Scale=0),            Nullable] public long?     BIGINTVALUE    { get; set; } // bigint
	}

	[Table("PARENT")]
	public partial class PARENT
	{
		[Column(DbType="integer", DataType=DataType.Int32, Length=4, Precision=0, Scale=0), Nullable] public int? PARENTID { get; set; } // integer
		[Column(DbType="integer", DataType=DataType.Int32, Length=4, Precision=0, Scale=0), Nullable] public int? VALUE1   { get; set; } // integer
	}

	[Table("PATIENT")]
	public partial class PATIENT
	{
		[Column(DbType="integer",      DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),   NotNull] public int    PERSONID  { get; set; } // integer
		[Column(DbType="varchar(256)", DataType=DataType.NVarChar, Length=256, Precision=0, Scale=0), NotNull] public string DIAGNOSIS { get; set; } // varchar(256)

		#region Associations

		/// <summary>
		/// INTEG_8798
		/// </summary>
		[Association(ThisKey="PERSONID", OtherKey="PERSONID", CanBeNull=false, KeyName="INTEG_8798", BackReferenceName="INTEG8798")]
		public PERSON INTEG8798 { get; set; }

		#endregion
	}

	[Table("PERSON")]
	public partial class PERSON
	{
		[Column(DbType="integer",     DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),  PrimaryKey,  NotNull] public int    PERSONID   { get; set; } // integer
		[Column(DbType="varchar(50)", DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0),              NotNull] public string FIRSTNAME  { get; set; } // varchar(50)
		[Column(DbType="varchar(50)", DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0),              NotNull] public string LASTNAME   { get; set; } // varchar(50)
		[Column(DbType="varchar(50)", DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0),    Nullable         ] public string MIDDLENAME { get; set; } // varchar(50)
		[Column(DbType="char(1)",     DataType=DataType.NChar,    Length=1, Precision=0, Scale=0),               NotNull] public char   GENDER     { get; set; } // char(1)

		#region Associations

		/// <summary>
		/// FK_DOCTOR_PERSON_BackReference
		/// </summary>
		[Association(ThisKey="PERSONID", OtherKey="PERSONID", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<DOCTOR> DOCTORs { get; set; }

		/// <summary>
		/// INTEG_8798_BackReference
		/// </summary>
		[Association(ThisKey="PERSONID", OtherKey="PERSONID", CanBeNull=true, IsBackReference=true)]
		public IEnumerable<PATIENT> INTEG8798 { get; set; }

		#endregion
	}

	// View
	[Table("PERSONVIEW")]
	public partial class PERSONVIEW
	{
		[Column(DbType="integer",     DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),  Nullable] public int?   PERSONID   { get; set; } // integer
		[Column(DbType="varchar(50)", DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0), Nullable] public string FIRSTNAME  { get; set; } // varchar(50)
		[Column(DbType="varchar(50)", DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0), Nullable] public string LASTNAME   { get; set; } // varchar(50)
		[Column(DbType="varchar(50)", DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0), Nullable] public string MIDDLENAME { get; set; } // varchar(50)
		[Column(DbType="char(1)",     DataType=DataType.NChar,    Length=1, Precision=0, Scale=0),  Nullable] public char?  GENDER     { get; set; } // char(1)
	}

	[Table("SEQUENCETEST")]
	public partial class SEQUENCETEST
	{
		[Column(DbType="integer",     DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),  PrimaryKey, NotNull] public int    ID     { get; set; } // integer
		[Column(DbType="varchar(50)", DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0),             NotNull] public string VALUE_ { get; set; } // varchar(50)
	}

	[Table("TESTIDENTITY")]
	public partial class TESTIDENTITY
	{
		[Column(DbType="integer", DataType=DataType.Int32, Length=4, Precision=0, Scale=0), PrimaryKey, NotNull] public int ID { get; set; } // integer
	}

	[Table("TESTTABLE2")]
	public partial class TESTTABLE2
	{
		[Column(DbType="integer",      DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),   PrimaryKey,  NotNull] public int       ID          { get; set; } // integer
		[Column(DbType="varchar(50)",  DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0),               NotNull] public string    NAME        { get; set; } // varchar(50)
		[Column(DbType="varchar(250)", DataType=DataType.NVarChar, Length=250, Precision=0, Scale=0),    Nullable         ] public string    DESCRIPTION { get; set; } // varchar(250)
		[Column(DbType="timestamp",    DataType=DataType.DateTime, Length=8, Precision=0, Scale=0),      Nullable         ] public DateTime? CREATEDON   { get; set; } // timestamp
	}

	[Table("TESTTABLE3")]
	public partial class TESTTABLE3
	{
		[Column(DbType="integer",     DataType=DataType.Int32,    Length=4, Precision=0, Scale=0),  PrimaryKey, NotNull] public int    ID   { get; set; } // integer
		[Column(DbType="varchar(50)", DataType=DataType.NVarChar, Length=50, Precision=0, Scale=0),             NotNull] public string NAME { get; set; } // varchar(50)
	}

	public static partial class TestDataDBStoredProcedures
	{
		#region OUTREFENUMTEST

		public partial class OUTREFENUMTESTResult
		{
			public string INPUTOUTPUTSTR { get; set; }
			public string OUTPUTSTR      { get; set; }
		}

		public static IEnumerable<OUTREFENUMTESTResult> OUTREFENUMTEST(this DataConnection dataConnection, string STR, string IN_INPUTOUTPUTSTR, out string INPUTOUTPUTSTR, out string OUTPUTSTR)
		{
			var ret = dataConnection.QueryProc<OUTREFENUMTESTResult>("OUTREFENUMTEST",
				new DataParameter("STR",               STR,               DataType.NVarChar),
				new DataParameter("IN_INPUTOUTPUTSTR", IN_INPUTOUTPUTSTR, DataType.NVarChar));

			INPUTOUTPUTSTR = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["INPUTOUTPUTSTR"]).Value);
			OUTPUTSTR      = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["OUTPUTSTR"]).     Value);

			return ret;
		}

		#endregion

		#region OUTREFTEST

		public partial class OUTREFTESTResult
		{
			public int?   INPUTOUTPUTID  { get; set; }
			public string INPUTOUTPUTSTR { get; set; }
			public int?   OUTPUTID       { get; set; }
			public string OUTPUTSTR      { get; set; }
		}

		public static IEnumerable<OUTREFTESTResult> OUTREFTEST(this DataConnection dataConnection, int? ID, int? IN_INPUTOUTPUTID, string STR, string IN_INPUTOUTPUTSTR, out int? INPUTOUTPUTID, out string INPUTOUTPUTSTR, out int? OUTPUTID, out string OUTPUTSTR)
		{
			var ret = dataConnection.QueryProc<OUTREFTESTResult>("OUTREFTEST",
				new DataParameter("ID",                ID,                DataType.Int32),
				new DataParameter("IN_INPUTOUTPUTID",  IN_INPUTOUTPUTID,  DataType.Int32),
				new DataParameter("STR",               STR,               DataType.NVarChar),
				new DataParameter("IN_INPUTOUTPUTSTR", IN_INPUTOUTPUTSTR, DataType.NVarChar));

			INPUTOUTPUTID  = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["INPUTOUTPUTID"]). Value);
			INPUTOUTPUTSTR = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["INPUTOUTPUTSTR"]).Value);
			OUTPUTID       = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["OUTPUTID"]).      Value);
			OUTPUTSTR      = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["OUTPUTSTR"]).     Value);

			return ret;
		}

		#endregion

		#region PATIENT_SELECTALL

		public partial class PATIENT_SELECTALLResult
		{
			public int?   PERSONID   { get; set; }
			public string FIRSTNAME  { get; set; }
			public string LASTNAME   { get; set; }
			public string MIDDLENAME { get; set; }
			public string GENDER     { get; set; }
			public string DIAGNOSIS  { get; set; }
		}

		public static IEnumerable<PATIENT_SELECTALLResult> PATIENT_SELECTALL(this DataConnection dataConnection, out int? PERSONID, out string FIRSTNAME, out string LASTNAME, out string MIDDLENAME, out char? GENDER, out string DIAGNOSIS)
		{
			var ret = dataConnection.QueryProc<PATIENT_SELECTALLResult>("PATIENT_SELECTALL");

			PERSONID   = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["PERSONID"]).  Value);
			FIRSTNAME  = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["FIRSTNAME"]). Value);
			LASTNAME   = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["LASTNAME"]).  Value);
			MIDDLENAME = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["MIDDLENAME"]).Value);
			GENDER     = Converter.ChangeTypeTo<char?> (((IDbDataParameter)dataConnection.Command.Parameters["GENDER"]).    Value);
			DIAGNOSIS  = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["DIAGNOSIS"]). Value);

			return ret;
		}

		#endregion

		#region PATIENT_SELECTBYNAME

		public partial class PATIENT_SELECTBYNAMEResult
		{
			public int?   PERSONID   { get; set; }
			public string MIDDLENAME { get; set; }
			public string GENDER     { get; set; }
			public string DIAGNOSIS  { get; set; }
		}

		public static IEnumerable<PATIENT_SELECTBYNAMEResult> PATIENT_SELECTBYNAME(this DataConnection dataConnection, string FIRSTNAME, string LASTNAME, out int? PERSONID, out string MIDDLENAME, out char? GENDER, out string DIAGNOSIS)
		{
			var ret = dataConnection.QueryProc<PATIENT_SELECTBYNAMEResult>("PATIENT_SELECTBYNAME",
				new DataParameter("FIRSTNAME", FIRSTNAME, DataType.NVarChar),
				new DataParameter("LASTNAME",  LASTNAME,  DataType.NVarChar));

			PERSONID   = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["PERSONID"]).  Value);
			MIDDLENAME = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["MIDDLENAME"]).Value);
			GENDER     = Converter.ChangeTypeTo<char?> (((IDbDataParameter)dataConnection.Command.Parameters["GENDER"]).    Value);
			DIAGNOSIS  = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["DIAGNOSIS"]). Value);

			return ret;
		}

		#endregion

		#region PERSON_DELETE

		public static int PERSON_DELETE(this DataConnection dataConnection, int? PERSONID)
		{
			return dataConnection.ExecuteProc("PERSON_DELETE",
				new DataParameter("PERSONID", PERSONID, DataType.Int32));
		}

		#endregion

		#region PERSON_INSERT

		public partial class PERSON_INSERTResult
		{
			public int? PERSONID { get; set; }
		}

		public static IEnumerable<PERSON_INSERTResult> PERSON_INSERT(this DataConnection dataConnection, string FIRSTNAME, string LASTNAME, string MIDDLENAME, char? GENDER, out int? PERSONID)
		{
			var ret = dataConnection.QueryProc<PERSON_INSERTResult>("PERSON_INSERT",
				new DataParameter("FIRSTNAME",  FIRSTNAME,  DataType.NVarChar),
				new DataParameter("LASTNAME",   LASTNAME,   DataType.NVarChar),
				new DataParameter("MIDDLENAME", MIDDLENAME, DataType.NVarChar),
				new DataParameter("GENDER",     GENDER,     DataType.NChar));

			PERSONID = Converter.ChangeTypeTo<int?>(((IDbDataParameter)dataConnection.Command.Parameters["PERSONID"]).Value);

			return ret;
		}

		#endregion

		#region PERSON_INSERT_OUTPUTPARAMETER

		public partial class PERSON_INSERT_OUTPUTPARAMETERResult
		{
			public int? PERSONID { get; set; }
		}

		public static IEnumerable<PERSON_INSERT_OUTPUTPARAMETERResult> PERSON_INSERT_OUTPUTPARAMETER(this DataConnection dataConnection, string FIRSTNAME, string LASTNAME, string MIDDLENAME, char? GENDER, out int? PERSONID)
		{
			var ret = dataConnection.QueryProc<PERSON_INSERT_OUTPUTPARAMETERResult>("PERSON_INSERT_OUTPUTPARAMETER",
				new DataParameter("FIRSTNAME",  FIRSTNAME,  DataType.NVarChar),
				new DataParameter("LASTNAME",   LASTNAME,   DataType.NVarChar),
				new DataParameter("MIDDLENAME", MIDDLENAME, DataType.NVarChar),
				new DataParameter("GENDER",     GENDER,     DataType.NChar));

			PERSONID = Converter.ChangeTypeTo<int?>(((IDbDataParameter)dataConnection.Command.Parameters["PERSONID"]).Value);

			return ret;
		}

		#endregion

		#region PERSON_SELECTALL

		public partial class PERSON_SELECTALLResult
		{
			public int?   PERSONID   { get; set; }
			public string FIRSTNAME  { get; set; }
			public string LASTNAME   { get; set; }
			public string MIDDLENAME { get; set; }
			public string GENDER     { get; set; }
		}

		public static IEnumerable<PERSON_SELECTALLResult> PERSON_SELECTALL(this DataConnection dataConnection, out int? PERSONID, out string FIRSTNAME, out string LASTNAME, out string MIDDLENAME, out char? GENDER)
		{
			var ret = dataConnection.QueryProc<PERSON_SELECTALLResult>("PERSON_SELECTALL");

			PERSONID   = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["PERSONID"]).  Value);
			FIRSTNAME  = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["FIRSTNAME"]). Value);
			LASTNAME   = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["LASTNAME"]).  Value);
			MIDDLENAME = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["MIDDLENAME"]).Value);
			GENDER     = Converter.ChangeTypeTo<char?> (((IDbDataParameter)dataConnection.Command.Parameters["GENDER"]).    Value);

			return ret;
		}

		#endregion

		#region PERSON_SELECTBYKEY

		public partial class PERSON_SELECTBYKEYResult
		{
			public int?   PERSONID   { get; set; }
			public string FIRSTNAME  { get; set; }
			public string LASTNAME   { get; set; }
			public string MIDDLENAME { get; set; }
			public string GENDER     { get; set; }
		}

		public static IEnumerable<PERSON_SELECTBYKEYResult> PERSON_SELECTBYKEY(this DataConnection dataConnection, int? ID, out int? PERSONID, out string FIRSTNAME, out string LASTNAME, out string MIDDLENAME, out char? GENDER)
		{
			var ret = dataConnection.QueryProc<PERSON_SELECTBYKEYResult>("PERSON_SELECTBYKEY",
				new DataParameter("ID", ID, DataType.Int32));

			PERSONID   = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["PERSONID"]).  Value);
			FIRSTNAME  = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["FIRSTNAME"]). Value);
			LASTNAME   = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["LASTNAME"]).  Value);
			MIDDLENAME = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["MIDDLENAME"]).Value);
			GENDER     = Converter.ChangeTypeTo<char?> (((IDbDataParameter)dataConnection.Command.Parameters["GENDER"]).    Value);

			return ret;
		}

		#endregion

		#region PERSON_SELECTBYNAME

		public partial class PERSON_SELECTBYNAMEResult
		{
			public int?   PERSONID   { get; set; }
			public string FIRSTNAME  { get; set; }
			public string LASTNAME   { get; set; }
			public string MIDDLENAME { get; set; }
			public string GENDER     { get; set; }
		}

		public static IEnumerable<PERSON_SELECTBYNAMEResult> PERSON_SELECTBYNAME(this DataConnection dataConnection, string IN_FIRSTNAME, string IN_LASTNAME, out int? PERSONID, out string FIRSTNAME, out string LASTNAME, out string MIDDLENAME, out char? GENDER)
		{
			var ret = dataConnection.QueryProc<PERSON_SELECTBYNAMEResult>("PERSON_SELECTBYNAME",
				new DataParameter("IN_FIRSTNAME", IN_FIRSTNAME, DataType.NVarChar),
				new DataParameter("IN_LASTNAME",  IN_LASTNAME,  DataType.NVarChar));

			PERSONID   = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["PERSONID"]).  Value);
			FIRSTNAME  = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["FIRSTNAME"]). Value);
			LASTNAME   = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["LASTNAME"]).  Value);
			MIDDLENAME = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["MIDDLENAME"]).Value);
			GENDER     = Converter.ChangeTypeTo<char?> (((IDbDataParameter)dataConnection.Command.Parameters["GENDER"]).    Value);

			return ret;
		}

		#endregion

		#region PERSON_UPDATE

		public static int PERSON_UPDATE(this DataConnection dataConnection, int? PERSONID, string FIRSTNAME, string LASTNAME, string MIDDLENAME, char? GENDER)
		{
			return dataConnection.ExecuteProc("PERSON_UPDATE",
				new DataParameter("PERSONID",   PERSONID,   DataType.Int32),
				new DataParameter("FIRSTNAME",  FIRSTNAME,  DataType.NVarChar),
				new DataParameter("LASTNAME",   LASTNAME,   DataType.NVarChar),
				new DataParameter("MIDDLENAME", MIDDLENAME, DataType.NVarChar),
				new DataParameter("GENDER",     GENDER,     DataType.NChar));
		}

		#endregion

		#region SCALAR_DATAREADER

		public partial class SCALAR_DATAREADERResult
		{
			public int?   INTFIELD    { get; set; }
			public string STRINGFIELD { get; set; }
		}

		public static IEnumerable<SCALAR_DATAREADERResult> SCALAR_DATAREADER(this DataConnection dataConnection, out int? INTFIELD, out string STRINGFIELD)
		{
			var ret = dataConnection.QueryProc<SCALAR_DATAREADERResult>("SCALAR_DATAREADER");

			INTFIELD    = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["INTFIELD"]).   Value);
			STRINGFIELD = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["STRINGFIELD"]).Value);

			return ret;
		}

		#endregion

		#region SCALAR_OUTPUTPARAMETER

		public partial class SCALAR_OUTPUTPARAMETERResult
		{
			public int?   OUTPUTINT    { get; set; }
			public string OUTPUTSTRING { get; set; }
		}

		public static IEnumerable<SCALAR_OUTPUTPARAMETERResult> SCALAR_OUTPUTPARAMETER(this DataConnection dataConnection, out int? OUTPUTINT, out string OUTPUTSTRING)
		{
			var ret = dataConnection.QueryProc<SCALAR_OUTPUTPARAMETERResult>("SCALAR_OUTPUTPARAMETER");

			OUTPUTINT    = Converter.ChangeTypeTo<int?>  (((IDbDataParameter)dataConnection.Command.Parameters["OUTPUTINT"]).   Value);
			OUTPUTSTRING = Converter.ChangeTypeTo<string>(((IDbDataParameter)dataConnection.Command.Parameters["OUTPUTSTRING"]).Value);

			return ret;
		}

		#endregion

		#region SCALAR_RETURNPARAMETER

		public partial class SCALAR_RETURNPARAMETERResult
		{
			public int? RETURN_VALUE { get; set; }
		}

		public static IEnumerable<SCALAR_RETURNPARAMETERResult> SCALAR_RETURNPARAMETER(this DataConnection dataConnection, out int? RETURN_VALUE)
		{
			var ret = dataConnection.QueryProc<SCALAR_RETURNPARAMETERResult>("SCALAR_RETURNPARAMETER");

			RETURN_VALUE = Converter.ChangeTypeTo<int?>(((IDbDataParameter)dataConnection.Command.Parameters["RETURN_VALUE"]).Value);

			return ret;
		}

		#endregion
	}

	public static partial class TableExtensions
	{
		public static ALLTYPE Find(this ITable<ALLTYPE> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static BINARYDATA Find(this ITable<BINARYDATA> table, int BINARYDATAID)
		{
			return table.FirstOrDefault(t =>
				t.BINARYDATAID == BINARYDATAID);
		}

		public static CamelCaseName Find(this ITable<CamelCaseName> table, int Id)
		{
			return table.FirstOrDefault(t =>
				t.Id == Id);
		}

		public static DATATYPETEST Find(this ITable<DATATYPETEST> table, int DATATYPEID)
		{
			return table.FirstOrDefault(t =>
				t.DATATYPEID == DATATYPEID);
		}

		public static PERSON Find(this ITable<PERSON> table, int PERSONID)
		{
			return table.FirstOrDefault(t =>
				t.PERSONID == PERSONID);
		}

		public static SEQUENCETEST Find(this ITable<SEQUENCETEST> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TESTIDENTITY Find(this ITable<TESTIDENTITY> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TESTTABLE2 Find(this ITable<TESTTABLE2> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}

		public static TESTTABLE3 Find(this ITable<TESTTABLE3> table, int ID)
		{
			return table.FirstOrDefault(t =>
				t.ID == ID);
		}
	}
}
