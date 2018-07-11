using System;

namespace LotteryConsole {
    class LotteryMenue {
        public LotteryMenue() {
            
        }
        public int GetNumber() {
            int number = -1;        
            do {
                Console.WriteLine("Bitte geben Sie eine Zahl ein");
                string input = Console.ReadLine();
                number = int.Parse(input);
            } while (number < 0);
            return number;
        }
        public bool GetConfirmation(int[] zahlen) {
            Console.WriteLine("Das sind Ihre gewählten Zahlen - bitte bestätigen");
            var outpnumbers = "";
            foreach(var i in zahlen) {
                if(outpnumbers.Length > 0) {
                    outpnumbers =  outpnumbers + " - ";
                }
                outpnumbers = outpnumbers + i.ToString();
            }
            Console.WriteLine(outpnumbers);
            Console.WriteLine();
            Console.WriteLine("Bestätigung (j)");
            Console.WriteLine("Abbrechen (n)");
            var answer = "";
            do {
                answer = Console.ReadLine().ToLower();
            } while (answer != "j" && answer != "n");
            return answer == "j" ? true : false;
        }
        public void StartLottery(int[] winningnumbers) {
            Console.WriteLine("Start der Ziehung");
            Console.WriteLine("...");
            Console.WriteLine();
            Console.WriteLine("Folgende Zahlen haben gewonnen...");
            for(var i = 0; i < 6; i++) {
                Console.WriteLine(winningnumbers[i].ToString());
            }
        }
        public void ShowResult(int correctNumbers) {
            Console.WriteLine("Sie haben " + correctNumbers.ToString() + " Zahlen" + " richtig!");
        }
    }
}