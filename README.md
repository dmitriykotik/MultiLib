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

By using the MultiLib library, you acknowledge that the library is being used for NON-COMMERCIAL PURPOSES only! If you are going to use the library for your software for commercial purposes, then you will need to request permission by mail multiplayercorporation@gmail.com to use the library for commercial purposes. In the same place, you must discuss the terms of use for commercial purposes. The publisher of MultiPlayer reserves the right to ask you for a fee for using the library, but no more than once every 2 months. If the Publisher of MultiPlayer asks for a fee again before the expiration date, the contract will be terminated and the recipient of the service will receive additional time to use the received service. If the contract has expired/You have terminated the contract with the publisher of MultiPlayer/By breach of the contract, additional (free time outside the contract) time has expired, and you are not going to enter into a new contract with the publisher of MultiPlayer, then you MUST remove the MultiLib library from your project. In order to verify ownership of the MultiPlayer contract, you must add the "Publication Contract" to some tab in your software (For example: Settings). Upon receipt of the contract, you will receive: 1. The main contract to confirm ownership of a copy of the MultiLib library; 2. Secondary contract for publication with a unique code to add to the software section, to confirm the ownership of a copy of the MultiID library for commercial purposes. The publisher of MultiPlayer has the right to request an up-to-date version of your software to check for a "Publication Agreement" or to check for unacceptable things. The publisher of MultiPlayer has the right to terminate the agreement if there is no "Agreement for publication" when checking the software (the Agreement will be terminated if this is a version for publication on the site or in any other place, if it is a version for). The recipient of the service has the right to terminate the contract at any time with a reason, in which case the unique code becomes invalid, and the recipient of the service MUST remove the library from his program. If these actions are not completed within 7 days after the termination of the contract, the publisher of MultiPlayer remains entitled to request a cash equivalent of up to $100 USD. After receiving the contract, save the received license agreement (this is the license agreement) with a unique code, if the license agreement suddenly changes, then you will continue to use the MultiLib library under the license agreement that you received. If you receive a new contract for the MultiLib library, then you can optionally attach the license agreement that you received the first time, from which you can continue to work on the old license agreement. Also, upon receipt of a new contract, you can use the new license agreement.
!!! The MultiLib library is also suitable for creating games in C # (for example, in Unity), while games for publishing on the Internet require a commercial contract!
To obtain a commercial contract, you need:
- Full name (middle name if any)
- Phone number
- Mail
- For what purposes do you need a contract and a library
- Description of the program / game
- If you receive the agreement for the 2nd time or more, you can attach the old license agreement received 1 time or other times, indicating the reason why the agreement was terminated

Example: application form for obtaining a commercial contract for the first time:
Subject: Obtaining a commercial contract for the MultiLib library
Message: I'm Petr Ivanovich Dolinin, I want to get a contract for the first time. I want to use the MultiLib library for my horror game. It's just a normal horror game. The library is needed to work with INI and other functions. Here is my number and mail for communication: 00000000000 and d.petr@mail.ru

Example: application form for obtaining a commercial contract for the 2nd time or more:
Subject: Obtaining a commercial contract for the MultiLib library
Message: I'm Dolinin Petr Ivanovich, I want to get a contract again (3rd time). The contract was terminated due to the fact that the term of the contract had expired. I noticed that the license agreement has recently changed, I'm not satisfied with the new license agreement, so I want to get an agreement under the old license agreement (* Attached file with a unique old-style license agreement *). If possible, I want to get a contract under the old terms.

No contract required for NON-COMMERCIAL use!

What is meant by commercial use in this form:
- Uploading the program to the Internet (for example: On your site, On SOFTPORTAL. Exceptions: Uploading the program on GitHub)
- For use in a company larger than 10 people
- For use in a popular program

```python
Application.Exit()
```

```python
printf("Russian version")
```

