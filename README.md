# MultiLib
Проект временно приостановлен навсегда!

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

Библиотека для разрабочиков. Создана для сокращения кода. Библиотека будет входить в состав MultiDeveloperKit и MultiRedistributable.

Данная библиотека немного сокращает код на C#. Её нужно использовать если программа требует библиотеку MultiLib. Если вы хотите программировать на ней, то стоит почитать документацию (пока что нет) и загрузить её в свой проект VisualStudio C#. Для загрузки почти ничего не требуется. Скачайте библиотеку, сохраните в любом удобном месте, откройте проект в VisualStudio, в правом окне нажмите ПКМ по "Ссылки" и выберите пункт "Добавить ссылку...", после нажмите на кнопку внизу "Обзор..." и наконец выберите скачанную библиотеку.

Библиотека создана на C# .net framework 4.8, если вы программируете под версию ниже, то библиотека будет не совместима!

-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

Так как в новых версиях появился архив с библиотекой, хотелось бы напомнить, что оснавная библиотека - это файлик "MultiLib.dll"
А ещё предупреждение! Не пытайтесь совместить нашу библиотеку C# с C++, у вас просто это не получится. Это не мы так решили, мы на оборот пытались подружить эти 2 языка, но без успешно. Так что не тратьте время на подключение к C++/CLI. Если вы смолги без ошибок подключить библиотеку и у неё все функции работают, то напишите издателю MultiPlayer (multiplayercorporation@gmail.com) об этом и создайте комит если вам не трудно. Спасибо)

# Помоги в разработке
Вы можете исправлять или добавлять свой код для библиотек MultiLib с помощью раздела Pull requests! Подробнее: https://docs.github.com/en/pull-requests/collaborating-with-pull-requests/proposing-changes-to-your-work-with-pull-requests/creating-a-pull-request
> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

# Классы
> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".
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
> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".
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

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

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

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

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

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

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

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

# Документация
В документации содержится: библиотека.класс.функция(аргументы) - описание

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

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

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

- MultiLib.basic.read(*string expectedText) - Активация пользовательского ввода данных. 1 аргумент являетсвя дополнительным и его можно не указывать. Он отвевает за проверку текста. Например: без аргумента, пользователь ввёл: 918 Итог: 918; 1 аргумент-918, пользователь ввёл 918 Итог: true; 1 аргумент-918, пользователь ввёл: 387, Итог: false. Возвращает: Без аргументов - Введённую строку пользователем; true - при наличии 1 аргумента, если пользователь ввёл текст который указан в аргументе; false - при наличии 1 аргумента, если строка пользователя не равна строке в аргументе.


- MultiLib.basic.pause() - Приостанавливает консоль до нажатия любого клавиша. Возвращает: Ничего

- MultiLib.basic.sleep(int sleepTime) - Приостанавливает работу на некое время из аргумента. Укажите время в аргументе, в секундах. Возвращает: Ничего

- MultiLib.basic.terminate(int errCode) - Завершает работу консоли. В аргументе укажите код завершения (Можно указать любой код, например: 0). Возвращает: Ничего

- MultiLib.basic.writel(string text) - Выводит новую строку. В аргументе укажите текст для вывода. Возвращает: Ничего

- MultiLib.basic.write(string text) - Выводит текст. В аргументе укажите текст для вывода. Возвращает: Ничего

- MultiLib.basic.versionProgram(string namePacket, string description, string Version, string Revese, string copyright, string company, string trademark) - Выводит текст "О программе...". namePacket - Имя программы; description - Описание программы; Version - Версия программы; Revese - Ревизия программы (RELEASE, BETA, ALPHA); copyright - копирайт ((C) Aboio - 3022); company - компания; trademark - торговая марка

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

- MultiLib.czipC.EncryptFile(string inputFile, string outputFile, string password) - Криптование файла/архива. inputFile - Входной файл или архив который будет закриптован (если файл или архив находится не рядом с программой, то укажите полный путь до файла); outputFile - Выходной файл или архив зашифрованный; password - Пароль на расшифровку. Возвращает: return - None, file - cryptedFile

