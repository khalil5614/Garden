using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGarden;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ProjectGarden.Models;

namespace ProjectGarden
{
    class DrawLand
    {
        static int height, width;
        static double distance, redius;
        //static int width;
        //Form1 formf = new Form1();
        PictureBox pictureBox;
        int clickCount = 0;
        GraphicsPath drawnPath = new GraphicsPath();
        GraphicsPath path = new GraphicsPath();
        bool isDoubleClicked = false;
        Point currentPosition;
        public DrawLand(PictureBox pb)
        {
            this.pictureBox = pb;
            //   Settings.SelectedLandStyle=(int)Constants.LandType.rectangle;
            pictureBox.MouseDoubleClick += pb_MouseDoubleClick;
            pictureBox.MouseClick += pictureBox_MouseClick;

            pictureBox.MouseMove += pictureBox_MouseMove;
            pictureBox.Paint += pictureBox_Paint;





        }

        void pb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //////   Console.WriteLine("dclick=" + e.Clicks);
            //////   isDoubleClicked = true;
            //////   path.Dispose();
            //////   Point clickedPosition = getGridPosition(e);
            ////////   LandLayerModel.SelectedPoint.Add(new Point { X = clickedPosition.X, Y = clickedPosition.Y });

            //////   for (int i = 0; i <  LandLayerModel.SelectedPoint.Count; i++)
            //////   {
            //////       Console.WriteLine("x={0},Y={1}",  LandLayerModel.SelectedPoint[i].X,  LandLayerModel.SelectedPoint[i].Y);
            //////   }

            //////  // pictureBox.Paint -= pictureBox_Paint;
            //////   if(Settings.SelectedLandStyle==(int)Constants.LandType.rectangle)
            //////   {
            //////       Console.WriteLine("count= " +  LandLayerModel.SelectedPoint.Count);
            //////       if( LandLayerModel.SelectedPoint.Count==4 )
            //////       {
            //////           int n = 5 -  LandLayerModel.SelectedPoint.Count;
            //////           MessageBox.Show("Enter " + n + " more point");
            //////           Console.WriteLine("n= " + n);
            //////            LandLayerModel.SelectedPoint.Add( LandLayerModel.SelectedPoint[0]);
            //////       }

            //////       else if( LandLayerModel.SelectedPoint.Count<4)
            //////       {
            //////           int n=5 -  LandLayerModel.SelectedPoint.Count;
            //////           MessageBox.Show("Enter "+n+" more point" );
            //////           Console.WriteLine("n= " + n);
            //////       }
            //////       else
            //////       {
            //////           pictureBox.MouseMove -= pictureBox_MouseMove;
            //////          // pictureBox.Invalidate();
            //////       }
            //////   }


        }

