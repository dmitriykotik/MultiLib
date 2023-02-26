using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Threading;
using System.IO;
using System.Security.Cryptography;
using System.Net.NetworkInformation;
using System.Net;

namespace MultiLib
{
    /// <summary>
    /// Стандартные команды
    /// </summary>
    public class basicC
    {



        /// <summary>
        /// Ввод пользовательской строки
        /// </summary>
        /// <returns>Введённый текст в строке</returns>
        public static string read()
        {
            string line = Console.ReadLine();
            return line;
        }
        /// <summary>
        /// Ввод пользовательской строки и проверка ожидаемого текста
        /// </summary>
        /// <param name="expectedText">Текст для проверки</param>
        /// <returns>true - текст равен ожид. значению; false - текст не равен ожид. значению</returns>
        public static bool read(string expectedText) 
        {
            string line = Console.ReadLine();
            if (expectedText == line)
            {
                return true;
            }
            else
            {
                return false;
            }
            //test
        }

        /// <summary>
        /// Приостановка работы
        /// </summary>
        public static void pause()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// Ожидание на определённое время
        /// </summary>
        /// <param name="sleepTime">Время (Милисекунды)</param>
        public static void sleep(int sleepTime) 
        { 
            Thread.Sleep(sleepTime);
        }

        /// <summary>
        /// Завершение работы консоли
        /// </summary>
        /// <param name="errCode">Код ошибки/выхода</param>
        public static void terminate(int errCode)
        {
            Environment.Exit(errCode);
        }

        /// <summary>
        /// Вывод строчки
        /// </summary>
        /// <param name="text">Текст в строчке</param>
        public static void writel(string text)
        {
            Console.WriteLine(text);
        }

        /// <summary>
        /// Вывод текста
        /// </summary>
        /// <param name="text">Текст</param>
        public static void write(string text) 
        {
            Console.Write(text);
        }

        /// <summary>
        /// Выводит в терминал указанные данные о программе
        /// </summary>
        /// <param name="namePacket">Название программы</param>
        /// <param name="description">Описание</param>
        /// <param name="Version">Версия</param>
        /// <param name="Revese">Ревизия (DEBUG/Alpha/Release/Beta)</param>
        /// <param name="copyright">Копирайт</param>
        /// <param name="company">Компания</param>
        /// <param name="trademark">Торговая марка</param>
        public static void versionProgramm(string namePacket, string description, string Version, string Revese, string copyright, string company, string trademark)
        {
            Console.WriteLine("Programm: " + namePacket);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Version: " + Version);
            Console.WriteLine("Revese: " + Revese);
            Console.WriteLine("Company: " + company);
            Console.WriteLine("Copyright: " + copyright);
            Console.WriteLine("Trademark: " + trademark);
            Console.WriteLine("Created by MultiLib V1.0 ((C) MultiPlayer 2019-2023)");

        }
    }
    /// <summary>
    /// Работа с архивами
    /// </summary>
    class czipC
    {
        /// <summary>
        /// Зашифровка файла/архива
        /// </summary>
        /// <param name="inputFile">Файл входа (например: example.txt)</param>
        /// <param name="outputFile">Выходной файл (например: exapmple.enc)</param>
        /// <param name="password">Установка пароля для расшифровки</param>
        public static void EncryptFile(string inputFile, string outputFile, string password)
        {

            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateEncryptor(key, key),
                CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();
            }
            catch
            {

            }
        }

        /// <summary>
        /// Расшифровка файла/архива.
        /// </summary>
        /// <param name="inputFile">Входной файл (например: example.enc)</param>
        /// <param name="outputFile">Выходной файл (например: example.txt)</param>
        /// <param name="password">Пароль для расшифровки</param>
        public static void DecryptFile(string inputFile, string outputFile, string password)
        {

            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt,
                RMCrypto.CreateDecryptor(key, key),
                CryptoStreamMode.Read);

                FileStream fsOut = new FileStream(outputFile, FileMode.Create);

                int data;
                while ((data = cs.ReadByte()) != -1)
                    fsOut.WriteByte((byte)data);

