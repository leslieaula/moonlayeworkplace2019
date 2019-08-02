﻿using System;
using Employees.Data.Abstractions;
using Employees.ViewModels.Employee;
using ExtCore.Data.Abstractions;

namespace Employees.ViewModels.BankAccount
{
    internal class BankAccountModelFactory
    {
        public BankAccountModelFactory()
        {
        }

        internal BankAccountIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var bankRepo = storage.GetRepository<IBankAccountRepository>();

            var queryBank = bankRepo.Query;

            return new BankAccountIndexViewModel(bankRepo.All(queryBank, page, size));
        }
    }
}