namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PlayAgain = "Ja";

            while (PlayAgain.ToLower().Trim() == "ja")
            {
                Random rand = new Random();
                int tärning = rand.Next(1, 7);
                int Playersum = 0;
                int Dealersum = 0;

                Console.WriteLine("\n" + "Välkommen till 21:an!");
                Console.WriteLine("Vill du kasta tärningen? JA ELLER NEJ?");

                string Kast = Console.ReadLine();

                while (Kast.ToLower().Trim() == "ja")
                {

                    tärning = rand.Next(1, 7);
                    Console.WriteLine("Du fick " + tärning);
                    Playersum += tärning;



                    if (Dealersum < 17 && Playersum < 21)
                    {
                        tärning = rand.Next(1, 7);
                        Console.WriteLine("Dealern fick " + tärning);
                        Dealersum += tärning;
                    }


                    if (Dealersum > 17 || Dealersum == 17)
                    {
                        Console.WriteLine("Dealern är klar! Han vill inte kasta igen!");
                    }

                    Console.WriteLine("Dealerna har: " + Dealersum + " poäng");
                    Console.WriteLine("Du har: " + Playersum + " poäng");

                    if (Playersum > 21)
                    {
                        break;
                    }

                    else if (Dealersum > 21)
                    {
                        break;
                    }

                    else if (Playersum == 21)
                    {
                        break;
                    }

                    else if (Dealersum == 21)
                    {
                        break;
                    }

                    Console.WriteLine("\n" + "Vill du kasta tärningen igen? JA ELLER NEJ?");
                    Kast = Console.ReadLine();
                }


                while (Kast.ToLower().Trim() == "nej")
                {
                    if (Dealersum < 17)
                    {
                        tärning = rand.Next(1, 7);
                        Console.WriteLine("\n" + "Dealern fick " + tärning);
                        Dealersum += tärning;
                        Console.WriteLine("Dealerna har: " + Dealersum + " poäng");
                    }


                    else if (Dealersum >= 17)
                    {
                        Console.WriteLine("Dealern är klar! Han vill inte kasta igen!");
                        break;
                    }


                }



                if (Dealersum > 21)
                {
                    Console.WriteLine("\n" + "Du vann för att Dealern fick över 21 poäng");
                }

                else if (Playersum > 21)
                {
                    Console.WriteLine("\n" + "Du förlårade för att du fick över 21 poäng");
                }

                else if (Dealersum == 21)
                {
                    Console.WriteLine("\n" + "Du förlorade för Dealern fick 21 poäng");
                }

                else if (Playersum == 21)
                {
                    Console.WriteLine("\n" + "Du vann för du fick 21 poäng!");
                }

                else if (Playersum < 21 && Dealersum < 21 && Playersum > Dealersum)
                {
                    Console.WriteLine("\n" + "Du vann för du fick mer poäng än Dealern");
                }

                else if (Playersum < 21 && Dealersum < 21 && Dealersum > Playersum)
                {
                    Console.WriteLine("\n" + "Du förlårade för du fick mindre poäng än Dealern");
                }

                else if (Playersum < 21 && Dealersum < 21 && Playersum == Dealersum)
                {
                    Console.WriteLine("\n" + "Du förlårade för du fick lika mycket poäng som Dealern");
                }

                Console.WriteLine("\n" + "Dealerna fick: " + Dealersum + " poäng");
                Console.WriteLine("Du fick: " + Playersum + " poäng");

                Console.WriteLine("\n" + "Vill du spela igen?");
                PlayAgain = Console.ReadLine();

                if (PlayAgain.ToLower().Trim() == "nej")
                {
                    Console.WriteLine("Okej, kul att du spelade");
                    break;
                }
            }

        }
    }
}