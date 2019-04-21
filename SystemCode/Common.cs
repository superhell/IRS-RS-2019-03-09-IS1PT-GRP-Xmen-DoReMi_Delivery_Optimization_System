using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
 

namespace Sys.Tool
{
    public class Serialization
    {
        public static void SerializeObject(object obj, string fileName)
        {           
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryFormatter BF = new BinaryFormatter();
                BF.Serialize(fs, obj);
                fs.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
           
        }

        public static object DeSerializeObject(string fileName)
        {
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter BF = new BinaryFormatter();
                object obj = BF.Deserialize(fs);
                fs.Close();
                return obj;
            }
            catch (Exception e)
            {
                throw e;
            }
          
        }

    }


}