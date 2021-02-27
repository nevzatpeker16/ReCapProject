using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Core.Utilities.FileHelper
{
   public class FileHelper
    {
        public static string AddAsync(IFormFile formFile)
        {
            var result = newPath(formFile);
            try
            {
                var sourcepath = Path.GetTempFileName();
                if (formFile.Length > 0)
                    using (var stream = new FileStream(sourcepath, FileMode.Create))
                        formFile.CopyTo(stream);

                File.Move(sourcepath, result.newPath);


            }
            catch (Exception ex)
            {
                return ex.Message;
               
            }
            return result.Path2;

        }
        public static string UpdateAsync(string sourcePath,IFormFile formFile)
        {
            var result = newPath(formFile);
            try
            {
                if (formFile.Length > 0)
                {
                    using (var stream = new FileStream(sourcePath, FileMode.Create))
                        formFile.CopyTo(stream);
                }
                File.Delete(sourcePath);

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            return result.Path2;
        }
        public static IResult DeleteAsync(string filePath)
        {
            try
            {
                File.Delete(filePath);
            }
            catch (Exception ex)
            {

                return new ErorResult(ex.Message);
            }
            return new SuccessResult();
        }
        public static (string newPath, string Path2) newPath(IFormFile file)
        {
            System.IO.FileInfo ff = new System.IO.FileInfo(file.FileName);
            string fileExtension = ff.Extension;

            var creatingUniqueFilename = Guid.NewGuid().ToString("N")
               + "_" + DateTime.Now.Month + "_"
               + DateTime.Now.Day + "_"
               + DateTime.Now.Year + fileExtension;

            //string path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).FullName + @"\Images");

            string path = Environment.CurrentDirectory + @"\wwwroot\Images";

            string result = $@"{path}\{creatingUniqueFilename}";

            return (result, $"\\Images\\{creatingUniqueFilename}");
        }
    }
}
