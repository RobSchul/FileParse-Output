using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerFile
{
    public class FileReader
    {
        public  LinkedList<int> FileRead(string filePath)
        {
            try
            {
              return new LinkedList<int>(Array.ConvertAll(System.IO.File.ReadAllLines(filePath), s=> int.Parse(s)));
            }
            catch(Exception e)
            {
                throw new Exception("Error with file, please check input file");
            }
        }

    }
}
