using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroQuiz.model
{
    public class JudgeEventArgs : EventArgs
    {
        public OrderModel Order {
            get;
            set;
        }
    }
}
