using System.Collections.Generic;

namespace GildedRose
{
    class Inventory
    {
        private readonly IEnumerable<Item> items;

        public Inventory(IEnumerable<Item> items)
        {
            this.items = items;
        }

        /// <summary>
        /// Items:
        /// "+5 Dexterity Vest"
        /// "Aged Brie"
        /// "Elixir of the Mongoose"
        /// "Sulfuras, Hand of Ragnaros"
        /// "Backstage passes to a TAFKAL80ETC concert"
        /// "Conjured Mana Cake"
        /// </summary>
        public void UpdateQuality()
        {
            foreach(Item item in items)
            {
                item.Quality--;
                item.SellIn--;

                if (item.Name == "Aged Brie")
                {
                    item.Quality+=2;                   
                    if (item.SellIn < 0)
                    {
                        item.Quality +=2;
                    }
                }

                if (item.SellIn < 0)
                {
                    item.Quality --;
                }
                if (item.Name.Contains("Conjured"))
                {
                    item.Quality--;
                    if (item.SellIn < 0)
                    {
                        item.Quality--;
                    }
                }
                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    item.Quality += 2;

                    if (item.SellIn < 11)
                    {
                        item.Quality++;
                    }
                    if (item.SellIn < 6)
                    {
                        item.Quality++;
                    }
                    if (item.SellIn <= 0)
                    {
                        item.Quality = 0;
                    }
                }

                if (item.Quality > 50)
                {
                    item.Quality = 50;
                }
                if (item.Quality < 0)
                {
                    item.Quality = 0;
                }

                if (item.Name == "Sulfuras, Hand of Ragnaros")
                {
                    item.Quality = 80;
                    item.SellIn++;
                }
                
            }
        }
    }
}
