AIUtil.SetContext Browser("creationtime:=0")
AIUtil("profile").Click
AIUtil.FindText("My orders").Click
OrderNumber = AIUtil.FindTextBlock(micAnyText, micWithAnchorAbove, AIUtil.FindTextBlock("ORDER NUMBER")).GetText
If OrderNumber = Parameter("iOrderNumber") Then
	Reporter.ReportEvent micPass, "Order number match", "Pass"
Else
	Reporter.ReportEvent 1, "Order number mismatch", "Failure! Order number actual: " & OrderNumber & " Order number expected: " & Parameter("iOrderNumber")
End If
systemutil.CloseProcessByName "chrome.exe"


