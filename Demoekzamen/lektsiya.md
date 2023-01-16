# Демоэкзамен
## Диаграммы
### Содержание:
- [UML-диаграммы](https://github.com/sanyagribanov/7sem/blob/main/Demoekzamen/lektsiya.md#что-это-такое)
- [ER-диаграммы](https://github.com/sanyagribanov/7sem/blob/main/Demoekzamen/lektsiya.md#ER-диаграммы)
- [WPF](https://github.com/sanyagribanov/7sem/blob/main/Demoekzamen/lektsiya.md#wpf)
- [Библиотека классов](https://github.com/sanyagribanov/7sem/blob/main/Demoekzamen/lektsiya.md#библиотека-классов)
---
### Что это такое?
UML (Unified Modeling Language) - международный язык рисования схем<br>

---
### Плюсы и минусы UML
<table>
<tr>
<th>Минусы</th>
<th>Плюсы</th>
</tr>
<tr>
<td>трата времени</td>
<td>возможность посмотреть задачу с разных т.з. </td>
</tr>
<tr>
<td>необходимость знания различных диаграмм и их нотаций</td>
<td>другим программистам легче понять суть задачи м способ ее реализации</td>
</tr>
<tr>
<td> - </td>
<td>диаграммы сравнительно просты для чтения после достаточно быстрого ознакомления с их синтаксисом</td>
</tr>
</table>

---
### Для чего она нужна?
- диаграмма прецедентов/вариантов использования;
- описание возможных сценариев работы с системой с т.з. пользователя;
- возможные пути использования системы;
- описание всех участников системы (актеры);

Для построения UseCase диаграммы открыть предметную область

---
### Отношения в UseCase диаграмме
Отношение ассоциации - отражает возможность использования актером прецедента;
Отношение включения - поведение одного прецедента включается в другой в качестве составного, причем дополнительный вариант использования не может выполняться без основного<br>
Отношение расширения - отражает возможное приосединение одного использования к другому, при этом расширяющий вариант использования выполняется лишь при определенных условиях и не является обязательным для выполения основного прецедента<br>
Include Extend прямая линия<br>
Ассоциация - использует Include - используем если без этого действия нельзя выполнить основное<br>
Extend - необязательное действие<br>

---
### ER-диаграммы
ER-diagramma - Entity-Relationship model, модель «сущность — связь». В БД сущность - таблица.
ER делиться на концептуацльная и физическая - диаграмма, которую СУБД строит автоматически
Физическая:
  * нивилируется автоматически
  * отображается тип данных
  * могут ли быть нулевые значения (ставим галочку, если поле необязательное
  * Всё написано на английском

Концептуальная:
  * нет типа данных
  * заполняется на русском
  * строится вручную в visio
  * связи многие ко многим
  
Отдельную таблицу для связи "многие-ко-многим" НЕ СОЗДАЮТ!1!!<br>
Нормальные формы (НФ):
* НФ1 - 1 ячейка - одно значение
* НФ2 - вынести повторяющиеся элементы в отдельную таблицу
* НФ3 - смотрим на взаимосвязи столбцов, если столбцы друг от друга не зависят, то выносим их в разные таблицы

---
### Cоздание БД
1) копируем скрипт БД
2) открываем MS SQL Server Management Studio
3) создаем БД с помощью кпопки "New Database"
![изображение](https://user-images.githubusercontent.com/86486142/189850269-28b022dc-ced6-416e-bc44-9076cfd3f8c5.png)
нажимаем ее и жмем ОК
![изображение](https://user-images.githubusercontent.com/86486142/189850594-3d7764f4-ad65-4936-8f77-bdebed8fd852.png)
4) в появившуюся БД вставляем скрипт из буфера обмена при помощи New Query
![изображение](https://user-images.githubusercontent.com/86486142/189851001-ea512d98-e827-4a1e-b276-224dd677282e.png)
5) после создаем ER-диаграмму при помощи New Database Diagram в разделе Database Diagram
![изображение](https://user-images.githubusercontent.com/86486142/189851450-d6c512d1-1980-4d9b-9045-cbad40120c6a.png)
6) Ждем и наслаждаемся результатом :)

---
### Структура базы данных
Отношения - таблица<br>
Кортеж - соответствует строке этой таблицы<br>
Атрибут - столбец<br>
![изображение](https://user-images.githubusercontent.com/86486142/189946486-b179d61c-2ef8-499c-b0ed-6be3d61b53c6.png)<br>
Отключать автоинкримент, если первичный ключ - это паспортные двнные или другие данные, которые не идут попорядку<br>
Связь - 1 ко многим = внешний ключ<br>
Таблица у которой один выбираем первичный ключ и ведём связь к столбцу таблицы много (в одной стране много отелей)<br>
Многие ко многим (много книг нравятся многим людям)<br>
Отдельная таблица с двумя первичными ключами<br>
Генерация скрипта<br>
![image](https://user-images.githubusercontent.com/90381005/189865740-ef8d7f44-e9f1-4c48-b2cb-6f06d59fd966.png)<br>
если не сохраняется<br>
![image](https://user-images.githubusercontent.com/90381005/189873578-90d6bab2-5b65-4ce1-9413-e479fc371032.png)<br>
убрать галочку: запретить сохранение...<br>
Типы данных:
- числовые int, char, varchar, nvarchar(255), money, varbinary(50)
- логические bool
- символьные text
- дата date datetime

---
# WPF
WinForms-WPF-UWP<br>
Возможности WPF:
- адаптивная верстка
-привязка данных
Выбирать WPF App нужно будет с расширением (.NET Framework)
Элементы компоновки(контейнеры):
- Grid
- StackPanel
- WrapPanel
Элементы таблицы:
- RowDefinitions - строки
- ColumnDefinitions - столбцы
- Grid.ColumnSpan - разделение по кол-ву столбцов (RowSpan - разделение по строкам)<br>
Авторазмер - подгоняет элемент под размер окна<br>
Абсолютный размер - занимает строго столько места, сколько указано<br>
StackPanel - располагает все элементы в ряд по вертикали или горизонтали<br>
Вместо отступов лучше использовать Alignment<br>
WrapPanel - располагает все элементы в одной строке или колонке<br>
Заливка для текста - foreground; для фона- background;<br>

Cтиль прописывается в файле App.xaml
![изображение](https://user-images.githubusercontent.com/86486142/191473222-3d8b1e67-bb06-40ee-a424-5404fba8a1a3.png)
![изображение](https://user-images.githubusercontent.com/86486142/191473620-531da4a7-5c3e-4cbe-8817-91b93d3c1cbb.png)
![изображение](https://user-images.githubusercontent.com/86486142/191474429-fde29c0b-abbc-4958-b2ae-a4317f24533f.png)

# Библиотека классов
![image](https://user-images.githubusercontent.com/86486142/212640342-245e082b-6ecc-4632-9604-136670105526.png)
![image](https://user-images.githubusercontent.com/86486142/212640719-137845be-fc6a-4fb3-b9a3-6681b583b7f3.png)
![image](https://user-images.githubusercontent.com/86486142/212641029-8d1b75a3-7c4e-44ed-ad2f-38b36051fc92.png)
(название берем из таблицы)
1. Посмотреть из таблицы возвращаемые параметры
2. Добавить этот тип перед названием метода
3. Объявить переменную с этим типом данных и вернуть ее (return)
```C#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User02Lib.dll
{
    public class Calculations
    {
        public string[] AvailablePeriods()
        {
            string[] result = new string[] {};
            return result;

        }
    }
}
```
## Массивы обозначаются
```C#
public string[] AvailablePeriods()
        {
            string[] result = new string[] {};
            return result;
        }
```
Массивы бывают тех же типов, что и переменные
## Создание пустого массива:
ТипДанных[]НазваниеМассива = new ТипДанных{};

## После создания
Заходим в Сборка-Собрать решение<br>
![image](https://user-images.githubusercontent.com/86486142/212645858-39194c4f-9c35-4ad6-8e9c-77fdd00a714b.png)<br>
Путь к библиотеке: C:\Users\Администратор\source\repos\SF2022User02Lib.dll\SF2022User02Lib.dll\bin\Debug\SF2022User02Lib.dll
# Консольное приложение
![image](https://user-images.githubusercontent.com/86486142/212645163-b8c32b1c-f6f4-4308-952e-892117e3d2b0.png)
Добавляем ссылку на библу
![image](https://user-images.githubusercontent.com/86486142/212648435-580f5c09-759a-4e6a-93ee-5ca881644d98.png)
Тестовый вывод
![image](https://user-images.githubusercontent.com/86486142/212670598-18c6cb51-8bba-454a-9607-e30dd8b148ee.png)
Создание модульного теста (ПКМ по названию метода)
![image](https://user-images.githubusercontent.com/86486142/212669272-dea90866-17d5-4e75-9cc2-3126c6d3a4be.png)
![image](https://user-images.githubusercontent.com/86486142/212669319-c35f5a90-4038-4bb9-9caf-5163c66696dc.png)
Тесты
![image](https://user-images.githubusercontent.com/86486142/212672572-63587666-4f54-4f9d-a6d8-54d308f7c872.png)
