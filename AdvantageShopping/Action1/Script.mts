Device("Device").App("Ishopping").MobileButton("Menu").Tap
Device("Device").App("Ishopping").MobileObject("user.png").Tap
Device("Device").App("Ishopping").MobileEdit("userNameLabel").Tap
Device("Device").EnterKeys 0,"aidemo"
Device("Device").App("Ishopping").MobileEdit("passwordLabel").Tap
Device("Device").EnterKeys 0,"Password1"
Device("Device").App("Ishopping").MobileButton("LOGIN").Tap