        void pictureBox_Paint(object sender, PaintEventArgs e)
        {

            //  path.AddPath(drawnPath, true);

            ////if(isDoubleClicked)
            ////{
            ////    if ( LandLayerModel.SelectedPoint.Count > 1 && Settings.SelectedLandStyle == (int)Constants.LandType.rectangle)
            ////        e.Graphics.DrawLines(Pens.Black,  LandLayerModel.SelectedPoint.ToArray());
            ////}
            ////else
            ////{
            ////    if ( LandLayerModel.SelectedPoint.Count > 1 && Settings.SelectedLandStyle == (int)Constants.LandType.rectangle)
            ////        e.Graphics.DrawLines(Pens.Black,  LandLayerModel.SelectedPoint.ToArray());
            ////    //e.Graphics.DrawLine(Pens.Black,  LandLayerModel.SelectedPoint[ LandLayerModel.SelectedPoint.Count - 1],  LandLayerModel.SelectedPoint[ LandLayerModel.SelectedPoint.Count - 2]);
            ////    //  e.Graphics.DrawPath(Pens.Black, drawnPath);
            ////    e.Graphics.DrawPath(Pens.Black, path);
            ////}


            //if(Constants.LandType.rectangle.Equals(Settings.SelectedLandStyle))
            //{

            //}

            Pen pen = new Pen(Color.Blue);
            //if (! LandLayerModel.StartPoint.IsEmpty)
            //    e.Graphics.DrawRectangle(pen,  LandLayerModel.StartPoint.X,  LandLayerModel.StartPoint.Y, hight, width);
            if (LandLayerModel.IsCreateLandSelected)
            {
                if (LandLayerModel.EndPoint.IsEmpty)
                {
                    switch (Settings.SelectedLandType)
                    {
                        case (int)Constants.LandType.Circle:
                            // e.Graphics.DrawEllipse(pen, LandLayerModel.StartPoint.X, LandLayerModel.StartPoint.Y, (int)redius, (int)redius);
                            e.Graphics.DrawEllipse(pen, GetSquare());

                            break;
                        case (int)Constants.LandType.Ellipse:

                            break;
                        case (int)Constants.LandType.Parallelogram:
                            break;
                        case (int)Constants.LandType.Polygon:
                            break;
                        case (int)Constants.LandType.Random:
                            break;
                        case (int)Constants.LandType.Rectangle:
                            //e.Graphics.DrawRectangle(pen, LandLayerModel.StartPoint.X, LandLayerModel.StartPoint.Y, height, width);
                            e.Graphics.DrawRectangle(pen, GetRectangle());

                            //                        pictureBox.Invalidate();
                            break;
                        case (int)Constants.LandType.Sector:
                            break;
                        case (int)Constants.LandType.Square:
                            //if (height > width)
                            //    e.Graphics.DrawRectangle(pen, LandLayerModel.StartPoint.X, LandLayerModel.StartPoint.Y, height, height);
                            //else
                            //    e.Graphics.DrawRectangle(pen, LandLayerModel.StartPoint.X, LandLayerModel.StartPoint.Y, width, width);
                            e.Graphics.DrawRectangle(pen, GetSquare());
                            break;
                        case (int)Constants.LandType.Trapezoid:
                            break;
                        case (int)Constants.LandType.Triangle:
                            Point[] points = new Point[3];
                            points[0] = LandLayerModel.StartPoint;

                            points[1] = new Point(LandLayerModel.StartPoint.X - height, currentPosition.Y);

                            points[2] = currentPosition;
                            Console.WriteLine("current position={0}", points[1]);
                            e.Graphics.DrawPolygon(pen, points);
                            break;
                        // case Constants.LandType.rectangle:
                    }
                }
                else
                {
                    drawnPath = new GraphicsPath();
                    // Rectangle rectangle, square;


                    Bitmap textureImage = new Bitmap(Settings.SelectedLandStyleImage);

                    TextureBrush texture = new TextureBrush(textureImage);


                    switch (Settings.SelectedLandType)
                    {
                        case (int)Constants.LandType.Circle:
                            //   drawnPath.AddEllipse()
                            //   e.Graphics.FillEllipse(texture, LandLayerModel.StartPoint.X, LandLayerModel.StartPoint.Y, (int)redius, (int)redius);
                            drawnPath.AddEllipse(GetSquare());
                            //  pictureBox.Invalidate();
                            break;
                        case (int)Constants.LandType.Ellipse:
                            drawnPath.AddEllipse(GetRectangle());
                            break;
                        case (int)Constants.LandType.Parallelogram:
                            break;
                        case (int)Constants.LandType.Polygon:
                            break;
                        case (int)Constants.LandType.Random:
                            break;
                        case (int)Constants.LandType.Rectangle:
                            //   e.Graphics.FillRectangle(texture, LandLayerModel.StartPoint.X, LandLayerModel.StartPoint.Y, height, width);
                            drawnPath.AddRectangle(GetRectangle());
                            //    pictureBox.Invalidate();
                            break;
                        case (int)Constants.LandType.Sector:
                            break;
                        case (int)Constants.LandType.Square:

                            drawnPath.AddRectangle(GetSquare());

                            break;
                        case (int)Constants.LandType.Trapezoid:
                            break;
                        case (int)Constants.LandType.Triangle:
                            //  Point[] points = new Point[3];
                            //   points[0] =  LandLayerModel.StartPoint;

                            //   points[1] =  LandLayerModel.EndPoint;
                            //   points[2] = new Point(LandLayerModel.StartPoint.X - height, LandLayerModel.EndPoint.Y);
                            LandLayerModel.SelectedPoints.Add(new Point { X = LandLayerModel.SelectedPoints[0].X - height, Y = LandLayerModel.SelectedPoints[1].Y });
                            // Console.WriteLine("end point={0}", points[1]);
                            drawnPath.AddPolygon(LandLayerModel.SelectedPoints.ToArray());


                            // e.Graphics.FillPolygon(texture, points);
                            // e.Graphics.FillPolygon(t)
                            //        pictureBox.Invalidate();//if this set when land style image click automatically change
                            break;


                        // case Constants.LandType.rectangle:
                    }

                    e.Graphics.FillPath(texture, drawnPath);
                }


            }


        }

        private Rectangle GetRectangle()
        {
            Rectangle rectangle;
            int x, y, h, w;
            h = height;
            w = width;
            if (h < 0)
            {
                x = LandLayerModel.SelectedPoints[0].X + h;
                h = Math.Abs(h);
            }
            else
            {
                x = LandLayerModel.SelectedPoints[0].X;

            }
            if (w < 0)
            {
                y = LandLayerModel.SelectedPoints[0].Y + w;
                w = Math.Abs(w);
            }
            else
            {
                y = LandLayerModel.SelectedPoints[0].Y;

            }

            rectangle = new Rectangle(x, y, h, w);

            ////if (h > w)
            //    square = new Rectangle(x, y, h, h);
            ////                            e.Graphics.FillRectangle(texture, LandLayerModel.StartPoint.X, LandLayerModel.StartPoint.Y, h, h);
            //else
            //    //e.Graphics.FillRectangle(texture, LandLayerModel.StartPoint.X, LandLayerModel.StartPoint.Y, w, w);
            //    square = new Rectangle(x,y, w, w);

            return rectangle;
        }

