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
11. INI

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
11. INI

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

XI. INI
1. get(string pathToFile, string Section, string variable)
2. set(string pathToFile, string Section, string variable, string newTextForVariable, bool returnMSGError)

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

XI. INI
1. get(string pathToFile, string Section, string variable)
2. set(string pathToFile, string Section, string variable, string newTextForVariable, bool returnMSGError)

# Документация
В документации содержится: библиотека.класс.функция(аргументы) - описание

``` bash
\
/
\
/
\
- MultiLib
/
\
/
\
/
```

- MultiLib.basic.random(int start, int finish) - Генерация рандомного числа. Первый параметр означает от какого числа начать генерацию, второй параметр означает ДО какого числа закончить генирацию. Например: 1 аргумент-111111 2 аргумент-999999 Итог: 874674. Возвращает: Рандомное сгенирированное число

- MultiLib.basic.read(*string expectedText) - Активация пользовательского ввода данных. 1 аргумент являетсвя дополнительным и его можно не указывать. Он отвевает за проверку текста. Например: без аргумента, пользователь ввёл: 918 Итог: 918; 1 аргумент-918, пользователь ввёл 918 Итог: true; 1 аргумент-918, пользователь ввёл: 387, Итог: false. Возвращает: Без аргументов - Введённую строку пользователем; true - при наличии 1 аргумента, если пользователь ввёл текст который указан в аргументе; false - при наличии 1 аргумента, если строка пользователя не равна строке в аргументе.

- MultiLib.basic.pause() - Приостанавливает консоль до нажатия любого клавиша. Возвращает: Ничего

- MultiLib.basic.sleep(int sleepTime) - Приостанавливает работу на некое время из аргумента. Укажите время в аргументе, в секундах. Возвращает: Ничего

- MultiLib.basic.terminate(int errCode) - Завершает работу консоли. В аргументе укажите код завершения (Можно указать любой код, например: 0). Возвращает: Ничего

- MultiLib.basic.writel(string text) - Выводит новую строку. В аргументе укажите текст для вывода. Возвращает: Ничего

- MultiLib.basic.write(string text) - Выводит текст. В аргументе укажите текст для вывода. Возвращает: Ничего

- MultiLib.basic.versionProgram(string namePacket, string description, string Version, string Revese, string copyright, string company, string trademark) - Выводит текст "О программе...". namePacket - Имя программы; description - Описание программы; Version - Версия программы; Revese - Ревизия программы (RELEASE, BETA, ALPHA); copyright - копирайт ((C) Aboio - 3022); company - компания; trademark - торговая марка

- MultiLib.czipC.EncryptFile(string inputFile, string outputFile, string password) - Криптование файла/архива. inputFile - Входной файл или архив который будет закриптован (если файл или архив находится не рядом с программой, то укажите полный путь до файла); outputFile - Выходной файл или архив зашифрованный; password - Пароль на расшифровку. Возвращает: return - None, file - cryptedFile

- MultiLib.czipC.DecryptFile(string inputFile, string outputFile, string password) - Расшифровка файла или архива. inputFile - Входной файл или архив который будет расшифрован (если файл или архив находится не рядом с программой, то укажите полный путь до файла); outputFile - Выходной файл или архив расшифрован; password - Пароль на расшифровку. Возвращает: return - None, file - decryptedFile

- MultiLib.czipC.compress(string pathFoler, string outputArchive) - Создание архива. pathFolder - полный путь до папки из которой будут взяты все файлы в архив; outputArchive - полное название файла архива (можно указать любое например: archive.mp, или указать с полным путём C:\Folder\ArChIvE.MyArchive)(можно не указывать полный путь, если архив будет находится рядом с программой)

- MultiLib.czipC.decompress(string pathArchive, string outputFolder) - Распаковывает архив. pathArchive - полный путь до архива (можно не указывать полный путь, если архив будет находится рядом с программой); outputFolder - полный путь до папки в которую будет расшифрован архив.

- MultiLib.internet.TestConnection() - Проверяет наличие интернета. Возвращает: true - если интернет есть, false - если интернета нет

- MultiLib.internet.ping(string url) - Проверяет соединение с сайтом. Возвращает: true - если соединение установлено, false - если соединение не удалось установить

