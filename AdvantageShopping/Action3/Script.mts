systemUtil.Run "chrome.exe", "www.advantageonlineshopping.com/#/"
AIUtil.SetContext Browser("creationtime:=0")
wait 5
AIUtil("profile").Click
AIUtil("input", "Username").Type "aidemo"
AIUtil("input", "Password").Type "Password1"
AIUtil("button", "SIGN IN").Click
