// 
// for (int i = 1; i <= 5; i++) {
//     Console.WriteLine(i);
// }
// int n = 1;
// while (n <= 5) {
//     Console.WriteLine(n);
//     n++;
// }
// int answer;
// do {
//     Console.Write("Введите число больше 0: ");
//     answer = Convert.ToInt32(Console.ReadLine());
// }
// while (answer <= 0);
// for (int i = 1; i <= 10; i++) {
//     if (i == 3) continue;      // пропустить 3
//     if (i == 7) break;         // остановить цикл на 7
//     Console.WriteLine(i);
// }
// // Выведет: 1 2 4 5 6
// /1.1 задание
// for (int i = 10; i >= 1; i--) {
//     Console.WriteLine(i);
// }
// 1.2 задание
// for (int i = 2; i <= 50; i += 2) {
//     Console.WriteLine(i);
// }
// задание 2
// int count = 0;
// for (int i = 1; i <= 20; i++) {
//     if (i % 5 == 0) {
//         count++;
//     }
// }
// Console.WriteLine($"Чисел, кратных 5: {count}");
// Задание 3
// int n = Convert.ToInt32(Console.ReadLine()); 
// int p = 0;                                   
// int m = 0;                               
// while (n != 0) {
//     if (n > 0) {
//         p++;
//     }
//     else if (n < 0) {
//         m++;
//     }
//     n = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Положительных чисел: {p}");
// Console.WriteLine($"Отрицательных чисел: {m}");
// Задание 4
// bool b = false;
// for (int i = 1; i <= 3; i++) {
//     Console.Write("Введите пароль: ");
//     string p = Console.ReadLine();
//     if (p == "qwerty") {
//         b = true;
//         Console.WriteLine("Доступ разрешён");
//         break;
//     }
// }
// if (!b) {
//     Console.WriteLine("Доступ заблокирован");
// }
// самостоятельная работа 
// Задание 5
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++) {
//     Console.WriteLine($"{n} x {i} = {n * i}");
// }
// Задание 6
// for (int i = 1; i <= 30; i++) {
//     if (i % 10 == 0 && i > 20) {
//         break;
//     }
//     if (i % 3 == 0) {
//         continue;
//     }
//     Console.WriteLine(i);
// }
// Итоговая задача
int secret = 42;
bool b = false;
for (int i = 1; i <= 5; i++) {
    int g = Convert.ToInt32(Console.ReadLine());
    if (g == secret) {
        Console.WriteLine($"Победа! Попыток: {i}");
        b = true;
        break;
    }
    else if (g < secret) {
        Console.WriteLine("Больше");
    }
    else {
        Console.WriteLine("Меньше");
    }
}
if (!b) {
    Console.WriteLine($"Вы проиграли, число было {secret}");
}
