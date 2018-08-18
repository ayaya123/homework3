using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    class PolygonAreaCalc
    {
        public static int count = 0;
        public static double LastX = 0, LastY = 0, NowX = 0, NowY = 0, Area = 0, IniX = 0, IniY = 0;

        public static void NextSetCord(double InputX, double InputY)
        {
            LastX = NowX;
            LastY = NowY;
            NowX = InputX;
            NowY = InputY;

            Area = Area + 0.5 * DetCalc(LastX, LastY, NowX, NowY);
        }

        public static void CountPlus()
        {
            count = count + 1;
        }

        public static void SetIni()
        {
            if (count == 1)
            {
                IniX = NowX;
                IniY = NowY;
            }
        }

        public static void ResultOutput(bool UnitCheck)
        {
            Form4 Form = new Form4();
            if (UnitCheck)
            {
                Form.label1.Text = "面积为：" + Math.Abs(Area + 0.5 * DetCalc(NowX, NowY, IniX, IniY)).ToString("F3") + "平方厘米";
            }
            else
            {
                Form.label1.Text = "面积为：" + (6.4516 * Math.Abs(Area + 0.5 * DetCalc(NowX, NowY, IniX, IniY))).ToString("F3") + "平方厘米";
            }
            if (count > 2)
            {
                Form.label2.Text = "是" + (count + 1).ToString() + "边形";
            }
            else
            {
                Form.label2.Text = "是三角形";
            }

            Area = 0;

            Form.Show();
        }

        public static double DetCalc(double detA, double detB, double detC, double detD)
        {
            return detA * detD - detB * detC;
        }
    }
}
