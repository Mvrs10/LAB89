using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagementSystem
{
    public interface IPersistable
    {
        void Save(string path);
        void Load(string path);
    }
}
