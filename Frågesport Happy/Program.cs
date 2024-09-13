

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Clear();
string igen = "";

spel();

System.Console.WriteLine("Vill du spela igen?");
igen = Console.ReadLine();
if(igen =="ja" || igen == "Ja"){
spel();
}
else if(igen == "Nej" || igen == "nej"){
   Environment.Exit(0);
}


static void spel()
{
   string Startsvar = "";
string fråga1 = "";
string fråga2 = "";
string fråga3 = "";
string fråga4 = "";
string resultat = "";
int fel = 0;
int rätt = 0;

   System.Console.WriteLine("Välkommen till frågesport. Är du redo?");
   Startsvar = Console.ReadLine();
   if (Startsvar == "ja" || Startsvar == "Ja")
   {
      System.Console.WriteLine("Du kommer att få svara på 4 frågor. Om du svara rätt på alla vinner du 20000$!");
      System.Console.WriteLine("Fråga 1, Vad är en fluga? Är det en insekt, frukt eller ett land?");
      fråga1 = Console.ReadLine();
   }
   else if (Startsvar.ToLower() == "nej")
   {
      Environment.Exit(0);
   }

   if (fråga1.ToLower() == "en insekt")
   {
      System.Console.WriteLine("Grattis rätt svar");
      rätt = 1;
      System.Console.WriteLine($" Du har {rätt} poäng rätt");
   }
   else
   {
      System.Console.WriteLine("Womp Womp fel svar");
      fel = 1;
      System.Console.WriteLine($"Du har {fel} poäng fel");
   }

   System.Console.WriteLine("Fråga 2, Hur många ben har en kyckling? 2, 4 eller 16?");
   fråga2 = Console.ReadLine();

   if (fråga2.ToLower() == "2")
   {
      System.Console.WriteLine("rätt svar");
      rätt++;
      System.Console.WriteLine($"Du har {rätt} poäng rätt");
   }
   else
   {
      System.Console.WriteLine("Fel svar");
      fel++;
      Console.WriteLine($"Du har {fel} pöäng fel");
   }

   System.Console.WriteLine("Fråga 3, Vad är mjöl. Vete, råg eller havre");
   fråga3 = Console.ReadLine();
   if (fråga3.ToLower() == "vete")
   {
      System.Console.WriteLine("Rätt svar");
      rätt++;
      System.Console.WriteLine($"Du har {rätt} pöäng rätt");
   }
   else
   {
      System.Console.WriteLine("Fel svar");
      fel++;
      System.Console.WriteLine($"Du har {fel} poäng fel ");
   }

   System.Console.WriteLine(" fråga 4, hur många pucklar har en kamel. 4,2 eller 3.");
   fråga4 = Console.ReadLine();
   if (fråga4.ToLower() == "2")
   {
      System.Console.WriteLine("Rätt svar");
      rätt++;
      System.Console.WriteLine($"Du har {rätt} poäng rätt");
   }
   else
   {
      System.Console.WriteLine("Fel svar.");
      fel++;
      System.Console.WriteLine($"Du har {fel} poäng fel");
   }
   System.Console.WriteLine(" Redo för resultat?");
   resultat = Console.ReadLine();

   if (resultat.ToLower() == "ja")
   {
      System.Console.WriteLine($"Du fick {rätt} poäng rätt och {fel} poäng fel");
   }


   
}
