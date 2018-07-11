using System;

namespace LotteryConsole {
    class Lottery {
        private LotteryMenue menue;
        private int[] numbers = new int[6];
        private int[] winningnumbers = new int[6];
        public Lottery() {
            Initialize();
        }
        public void Start() {
            Console.Clear();
            GetPlayerNumbers();
            Console.Clear();
            if(menue.GetConfirmation(numbers) == true) {
                Console.Clear();
                GetWinningNumbers();
                menue.StartLottery(winningnumbers);
                menue.ShowResult(CompareNumbers());
                Console.ReadLine();
            }
        }
        private void Initialize() {
            menue = new LotteryMenue();
        }
        private void GetPlayerNumbers() {
            for(var i = 0; i < 6; i++) {
                numbers[i] = menue.GetNumber();
            }
        }
        private void GetWinningNumbers() {
            var random = new Random();
            for(var i = 0; i < 6; i++) {
                winningnumbers[i] = random.Next(0, 49);
            }
        }
        private int CompareNumbers() {
            var correct = 0;
            for(var i = 0; i < 6; i++) {
                for( var j = 0; j < 6; j++) {
                    if(numbers[i] == winningnumbers[j]) {
                        correct++;
                    }
                }
            }
            return correct;
        }
    }
}