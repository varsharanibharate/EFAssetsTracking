// See https://aka.ms/new-console-template for more information
using EFAssetsTracking;
using System.Runtime.Intrinsics.X86;



MyDbContext Context = new MyDbContext();

Gadget gadget = new Gadget();

// CRUD

while (true)
{
    Console.Write("Enter 'Get' to fetch,'Insert' to add, 'Edit' for Editing list,'Delete' to Delete, 'Q' for Quit: ");
    var input = Console.ReadLine();

    Console.WriteLine();
    Console.WriteLine();


    if (input == "Get")
    {
        List<Gadget> items = Context.Gadgets.ToList();
        Console.WriteLine("Id".PadRight(8) + "Brand".PadRight(15) + "Model".PadRight(15) + "Purchase Date".PadRight(15) + "Office".PadRight(13) + "Price".PadRight(10) + "Currency".PadRight(10) + "Local Price".PadRight(15) + "Electronic Id");

        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
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
                Console.WriteLine(item.Id.ToString().PadRight(8) + item.Brand.PadRight(15) +
                item.Model.PadRight(15) + item.PurchaseDate.ToString("yyyy/MM/dd").PadRight(15) + item.Office.PadRight(13) + item.Price.ToString().PadRight(10) + item.Currency.PadRight(10) + LocalPrice.ToString().PadRight(15) + item.ElectronicId);
                Console.ResetColor();
            }
            ////Checking if device purchase date less than 6 months away from 3 years
            else if (timeDiff.Days >= 915 && timeDiff.Days < 1005)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item.Id.ToString().PadRight(8) + item.Brand.PadRight(15) +
                item.Model.PadRight(15) + item.PurchaseDate.ToString("yyyy/MM/dd").PadRight(15) + item.Office.PadRight(13) + item.Price.ToString().PadRight(10) + item.Currency.PadRight(10) + LocalPrice.ToString().PadRight(15) + item.ElectronicId);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine(item.Id.ToString().PadRight(8) + item.Brand.PadRight(15) +
                item.Model.PadRight(15) + item.PurchaseDate.ToString("yyyy/MM/dd").PadRight(15) + item.Office.PadRight(13) + item.Price.ToString().PadRight(10) + item.Currency.PadRight(10) + LocalPrice.ToString().PadRight(15) + item.ElectronicId);
               
            }

        }

        Console.WriteLine();

        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");


    }

    else if (input == "Insert")
    {

        // CREATE Data (Insert Data)
        Console.WriteLine("Enter Gadget To Add In List");

       
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
        gadget.PurchaseDate = Convert.ToDateTime(gadgetPurchaseDate);
        gadget.Office = gadgetOffice;
        gadget.Price = gadgetPrice;
        gadget.Currency = gadgetCurrency;
        gadget.ElectronicId = electronicId;

        Context.Gadgets.Add(gadget);
        Context.SaveChanges();

        Console.WriteLine("gadget added");

        Console.WriteLine("-----------------------------------------------------------------------------------------------------");
        Console.WriteLine();

    }
    else if (input == "Edit")
    {

        //UPDATE Data (Edit Data in ´Database)

        Console.Write("Enter Gadget Id To Edit: ");
        int idToUpdate = Convert.ToInt32(Console.ReadLine());
        Gadget gadgetUpdated = Context.Gadgets.FirstOrDefault(x => x.Id == idToUpdate);

        Console.WriteLine();

        Console.Write("Gadget Brand: ");
        gadgetUpdated.Brand = Console.ReadLine();
        Console.Write("Gadget Model: ");
        gadgetUpdated.Model = Console.ReadLine();
        Console.Write("Gadget PurchaseDate: ");
        gadgetUpdated.PurchaseDate = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Gadget Office: ");
        gadgetUpdated.Office = Console.ReadLine();
        Console.Write("Gadget Price: ");
        gadgetUpdated.Price = Convert.ToInt32(Console.ReadLine());
        Console.Write("Gadget Currency: ");
        gadgetUpdated.Currency = Console.ReadLine();
        Console.Write("Gadget ElectronicId: ");
        gadgetUpdated.ElectronicId = Convert.ToInt32(Console.ReadLine());
        Context.Gadgets.Update(gadgetUpdated);
        Context.SaveChanges();

    }

    else if (input == "Delete")
    {
        // DELETE (Remove data from Database)

        Console.Write("Enter Gadget Id To Delete: ");
        int idToDelete = Convert.ToInt32(Console.ReadLine());
        Gadget gadgetDelete = Context.Gadgets.FirstOrDefault(y => y.Id == idToDelete);
        Context.Gadgets.Remove(gadgetDelete);
        Context.SaveChanges();

    }

    else if (input == "Q")
    {
        break;
    }
}