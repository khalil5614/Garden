using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ProjectGarden.Models
{
   class LandLayerModel
    {
       private static List<Point> _selectedPoints = null;
       public static List<Point> SelectedPoints
       {
           get
           {
               if(_selectedPoints==null)
               {
                   _selectedPoints = new List<Point>();
               }
               return _selectedPoints;
           }
       }
       public static Point StartPoint;
       public static Point EndPoint;
      // public  ObservableCollection<Point> SelectedPoint;

      

       public static bool IsCreateLandSelected = false;
       public static bool IsLandCreated = false;
    }
}
