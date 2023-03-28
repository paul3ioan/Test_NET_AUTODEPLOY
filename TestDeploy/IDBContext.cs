using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDeploy
{
    public interface IDBContext: IDisposable
    {
        DbSet<Test1> Test1s { get; set; }

    }
}