        private Rectangle GetSquare()
        {
            Rectangle square;
            int x, y, h, w;

            h = height;
            w = width;

            if(h<0 && w<0)
            {
                if (h < w)
                {
                    x = LandLayerModel.SelectedPoints[0].X + h;

                }
                else
                {
                    x = LandLayerModel.SelectedPoints[0].X + w;

                }

            }

         else if (h < 0)
            {
                x = LandLayerModel.SelectedPoints[0].X + w;

                h = Math.Abs(h);

            }
            else
            {
                x = LandLayerModel.SelectedPoints[0].X;

            }
            if (w < 0)
            {
                if (h < w)
                    y = LandLayerModel.SelectedPoints[0].Y + h;
                else
                    y = LandLayerModel.SelectedPoints[0].Y + w;

                w = Math.Abs(w);
            }
            else
            {
                y = LandLayerModel.SelectedPoints[0].Y;

            }

            //  rectangle = new Rectangle(x, y, h, h);

            if (h > w)
                square = new Rectangle(x, y, h, h);
            //                            e.Graphics.FillRectangle(texture, LandLayerModel.StartPoint.X, LandLayerModel.StartPoint.Y, h, h);
            else
                //e.Graphics.FillRectangle(texture, LandLayerModel.StartPoint.X, LandLayerModel.StartPoint.Y, w, w);
                square = new Rectangle(x, y, w, w);

            return square;
        }


        void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            ////if ( LandLayerModel.SelectedPoint.Count != 0)
            ////{
            ////    int index = (int)Constants.LandType.rectangle + 1;

            ////    path.Reset();
            ////    switch (index)
            ////    {
            ////        case 1:
            ////            Point currentPosition = getGridPosition(e);
            ////            path.AddLine( LandLayerModel.SelectedPoint[ LandLayerModel.SelectedPoint.Count - 1], currentPosition);
            ////            //if ( LandLayerModel.SelectedPoint.Count > 1)
            ////            //    drawnPath.AddLine( LandLayerModel.SelectedPoint[ LandLayerModel.SelectedPoint.Count - 1],  LandLayerModel.SelectedPoint[ LandLayerModel.SelectedPoint.Count - 2]);
            ////          //  drawnPath.AddPath(path, true);
            ////            break;
            ////    }

            ////    pictureBox.Invalidate();
            ////}

            if (!LandLayerModel.StartPoint.IsEmpty)
            {
                currentPosition = getGridPosition(e);

                //   path.Reset();


                height = currentPosition.X - LandLayerModel.StartPoint.X;
                width = currentPosition.Y - LandLayerModel.StartPoint.Y;
                distance = Math.Sqrt(height * height + width * width);
                redius = distance;
                pictureBox.Invalidate();
            }


        }

        void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {


            Console.WriteLine("click={0}", e.Clicks);

            Point clickedPosition = getGridPosition(e);
            if (LandLayerModel.IsCreateLandSelected)
            {
                if (clickCount == 0)
                {
                    LandLayerModel.SelectedPoints.Add(new Point { X = clickedPosition.X, Y = clickedPosition.Y });
                    Console.WriteLine("mouse first click={0}", e.Location);
                    LandLayerModel.StartPoint.X = clickedPosition.X;
                    LandLayerModel.StartPoint.Y = clickedPosition.Y;
                    pictureBox.Invalidate();
                    clickCount++;
                }
                else if (clickCount == 1)
                {
                    LandLayerModel.SelectedPoints.Add(new Point { X = clickedPosition.X, Y = clickedPosition.Y });
                    LandLayerModel.EndPoint.X = clickedPosition.X;
                    LandLayerModel.EndPoint.Y = clickedPosition.Y;
                    clickCount++;

                    pictureBox.MouseMove -= pictureBox_MouseMove;
                    pictureBox.Invalidate();
                }
                else
                {
                    LandLayerModel.SelectedPoints.Add(new Point { X = clickedPosition.X, Y = clickedPosition.Y });

                    for (int i = 0; i < LandLayerModel.SelectedPoints.Count; i++)
                    {
                        Console.WriteLine("x={0},Y={1}", LandLayerModel.SelectedPoints[i].X, LandLayerModel.SelectedPoints[i].Y);
                    }

                }

            }

        }

        private Point getGridPosition(MouseEventArgs e)
        {
            Point position = new Point();
            double x, y;
            x = e.X / 10;
            y = e.Y / 10;

            if (e.X % 10 <= 5)
            {
                x = Math.Floor(x) * 10;
            }
            else
            {
                x = Math.Ceiling(x) * 10;
            }

            if (e.Y % 10 <= 5)
            {
                y = Math.Floor(y) * 10;
            }
            else
            {
                y = Math.Ceiling(y) * 10;
            }

            position.X = (int)x;
            position.Y = (int)y;
            return position;
        }

    }
}
