AIUtil.SetContext Browser("creationtime:=0")
AIUtil("profile", micAnyText, micFromBottom, 1).Click
AIUtil.FindTextBlock("Sign out").Click
systemutil.CloseProcessByName "chrome.exe"