- MultiLib.czipC.DecryptFile(string inputFile, string outputFile, string password) - Расшифровка файла или архива. inputFile - Входной файл или архив который будет расшифрован (если файл или архив находится не рядом с программой, то укажите полный путь до файла); outputFile - Выходной файл или архив расшифрован; password - Пароль на расшифровку. Возвращает: return - None, file - decryptedFile

- MultiLib.czipC.compress(string pathFoler, string outputArchive) - Создание архива. pathFolder - полный путь до папки из которой будут взяты все файлы в архив; outputArchive - полное название файла архива (можно указать любое например: archive.mp, или указать с полным путём C:\Folder\ArChIvE.MyArchive)(можно не указывать полный путь, если архив будет находится рядом с программой)

- MultiLib.czipC.decompress(string pathArchive, string outputFolder) - Распаковывает архив. pathArchive - полный путь до архива (можно не указывать полный путь, если архив будет находится рядом с программой); outputFolder - полный путь до папки в которую будет расшифрован архив.

- MultiLib.internet.TestConnection() - Проверяет наличие интернета. Возвращает: true - если интернет есть, false - если интернета нет

- MultiLib.internet.ping(string url) - Проверяет соединение с сайтом. Возвращает: true - если соединение установлено, false - если соединение не удалось установить

