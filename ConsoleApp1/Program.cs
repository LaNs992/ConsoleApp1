{
    //Бажин Кирилл ИП 20-3
    string dol;
    Console.Write("Напишите сумму перевода из долларов в рубли :");
    dol = Console.ReadLine();
    var a = int.Parse(dol);
    var rub=100;
    var dol1=0d;
    dol1 = a * rub;
    double proc = 0.37, rubproc=0;
    Console.WriteLine("Курс в рублях :"+dol1);
   
    if (dol1 < 500) {
        Console.WriteLine("Комиссия 8 р.");
        Console.WriteLine("Итог перевода:" + (dol1 - 8));
            }
    else
    {
        rubproc = dol1 * (proc / 100);
        Console.WriteLine("Процент комиссии :" + proc + "% =" + rubproc);
        Console.Write("Итог при переводе в рубялх :");
        dol1 = dol1 - rubproc;
        Console.WriteLine(dol1);
    }    
}