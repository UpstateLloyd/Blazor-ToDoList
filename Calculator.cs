using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Calculator
    {
        public string CurrentOperand { get; set; }
        public string PreviousOperand { get; set; }
        public void UpdateDisplay()
        {
            PreviousOperand = CurrentOperand;
            CurrentOperand = "";
        }
        //public void Delete()
        //{

        //}
        //public void ClearDisplay()
        //{

        //}

        //public void Compute(string Operator)
        //{
            
        //}

    }
}
