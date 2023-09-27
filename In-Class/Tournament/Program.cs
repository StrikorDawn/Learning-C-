// See https://aka.ms/new-console-template for more information
Team Mario = new Team("Mario");
Player ronaldo = new Player("Chrisiano Ronaldo", 7);
Player taden = new Player("Taden Marston", 47);

Mario.AddPlayer(taden);
Mario.AddPlayer(ronaldo);

Mario.DisplayRoster();