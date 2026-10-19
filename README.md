# Table-Ease

A Windows desktop app for small restaurants to manage table reservations and customer bills, available in English, French and Spanish.

## Features

- **Reservations:** book a table with the customer's name, phone number, party size, date, time, table number and special requests.
- **Manage bookings:** view all reservations, modify them and read customer comments.
- **Billing:** build a bill for a table with subtotal, tax, tip and total, and the waiter's name.
- **Three languages:** switch the whole interface between English, French (Canada) and Spanish at runtime using .NET resource files.
- **Local database:** reservations are stored in a SQL Server LocalDB database through Entity Framework.

## Tech stack

| Area | Tools |
|---|---|
| Language | C# |
| UI | Windows Forms (.NET Framework 4.7.2) |
| Data | SQL Server LocalDB, Entity Framework (database-first `.edmx` model), ADO.NET |
| Localization | .resx resource files (en, fr-CA, es) |

## Project structure

```text
TableEase/
├── TableEase.sln
└── TableEase/
    ├── Program.cs              # Entry point
    ├── MainMenu.cs             # Reservation list, modify, comments, billing
    ├── Reservation.cs          # New reservation form
    ├── Bill.cs                 # Billing form
    ├── ChangeLanguage.cs       # Runtime language switching
    ├── Connector.cs            # Database connection
    ├── Model1.edmx             # Entity Framework model
    ├── Database.mdf            # LocalDB database
    └── *.en / *.fr-CA / *.es .resx  # Translations
```

## Running it

1. Install Visual Studio with the **.NET desktop development** workload (this includes SQL Server LocalDB).
2. Open `TableEase/TableEase.sln`.
3. Press **F5**. The database file is copied next to the app when it builds, so no setup is needed.
