﻿AIUtil.SetContext Browser("creationtime:=0")
AIUtil("profile").Click
AIUtil.FindText("My orders").Click
OrderNumber = Parameter("iOrderNumber")
If OrderNumber = Parameter("iOrderNumber") Then
	Reporter.ReportEvent micPass, "Order number match", "Pass! Order number actual: " & OrderNumber & " Order number expected: " & Parameter("iOrderNumber")
Else
	Reporter.ReportEvent micWarning, "Order number mismatch", "Failure! Order number actual: " & OrderNumber & " Order number expected: " & Parameter("iOrderNumber")
End If
systemutil.CloseProcessByName "chrome.exe"


