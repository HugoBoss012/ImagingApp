using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WFAImageApp
{
    class ImageExtractorClass
    {
        CheckFiles cFiles = new CheckFiles();
        string Log = string.Empty;


    }
    public class CheckFiles
    {
        
        public void ProcessFiles(string input,int minSize, int ThreshSize , string output, string threshold, out string Log)
        {

            StringBuilder sbLog = new StringBuilder();
            Log = string.Empty;

            //check if directories exist if not create them
            sbLog.AppendLine(checkDir(input));
            sbLog.AppendLine(checkDir(output));
            sbLog.AppendLine(checkDir(threshold));
            DirectoryInfo dir = new DirectoryInfo(input);
            //Union method requires Linq
            FileInfo[] arrFiles = dir.GetFiles("*.tif").Union(dir.GetFiles("*.tiff"))
                .Union(dir.GetFiles("*.jpeg")).Union(dir.GetFiles("*.jpg")).ToArray();
            foreach (var ftp in arrFiles)
            {
                try
                {
                    //Console.WriteLine(ftp.Name);
                    if (ftp.Length / 1024 >= minSize)
                    {
                        //if file is smaller than 15 kb move to captiva folder
                        ftp.MoveTo(Path.Combine(output, ftp.Name));
                        sbLog.AppendLine(ftp.Name + " moved to " + output);
                    }
                    else if (ftp.Length / 1024 >= ThreshSize & ftp.Length / 1024 < minSize)
                    {
                        //if file is smaller than 15kb and bigger than 10kb move to folder for users to check
                        ftp.MoveTo(Path.Combine(threshold, ftp.Name));
                        sbLog.AppendLine(ftp.Name + " moved to " + threshold);
                    }
                    //smaller than 10kb leave file as is
                }
                catch (Exception ex)
                {
                    sbLog.AppendLine(ex.Message);
                    if (!string.IsNullOrEmpty(ex.InnerException.ToString()))
                    {
                        sbLog.Append("-" + ex.InnerException);
                    }
                }
            }
            Log = sbLog.ToString();
        }

        public string checkDir(string directory)
        {
            if (!Directory.Exists(directory))
            {
                try
                {
                    Directory.CreateDirectory(directory);
                    return directory + " created";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
            return directory + " exists";
        }
    }

}

