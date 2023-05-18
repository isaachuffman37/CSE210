// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Player neymar = new Player("Neymar jr", 10, "Forward");

// neymar._name = "Neymar Jr.";
// neymar._position = "Forward";
// neymar._jerseyNumber = 10;

Player kobe = new Player("Kobe Bryant", 24);
kobe.SetPosition("Guard");

// kobe.display();

Team awesomesauce = new Team("Awesome Sauce");
awesomesauce.AddPlayer(kobe);
awesomesauce.AddPlayer(neymar);
awesomesauce.DisplayRoster();
awesomesauce.AddWin();