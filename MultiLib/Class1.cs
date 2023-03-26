#region Импорт библиотек (16 библиотек...)
using System;
using System.Text;
using System.Threading;
using System.IO;
using System.Security.Cryptography;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.IO.Compression;
using LibGit2Sharp;
using Google.Authenticator;
using IniParser;
using IniParser.Model;
using System.Collections;
using System.Windows.Input;
#endregion

namespace MultiLib
{
    ///Все функции
    #region Стандартные команды
    /// <summary>
    /// Класс стандартных команд
    /// </summary>
    public static class basic
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
        public static void versionProgram(string namePacket, string description, string Version, string Revese, string copyright, string company, string trademark)
        {
            Console.WriteLine("Programm: " + namePacket);
            Console.WriteLine("Description: " + description);
            Console.WriteLine("Version: " + Version);
            Console.WriteLine("Revese: " + Revese);
            Console.WriteLine("Company: " + company);
            Console.WriteLine("Copyright: " + copyright);
            Console.WriteLine("Trademark: " + trademark);
            Console.WriteLine("Created by MultiLib V1.1 ((C) MultiPlayer 2019-2023)");

        }
    }
    #endregion

    #region Работа с архивами
    /// <summary>
    /// Класс работа с архивами
    /// </summary>
    public static class czipC
    {
        private const int BufferSize = 1048576;

        public static void CryptFile(string inputFile, string outputFile, string password)
        {
            try
            {
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                RijndaelManaged RMCrypto = new RijndaelManaged();
                RMCrypto.Mode = CipherMode.CBC;

                byte[] iv = RMCrypto.IV;

                using (FileStream fsCrypt = new FileStream(outputFile, FileMode.Create))
                {
                    fsCrypt.Write(iv, 0, iv.Length);

                    using (CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                    {
                        using (FileStream fsIn = new FileStream(inputFile, FileMode.Open))
                        {
                            byte[] buffer = new byte[BufferSize];
                            int read;

                            while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cs.Write(buffer, 0, read);
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DecryptFile(string inputFile, string outputFile, string password)
        {
            try { 
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);

            RijndaelManaged RMCrypto = new RijndaelManaged();
            RMCrypto.Mode = CipherMode.CBC;

            byte[] iv = new byte[16];

            using (FileStream fsCrypt = new FileStream(inputFile, FileMode.Open))
            {
                fsCrypt.Read(iv, 0, iv.Length);

                using (CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, iv), CryptoStreamMode.Read))
                {
                    using (FileStream fsOut = new FileStream(outputFile, FileMode.Create))
                    {
                        byte[] buffer = new byte[BufferSize];
                        int read;

                        while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fsOut.Write(buffer, 0, read);
                        }
                    }
                }
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    
    public static void compress(string pathFoler, string outputArchive)
        {
            if (Directory.Exists(pathFoler))
            {
                try
                {
                    ZipFile.CreateFromDirectory(pathFoler, outputArchive);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не удаётся создать архив! Другая причина! Причина: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Не удаётся создать архив! Папка не существует!");
            }

        }
        public static void decompress(string pathArchive, string outputFolder)
        {
            if (File.Exists(pathArchive))
            {
                if (Directory.Exists(outputFolder))
                {
                    try
                    {
                        System.IO.Compression.ZipFile.ExtractToDirectory(pathArchive, outputFolder);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Не удаётся извлечь файлы из архива! Другая причина! Причина: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Не удаётся извлечь файлы из архива! Папка для извлечения в него не существует!");
                }
            }
            else
            {
                MessageBox.Show("Не удаётся извлечь файлы из архива! Архив не существует!");
            }
        }
    }
    #endregion

    #region Работа с проверками в интернете
    /// <summary>
    /// Класс работа с проверками в интернете
    /// </summary>
    public static class internet
    {
        /// <summary>
        /// Проверка наличия интернета
        /// </summary>
        /// <returns>true - если интернет есть, false - если интернета нету</returns>
        public static bool TestConnection()
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

        public static bool ping(string url)
        {
            try
            {
                using (var ping = new Ping())
                {
                    var result = ping.Send(url, 1000);
                    return result.Status == IPStatus.Success;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
    #endregion

    #region Работа с FTP
    /// <summary>
    /// Класс работа с FTP
    /// </summary>
    public static class FTP
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
        public static void upload(string host, string username, string password, string localfullpath)
        {
            string ftpUsername = username;
            string ftpPassword = password;
            string filePath = localfullpath;

            // создаем объект запроса
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host);

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
        public static void download(string host, string username, string password, string localPath)
        {
            // Путь к локальному файлу
            string localFilePath = localPath;

            using (WebClient client = new WebClient())
            {
                // Устанавливаем учетные данные FTP-сервера
                client.Credentials = new NetworkCredential(username, password);

                // Скачиваем файл
                client.DownloadFile(host, localFilePath);
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
    #endregion

    #region Работа с почтой
    /// <summary>
    /// Класс работы с почтой
    /// </summary>
    public static class mail
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
            if (internet.TestConnection())
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
    #endregion

    #region Работа с музыкальными файлами
    /*
    /// <summary>
    /// Класс работы с музыкальными файлами
    /// </summary>
    public static class music
    {
        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        /// <summary>
        /// Запуск песни
        /// </summary>
        /// <param name="pathMusicFile">Полный путь до музыкального файла (Например: C:\Users\VM\MicroAPP\dolnayboishik.mp3)</param>
        public static void play(string pathMusicFile)
        {
            wplayer.URL = pathMusicFile;
            wplayer.controls.play();
        }

        /// <summary>
        /// Остановка песни
        /// </summary>
        public static void stop()
        {
            wplayer.controls.stop();
        }

        /// <summary>
        /// Приостановка песни
        /// </summary>
        public static void pause()
        {
            wplayer.controls.pause();
        }
    }
    */
    #endregion

    #region Работа с компилятором кода C#
    public static class compilator
    {
        public static void collect(string inputSourceFile, string outputCompileFile)
        {
            // Путь к файлу с исходным кодом C#
            string sourceFile = inputSourceFile;

            if (File.Exists(sourceFile))
            {
                // Создаем компилятор
                CSharpCodeProvider codeProvider = new CSharpCodeProvider();

                // Задаем параметры компиляции
                CompilerParameters parameters = new CompilerParameters();
                parameters.GenerateExecutable = true;
                parameters.OutputAssembly = outputCompileFile;

                // Компилируем исходный код
                CompilerResults results = codeProvider.CompileAssemblyFromFile(parameters, sourceFile);

                // Проверяем, была ли компиляция успешной
                if (results.Errors.Count > 0)
                {
                    foreach (CompilerError error in results.Errors)
                    {
                        MessageBox.Show("Ошибка компиляции файла! Проблема:" + error.ErrorText);
                    }
                }
                else
                {
                    MessageBox.Show("Компиляция успешно завершена!");
                }
            }
            else
            {
                MessageBox.Show("Файл не обнаружен!");
            }
        }
    }
    #endregion

    #region Работа с MGeT
    /// <summary>
    /// Работа с MGeT
    /// </summary>
    public static class mget
    {
        /// <summary>
        /// Получение файлов с репозитория
        /// </summary>
        /// <param name="url">Ссылка на репозитория</param>
        /// <param name="pathTo">Путь на высадку</param>
        public static void get(string url, string pathTo)
        {
            if (internet.TestConnection())
            {
                try
                {
                    Repository.Clone(url, pathTo);
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Нет подключения к интернету!");
                Console.ReadKey();
            }
        }

    }
    #endregion

    #region Работа с генератором пароля
    /// <summary>
    /// Работа с генератором пароля
    /// </summary>
    public static class pass
    {
        /// <summary>
        /// Генерация пароля
        /// </summary>
        /// <param name="length">Длина пароля</param>
        /// <returns></returns>
        public static string GenPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
    }
    #endregion

    #region Работа с Google Authenticator
    /// <summary>
    /// Работа с Google Authenticator
    /// </summary>
    public static class Authenticator
    {
        /// <summary>
        /// Создание аутентификатора
        /// </summary>
        /// <param name="uName">Имя (пользователя и т.д.)</param>
        /// <param name="uEmail">(Почта, телефон и т.д.)</param>
        /// <param name="createQRForm">Создать QR-код для добавления и открыть его в новом графическом окне?</param>
        /// <param name="visibleSecretKeyUserForAddAutentificator">Автоматически отобразить секретный ключ аутентификатора для пользователя, для добавления аутентификатора в программу?</param>>
        /// <returns>Секретный ключ аутентификатора</returns>
        public static string createAuthenticator(string uName, string uEmail, bool AUTOvisibleSecretKeyUserForAddAutentificator, bool createQRForm)
        {
            TwoFactorAuthenticator auth = new TwoFactorAuthenticator();
            string password = pass.GenPassword(32);
            var setupCode = auth.GenerateSetupCode(uName, uEmail, password, false, 3);
            if (AUTOvisibleSecretKeyUserForAddAutentificator)
            {
                Console.WriteLine($@"Вот ключ для аутентификатора: {password} | Укажите данный код в программу Google Authenticator
Вот имя для аутентификатора: {uName} | Укажите данное имя в программу Google Authenticator
Тип: Временный");
                if (createQRForm)
                {
                    var qr = new qrAuth();
                    qr.Text = uName;
                    using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(setupCode.QrCodeSetupImageUrl.Replace("data:image/png;base64,", ""))))
                        qr.start(ms);
                }
            }
                
            return password;
        }

        /// <summary>
        /// Проверка верности кода
        /// </summary>
        /// <param name="secretKey">Секретный ключ аутентификатора</param>
        /// <param name="enterPassword">Код введённый пользователем</param>
        /// <returns>true - если код верен, false - если код не верный</returns>
        public static bool checkEnterCode(string secretKey, string enteredPassword)
        {
            TwoFactorAuthenticator auth = new TwoFactorAuthenticator();
            if (auth.ValidateTwoFactorPIN(secretKey, enteredPassword))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Получение текущего кода (не требуется в использовании с "checkEnterCode(secretKey, enteredPassword);")
        /// </summary>
        /// <param name="secretKey">Секретный ключ аутентификатора</param>
        /// <returns>Текущий код доступа</returns>
        public static string getCurrentCode(string secretKey) 
        {
            return string.Join(System.Environment.NewLine, new TwoFactorAuthenticator().GetCurrentPINs(secretKey));
        }
    }
    #endregion

    #region Работа с INI файлами
    /// <summary>
    /// Класс работа с INI файлами
    /// </summary>
    public static class INI
    {
        /// <summary>
        /// Получить текст из определённой переменной в секции файла
        /// </summary>
        /// <param name="pathToFile">Полный путь до файла</param>
        /// <param name="Section">Секция</param>
        /// <param name="variable">Переменная</param>
        /// <returns>Код ошибки или текст из переменной (Вывод: 0x11 = Файл не существует; 0x21 = Указанная секция не существует; 0x31 = Указанная переменная не существует; (другое (текст)) = Вывод текст из переменной)</returns>
        public static string get(string pathToFile, string Section, string variable)
        {
            if (!File.Exists(pathToFile))
            {
                return "0x11";
            }
            else
            {
                if (Section == "")
                {
                    return "0x21";
                }
                else
                {
                    if (variable == "")
                    {
                        return "0x31";
                    }
                    else
                    {
                        FileIniDataParser parser = new FileIniDataParser();
                        IniData data = parser.ReadFile(pathToFile);
                        return data[Section][variable];
                    }
                    
                }
            }
        }

        /// <summary>
        /// Установка значения в определённую переменную в секиции файла
        /// </summary>
        /// <param name="pathToFile">Полный путь до файла</param>
        /// <param name="Section">Секция</param>
        /// <param name="variable">Переменная</param>
        /// <param name="newTextForVariable">Новый текст на переменную</param>
        /// <param name="returnMSGError">Показать сообщение об ошибке если она будет?</param>
        public static void set(string pathToFile, string Section, string variable, string newTextForVariable, bool returnMSGError)
        {
            if (!File.Exists(pathToFile))
            {
                if(returnMSGError){MessageBox.Show($"Файла {pathToFile} несуществует!", "Ошибка!");}
            }
            else
            {
                if (Section == "")
                {
                    if(returnMSGError){MessageBox.Show("Аргумент Секция пуст!", "Ошибка!");}
                }
                else
                {
                    if (variable == "")
                    {
                        if(returnMSGError){MessageBox.Show("Аргумент Переменная пуст!", "Ошибка!");}
                    }
                    else
                    {

                        FileIniDataParser parser = new FileIniDataParser();
                        IniData data = parser.ReadFile(pathToFile);
                        data[Section][variable] = newTextForVariable;
                        parser.WriteFile(pathToFile, data);
                    }
                    
                }
            }
        }
    }

    #endregion

}