Console.WriteLine(@"При использовании библиотеки MultiLib вы принимаете, что библиотека используется только для НЕКОММЕРЧЕСКИХ ЦЕЛЕЙ! Если же вы собираетесь использовать библиотеку для своего ПО в коммерческих целях, то вы должны будете запросить разрешение по почте multiplayercorporation@gmail.com на использовании библиотеки в коммерческих целях. Там же вы должны обговорить условия использования в коммерческих целях. Издатель MultiPlayer остаётся в праве запросить у вас некую плату за использование библиотеки, но не чаще чем раз в 2 месяца. Если же Издатель MultiPlayer запросит плату ещё раз не вышедшего срока, то договор будет расторгнут и получатель услуги получит дополнительное время, на использование полученной услуги. Если срок договора истёк/Вы расторгли договор с издателем MultiPlayer/При нарушении договора истекло дополнительное (бесплатное время вне договора) время, и вы не собираетесь заключить новый договор с издателем MultiPlayer, то вы ОБЯЗАНЫ удалить библиотеку MultiLib из своего проекта. Для подтверждения владения договором MultiPlayer вы должны добавить "Договор для публикации" в какую нибудь вкладку в вашем ПО (Например: Настройки). При получении договора вы получаете: 1. Основной договор для подтверждения о владении копии библиотеки MultiLib; 2. Вторичный договор для публикации с уникальным кодом для добавления в раздел ПО, для подтверждения владении копии библиотеки MultiID в коммерческих целях. Издатель MultiPlayer в праве запросить актуальную версию вашего ПО для проверки наличия "Договора для публикации" или для проверки наличия неприемлемых вещей. Издатель MultiPlayer в праве расторгнуть договор если при проверке ПО не будет "Договора для публикации" (Договор будет расторгнут в том случае если это версия для публикации на сайт или в любое другое место, если же это версия для). Получатель услуги остаётся в праве расторгнуть договор в любой момент с указанием причины, при этом уникальный код становится не действительным, и получатель услуги ОБЯЗАН удалить библиотеку из своей программы. Если указанные действия не будут выполнены в течение 7 дней после остановки действия договора, то издатель MultiPlayer остаётся в праве запросить денежный эквивалент в размере до 100$ США. После получения договора сохраните полученное лицензионное соглашение (это лицензионное соглашение) с уникальным кодом, если вдруг лицензионное соглашение изменится, то вы будете продолжать пользоваться библиотекой MultiLib по лицензионному соглашению которое вы получили. Если вы получаете новый договор на библиотеку MultiLib, то вы при желании можете прикрепить лицензионное соглашение которое вы получили в первый раз, из чего вы можете продолжать работу на старом лицензионном соглашении. Также при получении нового договора вы можете воспользоваться новым лицензионным соглашением.
!!! Библиотека MultiLib также подходит для создания игр на C# (например на Unity), при этом на игры для публикации в интернете нужен обязательно коммерческий договор!
Для получения коммерческого договора нужно:
- ФИО (отчество если есть)
- Номер телефона
- Почта
- На какие цели нужен договор и библиотека
- Описание работы программы/игры
- Если вы получаете договор во 2-й раз или более, то можете прикрепить старое лицензионное соглашение полученной в 1 раз или другие разы, с указанием причины почему договор был расторгнут

Пример: форма заявки на получение коммерческого договора впервые:
Тема: Получение коммерческого договора на библиотеку MultiLib
Сообщение: Я Долинин Пётр Иванович хочу получить договор впервые. Хочу использовать библиотеку MultiLib для своей хоррор-игры. Это обычная хоррор-игра. Библиотека нужна для работы с INI и другими функциями. Вот мой номер и почта для связи: 00000000000 и d.petr@mail.ru

Пример: форма заявки на получение коммерческого договора в 2-й раз и более:
Тема: Получение коммерческого договора на библиотеку MultiLib
Сообщение: Я Долинин Пётр Иванович хочу получить повторно договор (3-й раз). Договор был расторгнут из-за того, что истёк срок договора. Я заметил, что недавно изменилось лицензионное соглашение, меня не устраивает новое лицензионное соглашение, поэтому я хочу получить договор по старому лицензионному соглашению (* Прикреплённый файл с уникальным лицензионным соглашением старого образца *). Если возможно, то я хочу получить договор по старым условиям.

Для НЕКОММЕРЧЕСКОГО использования договор не требуется!

Что подразумевается под коммерческое использование в этой форме:
- Выкладывание программы в интернет (например: На свой сайт, На SOFTPORTAL. Исключения: Выкладывание программы на GitHub)
- Для использования в компании размером больше 10 человек
- Для использования в популярной программе");

```
Application.Exit()
```
