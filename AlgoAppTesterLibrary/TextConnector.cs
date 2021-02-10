using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;


namespace AlgoAppTesterLibrary.TextProcessor
{   /// <summary>
    /// Used before making txt files a resource. 
    /// Called by setting text box text = TextConnecter.FullFilePath("file Name.tx").LoadFile();
    /// </summary>
    public static class TextConnector
    {   /// <summary>
        /// Takes in string of file name and concats with file path from appsettings
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns> full file path as a string </returns>
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }

        public static string LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                string errorMessage = "File not found";
                return errorMessage;
            }
            return File.ReadAllText(file);
        }
    }
}
