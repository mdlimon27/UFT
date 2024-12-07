'Inputs
vSource="C:\AutomationTesting\InputDataBook2.xls"
vDestination="C:\AutomationTesting\InputDataBook3.xlsx"

'Calling the function
ConvertExtensionFromXLStoXLSX vSource,vDestination


'++++++++++++++++++++++++++++++++++++++Function Library++++++++++++++
'Function Name: ConvertExtensionFromXLStoXLSX
'Created By: Md Shahajada Imran
'Created Date: 12.07.2024
'Inputs: Path of the Excel file with .xls extension, path of the excel file with .xlsx extension
'Outputs: None
'Language/Tools: Visual Basic Scripting, Unified Functional Testing

Function ConvertExtensionFromXLStoXLSX(vSource,vDestination)
	Set myExcel=CreateObject("Excel.Application")
	myExcel.Workbooks.Open vSource
	
	'Error handling: If the destination file (File with .xlsx) is alrady exists, then delete first
	Set myFSO=CreateObject("Scripting.FileSystemObject")
	If myFSO.FileExists(vDestination) Then 
	   myFSO.DeleteFile vDestination
       else	   
	End If
	
	'After deletion copy & past the file with updated extension (from .xls TO .xlsx)
	myExcel.ActiveWorkbook.SaveAs vDestination, 51 '51 is the code
	myExcel.ActiveWorkbook.Close 'Closing workbook
	myExcel.Quit 'quiting the object	
	Set myExcel=Nothing 'cleaning the memory spaces
	Set myFSO=Nothing 'cleaning the memory spaces
End Function

