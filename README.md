# This is verifications work

## **Выполнить:** 

1. *Создать репо на гитхаб*
2. *Сделать блок-схему*
3. *Создать ридми*
4. *Написать программу*
5. *Использовать гит*

## **Задача:**
 >Из одного массива строк, создать новый, где длина стркои <= 3. Первоначальный массив вручную\автоматом. Пользоваться массивами.

 ## **Решение:**

В начале программы ввоидтся размер массива. Затем на выбор можно заполнить массив ручную или автоматически. При ручном заполнении используется цикл for и ввод с клавиатуры. Для автоматического способа используется метод CreateArray. В нем так же испольщуется цикл for, однако строки заполняются случайными числами, которые конвертируюся в строки.
        
Затем с помощью метода PrintArray выводится массив на экран. В методе также используется цикл for, который отображает каждый элемент массива.
        
Создается новый массив, длина которого определятся методом FindSizeToSortArray, который возращает количество всех элементов меньше либо равныз 3.
        
В новый массив помещаются все значения, удовлетворяющие условию с помощью метода SortArray. В нем в новый массив присваиваются строки, удовлетворяющие условию.
        
Затем новый массив отображается с помощью метода PrintArray.
 

 ## **Блок-схема:** 

 [Method Main](https://github.com/hvtee/verification_work/blob/main/algorithm/algorithm-main.png "Block sheme")
 
 [Method PrintArray](https://github.com/hvtee/verification_work/blob/main/algorithm/algorithm-printarray.png "Block sheme")

 [Method CreateArray](https://github.com/hvtee/verification_work/blob/main/algorithm/algorithm-createarray.png "Block sheme")

 [Method FindSortedArraySize](https://github.com/hvtee/verification_work/blob/main/algorithm/algorithm-findsortedarraysize.png "Block sheme")

 [Method SortArray](https://github.com/hvtee/verification_work/blob/main/algorithm/algorithm-sortarray.png "Block sheme")