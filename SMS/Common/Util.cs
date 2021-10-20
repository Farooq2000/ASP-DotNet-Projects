using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Common;

namespace SMS.Common
{
    public class Util
    {
        //[ExcludeFromCodeCoverage]
        //public static string GetPaynomixAPIKey(APIKey key)
        //{

        //    return Convert.ToBase64String(Encoding.UTF8.GetBytes(key.ToJson()))
        //            .Replace('+', '_')
        //            .Replace('/', ':')
        //            .Replace('=', 'A');
        //}

        /// <summary>
        /// TemplatePath complete template path 
        /// </summary>
        /// <param name="TemplatePath"></param>
        /// <returns></returns>
        public static string CreateEmailBody(string TemplatePath)
        {
            string body = string.Empty;

            using (StreamReader reader = new StreamReader(TemplatePath))
            {
                body = reader.ReadToEnd();
            }
            return body;

        }

        //   [ExcludeFromCodeCoverage]
        //    public static string Base64Encode(string plainText)
        //    {
        //        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        //        return System.Convert.ToBase64String(plainTextBytes);
        //    }

        //    [ExcludeFromCodeCoverage]
        //    public static string Base64Decode(string base64EncodedData)
        //    {
        //        var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
        //        return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        //    }

        //    public static string RandomString(int size, bool lowerCase)
        //    {
        //        StringBuilder builder = new StringBuilder();
        //        Random random = new Random();
        //        char ch;
        //        for (int i = 0; i < size; i++)
        //        {
        //            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
        //            builder.Append(ch);
        //        }
        //        if (lowerCase)
        //            return builder.ToString().ToLower();
        //        return builder.ToString();
        //    }
        //    public static int RandomNumber(int min, int max)
        //    {
        //        Random random = new Random();
        //        return random.Next(min, max);
        //    }
        //    public static string GenPassword(bool IsEncrypted = false)
        //    {
        //        string password = "";
        //        StringBuilder builder = new StringBuilder();
        //        builder.Append(RandomString(4, true));
        //        builder.Append(RandomNumber(1000, 9999));
        //        builder.Append(RandomString(2, false));
        //        password = builder.ToString();

        //        if (IsEncrypted)
        //            return password.MD5Encrypt();
        //        else
        //            return password;

        //        //return "123";
        //    }

        //    //public static string ReadConfig(string key)
        //    //{
        //    //    if (ConfigurationManager.AppSettings[key] != null)
        //    //    {
        //    //        return ConfigurationManager.AppSettings[key];
        //    //    }
        //    //    return string.Empty;
        //    //}

        //    public static string EncryptData(string plaintext)
        //    {
        //        if (!string.IsNullOrEmpty(plaintext))
        //        {
        //            byte[] plaintext_Bytes = Encoding.Unicode.GetBytes(plaintext);
        //            return Convert.ToBase64String(plaintext_Bytes);
        //            //return Security.Encrypt(text, "123");
        //        }
        //        else
        //            return string.Empty;
        //    }

        //    [ExcludeFromCodeCoverage]
        //    public static string DecryptData(string ciphertext)
        //    {
        //        if (!string.IsNullOrEmpty(ciphertext))
        //        {
        //            byte[] ciphertext_Bytes = Convert.FromBase64String(ciphertext);
        //            return Encoding.Unicode.GetString(ciphertext_Bytes);
        //            // return Security.Decrypt(ciphertext, "123");
        //        }
        //        else
        //            return string.Empty;
        //    }

        //    [ExcludeFromCodeCoverage]
        //    public static string GetClientIp(HttpRequestMessage httpRequest)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public static string DESEncrypt(string originalString)
        //    {
        //        byte[] encryptedArray = UTF8Encoding.UTF8.GetBytes(originalString);

        //        MD5CryptoServiceProvider MD5CryptoService = new MD5CryptoServiceProvider();
        //        byte[] securityKeyArray = MD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(Constant.SecurityKey));

        //        MD5CryptoService.Clear();

        //        var tripleDESCryptoService = new TripleDESCryptoServiceProvider();

        //        tripleDESCryptoService.Key = securityKeyArray;
        //        tripleDESCryptoService.Mode = CipherMode.ECB;
        //        tripleDESCryptoService.Padding = PaddingMode.PKCS7;

        //        var crytpoTransform = tripleDESCryptoService.CreateEncryptor();
        //        byte[] result = crytpoTransform.TransformFinalBlock(encryptedArray, 0, encryptedArray.Length);

