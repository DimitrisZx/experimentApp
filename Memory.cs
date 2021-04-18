namespace experimentApp
{
    internal class Memory
    {
        private int storedValue = 0;
        public void setMemory(int newValue)
        {
            this.storedValue = newValue;
        }
        public int getMemoryValue()
        {
            return this.storedValue;
        }
        public void clearMemory()
        {
            this.storedValue = 0;
        }
    }
}