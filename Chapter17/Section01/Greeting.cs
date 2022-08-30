using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class GreetingMorning : IGreetingBase {
        public  string GetMessage() {
            return "おはよう";
        }
    }

    class GreetingAfternoon : IGreetingBase {
        public  string GetMessage() {
            return "こんにちは";
        }
    }
            class GreetingEvening : IGreetingBase {
                public  string GetMessage() {
                    return "こんばんは";
                }
            }
        }
    