        //        tripleDESCryptoService.Clear();

        //        return Convert.ToBase64String(result, 0, result.Length);
        //    }

        //    public static string DESDecrypt(string cryptedString)
        //    {
        //        byte[] decryptArray = Convert.FromBase64String(cryptedString);

        //        MD5CryptoServiceProvider MD5CryptoService = new MD5CryptoServiceProvider();
        //        byte[] securityKeyArray = MD5CryptoService.ComputeHash(UTF8Encoding.UTF8.GetBytes(Constant.SecurityKey));

        //        MD5CryptoService.Clear();

        //        var tripleDESCryptoService = new TripleDESCryptoServiceProvider();

        //        tripleDESCryptoService.Key = securityKeyArray;
        //        tripleDESCryptoService.Mode = CipherMode.ECB;
        //        tripleDESCryptoService.Padding = PaddingMode.PKCS7;

        //        var crytpoTransform = tripleDESCryptoService.CreateDecryptor();
        //        byte[] result = crytpoTransform.TransformFinalBlock(decryptArray, 0, decryptArray.Length);

        //        tripleDESCryptoService.Clear();

        //        return UTF8Encoding.UTF8.GetString(result);
        //    }

        //    [ExcludeFromCodeCoverage]

        //    //public static string GetClientIp(HttpRequestMessage request)
        //    //{
        //    //    string IpAddress = string.Empty;
        //    //    if (request != null && request.Properties.ContainsKey("MS_HttpContext"))
        //    //    {
        //    //        IpAddress = ((HttpContextWrapper)request.Properties["MS_HttpContext"]).Request.UserHostAddress;
        //    //    }
        //    //    else if (HttpContext.Current != null)
        //    //    {
        //    //        IpAddress = HttpContext.Current.Request.UserHostAddress;
        //    //    }

        //    //    return IpAddress;
        //    //}        
        //    public static string Export<T>(string folderPath, List<T> list, string reportName, string type = "pdf", string dateTimeFormatString = "g")
        //    {
        //        string url = string.Empty;
        //        string fileName = "";
        //        string[] headers = null;
        //        string[][] data = new string[list.Count == 0 ? 1 : list.Count + 1][];
        //        string contentPath = string.Empty;
        //        string path = string.Empty;

        //        if (typeof(T) == typeof(object))
        //            headers = list.Select(row => (row as IDictionary<string, object>).Keys).FirstOrDefault().ToArray();

        //        else
        //            headers = typeof(T).GetProperties().Select(p => p.Name).ToArray();

        //        data[0] = headers.Select(h => h.ToTitleString()).ToArray();

        //        for (int index = 1; index < list.Count + 1; index++)
        //        {
        //            string[] bodyRow = new string[data[0].Length];

        //            var ObjList = list.Select(row => (row as IDictionary<string, object>)).ElementAt(index - 1);

        //            for (int i = 0; i < headers.Length; i++)
        //            {
        //                string cellValue = string.Empty;
        //                if (typeof(T) == typeof(object))
        //                {
        //                    cellValue = ObjList.ElementAt(i).Value.ToString();
        //                }

        //                else
        //                {
        //                    object obj = list.ElementAt(index - 1);
        //                    var property = typeof(T).GetProperties().First(p => p.Name == headers[i]);
        //                    object value = property.GetValueNull(obj);

        //                    if (value != null && value is DateTime)
        //                    {
        //                        cellValue = ((DateTime)value).ToString(dateTimeFormatString);
        //                    }
        //                    else
        //                    {
        //                        cellValue = value != null ? value.ToString() : null;
        //                    }
        //                }
        //                bodyRow[i] = cellValue == null ? "" : cellValue;
        //            }
        //            data[index] = bodyRow;
        //        }

        //        if (type == "pdf")
        //        {
        //            path = string.Format("{0}\\wwwroot\\PDF\\", folderPath);
        //            //path = contentPath.MapPath(contentPath);

        //            GeneratePDF(path, data, reportName, out fileName);
        //        }
        //        else if (type == "csv")
        //        {
        //            contentPath = string.Format("{0}\\wwwroot\\PDF\\", folderPath);
        //            //path = contentPath.MapPath(contentPath);

        //            GenerateCSV(contentPath, data, reportName, out fileName);
        //        }

        //        url = string.Format("{0}PDF/{1}", ApiUrls.BaseUrl, fileName);

