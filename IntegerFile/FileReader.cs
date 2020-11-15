using System;
using System.Collections.Generic;
using System.Text;

namespace IntegerFile
{
    public class FileReader
    {
        /// <summary>
        /// Make sure we can read the file and that it exists. if there are any strings in the file it fails any failure says that there is an issue with the file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
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
