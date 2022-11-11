# НИИ Агропром

Государственное учреждение, специально созданное для организации научных исследований и проведения опытно-конструкторских разработок

## Начало работы

Эти инструкции предоставят вам копию проекта и помогут запустить на вашем локальном компьютере для разработки и тестирования.

1. Для начала надо установить нужный шрифт, для это есть там ссылка
```
\WpfApp111\WpfApp1\Resources\Stalk.TTF
```
![alt text](https://i.ibb.co/TcGpRG6/image.png)

2. Запускаем в Visual Studio с помощью кнопки 
"Пуск" или F5

![alt text](https://i.ibb.co/LZ8bMQC/image.png)

3. Для того чтобы войти, нужно сначала зарегистрироваться и после этого уже можно войти. Дальше там уже все понятно.

![alt text](https://i.ibb.co/FgYdTBw/image.png)


### Необходимые условия

Минмальные требования ОЗУ:
```
1. Выключить, включить комп - в диспетчере задач посмотреть сколько памяти используется.
2. Запустить свою программу и по кнопайте кнопки в проге и еще раз посмотреть в диспетчере задач посмотреть сколько памяти используется.
Прирост памяти это и есть объем необходимы под Вашу программу.
Прибавим память под операционку + антивирус + запас 20% и тд. и получаем сколько надо памяти для комфортной работы Вашей программы.
У Вас должна получится табличка типа:
w2k - 250 Мб
ХР - 700 Мб
Виста - 1500 МБ
вин7 - 2000 Мб
```

### Установка

Для начала установки необходимо скачать Visual Studio на сайте

```
https://visualstudio.microsoft.com/ru/vs/
```

Зайтем перейти по ссылке проекта на GitHub

```
https://github.com/Pieez/WpfApp111/tree/master/WpfApp1
```
Нажимаем на "Open with Visual Studio"
![alt text](https://i.ibb.co/pw3Z0cz/image.png)


Запускаем Visual Studio и наслаждаемся

## Авторы

* **Иван Смолин** - *Творческая работа*
[Pieez](https://github.com/Pieez?tab=repositories)

* **Код работы для регистрации**
```C#
 if (Log.Text.Length > 0) // проверяем логин
            {
                if (Pass.Password.Length > 0) // проверяем пароль
                {
                    if (Pass.Password.Length > 0) // проверяем второй пароль
                    {


                    }
                    else MessageBox.Show("Повторите пароль");
                }
                else MessageBox.Show("Укажите пароль");
            }
            else MessageBox.Show("Укажите логин");



            if (Pass.Password.Length >= 2)
            {
                bool en = true; // английская раскладка
                bool symbol = false; // символ
                bool number = false; // цифра

                for (int i = 0; i < Pass.Password.Length; i++) // перебираем символы
                {
                    if (Pass.Password[i] >= 'А' && Pass.Password[i] <= 'Я') en = false; // если русская раскладка
                    if (Pass.Password[i] >= '0' && Pass.Password[i] <= '9') number = true; // если цифры
                    if (Pass.Password[i] == '_' || Pass.Password[i] == '-' || Pass.Password[i] == '!') symbol = true; // если символ
                }

                if (!en)
                    MessageBox.Show("Доступна только английская раскладка"); // выводим сообщение              
                else if (!number)
                    MessageBox.Show("Добавьте хотя бы одну цифру"); // выводим сообщение
                if (en && symbol && number) // проверяем соответствие
                {

                }
            }
            else MessageBox.Show("пароль слишком короткий, минимум 6 символов");

            if (Pass.Password == Pass_Copy.Password) // проверка на совпадение паролей
            {
                MessageBox.Show("Пользователь зарегистрирован");

            }
            else MessageBox.Show("Пароли не совподают");
            DataTable _dataTable = Select("insert into [dbo].[nik] ([a], [b]) values('" + Log.Text + "','" + Pass.Password + "')");


```# НИИ Агропром

Государственное учреждение, специально созданное для организации научных исследований и проведения опытно-конструкторских разработок

## Начало работы

Эти инструкции предоставят вам копию проекта и помогут запустить на вашем локальном компьютере для разработки и тестирования.

1. Для начала надо установить нужный шрифт, для это есть там ссылка
```
\WpfApp111\WpfApp1\Resources\Stalk.TTF
```
![alt text](https://i.ibb.co/TcGpRG6/image.png)

2. Запускаем в Visual Studio с помощью кнопки 
"Пуск" или F5

![alt text](https://i.ibb.co/LZ8bMQC/image.png)

3. Для того чтобы войти, нужно сначала зарегистрироваться и после этого уже можно войти. Дальше там уже все понятно.

![alt text](https://i.ibb.co/FgYdTBw/image.png)


### Необходимые условия

Минмальные требования ОЗУ:
```
1. Выключить, включить комп - в диспетчере задач посмотреть сколько памяти используется.
2. Запустить свою программу и по кнопайте кнопки в проге и еще раз посмотреть в диспетчере задач посмотреть сколько памяти используется.
Прирост памяти это и есть объем необходимы под Вашу программу.
Прибавим память под операционку + антивирус + запас 20% и тд. и получаем сколько надо памяти для комфортной работы Вашей программы.
У Вас должна получится табличка типа:
w2k - 250 Мб
ХР - 700 Мб
Виста - 1500 МБ
вин7 - 2000 Мб
```

### Установка

Для начала установки необходимо скачать Visual Studio на сайте

```
https://visualstudio.microsoft.com/ru/vs/
```

Зайтем перейти по ссылке проекта на GitHub

```
https://github.com/Pieez/WpfApp111/tree/master/WpfApp1
```
Нажимаем на "Open with Visual Studio"
![alt text](https://i.ibb.co/pw3Z0cz/image.png)


Запускаем Visual Studio и наслаждаемся

## Авторы

* **Иван Смолин** - *Творческая работа*
[Pieez](https://github.com/Pieez?tab=repositories)

* **Код работы для регистрации**
```C#
 if (Log.Text.Length > 0) // проверяем логин
            {
                if (Pass.Password.Length > 0) // проверяем пароль
                {
                    if (Pass.Password.Length > 0) // проверяем второй пароль
                    {


                    }
                    else MessageBox.Show("Повторите пароль");
                }
                else MessageBox.Show("Укажите пароль");
            }
            else MessageBox.Show("Укажите логин");



            if (Pass.Password.Length >= 2)
            {
                bool en = true; // английская раскладка
                bool symbol = false; // символ
                bool number = false; // цифра

                for (int i = 0; i < Pass.Password.Length; i++) // перебираем символы
                {
                    if (Pass.Password[i] >= 'А' && Pass.Password[i] <= 'Я') en = false; // если русская раскладка
                    if (Pass.Password[i] >= '0' && Pass.Password[i] <= '9') number = true; // если цифры
                    if (Pass.Password[i] == '_' || Pass.Password[i] == '-' || Pass.Password[i] == '!') symbol = true; // если символ
                }

                if (!en)
                    MessageBox.Show("Доступна только английская раскладка"); // выводим сообщение              
                else if (!number)
                    MessageBox.Show("Добавьте хотя бы одну цифру"); // выводим сообщение
                if (en && symbol && number) // проверяем соответствие
                {

                }
            }
            else MessageBox.Show("пароль слишком короткий, минимум 6 символов");

            if (Pass.Password == Pass_Copy.Password) // проверка на совпадение паролей
            {
                MessageBox.Show("Пользователь зарегистрирован");

            }
            else MessageBox.Show("Пароли не совподают");
            DataTable _dataTable = Select("insert into [dbo].[nik] ([a], [b]) values('" + Log.Text + "','" + Pass.Password + "')");


```
