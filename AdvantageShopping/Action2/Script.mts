Device("Device").App("Ishopping").MobileLabel("LAPTOPS").Tap
Device("Device").App("Ishopping").MobileObject("MobileObject").Tap 215,133
Device("Device").App("Ishopping").MobileLabel("ADD TO CART").Tap
Device("Device").App("Ishopping").MobileButton("cartItem").Tap
AIUtil.SetContext Device("micclass:=Device")
AIUtil.FindText("CHECKOUT").Click
Device("Device").App("Ishopping").MobileButton("PAY NOW").Tap
AIUtil.SetContext Device("micclass:=Device")
'AIUtil.FindTextBlock("Order number is 8173635466").Click
Parameter("oOrderNumber")= "8173635466"
AIUtil("button", "Ok").Click
