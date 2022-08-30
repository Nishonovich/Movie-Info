﻿using MovieInfo.Data.Common;
using MovieInto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfo.Data.Interfaces
{
    public interface ICountryRepository:
        ICreateable<Country>, IReadable<Country>, IUpdateable<Country>, IDeleteable<Country>
    {

    }
}
