// See https://aka.ms/new-console-template for more information
using EFAssetsTracking;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Enter Gadget To Add In List");

MyDbContext Context = new MyDbContext();

Gadget gadget = new Gadget();

// CRUD

// CREATE Data (Insert Data)

Console.Write("Gadget Brand: ");
string gadgetBrand = Console.ReadLine();
Console.Write("Gadget Model: ");
string gadgetModel = Console.ReadLine();
Console.Write("Gadget PurchaseDate: ");
string gadgetPurchaseDate = Console.ReadLine();
Console.Write("Gadget Office: ");
string gadgetOffice = Console.ReadLine();
Console.Write("Gadget Price: ");
int gadgetPrice = Convert.ToInt32(Console.ReadLine());
Console.Write("Gadget Currency: ");
string gadgetCurrency = Console.ReadLine();
Console.Write("Electronic Id: ");
int electronicId = Convert.ToInt32(Console.ReadLine());

gadget.Brand = gadgetBrand;
gadget.Model = gadgetModel;
gadget.Office = gadgetOffice;
gadget.Price = gadgetPrice;
gadget.Currency = gadgetCurrency;
gadget.ElectronicId = electronicId;

Context.Gadgets.Add(gadget);
Context.SaveChanges();

Console.WriteLine("gadget added");

Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine();

List<Gadget> items = Context.Gadgets.ToList();
Console.WriteLine("Brand".PadRight(15)+ "Model".PadRight(15)+ "PurchaseDate".PadRight(15) + "Office".PadRight(15) +"Price".PadRight(15) + "Currency".PadRight(15) + "Local price today");

Console.WriteLine("-----------------------------------------------------------------------------------------------------");
Console.WriteLine();

//READ Data (SELECT Data - Get Data from DB)

items = items.OrderBy(item => item.Office).ThenBy(item => item.PurchaseDate).ToList();

TimeSpan timeDiff;
foreach (var item in items)
{
    /*
     * Calculating localPrice depending on set currency.
     */
    var LocalPrice = 0;
    timeDiff = DateTime.Now - item.PurchaseDate;
    if (item.Currency.Equals("INR"))
    {
        LocalPrice = item.Price * 83;
    }
    else if (item.Currency == "SEK")
    {
        LocalPrice = item.Price * 11;
    }
    else
    {
        LocalPrice = item.Price;
    }

    //Checking if device purchase date less than 3 months away from 3 years
    if (timeDiff.Days >= 1005)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(item.Brand.PadRight(15) +
        item.Model.PadRight(15) + item.PurchaseDate.ToString("yyyy/MM/dd").PadRight(15) + item.Office.PadRight(15) + item.Price.ToString().PadRight(15) + item.Currency.PadRight(15) + LocalPrice);
        Console.ResetColor();
    }
    ////Checking if device purchase date less than 6 months away from 3 years
    else if (timeDiff.Days >= 915 && timeDiff.Days < 1005)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(item.Brand.PadRight(15) +
        item.Model.PadRight(15) + item.PurchaseDate.ToString("yyyy/MM/dd").PadRight(15) + item.Office.PadRight(15) + item.Price.ToString().PadRight(15) + item.Currency.PadRight(15) + LocalPrice);
        Console.ResetColor();
    }
    else
    {
        Console.WriteLine(item.Brand.PadRight(15) +
        item.Model.PadRight(15) + item.PurchaseDate.ToString("yyyy/MM/dd").PadRight(15) + item.Office.PadRight(15) + item.Price.ToString().PadRight(15) + item.Currency.PadRight(15) + LocalPrice);
        
    }

}




// UPDATE Data (Edit Data in ´Database)

Gadget gadget3 = Context.Gadgets.FirstOrDefault(x => x.Id == 3);
gadget3.Price = 700;
Context.Gadgets.Update(gadget3);
Context.SaveChanges();

// DELETE (Remove data from Database)
Gadget gadget5 = Context.Gadgets.FirstOrDefault(y => y.Id == 5);
Context.Gadgets.Remove(gadget5);
Context.SaveChanges();