- MultiLib.FTP.upload(string host, string username, string password, string localfullpath) - Загружает файл на фтп-сервер. host - полный путь на удалённом сервере куда будет загружен файл с указанием имя файла и расшерения для сохранение его под этими данными (например: https://ftp.multipl.com/UI/MultiIIcon.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя; localfullpath - полный путь до файла для загрузки его на сервер (например: C:\users\userName\desktop\miIcon.ico)

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

- MultiLib.FTP.download(string host, string username, string password, string localPath) - Скачивает файл с фтп-сервера. host - полный путь до файла на удалённом сервере откуда будет скачан файл (например: https://ftp.multipl.com/UI/MultiBrowser.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя; localPath - полный путь куда и под каким именем будет сохранён файл (например: C:\users\userName\source\repos\MultiBrowser\index.ico)

- MultiLib.FTP.exists(string host, string username, string password) - Проверяет наличие файла на фтп-сервере. host - полный путь до файла на удалённом сервере для проверки его наличия (например: https://ftp.multipl.com/UI/MultiBrowser.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя

- MultiLib.mail.send(string fromEmail, string fromName, string toEmail, string subject, string textOrHtml, string smtpServer, int smtpPort, string smtpMail, string smtpPasswordMail, bool saveLogFails) - Отправляет сообщение на почту с помощью smtp серверов. fromEmail - с какой почты отправлено письмо; fromName - с какого имени отправить письмо; toEmail - на какую почту отправить письмо; subject - тема письма; textOrHtml - сообщения письма (текст или html код); smtpServer - smtp-сервер (Можно использовать абсолютно бесплатные сервера, например от Google или Mail.ru, Дальше будут показанны примеры для Google. Например: mail.gmail.com); smtpPort - порт smtp-сервера (Например: 587); smtpMail - smtp-почта (Нужно указать почту от smtp-сервера. Для личных сервисов нужно указать созданную почту. Для бесплатных сервисов таких как Google, Mail.Ru и т.д. Нужно указать лишь почту от вашего аккаунта на этих сервисах. Почты на smtpMail и fromEmail должны совпадать! Например: mpcorp@gmail.com); smtpPassword - Пароль от почты. (Для Google тут не всё просто. Надо указать пароль от вашей почты которая указана в аргументе выше. Для Google же так просто не пройти. Вы должны получить пароль для сторонних приложений, инструкция: https://multiplayercorporation.mya5.ru/doc/smtp. Например: aaaaaaaaa); saveLogFails - Сохранить лог с проблемами? Возвращает: true - если письмо было успешно отправлено, false - если письмо не было отправлено

- MultiLib.music.play(string pathMusicFile) - Запуск проигрывания песни. pathMusicFile - полный путь до файла с музыкой (с форматами такими как .mp3, .wav, и т.д.)

- MultiLib.music.stop() - Остановка песни

- MultiLib.music.pause() - Приостановка песни

- MultiLib.compilator.collect(string inputSourceFile, string outputCompileFile) - Сборка файла C# в программу. inputSourceFile - полный путь до файла в котором хранится исходный код на C#; outputCompileFile - Выходной файл после сборки (Например: AsmCompileC#.exe) (можно также указать полный путь). Возвращает: return - None, file - compiled file

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

- MultiLib.mget.get(string url, string pathTo) - Получение репозитория. url - Ссылка на репозиторий (Например: https://github.com/dmitriykotik/MultiLib.git); pathTo - Полный путь куда расспаковать репозиторий (Например: C:\users\test\goha) (Папка должна быть создана и быть пустой)

- MultiLib.pass.GenPassword(int length) - Генерация случайного пароля. length - длина пароля.

- MultiLib.Authenticator.createAuthenticator(string uName, string uEmail, bool AUTOvisibleSecretKeyUserForAddAutentificator, bool createQRForm) - Создание аутентификатора. uName - отображаемое имя пользователя; uEmail - Отображаемая почта или телефон и т.д.; AUTOvisibleSecretKeyUserForAddAuthenticator - Показать пользователю его секретный ключ для добавления в приложение Google Authenticator?; crateQRForm - Показать также пользователю QR-код для добавления в приложение Google Authenticator. Возвращает: Секретный ключ

- MultiLib.Authenticator.checkEnterCode(string secretKey, string enteredPassword) - Проверка правильности введёного кода из приложения. secretKey - секретный ключ аутентификатора; enteredPassword - введёный пользователем пароль.

- MultiLib.Authenticator.getCurrentCode(string secretKey) - Получение действующего кода. secretKey - секретный ключ аутентификатора (данную функцию можно не использовать для проверки правильности кода!). Возвращает: Действующий код.

- MultiLib.INI.get(string pathToFile, string Section, string variable) - Получение текста из определённой переменной в секции файла. pathToFile - Полный путь до файла; Section - Секция; variable - Переменная; Возвращает: Код ошибки или текст из переменной (Вывод: 0x11 = Файл не существует; 0x21 = Указанная секция не существует; 0x31 = Указанная переменная не существует; (другое (текст)) = Вывод текст из переменной)

- MultiLib.INI.set(string pathToFile, string Section, string variable, string newTextForVariable, bool returnMSGError) - Установка значения в определённую переменную в секиции файла; pathToFile - Полный путь до файла; Section - Секция; variable - Переменная; newTextForVariable - Новый текст на переменную; returnMSGError - Показать сообщение об ошибке если она будет?

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

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

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

- MultiLibGUI.internet.TestConnection() - Проверяет наличие интернета. Возвращает: true - если интернет есть, false - если интернета нет

- MultiLibGUI.internet.ping(string url) - Проверяет соединение с сайтом. Возвращает: true - если соединение установлено, false - если соединение не удалось установить

- MultiLibGUI.FTP.upload(string host, string username, string password, string localfullpath) - Загружает файл на фтп-сервер. host - полный путь на удалённом сервере куда будет загружен файл с указанием имя файла и расшерения для сохранение его под этими данными (например: https://ftp.multipl.com/UI/MultiIIcon.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя; localfullpath - полный путь до файла для загрузки его на сервер (например: C:\users\userName\desktop\miIcon.ico)

- MultiLibGUI.FTP.download(string host, string username, string password, string localPath) - Скачивает файл с фтп-сервера. host - полный путь до файла на удалённом сервере откуда будет скачан файл (например: https://ftp.multipl.com/UI/MultiBrowser.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя; localPath - полный путь куда и под каким именем будет сохранён файл (например: C:\users\userName\source\repos\MultiBrowser\index.ico)

- MultiLibGUI.FTP.exists(string host, string username, string password) - Проверяет наличие файла на фтп-сервере. host - полный путь до файла на удалённом сервере для проверки его наличия (например: https://ftp.multipl.com/UI/MultiBrowser.ico); username - логин/имя пользователя для входа на сервер; password - пароль для этого пользователя

- MultiLibGUI.mail.send(string fromEmail, string fromName, string toEmail, string subject, string textOrHtml, string smtpServer, int smtpPort, string smtpMail, string smtpPasswordMail, bool saveLogFails) - Отправляет сообщение на почту с помощью smtp серверов. fromEmail - с какой почты отправлено письмо; fromName - с какого имени отправить письмо; toEmail - на какую почту отправить письмо; subject - тема письма; textOrHtml - сообщения письма (текст или html код); smtpServer - smtp-сервер (Можно использовать абсолютно бесплатные сервера, например от Google или Mail.ru, Дальше будут показанны примеры для Google. Например: mail.gmail.com); smtpPort - порт smtp-сервера (Например: 587); smtpMail - smtp-почта (Нужно указать почту от smtp-сервера. Для личных сервисов нужно указать созданную почту. Для бесплатных сервисов таких как Google, Mail.Ru и т.д. Нужно указать лишь почту от вашего аккаунта на этих сервисах. Почты на smtpMail и fromEmail должны совпадать! Например: mpcorp@gmail.com); smtpPassword - Пароль от почты. (Для Google тут не всё просто. Надо указать пароль от вашей почты которая указана в аргументе выше. Для Google же так просто не пройти. Вы должны получить пароль для сторонних приложений, инструкция: https://multiplayercorporation.mya5.ru/doc/smtp. Например: aaaaaaaaa); saveLogFails - Сохранить лог с проблемами? Возвращает: true - если письмо было успешно отправлено, false - если письмо не было отправлено

- MultiLibGUI.music.play(string pathMusicFile) - Запуск проигрывания песни. pathMusicFile - полный путь до файла с музыкой (с форматами такими как .mp3, .wav, и т.д.)

- MultiLibGUI.music.stop() - Остановка песни

- MultiLibGUI.music.pause() - Приостановка песни

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".

- MultiLibGUI.compilator.collect(string inputSourceFile, string outputCompileFile) - Сборка файла C# в программу. inputSourceFile - полный путь до файла в котором хранится исходный код на C#; outputCompileFile - Выходной файл после сборки (Например: AsmCompileC#.exe) (можно также указать полный путь). Возвращает: return - None, file - compiled file

- MultiLibGUI.mget.get(string url, string pathTo) - Получение репозитория. url - Ссылка на репозиторий (Например: https://github.com/dmitriykotik/MultiLib.git); pathTo - Полный путь куда расспаковать репозиторий (Например: C:\users\test\goha) (Папка должна быть создана и быть пустой)

- MultiLibGUI.pass.GenPassword(int length) - Генерация случайного пароля. length - длина пароля.

- MultiLibGUI.Authenticator.createAuthenticator(string uName, string uEmail, bool AUTOvisibleSecretKeyUserForAddAutentificator) - Создание аутентификатора. uName - отображаемое имя пользователя; uEmail - Отображаемая почта или телефон и т.д.; AUTOvisibleSecretKeyUserForAddAuthenticator - Показать пользователю его секретный ключ для добавления в приложение Google Authenticator?; Возвращает: Секретный ключ

- MultiLibGUI.Authenticator.checkEnterCode(string secretKey, string enteredPassword) - Проверка правильности введёного кода из приложения. secretKey - секретный ключ аутентификатора; enteredPassword - введёный пользователем пароль.

- MultiLibGUI.Authenticator.getCurrentCode(string secretKey) - Получение действующего кода. secretKey - секретный ключ аутентификатора (данную функцию можно не использовать для проверки правильности кода!). Возвращает: Действующий код.

- MultiLib.INI.get(string pathToFile, string Section, string variable) - Получение текста из определённой переменной в секции файла. pathToFile - Полный путь до файла; Section - Секция; variable - Переменная; Возвращает: Код ошибки или текст из переменной (Вывод: 0x11 = Файл не существует; 0x21 = Указанная секция не существует; 0x31 = Указанная переменная не существует; (другое (текст)) = Вывод текст из переменной)

- MultiLib.INI.set(string pathToFile, string Section, string variable, string newTextForVariable, bool returnMSGError) - Установка значения в определённую переменную в секиции файла; pathToFile - Полный путь до файла; Section - Секция; variable - Переменная; newTextForVariable - Новый текст на переменную; returnMSGError - Показать сообщение об ошибке если она будет?

> [!WARNING]
> Данный проект находится в архиве. Данный проект был переделан в "[MultiAPI](https://github.com/dmitriykotik/MultiAPI)".
