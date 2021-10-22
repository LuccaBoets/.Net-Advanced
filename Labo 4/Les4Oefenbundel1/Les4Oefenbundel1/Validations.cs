using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les4Oefenbundel1
{
    public static class Validations
    {

        public static bool IsEAN13BarcodeValid(string barcode)
        {
            if (barcode.Length != 13)
            {
                return false;
            }

            int getal1 = 0, getal2 = 0;

            for (int i = 0; i < barcode.Length; i++)
            {
                if ((i+1) % 2 == 0)
                {
                    getal1 += int.Parse(barcode[i].ToString());
                }
                else if (i != barcode.Length - 1)
                {
                    getal2 += int.Parse(barcode[i].ToString());

                }
            }

            getal1 *= 3;
            int sum = getal1 + getal2;

            sum %= 10;

            if (sum != 0)
            {
                sum = 10 - sum;

            }

            if (sum.ToString() == barcode[barcode.Length - 1].ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
