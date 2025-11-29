using System;
using Shared.Models;
using Shared.Services.Implementations;

class Program
{
    static void Main(string[] args)
    {
        //var usd = new Currency();
        //usd.Id = 1;
        //usd.Name = "US Dollar";
        //usd.Code = "USD";
        //usd.Symbol = "$";
        //usd.DecimalPlaces = 2;
        //Console.WriteLine("Currency created: " + usd.Name + "\n");


        //var cat = new Category();
        //cat.Id = 1;
        //cat.Name = "Food";

        //var sub = new SubCategory();
        //sub.Id = 1;
        //sub.CategoryId = 1;
        //sub.Name = "Restaurants";

        //Console.WriteLine("Category: " + cat.Name);
        //Console.WriteLine("SubCategory: " + sub.Name + " (CatId=" + sub.CategoryId + ")\n");


        //var project = new Project();
        //project.Id = 1;
        //project.Name = "Marketing";
        //project.Description = "Black Friday campaign";
        //project.IsActive = true;
        //Console.WriteLine("Project created: " + project.Name + "\n");


        //var accService = new AccountService();

        //var acc = new Account();
        //acc.Name = "Main Wallet";
        //acc.CurrencyId = 1;
        //acc.OwnerUserId = 10;
        //acc.DepartmentId = 3;
        //acc.Balance = 500;

        //var accCreated = accService.Create(acc);
        //Console.WriteLine("Account created: " + accCreated);

        //var accounts = accService.GetAll();
        //Console.WriteLine("Accounts count: " + accounts.Count);

        //var foundAcc = accService.GetById(1);
        //Console.WriteLine("Found account name: " + foundAcc.Name);

        //foundAcc.Name = "Updated Wallet";
        //accService.Update(foundAcc);

        //Console.WriteLine("Updated account name: " + accService.GetById(1).Name);

        //accService.Deactivate(1,100);
        //Console.WriteLine("Is active after deactivate: " + accService.GetById(1).IsActive + "\n");



        //var trxService = new TransactionService();

        //var t1 = new Transaction();
        //t1.AccountId = 1;
        //t1.CurrencyId = 1;
        //t1.Amount = 120;
        //t1.IsIncome = true;
        //t1.TrxDate = DateTime.Now;
        //t1.CategoryId = 1;
        //t1.SubCategoryId = 1;
        //t1.ProjectId = 1;
        //trxService.Create(t1);

        //Console.WriteLine("Created trx1, amount: " + t1.Amount);

        //var t2 = new Transaction();
        //t2.AccountId = 1;
        //t2.CurrencyId = 1;
        //t2.Amount = 300;
        //t2.IsIncome = false;
        //t2.TrxDate = DateTime.Now;
        //t2.CategoryId = 1;
        //t2.SubCategoryId = 1;
        //t2.ProjectId = 1;
        //trxService.Create(t2);

        //Console.WriteLine("Created trx2, amount: " + t2.Amount);

        //var trxList = trxService.GetAll();
        //Console.WriteLine("Total trx: " + trxList.Count);

        //var foundTrx = trxService.GetById(1);
        //Console.WriteLine("Found trx1 amount: " + foundTrx.Amount);

        //foundTrx.Amount = 999;
        //trxService.Update(foundTrx);
        //Console.WriteLine("Updated trx1 amount: " + trxService.GetById(1).Amount);

        //trxService.Cancel(2, 77);
        //Console.WriteLine("Trx2 status after cancel: " + trxService.GetById(2).StatusId);


    }
}