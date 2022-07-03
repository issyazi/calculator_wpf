using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_wpf
{
    public class Calculator
    {
        public double Accum { get; private set;  }
        public double Operand { get; private set; }
        public string Value { get; private set; }
        public enum State { FirstOp, SecondOp, Procent, Reciproc, Sqrt, SignChng }
        public State state { get; private set; } = State.FirstOp;
        public void Plus()
        {
            if (state == State.FirstOp) 
            { 
                Accum = double.Parse(Value);
                Value = "";
                state = State.SecondOp;
             }
            else
            {
                Operand = double.Parse(Value);
                Accum += Operand;
                Value = Accum.ToString();
            }
        }
        public void Digit(string digit) //добавление чисел
        {
            if (state == State.SecondOp) { Value = ""; }
            Value += digit;
        }
        public void Equal() //равно
        {
            Value = Convert.ToString(Accum);
            state = State.FirstOp;
        }
        public void Erase()
        {
            Value = Value.Remove(Value.Length - 1);
        }
    }
}
