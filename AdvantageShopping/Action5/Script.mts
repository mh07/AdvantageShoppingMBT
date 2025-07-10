systemUtil.Run "chrome.exe", "http://localhost:5173/"
AIUtil.SetContext Browser("creationtime:=0")
AIUtil("text_box", "SD Ask about products, orders, or site info").Type "laptops on sale?"
AIUtil("button", "Send").Click
chatBotCheck = AIUtil.FindTextBlock("Here are our laptops").GetText

If chatBotCheck = "Here are our laptops" Then
	Reporter.ReportEvent micPass, "ChatBot Response", "ChatBot response verified"
End If
systemutil.CloseProcessByName "chrome.exe"

