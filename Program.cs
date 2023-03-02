class program {
    static void Main(string[] args){
        Console.Write("Please Input Password : ");
        string pass = Console.ReadLine();
        Console.Write("Please Input Agency : ");
        string agen = Console.ReadLine();

        if (agen == "CIA" || agen == "FBI" || agen == "NSA"){

            int a = (int)pass[0] - 48 ; //แสน
            int b = (int)pass[1] - 48 ; //หมื่น
            int c = (int)pass[2] - 48 ; //พัน
            int d = (int)pass[3] - 48 ; //ร้อย
            int e = (int)pass[4] - 48 ; //สิบ
            int f = (int)pass[5] - 48 ; //หน่วย

            if (agen == "CIA"){
                if (c >= 6 && c != 8 && e != 1 && e != 3 && e != 5 && f % 3 == 0){
                    Console.WriteLine(true);
                    Console.WriteLine("You are CIA !!!");
                } else {
                    Console.WriteLine(false);
                    Console.WriteLine("You aren't CIA !!!");
                }
            } else if (agen == "FBI"){
                if (a >= 4 && a <= 7 && b % 2 != 0 && d % 2 == 0 && d != 6){
                    Console.WriteLine(true);
                    Console.WriteLine("You are FBI !!!");
                } else {
                    Console.WriteLine(false);
                    Console.WriteLine("You aren't FBI !!!");
                }
            } else if (agen == "NSA"){
                if (d % 3 == 0 && d % 2 != 0 && 30 % f == 0 && (a == 7 || b == 7 || c == 7 || e == 7)){
                    Console.WriteLine(true);
                    Console.WriteLine("You are NSA !!!");
                } else {
                    Console.WriteLine(false);
                    Console.WriteLine("You aren't NSA !!!");
                }
            } else {
                Console.WriteLine(false);
                Console.WriteLine("You aren't Agency !!!");
            }
        } 
    }
}
