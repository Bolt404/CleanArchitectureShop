using CleanArchitectureShop.Domain;
using CleanArchitectureShop.InterfaceAdapter;

namespace CleanArchitectureShop.Infrastructur.Adapters;

public class ItemTxtFileAdapter : IAdapterInterface
{
    /// <summary>
    /// GetAllItems, get's a list of items from a file.
    /// </summary>
    /// <param name="url"></param>
    /// <returns>List<Item></returns>
    public List<Order> GetAllItems(String url)
    {
        //Init list til items.
        List<Order> myItemList = new List<Order>();

        //Try-catch i tilfælde af at min StreamReader fejler.
        try
        {
            //Using til min StreamReader.
            using (StreamReader sr = new StreamReader(url))
            {
                string? line = sr.ReadLine();

                //Vi kigger kun i filen så længe der er liner at læse.
                while (line != null)
                {
                    //Deler filen op i de relevante dele.
                    string[] sub = line.Split(",");
                    
                    //Nyt item
                    Item item = new Item(sub[0], sub[1], double.Parse(sub[2]));
                    
                    //Tilføres til min List
                    myItemList.Add(item);

                    //Næste line
                    line = sr.ReadLine();
                }

                //Return min list
                return myItemList;
            }
        }
        catch (Exception e)
        {
            //Skulle aldrig nå her til hvis alt går godt.
            Console.WriteLine("Didn't work " + e);
            throw;
        }
    }
}