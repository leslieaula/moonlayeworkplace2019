﻿using System;
using Reimburses.Data.Abstractions;
using ExtCore.Data.Abstractions;

namespace Reimburses.ViewModels.QuickLeave
{
    class QuickLeaveModelFactory
    {
        public QuickLeaveModelFactory()
        {
        }
        internal QuickLeaveIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var quickLeaveRepo = storage.GetRepository<IQuickLeaveRepository>();

            var queryQuickLeave = quickLeaveRepo.Query;

            return new QuickLeaveIndexViewModel(quickLeaveRepo.All(queryQuickLeave, page, size));
        }
    }
}
