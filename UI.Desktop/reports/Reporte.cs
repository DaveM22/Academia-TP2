using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using FastReport;
using FastReport.Data;
using FastReport.Dialog;
using FastReport.Barcode;
using FastReport.Table;
using FastReport.Utils;

namespace FastReport
{
  public class Reporte : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.TextObject Academia;
    public FastReport.TextObject btnTituloPlan;
    public FastReport.Table.TableCell Cell26;
    public FastReport.Table.TableCell Cell27;
    public FastReport.Table.TableCell Cell28;
    public FastReport.Table.TableCell Cell29;
    public FastReport.Table.TableColumn Column6;
    public FastReport.Table.TableColumn Column7;
    public FastReport.Table.TableColumn Column8;
    public FastReport.Table.TableColumn Column9;
    public FastReport.ColumnHeaderBand ColumnHeader1;
    public FastReport.DataBand data;
    public FastReport.TextObject lblEspecialidad;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.PageHeaderBand PageHeader1;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.Table.TableRow Row6;
    public FastReport.Table.TableObject Table2;
    public FastReport.TextObject Text1;
    public FastReport.TextObject Text2;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text5;
    public FastReport.TextObject Text6;
    public FastReport.TextObject Text7;
    public FastReport.TextObject Text8;
    public FastReport.TextObject Text9;
    public FastReport.TextObject txtEspecialidad;
    private object Sum(TableCell cell)
    {
      return cell.Table.Sum(cell);
    }

    private object Min(TableCell cell)
    {
      return cell.Table.Min(cell);
    }

    private object Max(TableCell cell)
    {
      return cell.Table.Max(cell);
    }

    private object Avg(TableCell cell)
    {
      return cell.Table.Avg(cell);
    }

    private object Count(TableCell cell)
    {
      return cell.Table.Count(cell);
    }

    protected override object CalcExpression(string expression, Variant Value)
    {
      return null;
    }

    private SByte Abs(SByte value)
    {
      return System.Math.Abs(value);
    }

    private Int16 Abs(Int16 value)
    {
      return System.Math.Abs(value);
    }

    private Int32 Abs(Int32 value)
    {
      return System.Math.Abs(value);
    }

    private Int64 Abs(Int64 value)
    {
      return System.Math.Abs(value);
    }

    private Single Abs(Single value)
    {
      return System.Math.Abs(value);
    }

    private Double Abs(Double value)
    {
      return System.Math.Abs(value);
    }

    private Decimal Abs(Decimal value)
    {
      return System.Math.Abs(value);
    }

    private Double Acos(Double d)
    {
      return System.Math.Acos(d);
    }

    private Double Asin(Double d)
    {
      return System.Math.Asin(d);
    }

    private Double Atan(Double d)
    {
      return System.Math.Atan(d);
    }

    private Double Ceiling(Double a)
    {
      return System.Math.Ceiling(a);
    }

    private Decimal Ceiling(Decimal d)
    {
      return System.Math.Ceiling(d);
    }

    private Double Cos(Double d)
    {
      return System.Math.Cos(d);
    }

    private Double Exp(Double d)
    {
      return System.Math.Exp(d);
    }

    private Double Floor(Double d)
    {
      return System.Math.Floor(d);
    }

    private Decimal Floor(Decimal d)
    {
      return System.Math.Floor(d);
    }

    private Double Log(Double d)
    {
      return System.Math.Log(d);
    }

    private Int32 Maximum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int64 Maximum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Single Maximum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Double Maximum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Decimal Maximum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int32 Minimum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Int64 Minimum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Single Minimum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Minimum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Decimal Minimum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Round(Double a)
    {
      return System.Math.Round(a);
    }

    private Decimal Round(Decimal d)
    {
      return System.Math.Round(d);
    }

    private Double Round(Double value, Int32 digits)
    {
      return System.Math.Round(value, digits);
    }

    private Decimal Round(Decimal d, Int32 decimals)
    {
      return System.Math.Round(d, decimals);
    }

    private Double Sin(Double a)
    {
      return System.Math.Sin(a);
    }

