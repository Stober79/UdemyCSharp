using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; } = 0;
        public int CurrentQuestion { get; set; } = 1;
    }
}
