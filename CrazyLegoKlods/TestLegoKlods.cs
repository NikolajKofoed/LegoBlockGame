



LegoKlods newLego = new LegoKlods(1, 1);

//Console.WriteLine(newLego.XValue);
//Console.WriteLine(newLego.YValue);

newLego.GoUp();

newLego.GoUp();
newLego.GoUp();



// skriver x og y værdierne til konsolen
newLego.PrintXAndY();
Console.WriteLine();

// sætter position til en anden position
newLego.SetPosition(4, 7);


newLego.PrintXAndY();
Console.WriteLine();

// en anden måde at sætte position til en anden position
newLego.SetPositionAlternative(-25, 18);


newLego.PrintXAndY();
Console.WriteLine();

// test roter lego klods, den skal kunne ændres for newLego.RotateLego(); og gå fra true = false, og false = true hver gang den bliver kaldt

newLego.RotateLego();

Console.WriteLine(newLego.IsVertical);

newLego.RotateLego();

Console.WriteLine(newLego.IsVertical);

newLego.RotateLego();

Console.WriteLine(newLego.IsVertical);


