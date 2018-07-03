using System;

namespace app {
    class Nuclear {
        private bool fire;

        public int Fire { //속성 ()X [read only]
            get { return fire; } 
            //set { fire = value; }
        }

        public Nuclear() {
            fire = false;
        }

        public void ChkPW(string passwd) {
            if (passwd == "binggo") {
                fire = true;
            }
        }
        public void Lanch() {
            if (fire == true) {
                Console.WriteLine("Fire!!");
            } else {
                Console.WriteLine("Access Denied");
            }
        }
    }

    public class MainApp {
        static void Main(string[] args) {
            Nuclear nc = new Nuclear();

            nc.Chkpw("III");
            nc.Lanch();

            while(nc.Fire == true) {
                Console.WriteLine(nc.file());
            }
        }
    }
}
