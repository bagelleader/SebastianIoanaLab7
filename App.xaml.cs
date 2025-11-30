using SebastianIoanaLab7.Data;
using System.IO;
using System;

namespace SebastianIoanaLab7;

public partial class App : Application
{
    static ShoppingListDatabase? database;

    public static ShoppingListDatabase Database
    {
        get
        {
            if (database == null)
            {
                var dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                    "ShoppingList.db3");
                database = new ShoppingListDatabase(dbPath);
            }
            return database;
        }
    }

    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}