        //        return url;
        //    }

        //    [ExcludeFromCodeCoverage]
        //    public static void GeneratePDF(string folderPath, string[][] data, string reportName, out string fileName)
        //    {

        //        if (!Directory.Exists(folderPath))
        //        {
        //            Directory.CreateDirectory(folderPath);
        //        }

        //        fileName = string.Format("{0}_{1}.pdf", reportName,
        //        DateTime.Now.ToString("yyyyMMddhhmmss"));
        //        var filePath = Path.Combine(folderPath, fileName);
        //        File.WriteAllBytes(filePath, GeneratePDF(data, reportName));

        //    }

        //    [ExcludeFromCodeCoverage]
        //    public static void GenerateCSV(string folderPath, string[][] data, string reportName, out string fileName)
        //    {

        //        if (!Directory.Exists(folderPath))
        //        {
        //            Directory.CreateDirectory(folderPath);
        //        }
        //        fileName = string.Format("{0}_{1}.csv", reportName,
        //        DateTime.Now.ToString("yyyyMMddhhmmss"));
        //        var filePath = Path.Combine(folderPath, fileName);
        //        File.WriteAllText(filePath, GenerateCSV(data).ToString());
        //    }

        //    [ExcludeFromCodeCoverage]
        //    public static byte[] GeneratePDF(string[][] data, string reportName, bool isLandscape = true)
        //    {
        //        string[] headingRow = data[0];
        //        string headingHtml = headingRow.Aggregate("", (current, headerValue) => current + string.Format("<th>{0}</th>", headerValue));
        //        headingHtml = string.Format("<tr class='headings'>{0}</tr>", headingHtml);

        //        string bodyHtml = "";
        //        for (int index = 1; index < data.Length; index++)
        //        {
        //            string[] body = data[index];

        //            var rowHtml = body.Aggregate("", (current, bodyValue) => current + string.Format("<td>{0}</td>", IsValidText(bodyValue) ? bodyValue.Replace("&", "&#38;") : string.Empty));

        //            bodyHtml += string.Format("<tr>{0}</tr>", rowHtml);
        //        }

        //        string pdfHtml = string.Format("<html><body><div><div><h1>{2}</h1><br/></div><div>" +
        //            "<table class='table table-bordered' style='width: 100%;'>" +
        //                "<thead>{0}</thead>" +
        //                "<tbody>{1}</tbody>" +
        //            "</table>" +
        //        "</div></div></body></html>", headingHtml, bodyHtml, reportName);


        //        byte[] bPDF = null;
        //        MemoryStream ms = new MemoryStream();
        //        Document doc = new Document(isLandscape ? PageSize.A4.Rotate() : PageSize.A4);
        //        PdfWriter oPdfWriter = PdfWriter.GetInstance(doc, ms);
        //        doc.Open();

        //        string example_css = @" table, th, td {font-size: 12px;font-family: Segoe UI; border: .5px solid grey; border-collapse: collapse; padding: 3px; }  table th { background-color: #039be5; color: #fff; } ";

        //        using (var msCss = new MemoryStream(Encoding.UTF8.GetBytes(example_css)))
        //        {
        //            using (var msHtml = new MemoryStream(Encoding.UTF8.GetBytes(pdfHtml)))
        //            {
        //                iTextSharp.tool.xml.XMLWorkerHelper.GetInstance().ParseXHtml(oPdfWriter, doc, msHtml, msCss);
        //            }
        //        }

        //        doc.Close();
        //        bPDF = ms.ToArray();

        //        return bPDF;
        //    }

        //    [ExcludeFromCodeCoverage]
        //    public static MemoryStream ExportToPdf()
        //    {

        //        new CustomAssemblyLoadContext().LoadUnmanagedLibrary(@"E:\\Repos\\Development\\PAYFAC_2021_F1_Riz\\Lib\\libwkhtmltox.dll");

        //        var converter = new BasicConverter(new PdfTools());

        //        var doc = new HtmlToPdfDocument()
        //        {
        //            GlobalSettings = {
        //    ColorMode = ColorMode.Color,
        //    Orientation = Orientation.Landscape,
        //    PaperSize = PaperKind.A4Plus,
        //},
        //            Objects = {
        //    //new ObjectSettings() {
        //    //    PagesCount = true,
        //    //    HtmlContent = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In consectetur mauris eget ultrices  iaculis. Ut                               odio viverra, molestie lectus nec, venenatis turpis.",
        //    //    WebSettings = { DefaultEncoding = "utf-8" },
        //    //    HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
        //    //}

