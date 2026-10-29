class Ove
{
    static void Main(string[] args)  // hjelp metoder i samme class main da use static
    {


        Product product1 = new Product();
        product1.Name = "Apple";
        product1.Price = 0.5;
        product1.Count = 10;

        Product product2 = new Product();
        product2.Name = "Banana";
        product2.Price = 0.3;
        product2.Count = 20;
        product2.Price = 0.4;

        Console.WriteLine($"Product: {product1.Name}, har Price: {product1.Price}, og  Count: {product1.Count}, Total Value: {product1.TotalValue}");
        Console.WriteLine($"Product: {product2.Name}, Price: {product2.Price}, Count: {product2.Count}, Total Value: {product2.TotalValue}");





        string[] produkter =
       {    "Apple",
            "Banana",
            "brød",
            "milk",
            "Mango"};

        List<string> card = new List<string>(); // card user tom


        while (true)
        {
            Console.WriteLine("Skriv inn produktnavn for å legge til  your card, eller 'exit' for å avslutte:");
            String input = Console.ReadLine();

            if (input == "1")
            {
                Allprodukter(produkter);
            }

            if (input == "2")
            {

                AllelmnterCard(card);

            }

            if (input == "3") // legge til card hvis finnes i produkter array
            {    //chec hvis item er i produkter array

                Console.WriteLine("Skriv inn produktnavn :");
                String item = Console.ReadLine();

                bool isInArray = produktAvaible(produkter, item);// hvis true add to card
                if (isInArray)
                {
                    AdditemToCard(card, item); //

                    Console.WriteLine($"Produktet {item} er lagt til your card.");
                }

                Console.WriteLine("Press any key to coninue");
                Console.ReadLine();

            }
            if (input == "4")
            {  // chek if item is in card

                Console.WriteLine("Skriv inn produktnavn :");
                String item = Console.ReadLine();

                // bool isInArray = produktAvaible(produkter, item);
                bool isitemInCard = ItemInCard(card, item); //hvis true remove from card
                if (isitemInCard == true)
                {
                    card.Remove(item);
                    Console.WriteLine($"Produktet {item} er fjernet fra  your card.");
                }
                else
                {
                    Console.WriteLine($"Produktet {item} er ikke fjernet fra  your card Finnes ikke.");
                }







                Console.WriteLine("Press any key to coninue");
                Console.ReadLine();
            }

            if (input == "5")
            { // remov all items from card
              // card.Clear();
              // Console.WriteLine("Alle produkter er fjernet fra handlekurven.");
              // Console.WriteLine("Press any key to coninue");
              // Console.ReadLine();

                RemoveAllitemCard(card); // 

                Console.WriteLine("Press any key to coninue");
                Console.ReadLine();

            }
            if (input == "6")
            {
                Console.WriteLine("Avslutter programmet.");
                break;
            }


        }    // end while loop


        static void Allprodukter(string[] produkter)
        {
            Console.WriteLine("Produkter i butikken:");
            foreach (string produkt in produkter)
            {
                Console.WriteLine(produkt);
            }

            Console.WriteLine("Press enter to return to main menu.");
            Console.ReadLine(); // pause the loop :)
        }

        static void AllelmnterCard(List<string> card)
        {

            if (card.Count == 0)
            {
                Console.WriteLine("Card er tom.");
                Console.WriteLine("Press enter to return to main menu.");
                Console.ReadLine(); // pause the loop :)

            }


            Console.WriteLine("Produkter in card:");
            foreach (string produkt in card)
            {
                Console.WriteLine(produkt);
            }

            Console.WriteLine("Press enter to return to main menu.");
            Console.ReadLine(); // pause the loop :)
        }

        static bool produktAvaible(string[] produkter, string item)
        {
            foreach (string produkt in produkter)

            {

                if (produkt == item)
                {
                    Console.WriteLine($"Produktet {item} er tilgjengelig i butikken.");
                    return true;
                }

            }
            return false;
        }


        static bool ItemInCard(List<string> card, string item2)
        {
            if (card.Contains(item2))
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        static void AdditemToCard(List<string> card, string item)
        {
            card.Add(item);

        }

        static void RemoveAllitemCard(List<string> card)

        {

            while (card.Count > 0)
            {

                Console.WriteLine("Removing" + card[0]);

                card.Remove(card[0]);

            }







            // if (card.Contains(item3))
            // {
            //     card.Remove(item3);
            //     Console.WriteLine($"Produktet {item3} er fjernet fra your card.");
            // }
            // else
            // {
            //     Console.WriteLine($"Produktet {item} finnes ikke i your card.");
            // }
        }




    }



    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

        public double TotalValue
        {

            get { return Price * Count; }



        }

    }

}





//Vi skal hjelpe en butikk å lage en produktoversikt,