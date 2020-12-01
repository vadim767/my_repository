using System;
using System.Collections.Generic;
using System.Drawing;


namespace DrawShapes
{
    public class StringManager
    {
        public static Size ParseSize(string resolution)
        {
            Size size = new Size();
            string strTemp = "";
            
            for(int i = 0; i < resolution.Length; ++i)
            {
                if(resolution[i] == 'x')
                {
                    size.Width = int.Parse(strTemp);
                    strTemp = "";
                    continue;
                }
                strTemp += resolution[i];
            }

            size.Height = int.Parse(strTemp);

            return size;
        }

        public static Point[] ParseCoordinates(string[] coordinares)
        {
            Point point = new Point();
            List<Point> pointsList = new List<Point>();

            string tempCoord = "";
            foreach (string coord in coordinares)
            {
                for (int i = 0; i < coord.Length; ++i)
                {
                    if (coord[i] == ' ')
                        continue;

                    if (coord[i] == ',')
                    {
                        point.X = int.Parse(tempCoord);
                        tempCoord = "";
                        continue;
                    }

                    tempCoord += coord[i];
                }

                point.Y = int.Parse(tempCoord);

                pointsList.Add(point);
                tempCoord = "";
            }
            return pointsList.ToArray();
        }
    }
}
