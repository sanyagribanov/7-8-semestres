from csv_csv import file_open, insert, drop_by_arg, find, avg_age, save, show_csv
from builtins import print

FILENAME = "users2.csv"

MENU = {
    '1': 'Открыть файл',
    '2': 'Добавить студента',
    '3': 'Удалить студента',
    '4': 'Найти студента',
    '5': 'Сохранить',
    '6': 'Вывести студентов',
    '0': 'Меню',
    'e': 'Выход'
}

for key, val in MENU.items():
    print(key, '-', val)

while True:
    action = input('> ')
    if action == '1':
        file_open()
    elif action == '2':
        print(insert(input('ФИО: '), int(input('Возраст: ')), input('Курс: '), int(input('студ.билет: '))))
    elif action == '3':
        col = input('Колонка: ')
        val = input('Значение: ')
        print(drop_by_arg(val, col_name=col))
    elif action == '4':
        col = input('Колонка: ')
        val = input('Значение: ')
        find(val, col_name=col)

    elif action == '5':
        save()
    elif action == '0':
        for key, val in MENU.items():
            print(key, '-', val)
    elif action == '6':
        show_csv()
    elif action == 'e':
        break
