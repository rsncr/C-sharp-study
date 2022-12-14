// =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// большие буквы "С" заменить маленькими "С".

// Ясна ли задача?

string text = "-Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123.. // если требуется обратится к конкретному символу строки,
// мы можем это сделать используя его индекс в строке
// для того, чтобы обратиться к конкретному символу по его индексу, используем следующую конструкцию:
// s[3] //- так мы обратимся к символу "r"

string replace(string text, char oldS, char newS); // здесь мы задали строку, 
// которую будем выводить после замены символов в тексте, а также
// задали ей аргументы: (сам текст, старые символы, новые символы)
{
    string result = String.Empty; //заводим новую пустую строку
    int length = text.Length;
    for(int i = 0; i <= length; i++)
    {
        if(text[i] == oldS) result = result + $"{newS}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = replace(text, ' ', '|');
Console.WriteLine(newText);