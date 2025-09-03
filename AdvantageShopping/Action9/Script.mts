systemutil.Run "chrome.exe", "https://sap-hana.mfdemoportal.com:44300/sap/bc/ui5_ui5/ui2/ushell/shells/abap/FioriLaunchpad.html"

AIUtil.SetContext Browser("creationtime:=0")
AIUtil("text_box", "User").Type "S4H_SD"
AIUtil("text_box", "Password").Type "Welcome1"
AIUtil("button", "Log On").Click
wait 10
AIUtil("search").Search "va01"
AIUtil.FindTextBlock("Create Sales Orders").Click

AIUtil("text_box", "Order Type:").SetText "OR"
AIUtil.Context.Freeze
set objSendKey=CreateObject("WScript.shell")
objSendKey.SendKeys "{TAB}{BACKSPACE}"
AIUtil("text_box", "Division").SetText "00"
AIUtil("text_box", "Distribution Channel:").SetText "10"
AIUtil("text_box", "Sales Organization:").SetText "1710"
AIUtil("button", "Continue").Click
AIUtil.Context.UnFreeze

AIUtil("text_box", "Cust. Reference:").SetText "450000019998"
'AIUtil.Context.Freeze 
AIUtil("text_box", "Cust. Ref. Date:").SetText FormatDateTime((Date-1), 2)
AIUtil("text_box", "Ship-To Party:").SetText "EWM17-CU02"
AIUtil("text_box", "Sold-To Party:").SetText "EWM17-CU02"

AIUtil("text_box", "Standard Order:").SetText Parameter("iOrderNumber")
'AIUtil.Context.UnFreeze 

AIUtil.FindText("Save").Click
AIUtil.FindText("Exit").Click

AIUtil.SetContext Browser("creationtime:=0")
AIUtil.FindTextBlock("dj").Click
AIUtil.FindTextBlock("Sign Out").Click
AIUtil("button", "OK").Click
systemutil.CloseProcessByName "chrome.exe"
