using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_wpf
{
    public class Calculator
    {
        private const short MaxLenInput = 15;
        private const short MaxLenComma = 9;
        private const short MaxLenOutput = 45;
        private bool IsFirst = true;
        private string SignSave;
        private bool BlockAction = false;
        //public string Sign = "no";
        public double Accum { get; private set;  }
        public double Operand { get; private set; }
        public string Value { get; private set; }
        public enum State {
            Neutral, Plus, Minus, Divide, Mult
        }
        public State state { get; private set; } = State.Neutral;
        public void Digit(string digit) //добавление чисел
        {
            if (IsFirst == false) { Value = ""; }
            Value += digit;
        }
        public void Operations (string sign)
        {
            BlockAction = false;
            if (IsFirst == true)
            {
                Accum = double.Parse(Value);
                Value = "";
                IsFirst = false;
            }
            else
            {
                Operand = double.Parse(Value);
                switch (sign)
                {
                    case "+":
                        Accum += Operand;
                        break;
                    case "-":
                        Accum -= Operand;
                        break;
                    case "/":
                        if (Value == "0")
                        {
                            //ошибка
                            return;
                        }
                        Accum /= Operand;
                        break;
                    case "*":
                        Accum *= Operand;
                        break;

                }
                SignSave = sign;
                Value = Accum.ToString();
            }
        }
        public void Equal() //равно
        {
            Operations(SignSave);
            Value = Convert.ToString(Accum);
            IsFirst = true;
        }
        public void Erase()
        {
            if (Value.Length == 1 && BlockAction == false)
            {
                Value = "0";
                BlockAction = true;
            }
            else
            {
                Value = Value.Remove(Value.Length - 1);
            }
        }
        public void MemorySave()
        {

        }
        public void MemoryDel()
        {

        }
        public void MemoryPlus()
        {

        }
        public void MemoryMinus()
        {

        }
        public void MemoryR()
        {

        }
    }
}
