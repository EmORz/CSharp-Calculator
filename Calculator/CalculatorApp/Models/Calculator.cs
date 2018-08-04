using System;

namespace CalculatorApp.Models
{
    public class Calculator
    {
        public decimal LeftOperand { get; set; }

        public decimal RightOperand { get; set; }

        public string Operator { get; set; }

        public decimal Result { get; set; }

        public void CalculateResult()
        {
            switch (this.Operator)
            {
                case "+":
                    this.Result = this.LeftOperand + this.RightOperand;
                    break;
                case "-":
                    this.Result = this.LeftOperand - this.RightOperand;
                    break;
                case "*":
                    this.Result = this.LeftOperand * this.RightOperand;
                    break;
                case "/":
                    this.Result = this.LeftOperand / this.RightOperand;
                    break;
                case "%":
                    this.Result = this.LeftOperand % this.RightOperand;
                    break;
                case "^":
                    int a = Convert.ToInt32(this.RightOperand);
                    int b = Convert.ToInt32(this.LeftOperand);
                    this.Result = (int)Math.Pow(b, a);
                    break;
            }
            
        }

    }
}
