﻿
Console.Write ("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine ());
void CheckingTheDay0fTheWeek (int dayNumber) {
if (dayNumber == 6 || dayNumber == 7) {
Console.WriteLine ("(этот день выходной) -> да");
}
else if (dayNumber < 1 || dayNumber > 7) {
Console.WriteLine ("это вообще не день недели");
}
else Console.WriteLine (" (этот день не выходной) -> нет");
}
CheckingTheDay0fTheWeek (dayNumber);