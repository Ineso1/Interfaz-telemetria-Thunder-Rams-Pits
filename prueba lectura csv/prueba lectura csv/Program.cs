// See https://aka.ms/new-console-template for more information

using System.IO;
using System.Drawing;
using var bmp = new Bitmap(2000, 5200);
using var gfx = Graphics.FromImage(bmp);
using var pen = new Pen(Color.Gray, 20);
pen.Width = 46.0f;

var reader = new StreamReader(File.OpenRead(@"E:\archivoPistas\CoordenadasPista.csv"));
List<string> listA = new List<string>();
List<string> listB = new List<string>();
while (!reader.EndOfStream)
{
    var line = reader.ReadLine();
    var values = line.Split(',');

    listA.Add(values[0]);
    listB.Add(values[1]);
    
}
foreach (var coloumn1 in listA)
{
    Console.WriteLine(coloumn1);
}
foreach (var coloumn2 in listB)
{
    Console.WriteLine(coloumn2);
}


List<PointF> points = new List<PointF>();

// Create the XY coords as PointF and add it to our list. 
for (int i = 0; i < listA.Count; i++ )
{
    var pt = new PointF(float.Parse(listA[i]),float.Parse(listB[i]));
    points.Add(pt);
}

// Convert the points list to an array for Drawlines(). 
PointF[] pointArray = points.ToArray();

// Smooth the plot using AntiAliasing and create a white background.
gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
//gfx.Clear(Color.White);

// Change the coordinate system so that the track is centered in the image.
gfx.TranslateTransform(500, 5000);

gfx.DrawLines(pen, pointArray);
bmp.Save(@"E:\archivoPistas\Pistaaa.png");
Console.WriteLine("The track image has been saved successfully.");