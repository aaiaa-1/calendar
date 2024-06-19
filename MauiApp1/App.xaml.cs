﻿using Calendar.Data;

namespace MauiApp1;

public partial class App : Application
{
    static EventDatabase database;

    public static EventDatabase Database
    {
        get
        {
            if (database == null)
            {
                var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Events.db3");
                database = new EventDatabase(dbPath);
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