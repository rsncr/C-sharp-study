﻿// Виды функций (методов)

// Вид 1 - ничего не принимают и ничего не возвращают

void Method1()
{
    Console.WriteLine("Автор ...");
}
// Метод void вызвается следующимм образом:
// Method1();


// Вид 2 - принимают какие-нибудь аргументы, но ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

// void может принимать 2 аргумента разного вида, как в следующем примере Method21

void Method21(string msg, int count)
{
    int i = 0; //добавили инкремент
    while(i < count)
        {
        Console.WriteLine(msg);
        i++;
        }
}

// Method21("Текст", 4); //здесь мы вызываем заданную ранее функцию 
//и ожидаем увидеть 4 раза сообщение "Текст"
// также возможна запись с названием аргументов следующим образом:
// Method21(count:4, msg:"Новый текст"); //при такой записи, аргументы 
// можно указывать в произвольном порядке


// Вид 3 - не принимает аргументы, но возвращает данные. 
// Здесь всегда нужно указывать тип данных, которые мы ожидаем 

int Method3()
{
    return DateTime.Now.Year; //здесь происходит операции метода
}
int year = Method3(); //для вызова метода, объявляем переменную year 
// и "кладем" в нее таким образом результат работы данного метода  
// и далее выводим на экран с помощью Console.WriteLine
// Console.WriteLine(year);


//Вид 4 - функции, который что-то принимают и что-то возвращают

string Method4(int count, char c)   //данный вид записи означает, что мы собираемся повторять
                                    // символ/строку char друг за другом count раз
{
    int i = 0;                      //вводим инкремент
    string result = string.Empty;   //вводим переменную (пустую строку), 
                                    // куда будем далее класть конечный результат
    while(i < count)
    {
        result = result + c;        // пока инкремент меньше count, который мы зададим далее
                                    // программа будет  повторять класть char c в строку result
        i++;
    }
    return result;
}
string res = Method4(4, "пок-");
Console.WriteLine(res);


// 4 не запускается, спросить в чем проблема на практике