        //                new ObjectSettings { Page = "http://google.com/"}
        //}
        //        };


        //        return new MemoryStream(converter.Convert(doc));


        //    }

        //    [ExcludeFromCodeCoverage]
        //    public byte[] WKHtmlToPdf(string url_input)
        //    {
        //        try
        //        {
        //            var fileName = " - ";
        //            var wkhtmlDir = "";
        //            var wkhtml = "";
        //            var p = new Process();

        //            string url = "";//Request.Url.GetLeftPart(UriPartial.Authority) + @"/application/" + url_input;

        //            p.StartInfo.CreateNoWindow = true;
        //            p.StartInfo.RedirectStandardOutput = true;
        //            p.StartInfo.RedirectStandardError = true;
        //            p.StartInfo.RedirectStandardInput = true;
        //            p.StartInfo.UseShellExecute = false;
        //            p.StartInfo.FileName = wkhtml;
        //            p.StartInfo.WorkingDirectory = wkhtmlDir;

        //            string switches = "";
        //            switches += "--print-media-type ";
        //            switches += "--margin-top 10mm --margin-bottom 10mm --margin-right 10mm --margin-left 10mm ";
        //            switches += "--page-size Letter ";
        //            p.StartInfo.Arguments = switches + " " + url + " " + fileName;
        //            p.Start();

        //            //read output
        //            byte[] buffer = new byte[32768];
        //            byte[] file;
        //            using (var ms = new MemoryStream())
        //            {
        //                while (true)
        //                {
        //                    int read = p.StandardOutput.BaseStream.Read(buffer, 0, buffer.Length);

        //                    if (read <= 0)
        //                    {
        //                        break;
        //                    }
        //                    ms.Write(buffer, 0, read);
        //                }
        //                file = ms.ToArray();
        //            }

        //            // wait or exit
        //            p.WaitForExit(60000);

        //            // read the exit code, close process
        //            int returnCode = p.ExitCode;
        //            p.Close();

        //            return returnCode == 0 ? file : null;
        //        }
        //        catch (Exception ex)
        //        {

        //            // set your exceptions here
        //            return null;
        //        }
        //    }

        //    [ExcludeFromCodeCoverage]
        //    private static bool IsValidText(string text)
        //    {
        //        var phoneRegex = @"/\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})/";
        //        var emailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        //        var alphaNumericRegex = @"[a-zA-Z0-9\s]+";

        //        DateTime dt = new DateTime();

        //        bool isValidDate = DateTime.TryParse(text, out dt);

        //        return Regex.IsMatch(text, emailRegex)
        //            || Regex.IsMatch(text, alphaNumericRegex)
        //            || Regex.IsMatch(text, phoneRegex)
        //            || isValidDate;
        //    }

        //    [ExcludeFromCodeCoverage]
        //    public static StringBuilder GenerateCSV(string[][] data)
        //    {
        //        StringBuilder csvText = new StringBuilder();
        //        string[] headingRow = data[0];
        //        string headingHtml = string.Join(",", headingRow.Select(value => FormatCSVData(value)));
        //        //  headingHtml = headingHtml.Remove(headingHtml.Length-1,1);
        //        csvText.AppendLine(headingHtml);


        //        for (int index = 1; index < data.Length; index++)
        //        {
        //            string[] body = data[index];
        //            string rowHtml = string.Join(",", body.Select(value => FormatCSVData(value)));
        //            //  rowHtml = rowHtml.Remove(rowHtml.Length-1,1);
        //            rowHtml = rowHtml.Replace("\xA0", " ");
        //            csvText.AppendLine(rowHtml);
        //        }
        //        return csvText;
        //    }

        //    [ExcludeFromCodeCoverage]
        //    private static string FormatCSVData(string value)
        //    {
        //        return value.Contains(",") ?
        //            string.Format(@"""{0}""", value) :
        //            string.Format(@"{0}", value);
        //    }
        //}

        //public class APIKey
        //{
        //    [ExcludeFromCodeCoverage]
        //    public string DBA { get; set; }
        //    [ExcludeFromCodeCoverage]
        //    public int MerchantID { get; set; }

        //    internal char[] ToJson()
        //    {
        //        throw new NotImplementedException();
        //    }
        //}
    }
}