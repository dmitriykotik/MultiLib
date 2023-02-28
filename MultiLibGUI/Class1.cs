﻿using System;
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
using System.Net.Mail;
using System.Windows.Forms;

namespace MultiLibGUI
{
    /// <summary>
    /// Класс стандартных команд
    /// </summary>
    public class basic
    {
        /// <summary>
        /// Рандомное число
        /// </summary>
        /// <param name="start">Начальное число</param>
        /// <param name="finish">Конечное число</param>
        /// <returns>Случайное число</returns>
        public static int random(int start, int finish)
        {
            Random rnd = new Random();
            return rnd.Next(start, finish);

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
        /// Создание формы и вывод в неё указанные данные о программе
        /// </summary>
        /// <param name="namePacket">Название программы</param>
        /// <param name="description">Описание</param>
        /// <param name="Version">Версия</param>
        /// <param name="Revese">Ревизия (DEBUG/Alpha/Release/Beta)</param>
        /// <param name="copyright">Копирайт</param>
        /// <param name="company">Компания</param>
        /// <param name="trademark">Торговая марка</param>
        public static void versionProgram(string namePacket, string description, string Version, string Revese, string company)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Start(namePacket, description, Version, Revese, company);
        }
    }
    /// <summary>
    /// Класс работа с архивами
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
    /// Класс проверка наличия инетрнета
    /// </summary>
    static class ping
    {
        /// <summary>
        /// Проверка наличия интернета
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
    /// Класс работа с FTP
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
    /// <summary>
    /// Класс работы с почтой
    /// </summary>
    class mail
    {
        /// <summary>
        /// Отправка письма на почту
        /// </summary>
        /// <param name="fromEmail">Почта отправителя (укажите почту которую будете использовать и в параметре SMTP почта)</param>
        /// <param name="fromName">Имя отправителя</param>
        /// <param name="toEmail">Почта получателя</param>
        /// <param name="subject">Тема письма</param>
        /// <param name="textOrHtml">Текст или html код для письма</param>
        /// <param name="smtpServer">SMTP сервер (например: mail.gmail.com)</param>
        /// <param name="smtpPort">SMTP порт сервера (например: 587)</param>
        /// <param name="smtpMail">SMTP почта (используйте почту указанную в почте отправителя ОЧЕНЬ ВАЖНО: ИСПОЛЬЗУЙТЕ ПОЧТУ ЗАРЕГЕСТРИРОВАННУЮ НА SMTP СЕРВЕРЕ! НАПРИМЕР ДЛЯ ПОЧТЫ ЗАКАНЧИВАЮЩИХСЯ НА @gmail.com НУЖЕН ОБЯЗАТЕЛЬНО СЕРВЕР mail.gmail.com, А ПОРТ НУЖЕН 587. ЕСЛИ ПОЧТА ОКАНЧИВАЕТСЯ НА ЧТОТО ДРУГОЕ НАПРИМЕР @mail.ru, ТО ПОИЩИТЕ В ИНТЕРНЕТЕ ЕГО SMTP СЕРВЕР И КАК ЕГО ИСПОЛЬЗОВАТЬ!)</param>
        /// <param name="smtpPasswordMail">SMTP пароль (для mail.gmail.com нужно выполнить некоторые действия для создания пароля (не вашего стандартного пароля) от вашей почты (документация по получению: https://multiplayercorporation.mya5.ru/doc/smtp))</param>
        /// <param name="saveLogFails">Сохранять логи ошибок?</param>
        /// <returns>true - Сообщение отправлено, false - Сообщение не отправлено</returns>
        public static bool send(string fromEmail, string fromName, string toEmail, string subject, string textOrHtml, string smtpServer, int smtpPort, string smtpMail, string smtpPasswordMail, bool saveLogFails)
        {
            if (ping.InternetConection())
            {
                MailAddress from = new MailAddress(fromEmail, fromName);
                MailAddress to = new MailAddress(toEmail);
                MailMessage m = new MailMessage(from, to);
                m.Subject = subject;
                m.Body = textOrHtml;
                m.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient(smtpServer, smtpPort);
                smtp.Credentials = new NetworkCredential(smtpMail, smtpPasswordMail);
                smtp.EnableSsl = true;
                try
                {
                    smtp.Send(m);
                    return true;
                }
                catch (Exception ex)
                {
                    if (saveLogFails)
                    {
                        try
                        {
                            File.WriteAllText($"log{basic.random(111, 999)}.log", $"{ex.Message}");
                        }
                        catch (Exception ex2)
                        {
                            Console.WriteLine(MessageBox.Show($@"1. {ex.Message}
2. {ex2.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop));
                        }
                    }
                    return false;
                }
            }
            else
            {
                if (saveLogFails)
                {
                    try
                    {
                        File.WriteAllText($"log{basic.random(111, 999)}.log", $"Нет подключения к интернету!");
                    }
                    catch (Exception ex2)
                    {
                        Console.WriteLine(MessageBox.Show($@"1. Нет подключения к интернету!
2. {ex2.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop));
                    }
                }
                return false;
            }
        }
    }
}