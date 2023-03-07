# MultiLib
Библиотека для разрабочиков. Создана для сокращения кода. Библиотека будет входить в состав MultiDeveloperKit и MultiRedistributable.

Данная библиотека немного сокращает код на C#. Её нужно использовать если программа требует библиотеку MultiLib. Если вы хотите программировать на ней, то стоит почитать документацию (пока что нет) и загрузить её в свой проект VisualStudio C#. Для загрузки почти ничего не требуется. Скачайте библиотеку, сохраните в любом удобном месте, откройте проект в VisualStudio, в правом окне нажмите ПКМ по "Ссылки" и выберите пункт "Добавить ссылку...", после нажмите на кнопку внизу "Обзор..." и наконец выберите скачанную библиотеку.

Библиотека создана на C# .net framework 4.8, если вы программируете под версию ниже, то библиотека будет не совместима!

# Помоги в разработке
Вы можете исправлять или добавлять свой код для библиотек MultiLib с помощью раздела Pull requests! Подробнее: https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/creating-a-pull-request

# Классы
- MultiLib
1. basic
2. czipC
3. ping
4. FTP
5. mail
6. music
7. compilator
8. mget
9. pass
10. Authenticator

- MultiLibGUI
1. basic
2. czipC
3. ping
4. FTP
5. mail
6. music
7. compilator
8. mget
9. pass
10. Authenticator

# Функции
- MultiLib

I. basic
1. random(int start, int finish)
2. read(*string expectedText) 
3. pause()
4. sleep(int sleepTime)
5. terminate(int errCode)
6. writel(string text)
7. write(string text)
8. versionProgram(string namePacket, string description, string Version, string Revese, string copyright, string company, string trademark)

II. czipC
1. EncryptFile(string inputFile, string outputFile, string password)
2. DecryptFile(string inputFile, string outputFile, string password)
4. compress(string pathFoler, string outputArchive)
5. decompress(string pathArchive, string outputFolder)

III. ping
1. InternetConection()

IV. FTP
1. upload(string host, string username, string password, string remoteDir, string filename, string localfullpath)
2. download(string host, string username, string password, string remotePath, string localPath)
3. exists(string host, string username, string password)

V. mail
1. send(string fromEmail, string fromName, string toEmail, string subject, string textOrHtml, string smtpServer, int smtpPort, string smtpMail, string smtpPasswordMail, bool saveLogFails)

VI. music
1. play(string pathMusicFile)
2. stop()
3. pause()

VII. compilator
1. collect(string inputSourceFile, string outputCompileFile)

VIII. mget
1. get(string url, string outputClonedFiles)

IX. pass
1. GenPassword(int length)

X. Authenticator
1. createAuthenticator(string uName, string uEmail, bool AUTOvisibleSecretKeyUserForAddAutentificator, bool createQRForm)
2. checkEnterCode(string secretKey, string enteredPassword)
3. getCurrentCode(string secretKey)

- MultiLibGUI

I. basic
1. random(int start, int finish)
2. sleep(int sleepTime)
3. terminate(int errCode)
4. versionProgram(string namePacket, string description, string Version, string Revese, string copyright, string company, string trademark)

II. czipC
1. EncryptFile(string inputFile, string outputFile, string password)
2. DecryptFile(string inputFile, string outputFile, string password)
4. compress(string pathFoler, string outputArchive)
5. decompress(string pathArchive, string outputFolder)

III. ping
1. InternetConection()

IV. FTP
1. upload(string host, string username, string password, string remoteDir, string filename, string localfullpath)
2. download(string host, string username, string password, string remotePath, string localPath)
3. exists(string host, string username, string password)

V. mail
1. send(string fromEmail, string fromName, string toEmail, string subject, string textOrHtml, string smtpServer, int smtpPort, string smtpMail, string smtpPasswordMail, bool saveLogFails)

VI. music
1. play(string pathMusicFile)
2. stop()
3. pause()

VII. compilator
1. collect(string inputSourceFile, string outputCompileFile)

VIII. mget
1. get(string url, string outputClonedFiles)

IX. pass
1. GenPassword(int length)

X. Authenticator
1. createAuthenticator(string uName, string uEmail, bool AUTOvisibleSecretKeyUserForAddAutentificator, bool createQRForm)
2. checkEnterCode(string secretKey, string enteredPassword)
3. getCurrentCode(string secretKey)

# Документация
В документации содержится: библиотека.класс.функция(аргументы) - описание

- MultiID.basic.random(int start, int finish) - Генерация рандомного числа. Первый параметр означает от какого числа начать генерацию, второй параметр означает ДО какого числа закончить генирацию. Например: 1 аргумент-111111 2 аргумент-999999 Итог: 874674. Возвращает: Рандомное сгенирированное число

- MultiID.basic.read(*string expectedText) - Активация пользовательского ввода данных. 1 аргумент являетсвя дополнительным и его можно не указывать. Он отвевает за проверку текста. Например: без аргумента, пользователь ввёл: 918 Итог: 918; 1 аргумент-918, пользователь ввёл 918 Итог: true; 1 аргумент-918, пользователь ввёл: 387, Итог: false. Возвращает: Без аргументов - Введённую строку пользователем; true - при наличии 1 аргумента, если пользователь ввёл текст который указан в аргументе; false - при наличии 1 аргумента, если строка пользователя не равна строке в аргументе.
