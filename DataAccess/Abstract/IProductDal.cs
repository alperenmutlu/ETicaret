﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //product ile ilgili veri tabanında yapılacak operasyonları içerir.
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
