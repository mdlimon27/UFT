'################################ Reusabel Function 1#######################
'Inputs
vSource="C:\AutomationTesting\InputDataBook2.xls"
vDestination="C:\AutomationTesting\InputDataBook3.xlsx"

'Calling the function
ConvertExtensionFromXLStoXLSX vSource,vDestination


'++++++++++++++++++++++++++++++++++++++The Function ++++++++++++++
'Function Name: ConvertExtensionFromXLStoXLSX
'Created By: Md Shahajada Imran
'Created Date: 12.07.2024
'Inputs: Path of the Excel file with .xls extension, path of the excel file with .xlsx extension
'Outputs: None
'Language/Tools: Visual Basic Scripting, Unified Functional Testing, Microsoft Excel

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


'################################ Reusabel Function 2 #######################


'Inputs
var_CallAPITest="<Arguments><tpFirstName>Md</tpFirstName><tpMiddleName>Shahajada</tpMiddleName><tpLastName>Imran</tpLastName><tpOrderNumber>23</tpOrderNumber><tpTotalPrice>483</tpTotalPrice></Arguments>"
var_pName="tpLastName"

'Calling the function
vOutput=fnGetAPITestParameterValue(var_CallAPITest,var_pName)
print vOutput

'++++++++++++++++++++++++++++++++++++++The Function ++++++++++++++
'Function Name: fnGetAPITestParameterValue
'Created By: Md Shahajada Imran
'Creation Date: 12/25/2024
'Inputs: String containing API Test output parameters in XML format, API Test output pamameter name
'OutPuts: API test output parameter value
'Language/Tools: Visual Basic scripting, Unified Functional Testing (UFT) OR UFT One or HP API Test

Function fnGetAPITestParameterValue(var_CallAPITest,var_pName)
	aMA=split(var_CallAPITest,var_pName)
	vTemp=aMA(1) 'Assigning the 2nd element of array into a global variable
	vTemp=Replace (vTemp,">","") 'removing > from the string
	vTemp=Replace (vTemp,"</","") 'removing </ from the string
	fnGetAPITestParameterValue=vTemp 
End Function

