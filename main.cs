using System;
using System.Collections.Generic;
using System.Text;

namespace experimentApp
{
    public class Calculator
    {
        private Memory memory { get; set; }

        public Calculator()
        {
            this.memory = new Memory();
        }

        public int addTwo(int num1, int num2)
        {
            this.memory.setMemory(num1 + num2);
            return num1 + num2;
        }

        public int getCurrentValue()
        {
            return this.memory.getMemoryValue();
        }
        public void clearMemory()
        {
            this.memory.clearMemory();
        }
    }
}
