using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace NBA_League.Repository
{
    class DataReader
    {
        public static List<T> ReadData<T>(string FileName, CreateEntity<T> CreateEntity)
        {
            List<T> list = new List<T>();
            using (StreamReader sr = new StreamReader(FileName))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    T entity = CreateEntity(s);
                    list.Add(entity);
                }
            }
            return list;
        }
    }
}
