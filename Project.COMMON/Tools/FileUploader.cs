using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Project.COMMON.Tools
{
    public static class FileUploader
    {
        //HttpPostedFileBase => MVC'de eğer Post yönteminde bir dosya geliyorsa bu dosya, HttpPostedFileBase tipinde tutulur!

        public static string UploadFile(string serverPath, HttpPostedFileBase file)
        {
            if (file != null)
            {
                Guid uniqueName = Guid.NewGuid();

                string[] fileArray = file.FileName.Split('.');

                string extension = fileArray[fileArray.Length - 1].ToLower();

                string fileName = $"{uniqueName}.{extension}";

                if (extension == "docx" || extension == "xlsx")
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(serverPath+fileName)))
                    {
                        return "1";
                    }
                    else
                    {
                        string filePath = HttpContext.Current.Server.MapPath(serverPath + fileName);
                        file.SaveAs(filePath);

                        return serverPath + fileName;
                    }
                }
                else
                {
                    return "2";
                }
            }
            else
            {
                return "3";
            }
        }
    }
}
