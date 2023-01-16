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
# Консольное приложение<br>
![image](https://user-images.githubusercontent.com/86486142/212645163-b8c32b1c-f6f4-4308-952e-892117e3d2b0.png)
Добавляем ссылку на библу<br>
![image](https://user-images.githubusercontent.com/86486142/212648435-580f5c09-759a-4e6a-93ee-5ca881644d98.png)
Тестовый вывод<br>
![image](https://user-images.githubusercontent.com/86486142/212670598-18c6cb51-8bba-454a-9607-e30dd8b148ee.png)
Создание модульного теста (ПКМ по названию метода)<br>
![image](https://user-images.githubusercontent.com/86486142/212669272-dea90866-17d5-4e75-9cc2-3126c6d3a4be.png)
![image](https://user-images.githubusercontent.com/86486142/212669319-c35f5a90-4038-4bb9-9caf-5163c66696dc.png)
Тесты<br>
![image](https://user-images.githubusercontent.com/86486142/212672572-63587666-4f54-4f9d-a6d8-54d308f7c872.png)
