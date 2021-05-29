using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cmd.App.Storages
{
    public interface IStorage
    {

    }

    public interface IDriveStorage
    {

    }

    public interface ICloudStorage : IStorage, IDriveStorage
    {

    }
}
