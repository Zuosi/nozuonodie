using System;

namespace Fork_Bomb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            fork();
        }
        public static void fork()
        {
            while(true){
                fork(); 
            }
        }
    }
}
