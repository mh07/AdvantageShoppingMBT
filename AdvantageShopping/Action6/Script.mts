systemutil.Run "C:\Program Files (x86)\OpenText\UFT One\samples\Flights Application\FlightsGUI.exe"
AIUtil.SetContext Window("regexpwndtitle:=OpenText MyFlight Sample Application")
AIUtil("text_box", "Username").Type "john"
AIUtil("text_box", "Password").Type "hp"
AIUtil("button", "OK").Click
AIUtil.SetContext Window("regexpwndtitle:=OpenText MyFlight Sample Application") 
AIUtil.FindText("SEARCH ORDER").Click
AIUtil("radio_button", "", micWithAnchorOnRight, AIUtil.FindTextBlock("Order number")).SetState "On"
AIUtil("text_box", "Order number").Type Parameter("iOrderInput")
AIUtil("button", "SEARCH").Click
AIUtil.FindTextBlock("Order number does not exist.").Click
AIUtil("button", "OK").Click
systemutil.CloseProcessByName "FlightsGUI.exe"

