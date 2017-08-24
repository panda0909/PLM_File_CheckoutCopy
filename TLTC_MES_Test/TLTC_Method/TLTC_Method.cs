using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Aras.IOM;

namespace TLTC_Method
{
    public class SaveMethod
    {
        Innovator inn;
        public SaveMethod(Innovator inno)
        {
            inn = inno;
        }
        public bool SaveMethodXML(Item itmMethod)
        {
            try
            {
                Item itmPath = inn.applySQL("select value from [innovator].[Variable] where name='TLTC_SaveMethod_Path'");
                if (itmPath.isError() == true)
                {
                    return false;
                }
                string path = itmPath.getProperty("value", "");
                string path_class = "";
                string path_name = itmMethod.getProperty("name","");
                switch (itmMethod.getProperty("method_type", ""))
                {
                    case "VB":
                        path_class = "VB";
                        break;
                    case "C#":
                        path_class = "C#";
                        break;
                    case "JavaScript":
                        path_class = "JavaScript";
                        break;
                }
                StreamWriter swXML = new StreamWriter(path + path_class +"\\"+ path_name+".xml");

                swXML.WriteLine(itmMethod.getProperty("method_code",""));
                swXML.Close();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }
    }
}
