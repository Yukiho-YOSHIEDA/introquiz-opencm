using IntroQuiz.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroQuiz.model
{
    public class OrderModel
    {
        public OrderEnum Order {
            get;
            set;
        }

        public String Answerer {
            get;
            set;
        }
    }
}
