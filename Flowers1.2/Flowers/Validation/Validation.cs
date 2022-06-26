namespace Flowers.Validation
{
    using System;
    using FlowerField;
    using Service;

    public class ValidationFlowers
    {
        public int ValidationFlowerId(int flowerId)
        {

            int idLength = (int)Math.Log10(flowerId) + 1;

            if (flowerId == 0 && idLength > 10)
            {
                throw new Exception("Please, enter id again.");
            }

            return flowerId;
        }

        public string ValidationFlowerName(string FlowerName)
        {

            if (FlowerName.Length > 10 || FlowerName.Length == 0 || FlowerName.Contains(" ") || FlowerName.Contains("@") || FlowerName.Contains("#") || FlowerName.Contains("$") || FlowerName.Contains("%") || FlowerName.Contains("^") || FlowerName.Contains("&")
                || FlowerName.Contains("*") || FlowerName.Contains("(") || FlowerName.Contains(")") || FlowerName.Contains("-") || FlowerName.Contains("=") || FlowerName.Contains("_") || FlowerName.Contains("+"))
            {
                throw new Exception("Please, enter name again.");
            }
            return FlowerName;
        }
    }
}
