using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSoHardLogic
{
    public class Derivative
    {
        char variableOfDifferentiation = 'x';
        

        public string DerivativeOfAConstant(string constant)
        {
            string output = "0";
            return output;
        }

        public string SingleExponentRule(string singleExponent)
        {
            string output;
            output = singleExponent.Replace(variableOfDifferentiation,' ').Trim();
            if(output == "")
            {
                output = "1";
                return output;
            }
            return output;
        }

        public string ExponentRule(string exponent)
        {
            string[] tempArray;
            string output;
            double baseValue, expValue;
            tempArray = exponent.Split(variableOfDifferentiation);
            tempArray[1] = tempArray[1].Replace('^', ' ').Trim();
            if (tempArray[0] == "")
            {
                tempArray[0] = "1";
            }
            expValue = Convert.ToDouble(tempArray[1]);
            baseValue = Convert.ToDouble(tempArray[0]);

            if (expValue == 1)
            {
                output = baseValue.ToString();
            }
            else
            {
                double newBase, newExp;
                newBase = baseValue * expValue;
                newExp = expValue - 1;

                if (newExp == 1)
                {
                    output = string.Format("{0}{1}", newBase, variableOfDifferentiation);
                }
                else
                {
                    output = string.Format("{0}{1}^{2}", newBase, variableOfDifferentiation, newExp);
                }
            }
            return output;
        }

        public string TakeDerivative(string equation)
        {
            if (equation.Contains('+'))
            {
                string output = string.Empty;
                string[] tempArray;
                tempArray = equation.Split('+');
                for (int i = 0; i < tempArray.Length; i++)
                {
                    if (i == 0)
                    {
                        output = insideDerivative(tempArray[i].Trim());
                    }
                    else
                    {
                        output += " + "+insideDerivative(tempArray[i].Trim());
                    }
                }
                return output;
            }
            return insideDerivative(equation);
            
        }

        public string insideDerivative(string equation)
        {
           
            string output;
            if (equation.Contains(variableOfDifferentiation))
            {
               if (equation.Contains("^"))
                {
                    output = ExponentRule(equation);
                    return output;
                }
               else
                {
                    output = SingleExponentRule(equation);
                    return output;
                }
            }
            else
            {
                output = DerivativeOfAConstant(equation);
                return output;
            }
        }

        //public string ProductRule(string productRule)
        //{
        //    string[] tempArray;
        //    tempArray = productRule.Split('*');

        //}
    }
}