                fsOut.Close();
                cs.Close();
                fsCrypt.Close();

            }
        }
    }
    /// <summary>
    /// Проверка наличия инетрнета (класс)
    /// </summary>
    class ping
    {
        /// <summary>
        /// Проверка наличия интернета (функция)
        /// </summary>
        /// <returns>true - если интернет есть, false - если интернета нету</returns>
        public static bool InternetConection()
        {
            try
            {
                using (var ping = new Ping())
                {
                    var result = ping.Send("google.com", 1000);
                    return result.Status == IPStatus.Success;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    /// <summary>
    /// Работа с FTP
    /// </summary>
    class FTP
    {
        /// <summary>
        /// Загрузка файла на ФТП сервер
        /// </summary>
        /// <param name="host">Полная ссылка до фтп сервера (например: ftp://example.exmp)</param>
        /// <param name="username">Вход: Имя пользователя (например: exampleName)</param>
        /// <param name="password">Вход: Пароль пользователя (например: Ex@mpleP@3w0rd)</param>
        /// <param name="remoteDir">Удалённая папка в которую будет загружен файл (например: path/)</param>
        /// <param name="filename">Имя файла (например: example.mo)</param>
        /// <param name="localfullpath">Полный путь до файла на локальном компьютере (можно также использовать не полный путь до фала, но тогда файл должен находится в одной папке с программой) (например: C:\path\to\file.exmp; например: file.exmp)</param>
        public static void upload(string host, string username, string password, string remoteDir, string filename, string localfullpath)
        {
            string ftpHost = host;
            string ftpUsername = username;
            string ftpPassword = password;
            string ftpDirectory = remoteDir;
            string fileName = filename;
            string filePath = localfullpath;

            // создаем объект запроса
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpHost + ftpDirectory + fileName);

            // устанавливаем параметры запроса
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(ftpUsername, ftpPassword);
            request.UsePassive = true;
            request.UseBinary = true;
            request.KeepAlive = false;

            // читаем данные из файла и отправляем их на сервер
            using (Stream inputStream = File.OpenRead(filePath))
            using (Stream outputStream = request.GetRequestStream())
            {
                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outputStream.Write(buffer, 0, bytesRead);
                }
            }
        }
        /// <summary>
        /// Загрузка файла на ФТП сервер
        /// </summary>
        /// <param name="host">Полная ссылка до фтп сервера (например: ftp://example.exmp)</param>
        /// <param name="username">Вход: Имя пользователя (например: exampleName)</param>
        /// <param name="password">Вход: Пароль пользователя (например: Ex@mpleP@3w0rd)</param>
        /// <param name="remotePath">Удалённый полный путь из которого будет скачат файл (например: path/to\file.exmp)</param>
        /// <param name="localPath">Полный путь до файла который будет сохранён на локальном компьютере (можно также использовать не полный путь до фала, но тогда файл будет находится в одной папке с программой) (например: C:\path\to\file.exmp; например: file.exmp)</param>
        public static void download(string host, string username, string password, string remotePath, string localPath)
        {
            // Параметры FTP-сервера
            string ftpServer = host;

            // Путь к файлу на FTP-сервере
            string remoteFilePath = remotePath;

            // Путь к локальному файлу
            string localFilePath = localPath;

            using (WebClient client = new WebClient())
            {
                // Устанавливаем учетные данные FTP-сервера
                client.Credentials = new NetworkCredential(username, password);

                // Скачиваем файл
                client.DownloadFile(ftpServer + remoteFilePath, localFilePath);
            }
        }
        /// <summary>
        /// Проверка наличия файла на FTP сервере
        /// </summary>
        /// <param name="host">Полный удалённый путь до файла (например: https://example.exm/path/to/file.examp)</param>
        /// <param name="username">Вход: Имя пользователя (например: exampleName)</param>
        /// <param name="password">Вход: Пароль пользователя (например: Ex@mpleP@3w0rd)</param>
        /// <returns>true - если файл существует, false - если файл отсутствует.</returns>
        public static bool exists(string host, string username, string password)
        {
            string url = host;

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Credentials = new NetworkCredential(username, password);
            request.Method = WebRequestMethods.Ftp.GetDateTimestamp;

            try
            {
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    return true;
                }
            }
            catch (WebException ex)
            {
                FtpWebResponse response = (FtpWebResponse)ex.Response;
                if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                {
                    return false;
                    
                }
            }
            return true;
        }
    }
}
