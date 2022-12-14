![Logo of the project](https://abrakadabra.fun/uploads/posts/2022-03/1646811536_8-abrakadabra-fun-p-ava-programmista-17.jpg)

# Итоговая контрольная работа по 1 блоку обучения
> Любой медленный, вялый труд рождает слабых людей. Только в тяжелых, суровых условиях вырабатывается сильный характер и появляются сильные люди.
>
> Виктор Поляков

Данная программа, позволяет из имеющегося массива строк сформировать массив строк, длина которых меньше либо равна 3 символам.
Первоначально массив вводится с клавиатуры

## Установка / начало работы

Для запуска кода вам потребуется:

1. [Visual Studio Code](https://code.visualstudio.com/download)
2. [GitHub](https://github.com/)


### Начальная конфигурация

*git config --global user.name «Ваше имя английскими буквами»  например: Artem*

*git config --global user.email ваша почта@example.com*

## Разработка

При разрработки данного проекта команда столкнулась со следующими проблемами:

+ ввод данных пользователем обошелся без написания метода, т.к. нужно было исключить падение программы из-за не коректного ввода данных

```shell
int size;

if (int.TryParse(Console.ReadLine(), out size) && size > 0 && size <= 10)
{
    Console.WriteLine("Заполните массив строками!");
}
else
{
    Console.WriteLine("Введены не допустимые символы!");
    return;
}
```

## Функции программы

* Принимает на вход данные о количестве строк в массиве и ограничивает количество в диапазоне от 1 до 10
* Принимает любые символы для заполнения строк
* Собирает новый массив строк из первоначального массива, но с длиной строк не привышающий 3-х символов

## Содействие проекту

"Если вы хотите внести свой вклад, сделайте **fork** репозитория и используйте функцию ответвляться. **Pull requests** приветствуются"

## Ссылки

- Repository: https://github.com/RIP1982/examination.git