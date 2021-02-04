using System;

namespace Inventory_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat Item are you putting in the inventory?");
            var item = Console.ReadLine();
            Console.WriteLine("Enter a Sell In Value");
            int sellIn;
            if (int.TryParse(Console.ReadLine(), out sellIn))
            {
            
            Console.WriteLine("Enter a Quality Value");
            int quality;
                if(int.TryParse(Console.ReadLine(), out quality)){
                    Console.WriteLine($"\n{item} has a Sell In value of {sellIn} and  Quality Value of {quality}");

                    if(item == "Aged Brie"){
                        int brieSellIn = sellIn - 1;
                        int brieQuality = quality + 1;
                        Console.WriteLine($"After one day the Aged Brie will have a Sell In value of {brieSellIn} and a Quality Value of {brieQuality}");
                    }

                    if(item == "Soap"){
                        int soapSellIn = sellIn;
                        int soapQuality = quality;
                        Console.WriteLine($"After one day the Soap will have a Sell In value of {soapSellIn} and a Quality Value of {soapQuality}");
                    }
                    if(item == "Fresh Item"){
                        int freshSellIn = sellIn -1;
                        int freshQuality;
                        if(freshSellIn < 0){

                            freshQuality = quality - (freshSellIn * -2);

                        } else {
                            freshQuality = quality -2;
                        };
                        Console.WriteLine($"After one day the Fresh Item will have a Sell In value of {freshSellIn} and a Quality Value of {freshQuality}");
                    }
                    if(item == "Frozen Food"){
                        int frozenSellIn = sellIn -1;
                        int frozenQuality;
                        if(sellIn < 0){
                            frozenQuality = quality - (sellIn * -5);
                        } else {
                            frozenQuality = quality -1;
                        };
                        Console.WriteLine($"After one day the Frozen Item will have a Sell In value of {frozenSellIn} and a Quality Value of {frozenQuality}");
                    }
                    if(item == "Christmas Crackers"){
                        DateTime christmasDay = new DateTime (2021, 12, 25);
                        DateTime today = DateTime.Now;
                        int daysUntilChristmas = (christmasDay - today).Days;

                        int christmasSellIn;
                        int christmasQuality;

                        if(daysUntilChristmas > 10){
                            christmasSellIn = sellIn - 1;
                            christmasQuality = quality * 0;

                            Console.WriteLine($"After one day the Christmas Cracker will have a Sell In value of {christmasSellIn} and a Quality Value of {christmasQuality}");
                        }else if(5 > daysUntilChristmas){
                            christmasSellIn = sellIn - 1;
                            christmasQuality = quality + 3;

                            Console.WriteLine($"After one day the Christmas Cracker will have a Sell In value of {christmasSellIn} and a Quality Value of {christmasQuality}");

                        } else {
                            christmasSellIn = sellIn - 1;
                            christmasQuality = quality + 2;

                            Console.WriteLine($"After one day the Christmas Cracker will have a Sell In value of {christmasSellIn} and a Quality Value of {christmasQuality}");
                        }
                    }

                    if(item=="INVALID ITEM"){
                        Console.WriteLine("NO SUCH ITEM");
                    }
            }
            else
            {

            Console.WriteLine("Please type a Sell In Number!");
            }
            Console.ReadLine();

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
    }
}