    private Double Sqrt(Double d)
    {
      return System.Math.Sqrt(d);
    }

    private Double Tan(Double a)
    {
      return System.Math.Tan(a);
    }

    private Double Truncate(Double d)
    {
      return System.Math.Truncate(d);
    }

    private Decimal Truncate(Decimal d)
    {
      return System.Math.Truncate(d);
    }

    private Int32 Asc(Char c)
    {
      return FastReport.Functions.StdFunctions.Asc(c);
    }

    private Char Chr(Int32 i)
    {
      return FastReport.Functions.StdFunctions.Chr(i);
    }

 
    private String Insert(String s, Int32 startIndex, String value)
    {
      return FastReport.Functions.StdFunctions.Insert(s, startIndex, value);
    }

    private Int32 Length(String s)
    {
      return FastReport.Functions.StdFunctions.Length(s);
    }

    private String LowerCase(String s)
    {
      return FastReport.Functions.StdFunctions.LowerCase(s);
    }

    private String PadLeft(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth);
    }

    private String PadLeft(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth, paddingChar);
    }

    private String PadRight(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth);
    }

    private String PadRight(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth, paddingChar);
    }

    private String Remove(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex);
    }

    private String Remove(String s, Int32 startIndex, Int32 count)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex, count);
    }

    private String Replace(String s, String oldValue, String newValue)
    {
      return FastReport.Functions.StdFunctions.Replace(s, oldValue, newValue);
    }

    private String Substring(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex);
    }

    private String Substring(String s, Int32 startIndex, Int32 length)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex, length);
    }

    private String TitleCase(String s)
    {
      return FastReport.Functions.StdFunctions.TitleCase(s);
    }

    private String Trim(String s)
    {
      return FastReport.Functions.StdFunctions.Trim(s);
    }

    private String UpperCase(String s)
    {
      return FastReport.Functions.StdFunctions.UpperCase(s);
    }

    private DateTime AddDays(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddDays(date, value);
    }

    private DateTime AddHours(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddHours(date, value);
    }

    private DateTime AddMinutes(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddMinutes(date, value);
    }

    private DateTime AddMonths(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddMonths(date, value);
    }

    private DateTime AddSeconds(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddSeconds(date, value);
    }

    private DateTime AddYears(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddYears(date, value);
    }

    private TimeSpan DateDiff(DateTime date1, DateTime date2)
    {
      return FastReport.Functions.StdFunctions.DateDiff(date1, date2);
    }

    private DateTime DateSerial(Int32 year, Int32 month, Int32 day)
    {
      return FastReport.Functions.StdFunctions.DateSerial(year, month, day);
    }

    private Int32 Day(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Day(date);
    }

    private String DayOfWeek(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfWeek(date);
    }

    private Int32 DayOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfYear(date);
    }

    private Int32 DaysInMonth(Int32 year, Int32 month)
    {
      return FastReport.Functions.StdFunctions.DaysInMonth(year, month);
    }

    private Int32 Hour(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Hour(date);
    }

    private Int32 Minute(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Minute(date);
    }

    private Int32 Month(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Month(date);
    }

    private String MonthName(Int32 month)
    {
      return FastReport.Functions.StdFunctions.MonthName(month);
    }

    private Int32 Second(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Second(date);
    }

    private Int32 WeekOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.WeekOfYear(date);
    }

    private Int32 Year(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Year(date);
    }

    private String Format(String format, params Object[] args)
    {
      return FastReport.Functions.StdFunctions.Format(format, args);
    }

    private String FormatCurrency(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value);
    }

    private String FormatCurrency(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value, decimalDigits);
    }

    private String FormatDateTime(DateTime value)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value);
    }

    private String FormatDateTime(DateTime value, String format)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value, format);
    }

    private String FormatNumber(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value);
    }

    private String FormatNumber(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value, decimalDigits);
    }

    private String FormatPercent(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value);
    }

    private String FormatPercent(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value, decimalDigits);
    }

    private Boolean ToBoolean(Object value)
    {
      return System.Convert.ToBoolean(value);
    }

    private Byte ToByte(Object value)
    {
      return System.Convert.ToByte(value);
    }

    private Char ToChar(Object value)
    {
      return System.Convert.ToChar(value);
    }

    private DateTime ToDateTime(Object value)
    {
      return System.Convert.ToDateTime(value);
    }

    private Decimal ToDecimal(Object value)
    {
      return System.Convert.ToDecimal(value);
    }

    private Double ToDouble(Object value)
    {
      return System.Convert.ToDouble(value);
    }

    private Int32 ToInt32(Object value)
    {
      return System.Convert.ToInt32(value);
    }

    private String ToRoman(Object value)
    {
      return FastReport.Functions.StdFunctions.ToRoman(value);
    }

    private Single ToSingle(Object value)
    {
      return System.Convert.ToSingle(value);
    }

    private String ToString(Object value)
    {
      return System.Convert.ToString(value);
    }

    private String ToWords(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWords(value);
    }

    private String ToWords(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, currencyName);
    }

    private String ToWords(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, one, many);
    }

    private String ToWordsIn(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value);
    }

    private String ToWordsIn(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, currencyName);
    }

    private String ToWordsIn(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, one, many);
    }

    private String ToWordsDe(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value);
    }

    private String ToWordsDe(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, currencyName);
    }

    private String ToWordsDe(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, one, many);
    }

    private String ToWordsEnGb(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value);
    }

    private String ToWordsEnGb(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, currencyName);
    }

    private String ToWordsEnGb(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, one, many);
    }

    private String ToWordsEs(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value);
    }

    private String ToWordsEs(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, currencyName);
    }

    private String ToWordsEs(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, one, many);
    }

    private String ToWordsFr(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value);
    }

    private String ToWordsFr(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, currencyName);
    }

    private String ToWordsFr(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, one, many);
    }

    private String ToWordsNl(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value);
    }

    private String ToWordsNl(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, currencyName);
    }

    private String ToWordsNl(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, one, many);
    }

    private String ToWordsRu(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value);
    }

    private String ToWordsRu(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, currencyName);
    }

    private String ToWordsRu(Object value, Boolean male, String one, String two, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, male, one, two, many);
    }

    private String ToWordsUkr(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value);
    }

    private String ToWordsUkr(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, currencyName);
    }

    private String ToWordsUkr(Object value, Boolean male, String one, String two, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, male, one, two, many);
    }

    private String ToWordsSp(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, currencyName);
    }

    private String ToWordsSp(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value);
    }

    private String ToWordsSp(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, one, many);
    }

    private String ToWordsPersian(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, currencyName);
    }

    private String ToWordsPersian(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value);
    }

    private String ToWordsPersian(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, one, many);
    }

    private String ToLetters(Object value)
    {
      return FastReport.Functions.StdFunctions.ToLetters(value);
    }

    private String ToLetters(Object value, Boolean isUpper)
    {
      return FastReport.Functions.StdFunctions.ToLetters(value, isUpper);
    }

    private String ToLettersRu(Object value)
    {
      return FastReport.Functions.StdFunctions.ToLettersRu(value);
    }

    private String ToLettersRu(Object value, Boolean isUpper)
    {
      return FastReport.Functions.StdFunctions.ToLettersRu(value, isUpper);
    }

    private String ToWordsPl(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, currencyName);
    }

    private String ToWordsPl(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value);
    }

    private String ToWordsPl(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, one, many);
    }

    private Object Choose(Double index, params Object[] choice)
    {
      return FastReport.Functions.StdFunctions.Choose(index, choice);
    }

    private Object IIf(Boolean expression, Object truePart, Object falsePart)
    {
      return FastReport.Functions.StdFunctions.IIf(expression, truePart, falsePart);
    }

    private Object Switch(params Object[] expressions)
    {
      return FastReport.Functions.StdFunctions.Switch(expressions);
    }

    private Boolean IsNull(String name)
    {
      return FastReport.Functions.StdFunctions.IsNull(Report, name);
    }

    private void InitializeComponent()
    {
      string reportString = 
        "﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Report ScriptLanguage=\"CSharp\" ReportI" +
        "nfo.Created=\"04/28/2024 08:34:07\" ReportInfo.Modified=\"04/30/2024 06:53:03\" Repo" +
        "rtInfo.CreatorVersion=\"2024.2.0.0\">\r\n  <Dictionary>\r\n    <BusinessObjectDataSour" +
        "ce Name=\"alumnos\" ReferenceName=\"alumnos\" DataType=\"System.Int32\" Enabled=\"true\"" +
        ">\r\n      <Column Name=\"Nombre\" DataType=\"System.String\"/>\r\n      <Column Name=\"A" +
        "pellido\" DataType=\"System.String\"/>\r\n      <Column Name=\"Legajo\" DataType=\"Syste" +
        "m.Int32\"/>\r\n      <Column Name=\"Email\" DataType=\"System.String\"/>\r\n    </Busines" +
        "sObjectDataSource>\r\n  </Dictionary>\r\n  <ReportPage Name=\"Page1\" Guides=\"37.8\" Wa" +
        "termark.Font=\"Arial, 60pt\">\r\n    <ReportTitleBand Name=\"ReportTitle1\" Width=\"718" +
        ".2\" Height=\"151.2\" Fill.Color=\"LightGray\" Guides=\"0\">\r\n      <TextObject Name=\"b" +
        "tnTituloPlan\" Left=\"189\" Top=\"9.45\" Width=\"330.75\" Height=\"47.25\" Text=\"Plan 200" +
        "8\" HorzAlign=\"Center\" Font=\"Arial Black, 20pt\"/>\r\n      <TextObject Name=\"lblEsp" +
        "ecialidad\" Left=\"18.9\" Top=\"66.15\" Width=\"122.85\" Height=\"18.9\" Text=\"Especialid";
      reportString += "ad:\" Font=\"Arial, 10pt, style=Bold\"/>\r\n      <TextObject Name=\"txtEspecialidad\" " +
        "Left=\"103.95\" Top=\"66.15\" Width=\"604.8\" Height=\"18.9\" Text=\"Ingenieria en sistem" +
        "as de la información\" Font=\"Arial, 10pt\"/>\r\n      <TextObject Name=\"Text1\" Left=" +
        "\"-9450\" Top=\"-9450\" Width=\"94.5\" Height=\"18.9\" HorzAlign=\"Center\" Font=\"Arial, 1" +
        "0pt\"/>\r\n      <TextObject Name=\"Text3\" Left=\"18.9\" Top=\"94.5\" Width=\"94.5\" Heigh" +
        "t=\"18.9\" Text=\"Materia:\" Font=\"Arial, 10pt, style=Bold\"/>\r\n      <TextObject Nam" +
        "e=\"Text4\" Left=\"103.95\" Top=\"94.5\" Width=\"633.15\" Height=\"18.9\" Text=\"Teoria de " +
        "control\" Font=\"Arial, 10pt\"/>\r\n      <TextObject Name=\"Text5\" Left=\"18.9\" Top=\"1" +
        "22.85\" Width=\"94.5\" Height=\"18.9\" Text=\"Comisión:\" Font=\"Arial, 10pt, style=Bold" +
        "\"/>\r\n      <TextObject Name=\"Text6\" Left=\"103.95\" Top=\"122.85\" Width=\"623.7\" Hei" +
        "ght=\"18.9\" Text=\"Comision 204K\" Font=\"Arial, 10pt\"/>\r\n    </ReportTitleBand>\r\n  " +
        "  <PageHeaderBand Name=\"PageHeader1\" Top=\"155.2\" Width=\"718.2\" Height=\"28.62\">\r\n";
      reportString += "      <TextObject Name=\"Text2\" Left=\"-28.35\" Width=\"718.2\" Height=\"28.35\" Font=\"" +
        "Arial, 10pt\"/>\r\n      <TextObject Name=\"Text7\" Top=\"0.03\" Width=\"718.2\" Height=\"" +
        "28.6\" Anchor=\"Top, Bottom\" Text=\"Inscriptos:\" HorzAlign=\"Center\" VertAlign=\"Cent" +
        "er\" Font=\"Arial Black, 14pt\"/>\r\n    </PageHeaderBand>\r\n    <ColumnHeaderBand Nam" +
        "e=\"ColumnHeader1\" Top=\"187.82\" Width=\"718.2\" Height=\"18.9\">\r\n      <TableObject " +
        "Name=\"Table2\" Left=\"9.45\" Top=\"-0.01\" Width=\"696.67\" Height=\"18.9\" Anchor=\"None\"" +
        " Border.Lines=\"All\">\r\n        <TableColumn Name=\"Column6\" Width=\"153.93\"/>\r\n    " +
        "    <TableColumn Name=\"Column7\" Width=\"153.93\"/>\r\n        <TableColumn Name=\"Col" +
        "umn8\" Width=\"163.38\"/>\r\n        <TableColumn Name=\"Column9\" Width=\"225.43\"/>\r\n  " +
        "      <TableRow Name=\"Row6\">\r\n          <TableCell Name=\"Cell26\" Border.Lines=\"R" +
        "ight\" Text=\"Legajo&#13;&#10;\" Font=\"Arial, 10pt, style=Bold\"/>\r\n          <Table" +
        "Cell Name=\"Cell27\" Border.Lines=\"Right\" Text=\"Apellido\" Font=\"Arial, 10pt, style";
      reportString += "=Bold\"/>\r\n          <TableCell Name=\"Cell28\" Border.Lines=\"All\" Text=\"Nombre\" Fo" +
        "nt=\"Arial, 10pt, style=Bold\"/>\r\n          <TableCell Name=\"Cell29\" Border.Lines=" +
        "\"Right\" Text=\"Correo electronico\" Font=\"Arial, 10pt, style=Bold\"/>\r\n        </Ta" +
        "bleRow>\r\n      </TableObject>\r\n    </ColumnHeaderBand>\r\n    <DataBand Name=\"data" +
        "\" Top=\"210.72\" Width=\"718.2\" Height=\"18.9\" DataSource=\"alumnos\">\r\n      <TextObj" +
        "ect Name=\"Text8\" Left=\"9.45\" Width=\"151.2\" Height=\"18.9\" Text=\"[alumnos.Nombre]\"" +
        " Font=\"Arial, 10pt\"/>\r\n      <TextObject Name=\"Text9\" Left=\"160.65\" Width=\"160.6" +
        "5\" Height=\"18.9\" Text=\"[alumnos.Apellido]\" Font=\"Arial, 10pt\"/>\r\n    </DataBand>" +
        "\r\n    <PageFooterBand Name=\"PageFooter1\" Top=\"233.62\" Width=\"718.2\" Height=\"141." +
        "75\" Fill.Color=\"LightGray\">\r\n      <TextObject Name=\"Academia\" Left=\"9.45\" Width" +
        "=\"94.5\" Height=\"18.9\" Text=\"Academia\" Font=\"Arial, 10pt\"/>\r\n    </PageFooterBand" +
        ">\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      StartReport += _StartReport;
      
    }

    public Reporte()
    {
      InitializeComponent();
    }
    public List<Alumnos> AlumnoList {get; set;}
    
    public class Alumnos
    {
      public string Nombre {get; set;}
      public string Apellido {get; set;}
      public int Legajo {get; set;}
      public string Email { get; set;}
    }
    

    private void _StartReport(object sender, EventArgs e)
    {
      AlumnoList  = new List<Alumnos>();
      Alumnos al = new Alumnos();
      al.Nombre = "Alejandro";
      al.Apellido = "Rodriguez";
      al.Legajo = 40302;
      al.Email = "mail@mail";
      AlumnoList.Add(al);
      
      Alumnos al2 = new Alumnos();
      al2.Nombre = "Roberto";
      al2.Apellido = "Martinez";
      al2.Legajo = 40303;
      al2.Email = "mail@mail";
      AlumnoList.Add(al2);
      this.Report.RegisterData(AlumnoList, "alumnos");
    }
  }
}
