systemUtil.Run "chrome.exe", "www.advantageonlineshopping.com/#/"
AIUtil.SetContext Browser("creationtime:=0")
wait 9
AIUtil("profile").Click
AIUtil("input", "Username").Type "aidemo"
AIUtil("input", "Password").Type "Password1"
AIUtil("button", "SIGN IN").Click
 @@ script infofile_;_ZIP::ssf1.xml_;_
 
Browser("Advantage Shopping_2").Page("Advantage Shopping").Check CheckPoint("Advantage Shopping") @@ script infofile_;_ZIP::ssf2.xml_;_
