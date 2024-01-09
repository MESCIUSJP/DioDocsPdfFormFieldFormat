// See https://aka.ms/new-console-template for more information
using GrapeCity.Documents.Pdf;
using GrapeCity.Documents.Pdf.AcroForms;
using System.Drawing;
using static GrapeCity.Documents.Pdf.AcroForms.Field;

Console.WriteLine("PDFフォームのテキストフィールドに書式を設定する");

//GcPdfDocument.SetLicenseKey("");

// GcPdfDocument を初期化
GcPdfDocument doc = new GcPdfDocument();

// ドキュメントに空白ページを追加
var p = doc.NewPage();

// GcPdfGraphics を初期化
var g = p.Graphics;

// パーセントの書式を設定
g.DrawString("パーセントの書式", StandardFonts.Helvetica, 14, Color.Black, new Point(10, 10));

// TextFieldにパーセント書式を設定
TextField percentformat = new();
p.Doc.AcroForm.Fields.Add(percentformat);

percentformat.Widget.Page = p;
percentformat.Widget.Rect = new RectangleF(10, 40, 60, 20);
percentformat.Widget.Border.Width = 1;
percentformat.SetPercentFormat(2, TextField.NumberSeparatorStyle.Dot);

// TextFieldにパーセント書式の値を設定
TextField percentformatvalue = new();
p.Doc.AcroForm.Fields.Add(percentformatvalue);

percentformatvalue.Widget.Page = p;
percentformatvalue.Widget.Rect = new RectangleF(80, 40, 60, 20);
percentformatvalue.Widget.Border.Width = 1;
percentformatvalue.SetPercentValue(1.5, 2, TextField.NumberSeparatorStyle.Dot);

// 数値の書式を設定
g.DrawString("数値の書式", StandardFonts.Helvetica, 14, Color.Black, new Point(10, 70));

// TextFieldに数値書式を設定
TextField numberformat = new TextField();
p.Doc.AcroForm.Fields.Add(numberformat);

numberformat.Widget.Page = p;
numberformat.Widget.Rect = new RectangleF(10, 100, 60, 20);
numberformat.Widget.Border.Width = 1;
numberformat.SetNumberFormat(2, TextField.NumberSeparatorStyle.CommaDot,
    TextField.NumberNegativeStyle.UseRedText, "\u00a5", TextField.CurrencySymbolStyle.BeforeNoSpace);

// TextFieldに数値書式の値を設定
TextField numberformatvalue = new TextField();
p.Doc.AcroForm.Fields.Add(numberformatvalue);

numberformatvalue.Widget.Page = p;
numberformatvalue.Widget.Rect = new RectangleF(80, 100, 60, 20);
numberformatvalue.Widget.Border.Width = 1;
numberformatvalue.SetNumberValue(12345, 2, TextField.NumberSeparatorStyle.CommaDot,
   TextField.NumberNegativeStyle.ShowParentheses, "\u00a5", TextField.CurrencySymbolStyle.BeforeNoSpace);

// 日付の書式を設定
g.DrawString("日付の書式", StandardFonts.Helvetica, 14, Color.Black, new Point(10, 130));

// TextField に日付書式を設定
TextField dateformat = new TextField();
p.Doc.AcroForm.Fields.Add(dateformat);

dateformat.Widget.Page = p;
dateformat.Widget.Rect = new RectangleF(10, 160, 60, 20);
dateformat.Widget.Border.Width = 1;
dateformat.SetDateFormat("yyyy-mm-dd");

// TextFieldに数値書式の値を設定
TextField dateformatvalue = new TextField();
p.Doc.AcroForm.Fields.Add(dateformatvalue);

dateformatvalue.Widget.Page = p;
dateformatvalue.Widget.Rect = new RectangleF(80, 160, 60, 20);
dateformatvalue.Widget.Border.Width = 1;
dateformatvalue.SetDateValue(DateTime.Now, "yyyy/mm/dd");

// 時刻の書式を設定
g.DrawString("時刻の書式", StandardFonts.Helvetica, 14, Color.Black, new Point(10, 200));

// TextField に時刻書式を設定
TextField timeformat = new TextField();
p.Doc.AcroForm.Fields.Add(timeformat);

timeformat.Widget.Page = p;
timeformat.Widget.Rect = new RectangleF(10, 230, 60, 20);
timeformat.Widget.Border.Width = 1;
timeformat.SetTimeFormat("HH:MM");

// TextFieldに時刻書式の値を設定
TextField timeformatvalue = new TextField();
p.Doc.AcroForm.Fields.Add(timeformatvalue);

timeformatvalue.Widget.Page = p;
timeformatvalue.Widget.Rect = new RectangleF(80, 230, 60, 20);
timeformatvalue.Widget.Border.Width = 1;
timeformatvalue.SetTimeValue(DateTime.Now, "HH:MM:ss");


// ドキュメントを保存します。
doc.Save("FieldFormat.pdf");
