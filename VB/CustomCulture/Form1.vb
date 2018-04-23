Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace CustomCulture
	Partial Public Class Form1
		Inherits Form
		<STAThread> _
		Shared Sub Main()
			' set the modified culture globally
			'System.Globalization.CultureInfo culture;
			'culture = System.Threading.Thread.CurrentThread.CurrentCulture.Clone() as System.Globalization.CultureInfo;
			'culture.NumberFormat.NumberDecimalSeparator = ",";
			'culture.NumberFormat.NumberGroupSeparator = " ";
			'System.Threading.Thread.CurrentThread.CurrentCulture = culture;

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			textEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
			textEdit1.EditValue = 1234.56789D
			textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
			textEdit2.Properties.Mask.UseMaskAsDisplayFormat = True
			textEdit2.EditValue = 1234.56789D

			'assign the modified culture only to a given editor
			Dim culture As System.Globalization.CultureInfo
			culture = TryCast(System.Threading.Thread.CurrentThread.CurrentCulture.Clone(), System.Globalization.CultureInfo)
			culture.NumberFormat.NumberDecimalSeparator = ","
			culture.NumberFormat.NumberGroupSeparator = " "
			textEdit1.Properties.Mask.Culture = culture
		End Sub
	End Class
End Namespace