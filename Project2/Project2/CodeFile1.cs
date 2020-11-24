using System;

class KaisyaTugou
{
    public static void Main()
    {
        //受給資格決定日を表示
        DateTime dt1 = new DateTime(2020, 11, 9, 0, 0, 0);//←退職後、ハローワークで手続きした日を入力
        Console.WriteLine("\n受給資格決定日※(退職後、ハローワークにて手続きをした日)\n　" + dt1 + "\n");

        //待機期間を表示
        DateTime dt2  = (dt1.AddDays(1));//資格決定日の翌日
        DateTime dt3 = (dt2.AddDays(6));//6日後
        Console.WriteLine("\n待機期間\n　" + dt2 + "　から　" + dt3 + "\n");

        //待機期間満了日を表示
        DateTime dt4 = (dt3.AddDays(1));//待機期間最終日の翌日
        DateTime dt5 = (dt4.AddMonths(3));
        DateTime dt6 = (dt5.AddDays(1));
        Console.WriteLine("\n待機期間満了日\n　" + dt4 + "\n");

        //支給対象期間を表示。会社都合と自己都合がある。
        Console.WriteLine("\n" + "支給対象期間");
        //会社都合の場合
        Console.WriteLine("・会社都合退職の場合は\n　" + dt4 + "　から支給対象期間に入る");
        //自己都合の場合
        Console.WriteLine("・自己都合退職の場合は\n　" + dt4 + "　から　" + dt5 + "　まで3ヶ月間の給付制限が課せられ、\n　" + dt6 + "　から　支給対象期間に入る。\n");

        //失業保険認定日
        Console.WriteLine("\n" + "失業保険認定日");
        DateTime dt7 = new DateTime(2020, 12, 8, 0, 0, 0);//ハローワークから呼ばれた日にちを記入
        DateTime dt8 = (dt7.AddDays(7));
        DateTime dt9 = (dt5.AddDays(7));
        //会社都合
        Console.WriteLine("・会社都合退職の場合");
        Console.WriteLine("　" + dt7 + "　に行われるハローワークの講習会を受け、\n　認定されれば、その日から遅くとも1週間以内の\n　" + dt7 + "　から　" + dt8 + "　の頃には振り込まれる");
        //自己都合
        Console.WriteLine("・自己都合退職の場合");
        Console.WriteLine("　" + dt4 + "　から　" + dt5 + "　まで給付制限期間を経て、" );
        Console.WriteLine("　" + dt5 + "　以降の認定日からおよそ1週間以内の\n　" + dt9 + "　頃に振り込まれる\n");

        Console.ReadKey();

    }
}