- MultiLib.FTP.upload(string host, string username, string password, string localfullpath) - Загружает файл на фтп-сервер. host - полный путь на удалённом сервере куда будет загружен файл с указанием имя файла и расшерения для сохранение его под этими данными (например: https://ftp.multipl.com/UI/MultiIIcon.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя; localfullpath - полный путь до файла для загрузки его на сервер (например: C:\users\userName\desktop\miIcon.ico)

- MultiLib.FTP.download(string host, string username, string password, string localPath) - Скачивает файл с фтп-сервера. host - полный путь до файла на удалённом сервере откуда будет скачан файл (например: https://ftp.multipl.com/UI/MultiBrowser.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя; localPath - полный путь куда и под каким именем будет сохранён файл (например: C:\users\userName\source\repos\MultiBrowser\index.ico)

- MultiLib.FTP.exists(string host, string username, string password) - Проверяет наличие файла на фтп-сервере. host - полный путь до файла на удалённом сервере для проверки его наличия (например: https://ftp.multipl.com/UI/MultiBrowser.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя

- MultiLib.mail.send(string fromEmail, string fromName, string toEmail, string subject, string textOrHtml, string smtpServer, int smtpPort, string smtpMail, string smtpPasswordMail, bool saveLogFails) - Отправляет сообщение на почту с помощью smtp серверов. fromEmail - с какой почты отправлено письмо; fromName - с какого имени отправить письмо; toEmail - на какую почту отправить письмо; subject - тема письма; textOrHtml - сообщения письма (текст или html код); smtpServer - smtp-сервер (Можно использовать абсолютно бесплатные сервера, например от Google или Mail.ru, Дальше будут показанны примеры для Google. Например: mail.gmail.com); smtpPort - порт smtp-сервера (Например: 587); smtpMail - smtp-почта (Нужно указать почту от smtp-сервера. Для личных сервисов нужно указать созданную почту. Для бесплатных сервисов таких как Google, Mail.Ru и т.д. Нужно указать лишь почту от вашего аккаунта на этих сервисах. Почты на smtpMail и fromEmail должны совпадать! Например: mpcorp@gmail.com); smtpPassword - Пароль от почты. (Для Google тут не всё просто. Надо указать пароль от вашей почты которая указана в аргументе выше. Для Google же так просто не пройти. Вы должны получить пароль для сторонних приложений, инструкция: https://multiplayercorporation.mya5.ru/doc/smtp. Например: aaaaaaaaa); saveLogFails - Сохранить лог с проблемами? Возвращает: true - если письмо было успешно отправлено, false - если письмо не было отправлено

- MultiLib.music.play(string pathMusicFile) - Запуск проигрывания песни. pathMusicFile - полный путь до файла с музыкой (с форматами такими как .mp3, .wav, и т.д.)

- MultiLib.music.stop() - Остановка песни

- MultiLib.music.pause() - Приостановка песни

- MultiLib.compilator.collect(string inputSourceFile, string outputCompileFile) - Сборка файла C# в программу. inputSourceFile - полный путь до файла в котором хранится исходный код на C#; outputCompileFile - Выходной файл после сборки (Например: AsmCompileC#.exe) (можно также указать полный путь). Возвращает: return - None, file - compiled file

- MultiLib.mget.get(string url, string pathTo) - Получение репозитория. url - Ссылка на репозиторий (Например: https://github.com/dmitriykotik/MultiLib.git); pathTo - Полный путь куда расспаковать репозиторий (Например: C:\users\test\goha) (Папка должна быть создана и быть пустой)

- MultiLib.pass.GenPassword(int length) - Генерация случайного пароля. length - длина пароля.

- MultiLib.Authenticator.createAuthenticator(string uName, string uEmail, bool AUTOvisibleSecretKeyUserForAddAutentificator, bool createQRForm) - Создание аутентификатора. uName - отображаемое имя пользователя; uEmail - Отображаемая почта или телефон и т.д.; AUTOvisibleSecretKeyUserForAddAuthenticator - Показать пользователю его секретный ключ для добавления в приложение Google Authenticator?; crateQRForm - Показать также пользователю QR-код для добавления в приложение Google Authenticator. Возвращает: Секретный ключ

- MultiLib.Authenticator.checkEnterCode(string secretKey, string enteredPassword) - Проверка правильности введёного кода из приложения. secretKey - секретный ключ аутентификатора; enteredPassword - введёный пользователем пароль.

- MultiLib.Authenticator.getCurrentCode(string secretKey) - Получение действующего кода. secretKey - секретный ключ аутентификатора (данную функцию можно не использовать для проверки правильности кода!). Возвращает: Действующий код.

- MultiLib.INI.get(string pathToFile, string Section, string variable) - Получение текста из определённой переменной в секции файла. pathToFile - Полный путь до файла; Section - Секция; variable - Переменная; Возвращает: Код ошибки или текст из переменной (Вывод: 0x11 = Файл не существует; 0x21 = Указанная секция не существует; 0x31 = Указанная переменная не существует; (другое (текст)) = Вывод текст из переменной)

- MultiLib.INI.set(string pathToFile, string Section, string variable, string newTextForVariable, bool returnMSGError) - Установка значения в определённую переменную в секиции файла; pathToFile - Полный путь до файла; Section - Секция; variable - Переменная; newTextForVariable - Новый текст на переменную; returnMSGError - Показать сообщение об ошибке если она будет?

``` bash
\
/
\
/
\
- MultiLibGUI
/
\
/
\
/
```

- MultiLibGUI.basic.random(int start, int finish) - Генерация рандомного числа. Первый параметр означает от какого числа начать генерацию, второй параметр означает ДО какого числа закончить генирацию. Например: 1 аргумент-111111 2 аргумент-999999 Итог: 874674. Возвращает: Рандомное сгенирированное число

- MultiLibGUI.basic.sleep(int sleepTime) - Приостанавливает работу на некое время из аргумента. Укажите время в аргументе, в секундах. Возвращает: Ничего

- MultiLibGUI.basic.terminate(int errCode) - Завершает работу консоли. В аргументе укажите код завершения (Можно указать любой код, например: 0). Возвращает: Ничего

- MultiLibGUI.basic.versionProgram(string namePacket, string description, string Version, string Revese, string company) - Выводит текст "О программе...". namePacket - Имя программы; description - Описание программы; Version - Версия программы; Revese - Ревизия программы (RELEASE, BETA, ALPHA);  company - компания

- MultiLibGUI.czipC.EncryptFile(string inputFile, string outputFile, string password) - Криптование файла/архива. inputFile - Входной файл или архив который будет закриптован (если файл или архив находится не рядом с программой, то укажите полный путь до файла); outputFile - Выходной файл или архив зашифрованный; password - Пароль на расшифровку. Возвращает: return - None, file - cryptedFile

- MultiLibGUI.czipC.DecryptFile(string inputFile, string outputFile, string password) - Расшифровка файла или архива. inputFile - Входной файл или архив который будет расшифрован (если файл или архив находится не рядом с программой, то укажите полный путь до файла); outputFile - Выходной файл или архив расшифрован; password - Пароль на расшифровку. Возвращает: return - None, file - decryptedFile

- MultiLibGUI.czipC.compress(string pathFoler, string outputArchive) - Создание архива. pathFolder - полный путь до папки из которой будут взяты все файлы в архив; outputArchive - полное название файла архива (можно указать любое например: archive.mp, или указать с полным путём C:\Folder\ArChIvE.MyArchive)(можно не указывать полный путь, если архив будет находится рядом с программой)

- MultiLibGUI.czipC.decompress(string pathArchive, string outputFolder) - Распаковывает архив. pathArchive - полный путь до архива (можно не указывать полный путь, если архив будет находится рядом с программой); outputFolder - полный путь до папки в которую будет расшифрован архив.

- MultiLibGUI.internet.TestConnection() - Проверяет наличие интернета. Возвращает: true - если интернет есть, false - если интернета нет

- MultiLibGUI.internet.ping(string url) - Проверяет соединение с сайтом. Возвращает: true - если соединение установлено, false - если соединение не удалось установить

- MultiLibGUI.FTP.upload(string host, string username, string password, string localfullpath) - Загружает файл на фтп-сервер. host - полный путь на удалённом сервере куда будет загружен файл с указанием имя файла и расшерения для сохранение его под этими данными (например: https://ftp.multipl.com/UI/MultiIIcon.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя; localfullpath - полный путь до файла для загрузки его на сервер (например: C:\users\userName\desktop\miIcon.ico)

- MultiLibGUI.FTP.download(string host, string username, string password, string localPath) - Скачивает файл с фтп-сервера. host - полный путь до файла на удалённом сервере откуда будет скачан файл (например: https://ftp.multipl.com/UI/MultiBrowser.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя; localPath - полный путь куда и под каким именем будет сохранён файл (например: C:\users\userName\source\repos\MultiBrowser\index.ico)

- MultiLibGUI.FTP.exists(string host, string username, string password) - Проверяет наличие файла на фтп-сервере. host - полный путь до файла на удалённом сервере для проверки его наличия (например: https://ftp.multipl.com/UI/MultiBrowser.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя

- MultiLibGUI.mail.send(string fromEmail, string fromName, string toEmail, string subject, string textOrHtml, string smtpServer, int smtpPort, string smtpMail, string smtpPasswordMail, bool saveLogFails) - Отправляет сообщение на почту с помощью smtp серверов. fromEmail - с какой почты отправлено письмо; fromName - с какого имени отправить письмо; toEmail - на какую почту отправить письмо; subject - тема письма; textOrHtml - сообщения письма (текст или html код); smtpServer - smtp-сервер (Можно использовать абсолютно бесплатные сервера, например от Google или Mail.ru, Дальше будут показанны примеры для Google. Например: mail.gmail.com); smtpPort - порт smtp-сервера (Например: 587); smtpMail - smtp-почта (Нужно указать почту от smtp-сервера. Для личных сервисов нужно указать созданную почту. Для бесплатных сервисов таких как Google, Mail.Ru и т.д. Нужно указать лишь почту от вашего аккаунта на этих сервисах. Почты на smtpMail и fromEmail должны совпадать! Например: mpcorp@gmail.com); smtpPassword - Пароль от почты. (Для Google тут не всё просто. Надо указать пароль от вашей почты которая указана в аргументе выше. Для Google же так просто не пройти. Вы должны получить пароль для сторонних приложений, инструкция: https://multiplayercorporation.mya5.ru/doc/smtp. Например: aaaaaaaaa); saveLogFails - Сохранить лог с проблемами? Возвращает: true - если письмо было успешно отправлено, false - если письмо не было отправлено

- MultiLibGUI.music.play(string pathMusicFile) - Запуск проигрывания песни. pathMusicFile - полный путь до файла с музыкой (с форматами такими как .mp3, .wav, и т.д.)

- MultiLibGUI.music.stop() - Остановка песни

- MultiLibGUI.music.pause() - Приостановка песни

- MultiLibGUI.compilator.collect(string inputSourceFile, string outputCompileFile) - Сборка файла C# в программу. inputSourceFile - полный путь до файла в котором хранится исходный код на C#; outputCompileFile - Выходной файл после сборки (Например: AsmCompileC#.exe) (можно также указать полный путь). Возвращает: return - None, file - compiled file

- MultiLibGUI.mget.get(string url, string pathTo) - Получение репозитория. url - Ссылка на репозиторий (Например: https://github.com/dmitriykotik/MultiLib.git); pathTo - Полный путь куда расспаковать репозиторий (Например: C:\users\test\goha) (Папка должна быть создана и быть пустой)

- MultiLibGUI.pass.GenPassword(int length) - Генерация случайного пароля. length - длина пароля.

- MultiLibGUI.Authenticator.createAuthenticator(string uName, string uEmail, bool AUTOvisibleSecretKeyUserForAddAutentificator) - Создание аутентификатора. uName - отображаемое имя пользователя; uEmail - Отображаемая почта или телефон и т.д.; AUTOvisibleSecretKeyUserForAddAuthenticator - Показать пользователю его секретный ключ для добавления в приложение Google Authenticator?; Возвращает: Секретный ключ

- MultiLibGUI.Authenticator.checkEnterCode(string secretKey, string enteredPassword) - Проверка правильности введёного кода из приложения. secretKey - секретный ключ аутентификатора; enteredPassword - введёный пользователем пароль.

- MultiLibGUI.Authenticator.getCurrentCode(string secretKey) - Получение действующего кода. secretKey - секретный ключ аутентификатора (данную функцию можно не использовать для проверки правильности кода!). Возвращает: Действующий код.

- MultiLib.INI.get(string pathToFile, string Section, string variable) - Получение текста из определённой переменной в секции файла. pathToFile - Полный путь до файла; Section - Секция; variable - Переменная; Возвращает: Код ошибки или текст из переменной (Вывод: 0x11 = Файл не существует; 0x21 = Указанная секция не существует; 0x31 = Указанная переменная не существует; (другое (текст)) = Вывод текст из переменной)

- MultiLib.INI.set(string pathToFile, string Section, string variable, string newTextForVariable, bool returnMSGError) - Установка значения в определённую переменную в секиции файла; pathToFile - Полный путь до файла; Section - Секция; variable - Переменная; newTextForVariable - Новый текст на переменную; returnMSGError - Показать сообщение об ошибке если она будет?

# Лицензионное соглашение
```python
printf("The actual license agreement of the MultiPlayer company for the MultiLib library for copyright compliance.")
printf("(C) MultiPlayer 2019 - 2023. All rights reserved.")
if ready:
  continue
else:
  printf("You not ready!")
  Application.Exit()
```
```python
printf("English version:")
```

By using the MultiLib library, you acknowledge that the library is being used for NON-COMMERCIAL PURPOSES only! If you are going to use the library for your software for commercial purposes, then you will need to request permission by mail multiplayercorporation@gmail.com to use the library for commercial purposes. In the same place, you must discuss the terms of use for commercial purposes. The publisher of MultiPlayer reserves the right to ask you for a fee for using the library, but no more than once every 2 months. If the Publisher of MultiPlayer asks for a fee again before the expiration date, the contract will be terminated and the recipient of the service will receive additional time to use the received service. If the contract has expired/You have terminated the contract with the publisher of MultiPlayer/By breach of the contract, additional (free time outside the contract) time has expired, and you are not going to enter into a new contract with the publisher of MultiPlayer, then you MUST remove the MultiLib library from your project. To verify ownership of the MultiPlayer contract, you must add a "Publish Contract" to some tab in your software (For example: Settings) or you can tell the publisher of MultiPlayer about the project with a link, in which case you do not need to specify anything about the publisher of MultiPlayer. Upon receipt of the contract, you will receive: 1. The main contract to confirm ownership of a copy of the MultiLib library; 2. Secondary contract for publication with a unique code to be added to the software section, to confirm the ownership of a copy of the MultiLib library for commercial purposes. The publisher of MultiPlayer has the right to request an up-to-date version of your software (or request the entire list of your software running MultiLib) to check for a "Publication Agreement" (in the event that you did not provide a link to the project to the publisher of MultiPlayer) or to check for unacceptable things. The publisher of MultiPlayer has the right to terminate the contract if obscene things are found during the inspection of the software or for any other well-reasoned reason, while the recipient of the service retains the right to appeal against this decision. The service recipient retains the right to terminate the contract at any time with a reason, in which case the unique code of the commercial agreement becomes invalid, like all agreements under the commercial agreement, and the service recipient MUST remove the library from his program. If these actions are not performed within 7 days after the termination of the contract, the publisher of MultiPlayer remains entitled to request a cash equivalent of up to $100 and the removal of the project on the sites where the projects are (are) (also apply to government agencies for removal project from your site). After the expiration of the time to remove the library from the project, the recipient of the service has the right to apply for additional time up to 24 days. After receiving the contract, save the received license agreement (this is the license agreement) with a unique code, if the license agreement suddenly changes, then you will continue to use the MultiLib library under the license agreement that you received. If you receive a new contract for the MultiLib library, then you can optionally attach the license agreement that you received the first time, from which you can continue to work on the old license agreement. Also, upon receipt of a new contract, you can use the new license agreement. If, after closing all contracts, you receive a message that you have received the "MPMLFL" status, then you can no longer receive new contracts for the MultiLib library. The recipient of the service has the right to receive the reason for becoming "MPMLFL" and file an appeal on a well-reasoned reason. Accordingly, when receiving a contract from a partner for its assembly, the publisher of MultiPlayer must receive a fee from the partner in accordance with a certain fee divided by 30 (If, in the conditions of issuing a commercial contract to a certain person, the partner has set a monetary equivalent for a certain amount). In this case, the partner must inform the publisher of MultiPlayer about the issuance of a commercial contract for certain conditions. The partner retains the right to set its own conditions for issuing a commercial contract to a certain person for its assembly. When issuing a commercial contract to a certain person for its assembly, the partner must comply with the License Agreement for the commercial use of MultiLib. Before obtaining a commercial contract from a partner for its assembly, it is necessary to familiarize yourself with the current license agreement of the commercial contract. If a partner violates the commercial contract of the publisher of MultiPlayer, please inform multiplayercorporation@gmail.com by mail, leaving a link to the project.
!!! The MultiLib library is also suitable for creating games in C # (for example, on Unity), while games for publishing on the Internet require a commercial contract (if the game uses the MultiLib library)!
To obtain a commercial/Partnership agreement, you need:
- Full name (middle name if any)
- Phone number
- Mail
- For what purposes do you need a contract and a library
- Description of the program / game
- If you receive the agreement for the 2nd time or more, you can attach the old license agreement received 1 time or other times, indicating the reason why the agreement was terminated
Example: application form for obtaining a commercial / partnership agreement for the first time:
Subject: Obtaining a commercial contract for the MultiLib library
Message: I'm Petr Ivanovich Dolinin, I want to get a commercial contract for the first time. I want to use the MultiLib library for my horror game. It's just a normal horror game. The library is needed to work with INI and other functions. Here is my number and mail for communication: +70000000000 and d.petr@mail.ru

Example: application form for obtaining a commercial / partnership agreement for the 2nd time or more:
Subject: Obtaining a commercial contract for the MultiLib library
Message: I'm Petr Ivanovich Dolinin, I want to get another commercial contract (3rd time). The contract was terminated due to the fact that the term of the contract had expired. I noticed that the license agreement has recently changed, I'm not satisfied with the new license agreement, so I want to get an agreement under the old license agreement (* Attached file with a unique old-style license agreement *). If possible, I want to get a contract under the old terms.

No contract is required for NON-COMMERCIAL use (because the license agreement is a non-commercial contract)!

What is meant by commercial use in this form:
- Uploading the program to the Internet (for example: On your site, On SOFTPORTAL. Exceptions: Uploading the program on GitHub)
- For use in a company larger than 10 people
- For use in a popular program

What is meant by non-commercial use in this form:
- Any user without a contract with the MultiPlayer publisher for the MultiLib library (Who develops software or an assembly that contains the MultiLib library)

After receiving a commercial contract, you have the right to:
- Spread your programs on any other sites.
- Create any programs using the library (in accordance with the terms of the commercial contract)
- Create any programs using the library (in accordance with the terms of the commercial agreement) without specifying the publisher of MultiPlayer in any form.
- Use the library for commercial purposes.

After receiving the partnership agreement, you have the right to:
- Create your own builds of the MultiLib library and software with the MultiLib library.
- Specify the publisher of MultiPlayer only 1 time in the developers.
- Establish your terms of the contract.
- Set your license agreement, and you must have the MultiLib license agreements of the MultiPlayer publisher, such as License Agreement for the partner use of MultiLib, License Agreement for the non-commercial use of MultiLib, License Agreement for the commercial use of MultiLib and additionally DMCA for its MultiLib build (you can set your license agreement only after approval of the MultiPlayer publisher) (in its build under a commercial contract, the MultiPlayer publisher must receive a set fee (if the partner has set a fee according to the issuance conditions) in accordance with a certain fee divided by 30 (for example: Fee 5 $; 5/30=$0.166; Result: You pay $0.166 to the publisher of MultiPlayer and you have $4.834 left )))

NON-COMMERCIAL CONTRACT:
You cannot obtain this agreement as it is a license agreement and will be your non-commercial agreement. The publisher of MultiPlayer retains the right to request removal of a project on GitHub in violation of the current non-commercial license agreement or if there is not a single mention of MultiLib in the program. If you do not have other types of contracts, then you cannot enjoy their benefits. Since a non-commercial agreement is a license agreement, you must comply with the current state of the license agreement! You must indicate in a conspicuous place about the use of the MultiLib library as a watermark (if you put the program on the Internet, if the program will be used locally, then this is not required). You can upload your software using the MultiLib library only on GitHub. You can request a separate service from the publisher of MultiPlayer (For example: Sending software to other services), if you receive a refusal, then you can apply again, if you receive a refusal with the "MPMLD" type, then you do not have the right to resend the application for the service, also this service will not be included upon receipt of any contract. You can make an unlimited number of programs with the MultiLib library, but also publish only on GitHub. If obscene features are found in a program with the MultiLib library, the publisher of MultiPlayer remains entitled to apply for the removal of your program under the current license agreement of the non-commercial agreement of the MultiLib library, from the publisher of MultiPlayer. The application for removal of the program is submitted in accordance with the DMCA agreement and the License Agreement for the non-commercial use of MultiLib. If GitHub refuses to remove your program, then the publisher of MultiPlayer has the right to re-apply to remove your program in accordance with the DMCA agreement and the License Agreement for the non-commercial use of MultiLib no more than 3 times, if for all these times it came refusal, then the user retains the right to leave the program on GitHub. The publisher of MultiPlayer reserves the right to request removal of the program for any other well-founded reason.

Partnership agreement:
To obtain a partnership agreement, you need to apply as a commercial agreement. The recipient of the service retains the right to create their own versions of the MultiLib library without the participation of the MultiPlayer publisher. The recipient of the partnership agreement service does not have the right to commercial use. The publisher of MultiPlayer does not have the right to request a monetary equivalent from a user with a partnership agreement (for a contract, the publisher of MultiPlayer can request a monetary equivalent only if the partner created his own assembly on MultiLib and requested a certain amount from a certain person under a commercial agreement (The publisher of MultiPlayer can request a monetary equivalent: a certain the amount of the partner / 30)) in the event that he does not have a commercial contract. The recipient of the service will receive a message by e-mail or by phone if his software or assembly with the MultiLib library violates the terms of the partnership agreement or for any other well-reasoned reason, and an application will be submitted to remove the software or assembly in accordance with the DMCA agreement and the License Agreement for the partner use of multilib. Also, the recipient of the service has the right to appeal the removal of the software or assembly with an explanation. If an appeal is denied for a well-reasoned reason, the recipient of the service has the right to file an appeal against the refusal for a well-founded reason with an explanation. The publisher of MultiPlayer does NOT have the right to reject the appeal if the recipient of the service is right. If upon receipt of the contract you received a satisfactory answer, then you will receive 2-contracts, as in a commercial contract. The recipient of the service is obliged to report the new build or software to the publisher of MultiPlayer with a link to the GitHub project to avoid filing a request to remove the project in accordance with the DMCA agreement and the License Agreement for the non-commercial use of MultiLib. If the publisher of MultiPlayer knows about the project, then you can not indicate the contract for publication, but only bring "MultiPlayer" or "MultiPlayer | MultiLib Project" to the developers, if there is no indication of the publisher of MultiPlayer, then the publisher of MultiPlayer remains the right to apply for removal project on GitHub in accordance with the DMCA agreement and the License Agreement for the partner use of MultiLib with a warning to the service recipient and receiving an appeal. The partner has the right to terminate the agreement at any time, and after this action, the partner can apply for a "minimum" version of the partnership agreement for current projects forever. In this case, the partner can leave their projects with the MultiLib library (or builds) on GitHub and not be touched in accordance with the DMCA agreement and the License Agreement for the non-commercial use of MultiLib. After receiving the "minimum" version of the partnership agreement, projects with the MultiLib library (or builds) before receiving this version of the agreement can continue to develop without restrictions, but projects with the MultiLib library (or builds) created after receiving the "minimum" version of the partner agreement fall under the License Agreement for the non-commercial use of MultiLib, and the recipient of the service will be warned of the violation and asked to remove the MultiLib library from the project. If the "minimum" partner is against the removal of the library, after receiving the "minimum" version of the partner, then the publisher of MultiPlayer remains entitled to request the removal of the project on GitHub in accordance with the DMCA agreement and the License Agreement for the non-commercial use of MultiLib. If the service recipient (ex-partner) does not apply for the "minimum" version of the partner within 7 days, then all projects with the MultiLib library (or builds) will be requested to remove projects in accordance with the DMCA agreement and the License Agreement for the non- commercial use of MultiLib, prior to submitting the application, the former partner will be informed of the application to remove projects in accordance with the DMCA agreement and the License Agreement for the non-commercial use of MultiLib. The Affiliate retains the right not to pay a certain fee upon agreement with the publisher of MultiPlayer. The Partner has the right to request the current violations of other users, consider them and file an appeal. The Partner has the right to request the addition of a certain item to one of the MultiLib library agreements. The partner has the right to request the MultiPlayer publisher to add its code to the MultiLib library.

Basic agreement:
You accept that you accept all the terms of the contracts and if you did not read them, then this is your fault. You agree that you will abide by all the rules for using the MultiLib library based on this license agreement. You accept that in the presence of any of the agreements you will not make malware or assemblies based on the MultiLib library and distribute them on the Internet, when creating virus software you agree that you will be punished under Article 273 of the Criminal Code. RF. (Creation, distribution or use of computer programs or other computer information, knowingly intended for unauthorized destruction, blocking, modification, copying of computer information or neutralization of computer information protection means, is punishable by restraint of liberty for a term of up to four years, or forced labor for a term of up to four years. years, or by deprivation of liberty for the same term with a fine in the amount of up to two hundred thousand rubles or in the amount of the wage or other income of the convicted person for a period of up to eighteen months.).
This license agreement DOES NOT APPLY to ordinary users who do not develop for the MultiLib library

```python
Application.Exit()
```

```python
printf("Russian version")
```

При использовании библиотеки MultiLib вы принимаете, что библиотека используется только для НЕКОММЕРЧЕСКИХ ЦЕЛЕЙ! Если же вы собираетесь использовать библиотеку для своего ПО в коммерческих целях, то вы должны будете запросить разрешение по почте multiplayercorporation@gmail.com на использовании библиотеки в коммерческих целях. Там же вы должны обговорить условия использования в коммерческих целях. Издатель MultiPlayer остаётся в праве запросить у вас некую плату за использование библиотеки, но не чаще чем раз в 2 месяца. Если же Издатель MultiPlayer запросит плату ещё раз не вышедшего срока, то договор будет расторгнут и получатель услуги получит дополнительное время, на использование полученной услуги. Если срок договора истёк/Вы расторгли договор с издателем MultiPlayer/При нарушении договора истекло дополнительное (бесплатное время вне договора) время, и вы не собираетесь заключить новый договор с издателем MultiPlayer, то вы ОБЯЗАНЫ удалить библиотеку MultiLib из своего проекта. Для подтверждения владения договором MultiPlayer вы должны добавить "Договор для публикации" в какую нибудь вкладку в вашем ПО (Например: Настройки) или вы можете сообщить издателю MultiPlayer о проекте с указанием ссылки, в этом случае вам не нужно указывать ничего об издателе MultiPlayer. При получении договора вы получаете: 1. Основной договор для подтверждения о владении копии библиотеки MultiLib; 2. Вторичный договор для публикации с уникальным кодом для добавления в раздел ПО, для подтверждения владении копии библиотеки MultiLib в коммерческих целях. Издатель MultiPlayer в праве запросить актуальную версию вашего ПО (или запросить весь список ваших ПО на которых работает MultiLib) для проверки наличия "Договора для публикации" (в том случае если вы не сообщили ссылку на проект издателю MultiPlayer) или для проверки наличия неприемлемых вещей. Издатель MultiPlayer в праве расторгнуть договор если при проверке ПО будут обнаружены непристойные вещи или по любой другой основательно аргументированной причине, получатель услуги же остаётся в праве подать апелляцию на данное решение. Получатель услуги остаётся в праве расторгнуть договор в любой момент с указанием причины, при этом уникальный код коммерческого договора становится не действительным, как и все договорённости в рамках коммерческого соглашения, и получатель услуги ОБЯЗАН удалить библиотеку из своей программы. Если указанные действия не будут выполнены в течение 7 дней после остановки действия договора, то издатель MultiPlayer остаётся в праве запросить денежный эквивалент в размере до 100$ США и удаление проекта на сайтах где находится (находятся) проекты (также обратится в гос. учреждения для удаления проекта с вашего сайта). После истечения времени на удаление библиотеки из проекта получатель услуги имеет право подать заявку на дополнительное время до 24 дней. После получения договора сохраните полученное лицензионное соглашение (это лицензионное соглашение) с уникальным кодом, если вдруг лицензионное соглашение изменится, то вы будете продолжать пользоваться библиотекой MultiLib по лицензионному соглашению которое вы получили. Если вы получаете новый договор на библиотеку MultiLib, то вы при желании можете прикрепить лицензионное соглашение которое вы получили в первый раз, из чего вы можете продолжать работу на старом лицензионном соглашении. Также при получении нового договора вы можете воспользоваться новым лицензионным соглашением. Если после закрытия всех договоров вам пришло сообщение о том, что вы получили статус "MPMLFL", то вы больше не можете получить новые договоры для библиотеки MultiLib. Получатель услуги имеет право получить причину получения статуса "MPMLFL" и подать апелляцию по основательно аргументированной причине. В соответствии при получении договора у партнёра на его сборку, издатель MultiPlayer должен получить плату от партнёра в соответствии некая плата делённая на 30 (Если в условиях выдачи коммерческого договора некому лицу партнёр установил денежный эквивалент на некую сумму). При этом партнёр должен сообщить издателю MultiPlayer о выдаче коммерческого договора на некие условия. Партнёр остаётся в праве установить свои условия для выдачи коммерческого договора некому лицу на свою сборку. При выдаче коммерческого договора некому лицу на свою сборку партнёр обязан соблюдать License Agreement for the commercial use of MultiLib. Перед получением коммерческого договора у партнёра на его сборку нужно обязательно ознакомиться с текущем лицензионным соглашением коммерческого договора. При нарушении партнёром коммерческого договора издателя MultiPlayer сообщите по почте multiplayercorporation@gmail.com оставив ссылку на проект.
!!! Библиотека MultiLib также подходит для создания игр на C# (например на Unity), при этом на игры для публикации в интернете нужен обязательно коммерческий договор (если в игре используется библиотека MultiLib)!
Для получения коммерческого/Партнёрского договора нужно:
- ФИО (отчество если есть)
- Номер телефона
- Почта
- На какие цели нужен договор и библиотека
- Описание работы программы/игры
- Если вы получаете договор во 2-й раз или более, то можете прикрепить старое лицензионное соглашение полученной в 1 раз или другие разы, с указанием причины почему договор был расторгнут
Пример: форма заявки на получение коммерческого/партнёрского договора впервые:
Тема: Получение коммерческого договора на библиотеку MultiLib
Сообщение: Я Долинин Пётр Иванович хочу получить коммерческий договор впервые. Хочу использовать библиотеку MultiLib для своей хоррор-игры. Это обычная хоррор-игра. Библиотека нужна для работы с INI и другими функциями. Вот мой номер и почта для связи: +70000000000 и d.petr@mail.ru

Пример: форма заявки на получение коммерческого/партнёрского договора в 2-й раз и более:
Тема: Получение коммерческого договора на библиотеку MultiLib
Сообщение: Я Долинин Пётр Иванович хочу получить повторно коммерческий договор (3-й раз). Договор был расторгнут из-за того, что истёк срок договора. Я заметил, что недавно изменилось лицензионное соглашение, меня не устраивает новое лицензионное соглашение, поэтому я хочу получить договор по старому лицензионному соглашению (* Прикреплённый файл с уникальным лицензионным соглашением старого образца *). Если возможно, то я хочу получить договор по старым условиям.

Для НЕКОММЕРЧЕСКОГО использования договор не требуется (так как лицензионное соглашение является некоммерческим договором)!

Что подразумевается под коммерческое использование в этой форме:
- Выкладывание программы в интернет (например: На свой сайт, На SOFTPORTAL. Исключения: Выкладывание программы на GitHub)
- Для использования в компании размером больше 10 человек
- Для использования в популярной программе

Что подразумевается под некоммерческое использование в этой форме:
- Любой пользователь без заключённого договора с издателем MultiPlayer на библиотеку MultiLib (Который разрабатывает ПО или сборку в которой есть библиотека MultiLib)

После получения коммерческого договора вы имеете право:
- Выкладывать свои программы на любые другие сайты.
- Создавать любые программы с использованием библиотеки (в соответствии с условиями коммерческого договора)
- Создавать любые программы с использованием библиотеки (в соответствии с условиями коммерческого договора) без указания издателя MultiPlayer в любом виде.
- Использовать библиотеку в коммерческих целях.

После получения партнёрского договора вы имеете право:
- Создавать свои сборки библиотеки MultiLib и ПО с библиотекой MultiLib.
- Указывать издателя MultiPlayer только 1 раз в разработчиках.
- Устанавливать свои условия договора.
- Установить своё лицензионное соглашение, при этом обязательно должны быть лицензионные соглашения MultiLib издателя MultiPlayer такие, как License Agreement for the partner use of MultiLib, License Agreement for the non-commercial use of MultiLib, License Agreement for the commercial use of MultiLib и дополнительно DMCA для своей сборки MultiLib (установить своё лицензионное соглашение можно только после утверждения издателя MultiPlayer) (в своей сборке по коммерческому договору издатель MultiPlayer должен получить установленную плату (если по условиям выдачи партнёр установил плату) в соответствии некая плата делённая на 30 (например: Плата 5$; 5/30=0,166$; Итог: Вы платите 0,166$ издателю MultiPlayer и у вас остаётся 4,834$ (5$ = 382,25 руб., 0.166$ = 12,69 руб., 4.834$ = 369,56 руб.)))

НЕКОММЕРЧЕСКИЙ ДОГОВОР:
Вы не можете получить данный договор так как лицензионное соглашение, и будет являться вашим некоммерческим договором. Издатель MultiPlayer остаётся в праве запросить удаление проекта на GitHub при нарушении текущего лицензионного соглашения некоммерческого использования или если в программе ни единого упоминания о MultiLib. Если вы не имеете договора других типов, то вы не можете пользоваться их преимуществами. Так как некоммерческий договор и есть лицензионное соглашение, то вы обязаны соблюдать текущее состояние лицензионного соглашения! Вы обязаны указать на видном месте об использовании библиотеки MultiLib как водные знаки (если вы выкладываете программу в интернет, если программа будет использоваться локально, то это не требуется). Вы можете выкладывать своё ПО с использованием библиотеки MultiLib только на GitHub. Вы можете запросить у издателя MultiPlayer отдельно услугу (Например: Отправка ПО на другие сервисы), если вам пришёл отказ, то вы можете подать заявку ещё раз, если же вам пришёл отказ с типом "MPMLD", то вы не имеете права повторно отправить заявку на услугу, также эта услуга не будет включена при получении любого договора. Вы можете делать неограниченное количество программ с библиотекой MultiLib, но также выкладывать только на GitHub. При обнаружении непристойных функций в программе с библиотекой MultiLib, издатель MultiPlayer остаётся в праве подать заявку на удалении вашей программы по текущему лицензионному соглашению некоммерческого договора библиотеки MultiLib, от издателя MultiPlayer. Заявка на удалении программы подаётся в соответствии соглашения DMCA и License Agreement for the non-commercial use of MultiLib. Если пришёл отказ GitHub на удаление вашей программы, то издатель MultiPlayer остаётся в праве подать повторную заявку на удаление вашей программы в соответствии соглашения DMCA и License Agreement for the non-commercial use of MultiLib не более 3-х раз, если за все эти разы приходил отказ, то пользователь остаётся в праве оставить программу на GitHub. Издатель MultiPlayer остаётся в праве подать заявку на удаление программы по любой другой основательно аргументированной причине.

Партнёрский договор:
Для получения партнёрского договора вам нужно подать заявку как на коммерческий договор. Получатель услуги остаётся в праве создавать свои версии библиотеки MultiLib без участия издателя MultiPlayer. Получатель услуги партнёрского договора не имеет права коммерческого использования. Издатель MultiPlayer не имеет права запросить у пользователя с партнёрским договором денежный эквивалент (за договор, издатель MultiPlayer может запросить денежный эквивалент только если партнёр создал свою сборку на MultiLib и запросил у некого лица по коммерческому договору некую сумму (Издатель MultiPlayer может запросить денежный эквивалент: некая сумма партнёра/30)) в том случае если у него нет коммерческого договора. Получатель услуги получит сообщение на почту или на телефон если его ПО или сборка с библиотекой MultiLib нарушает условия партнёрского договора или по любой другой основательно аргументированной причине, и будет подана заявка на удаление ПО или сборки в соответствии соглашения DMCA и License Agreement for the partner use of MultiLib. Также получатель услуги имеет право подать апелляцию на удаление ПО или сборки с объяснением. Если пришёл отказ на апелляцию по основательно аргументированной причине, то получатель услуги имеет право подать апелляцию на отказ по основательно аргументированной причине с объяснением. Издатель MultiPlayer НЕ имеет права отклонить апелляцию если получатель услуги прав. Если при получении договора вам пришёл удовлетворительный ответ, то вы получите 2-договора, как и в коммерческом договоре. Получатель услуги обязан сообщить о новой сборке или ПО издателю MultiPlayer со ссылкой на проект GitHub для исключения подачи заявки на удаление проекта в соответствии соглашения DMCA и License Agreement for the non-commercial use of MultiLib. Если издатель MultiPlayer знает о проекте, то вы можете не указывать договор на публикацию, а только занести "MultiPlayer" или "MultiPlayer | MultiLib Project" в разработчики, если не будет указаний на издателя MultiPlayer, то издатель MultiPlayer остаётся в праве подать заявку на удаление проекта на GitHub в соответствии соглашения DMCA и License Agreement for the partner use of MultiLib с предупреждением получателя услуг и получении апелляции. Партнёр имеет право расторгать договор в любой момент, также после этого действия партнёр может подать заявку на "минимальную" версию партнёрского договора на текущие проекты навсегда. В этом случае партнёр может оставить свои проекты с библиотекой MultiLib (или сборки) на GitHub и не быть тронутым в соответствии соглашения DMCA и License Agreement for the non-commercial use of MultiLib. После получения "минимальной" версии партнёрского договора, проекты с библиотекой MultiLib (либо сборки) до получения этой версии договора могут продолжать развиваться без ограничений, но проекты с библиотекой MultiLib (или сборки) созданные после получения "минимальной" версии партнёрского договора попадают под License Agreement for the non-commercial use of MultiLib, и получателя услуги предупредят о нарушении, и попросят удалить библиотеку MultiLib из проекта. Если "минимальный" партнёр будет против удаления библиотеки, после получения "минимальной" версии партнёра, то издатель MultiPlayer остаётся в праве запросить удаление проекта на GitHub в соответствии соглашения DMCA и License Agreement for the non-commercial use of MultiLib. Если получатель услуг (бывший партнёр) не подаст заявку на получение "минимальной" версии партнёра в течение 7 дней, то на все проекты с библиотекой MultiLib (или сборки) будет подана заявка на удаление проектов в соответствии соглашения DMCA и License Agreement for the non-commercial use of MultiLib, перед подачей заявки бывшему партнёру сообщат о подачи заявки на удаление проектов в соответствии соглашения DMCA и License Agreement for the non-commercial use of MultiLib. Партнёр остаётся в праве не оплачивать некую плату при договорённости об этом с издателем MultiPlayer. Партнёр имеет право запросить действующие нарушение других пользователей, рассмотреть их и подать апелляцию. Партнёр имеет право запросить добавление некого пункта в одно из соглашений библиотеки MultiLib. Партнёр имеет право запросить у издателя MultiPlayer добавление его кода в библиотеку MultiLib.

Основное соглашение:
Вы принимаете, что вы принимаете все условия договоров и если вы их не читали, то это ваша вина. Вы соглашаетесь, что вы будете соблюдать все правила пользования библиотекой MultiLib на основе данного лицензионного соглашения. Вы принимаете, что при наличии любого из договоров вы не будете делать вредоносное ПО или сборки на основе библиотеки MultiLib и распространять их в интернете, при создании вирусного ПО вы соглашаетесь, что вы будете наказаны по статье 273 УК. РФ. (Создание, распространение или использование компьютерных программ либо иной компьютерной информации, заведомо предназначенных для несанкционированного уничтожения, блокирования, модификации, копирования компьютерной информации или нейтрализации средств защиты компьютерной информации, — наказываются ограничением свободы на срок до четырех лет, либо принудительными работами на срок до четырех лет, либо лишением свободы на тот же срок со штрафом в размере до двухсот тысяч рублей или в размере заработной платы или иного дохода осужденного за период до восемнадцати месяцев.).
Данное лицензионное соглашение НЕ ДЕЙСТВУЕТ на обычных пользователей которые не разрабатывают под библиотеку MultiLib


```
Application.Exit()
```
