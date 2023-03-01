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

- MultiLibGUI
1. basic
2. czipC
3. ping
4. FTP
5. mail
6. music

# Функции
- MultiLib

I. basic
1. random(int start, int finish)
2. read(*string expectedText) 
3. pause()
4. sleep(int sleepTime)
5. terminate(errCode)
6. writel(string text)
7. write(string text)
8. versionProgram(string namePacket, string description, string Version, string Revese, string copyright, string company, string trademark)

II. czipC
1. EncryptFile(string inputFile, string outputFile, string password)
2. DecryptFile(string inputFile, string outputFile, string password)

III. ping
1. InternetConection()

IV. FTP
1. upload(string host, string username, string password, string remoteDir, string filename, string localfullpath)
2. download(string host, string username, string password, string remotePath, string localPath)
3. exists(string host, string username, string password)

V. mail
1. send(string fromEmail, string fromName, string toEmail, string subject, string textOrHtml, string smtpServer, int smtpPort, string smtpMail, string smtpPasswordMail, bool saveLogFails)

VI. music
1. play(pathMusicFile)
2. stop()
3. pause()

- MultiLibGUI

I. basic
1. random(int start, int finish)
2. sleep(int sleepTime)
3. terminate(errCode)
4. versionProgram(string namePacket, string description, string Version, string Revese, string copyright, string company, string trademark)

II. czipC
1. EncryptFile(string inputFile, string outputFile, string password)
2. DecryptFile(string inputFile, string outputFile, string password)

III. ping
1. InternetConection()

IV. FTP
1. upload(string host, string username, string password, string remoteDir, string filename, string localfullpath)
2. download(string host, string username, string password, string remotePath, string localPath)
3. exists(string host, string username, string password)

V. mail
1. send(string fromEmail, string fromName, string toEmail, string subject, string textOrHtml, string smtpServer, int smtpPort, string smtpMail, string smtpPasswordMail, bool saveLogFails)

VI. music
1. play(pathMusicFile)
2. stop()
3. pause()

# Документация
Пока что тут нет документации, но обещаем, она тут будет. Будет она очень подробной с примерами. Спасибо за ожидание!
