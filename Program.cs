//1. Bir integer arrayi yaradın, daha sonra istifadəçidən yaşını soruşun, əgər istifadəçinin yaşı bu arrayda varsa true əks halda false çap edin
int[] arr = { 10, 20, 25, 21, 22, 23, 26, 27 };

head:

Console.WriteLine("Yaşınızı daxil edin");
bool check = int.TryParse(Console.ReadLine(), out int a);

bool smt = false;
foreach (int i in arr)
{
    if (i == a)
    {
        smt = true;
    }
}
if (smt)
{
    Console.WriteLine(true);
}
else
{
    Console.WriteLine(false);
}

// 2.Bir array yaradın, bu massivdə sinifdəki tələbələrin adlarını saxlasın.
// Sonra, istifadəçidən bir tələbə adı daxil etməsini istəyin.
// Əgər daxil edilən ad array-də varsa,
// "Tələbənin adını" çap edin, əks halda "Bu "Adda" Tələbə tapılmadı!" çap edin.

//string[] names = { "Volvo", "BMW", "FORD", "MAZDA" };

//head:
//Console.WriteLine("Adı daxil edin");
//string name = Console.ReadLine();

//bool temp = false;
//foreach(string s in names)
//{
//    if(s == name)
//    {
//        temp = true;
//    }
//}
//if (temp)
//{
//    Console.WriteLine(true);
//}
//else
//{
//        Console.WriteLine("Bu adda ad yoxdur");
//}