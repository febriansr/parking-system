namespace parking_system.Util
{
    public class Validation 
    {
        public bool ValidatePlateNumber(string plateNumber)
        {
            string[] plateNumberParts = plateNumber.Split('-');
            if (plateNumberParts.Length != 3)
            {
                return false;
            }
            else
            {
                string firstPart = plateNumberParts[0];
                string secondPart = plateNumberParts[1];
                string thirdPart = plateNumberParts[2];

                if (firstPart.Length > 2)
                {
                    return false;
                }
                else if (!int.TryParse(secondPart, out int secondPartNumber) || secondPart.Length > 4)
                {
                    return false;
                }
                else if (thirdPart.Length > 3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }
    }
}