﻿using System;
using Reimburses.Data.Abstractions;
using ExtCore.Data.Abstractions;

namespace Reimburses.ViewModels. RequestOvertime
{
    class  RequestOvertimeModelFactory
    {
        public  RequestOvertimeModelFactory()
        {
        }

        internal  RequestOvertimeIndexViewModel LoadAll(IStorage storage, int page, int size)
        {
            var  requestOvertimeRepo = storage.GetRepository<IRequestOvertimeRepository>();

            var queryRequestOvertime = requestOvertimeRepo.Query;

            return new  RequestOvertimeIndexViewModel( requestOvertimeRepo.All(queryRequestOvertime, page, size));
        }
    }
}
