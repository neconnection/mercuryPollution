using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GMap.NET.WindowsForms.ToolTips;
using Tulpep.NotificationWindow;

namespace yt_DesignUI
{
    public partial class mapForm : Form
    {
        public mapForm()
        {
            InitializeComponent();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
            gMapControl1.MapProvider = GMap.NET.MapProviders.YandexHybridMapProvider.Instance; //какой провайдер карт используется  
            gMapControl1.MinZoom = 2; //минимальный зум
            gMapControl1.MaxZoom = 16; //максимальный зум
            gMapControl1.Zoom = 11; // какой используется зум при открытии
            gMapControl1.Position = new GMap.NET.PointLatLng(53.33863778587094, 83.77598762512208);// точка в центре карты при открытии 
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter; // как приближает 
            gMapControl1.Bearing = 0; //уол карты
            gMapControl1.CanDragMap = true; // перетаскивание карты мышью
            gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы
            gMapControl1.MapScaleInfoEnabled = true;
            gMapControl1.PolygonsEnabled = true;
            gMapControl1.MarkersEnabled = true;
        }

        GMapOverlay rezOverlay = new GMapOverlay("RezultMarker"); //cслой резултатов
        GMapOverlay mouseClickOverlay = new GMapOverlay("UserMarker"); //слой пользовательского маркера
        GMapOverlay listSQL = new GMapOverlay("SQLMarker"); //слой sql маркеров
        List<CPoint> ListWithSQLPoint = new List<CPoint>();  //Список координат
       // private PointLatLng mousePoint;

        public class CPoint
        {
            public double x { get; set; }
            public double y { get; set; }
            public string name { get; set; }

            public CPoint(double _d, double _sh, string _name)
            {
                x = _d;
                y = _sh;
                name = _name;
            }
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    if (mouseClickOverlay.Markers.Count > 0)
            //    {
            //        mouseClickOverlay.Clear();
            //    }

            //    mousePoint = gMapControl1.FromLocalToLatLng(e.X, e.Y);
            //    Bitmap mouseMarker = new Bitmap(imageList1.Images[1]);

            //    GMapMyMarker mouseClickPosition = new GMapMyMarker(mousePoint, mouseMarker);
            //    mouseClickPosition.ToolTip = new GMapRoundedToolTip(mouseClickPosition);
            //    mouseClickPosition.ToolTipText = "ClickPosition - " + Math.Round(gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat, 4) + " : " + Math.Round(gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng, 4);
            //    mouseClickOverlay.Markers.Add(mouseClickPosition);
            //    gMapControl1.Overlays.Add(mouseClickOverlay);
            //}
        }

        //GMapOverlay mouseClickOverlay = new GMapOverlay("userMarker");
        //GMapOverlay listSQL = new GMapOverlay("SQL"); //слой для координат sql
        //List<CPoint> ListWithSQLPoint = new List<CPoint>();  //Список координат

        //gMapControl1.Overlays.Add(ListSQL);
        //DataBase.openConnection();
        //SqlCommand sqlConnectiontoPoints = new SqlCommand("SELECT * FROM Point", DataBase.getConnection());
        //SqlDataReader sqlDataReaderPoints = sqlConnectiontoPoints.ExecuteReader();

        ////если есть строки 
        //if (sqlDataReaderPoints.HasRows)
        //{
        //    //считываем строки 
        //    while (sqlDataReaderPoints.Read())
        //    {
        //        ListWithSQLPoint.Add(new CPoint(Convert.ToDouble(sqlDataReaderPoints[1]), Convert.ToDouble(sqlDataReaderPoints[2]), sqlDataReaderPoints[3].ToString()));
        //    }
        //}

        //for (int i = 0; i < ListWithSQLPoint.Count; i++)
        //{
        //    GMarkerGoogle SQLPoint = new GMarkerGoogle(new PointLatLng(ListWithSQLPoint[i].x, ListWithSQLPoint[i].y), GMarkerGoogleType.red);
        //    SQLPoint.ToolTip = new GMapRoundedToolTip(SQLPoint);
        //    SQLPoint.ToolTipText = ("ПНЗ №" + ListWithSQLPoint[i].nomer_PNZ);
        //    ListSQL.Markers.Add(SQLPoint);
        //}
        //gMapControl1.Overlays.Add(ListSQL);
        //DataBase.closeConnection();
        //}


        private void yt_Button3_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.air_pollution;
            popup.HeaderColor = Color.DarkGray;
            popup.BodyColor = Color.DarkGray;
            popup.ShowCloseButton = false;
            popup.TitleText = "mercuryPollution";
            popup.TitleColor = Color.Gray;
            popup.ContentColor = Color.Black;
            popup.ContentText = "Точки отображены.";
            popup.Popup();

            
            SqlCommand sqlCommand;
            SqlConnection сonnection;
            сonnection = new SqlConnection("Data Source=DESKTOP-TA0GV1O;Initial Catalog=databasemercury;Integrated Security=True");
            сonnection.Open();
            gMapControl1.Overlays.Add(listSQL);
            sqlCommand = new SqlCommand("SELECT * FROM coordinate", сonnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            if (sqlDataReader.HasRows)
            {
                while (sqlDataReader.Read())
                {
                    ListWithSQLPoint.Add(new CPoint(Convert.ToDouble(sqlDataReader[1]), Convert.ToDouble(sqlDataReader[2]), sqlDataReader[3].ToString()));
                }
            }
            sqlDataReader.Close();

            for (int i = 0; i < listSQL.Markers.Count; i++)
            {
                GMap.NET.WindowsForms.Markers.GMarkerGoogle samplingmarker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(ListWithSQLPoint[i].x, ListWithSQLPoint[i].y), GMarkerGoogleType.black_small);
                samplingmarker.ToolTip = new GMapRoundedToolTip(samplingmarker);
                samplingmarker.ToolTipText = ListWithSQLPoint[i].name;
                listSQL.Markers.Add(samplingmarker);
            }

            gMapControl1.Overlays.Add(listSQL);
            сonnection.Close();


            //обновление карты при изменении данных

            //private static void Update(mapForm form)
            //{
            //    CheckedListBoxUpdate(form.pointListBox);
            //    form.gMapControl.Overlays.Clear();
            //    form.gMapControl.Overlays.Clear();
            //    PointsLoad(form.gMapControl);
            //}


            //отрисовка полей загрязнения

            //    private GMapPoint(PointLatLng p, double q) : base(p)
            //public GMapPoint(PointLatLng p, double q) : base(p)
            //{
            //        point_ = p;
            //        if (q > 310)
            //        {
            //            brush = new SolidBrush(Color.FromArgb(80, 255, 0, 0));
            //        }
            //        else if (q > 130)
            //        {
            //            brush = new SolidBrush(Color.FromArgb(80, 255, 128, 0));
            //        }
            //        else if (q > 70)
            //        {
            //            brush = new SolidBrush(Color.FromArgb(80, 255, 255, 0));
            //        }
            //        else if (q > 50)
            //        {
            //            brush = new SolidBrush(Color.FromArgb(80, 0, 255, 0));
            //        }
            //        else if (q > 30)
            //        {
            //            brush = new SolidBrush(Color.FromArgb(80, 0, 190, 50));
            //        }
            //        else if (q > 20)
            //        {
            //            brush = new SolidBrush(Color.FromArgb(80, 0, 150, 120));
            //        }
            //        else if (q > 10)
            //        {
            //            brush = new SolidBrush(Color.FromArgb(80, 50, 160, 210));
            //        }
            //        else
            //        {
            //            brush = new SolidBrush(Color.FromArgb(80, 50, 200, 240));
            //        }
            //    }

        }

        private void yt_Button4_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();

            popup.Image = Properties.Resources.air_pollution;
            popup.HeaderColor = Color.DarkGray;
            popup.BodyColor = Color.DarkGray;
            popup.ShowCloseButton = false;
            popup.TitleText = "mercuryPollution";
            // popup.TitleFont = Font.Height (Century Gothic; 9pt);
            // popup.ContentFont = ;
            popup.TitleColor = Color.Gray;
            popup.ContentColor = Color.Black;
            popup.ContentText = "Точки скрыты.";
            popup.Popup();

            listSQL.Clear();
        }

        private void yt_Button1_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();

            popup.Image = Properties.Resources.air_pollution;
            popup.HeaderColor = Color.DarkGray;
            popup.BodyColor = Color.DarkGray;
            popup.ShowCloseButton = false;
            popup.TitleText = "mercuryPollution";
            popup.TitleColor = Color.Gray;
            popup.ContentColor = Color.Black;
            popup.ContentText = "Расчет визуализации произведен.";
            popup.Popup();
        }

        private void yt_Button2_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();

            popup.Image = Properties.Resources.air_pollution;
            popup.HeaderColor = Color.DarkGray;
            popup.BodyColor = Color.DarkGray;
            popup.ShowCloseButton = false;
            popup.TitleText = "mercuryPollution";
            popup.TitleColor = Color.Gray;
            popup.ContentColor = Color.Black;
            popup.ContentText = "Проведите  экспорт  карты в открывшемся  окне.";
            popup.Popup();

            try
            {
                using (SaveFileDialog sfDialog = new SaveFileDialog())
                {
                    sfDialog.Filter = "PNG (*.png)|*.png";
                    sfDialog.FileName = "Pollution image";
                    Image image = gMapControl1.ToImage();
                    if (image != null)
                    {
                        using (image)
                        {
                            if (sfDialog.ShowDialog() == DialogResult.OK)
                            {
                                string fileName = sfDialog.FileName;
                                fileName += !fileName.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ? ".png" : "";
                                image.Save(fileName);
                                MessageBox.Show($"Карта успешно сохранена в директории:\n{sfDialog.FileName}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void yt_Button5_Click(object sender, EventArgs e)
        {
            PopupNotifier popup = new PopupNotifier();

            popup.Image = Properties.Resources.air_pollution;
            popup.HeaderColor = Color.DarkGray;
            popup.BodyColor = Color.DarkGray;
            popup.ShowCloseButton = false;
            popup.TitleText = "mercuryPollution";
            popup.TitleColor = Color.Gray;
            popup.ContentColor = Color.Black;
            popup.ContentText = "Источник загрязнения отображен на карте.";
            popup.Popup();

            GMapOverlay listSQL = new GMapOverlay("SQL");
            gMapControl1.Overlays.Add(this.listSQL);

            GMap.NET.WindowsForms.Markers.GMarkerGoogle plantmarker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new PointLatLng(53.33076, 83.60437), GMarkerGoogleType.red_small);
            plantmarker.ToolTip = new GMapRoundedToolTip(plantmarker);
            plantmarker.ToolTipText = "ТЭЦ-3";
            this.listSQL.Markers.Add(plantmarker);
        }

        private void yt_Button6_Click(object sender, EventArgs e)
        {
            pointsForm pointsform = new pointsForm();
            pointsform.Show();
        }

        //расчет розы ветров и угла направления ветра
        private static double Wind(double x, double y)   
        {
            //координаты источника загрязнения
            double xist = 53.33076;
            double yist = 83.60437;

            double ugol = 180 / Math.PI * Math.Atan((x - xist) / (y - yist));
            double[] roza = { 10.4, 37.1, 10.8, 7.8, 12.4, 4.7, 0.9, 3.1 };
            double wind;

            if (y - yist <= 0)
            {
                ugol += 180;
            }
            if (ugol < 0)
            {
                ugol += 360;
            }
            if (ugol >= 0 & ugol <= 45)
                wind = roza[0] + (roza[1] - roza[0]) * (ugol) / 45;
            else if (ugol >= 45 & ugol <= 90)
                wind = roza[1] + (roza[2] - roza[1]) * (ugol - 45) / 45;
            else if (ugol >= 90 & ugol < 135)
                wind = roza[2] + (roza[3] - roza[2]) * (ugol - 90) / 45;
            else if (ugol >= 135 & ugol <= 180)
                wind = roza[3] + (roza[4] - roza[3]) * (ugol - 135) / 45;
            else if (ugol >= 180 & ugol <= 225)
                wind = roza[4] + (roza[5] - roza[4]) * (ugol - 180) / 45;
            else if (ugol >= 225 & ugol <= 270)
                wind = roza[5] + (roza[6] - roza[5]) * (ugol - 225) / 45;
            else if (ugol >= 270 & ugol <= 315)
                wind = roza[6] + (roza[7] - roza[6]) * (ugol - 270) / 45;
            else
                wind = roza[7] + (roza[0] - roza[7]) * (ugol - 315) / 45;
            return wind;

        }


        //вычисление концетрации примеси в точке с координатами x и y
        private static void Qpole(double x, double y, double s1, double s2)  
        {
            //координаты источника загрязнения
            double xist = 53.33076;
            double yist = 83.60437;
            GMapOverlay rezOverlay = new GMapOverlay("RezultMarker");


            double windt = Wind(x, y);
            double angle = Math.Sin(xist * Math.PI / 180) * Math.Sin(x * Math.PI / 180) + Math.Cos(xist * Math.PI / 180) * Math.Cos(x * Math.PI / 180) * Math.Cos(yist * Math.PI / 180 - y * Math.PI / 180);
            double rt = Math.Acos(angle) * 6371;
            double qt = windt * s1 * Math.Pow(rt, s2) * Math.Exp(-2 * 1.5 / rt);
            GMapMarker point = new GMapMarker(new PointLatLng(x, y), qt);
            rezOverlay.Markers.Add(point);
        }


        //вычисление и отрисовка полей загрязгнения
        public static void Calculate(CheckedListBox listBox, ComboBox box, GMapControl map)
        {
            GMapOverlay rezOverlay = new GMapOverlay("RezultMarker");
            string subname = box.SelectedItem.ToString();
            StringBuilder builder = new StringBuilder();
            builder.Append("(");

            for (int i = 0; i < listBox.CheckedItems.Count; i++)
            {
                builder.Append(listBox.CheckedItems[i].ToString() + ",");
            }

            builder.Remove(builder.Length - 1, 1);
            builder.Append(")");
            double x = 0, y = 0, rez;

            SqlConnection сonnection;
            сonnection = new SqlConnection("Data Source=DESKTOP-TA0GV1O;Initial Catalog=databasemercury;Integrated Security=True");

            //координаты источника загрязнения
            double xist = 53.33076;   
            double yist = 83.60437;

            double[] qt = new double[listBox.CheckedItems.Count];
            double[] windt = new double[listBox.CheckedItems.Count];
            double[] rt = new double[listBox.CheckedItems.Count];
            double angle;
            int counter = 0;

            SqlCommand command = new SqlCommand($"Select lat, lng, {subname} FROM coordinate, Results WHERE Points.Id IN " + builder + " AND Results.Id = Points.Id ", сonnection);
            сonnection.Open();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                x = (double)reader["lat"];
                y = (double)reader["lng"];
                rez = (double)reader[subname];
                qt[counter] = rez;
                windt[counter] = Wind(x, y);
                angle = Math.Sin(xist * Math.PI / 180) * Math.Sin(x * Math.PI / 180) + Math.Cos(xist * Math.PI / 180) * Math.Cos(x * Math.PI / 180) * Math.Cos(yist * Math.PI / 180 - y * Math.PI / 180);
                rt[counter] = Math.Acos(angle) * 6371;
                counter++;
            }
            сonnection.Close();

            double s1 = 0, s2 = 0, temp1, temp2;
            double rm = 3.5;
            double[] tempQt = new double[listBox.CheckedItems.Count];
            double mnk = Double.MaxValue, mnk1 = 0;

            for (temp1 = 1; temp1 <= 10000; temp1 += 1)
            {

                for (temp2 = -2; temp2 < 2; temp2 += 0.01)
                {
                    for (int i = 0; i < listBox.CheckedItems.Count; i++)
                    {
                        tempQt[i] = windt[i] * temp1 * Math.Pow(rt[i], temp2) * Math.Exp(-2 * rm / rt[i]);
                        mnk1 += Math.Pow(tempQt[i] - qt[i], 2);
                    }
                    if (mnk1 < mnk)
                    {
                        mnk = mnk1;
                        s1 = temp1;
                        s2 = temp2;
                    }
                    mnk1 = 0;
                }
            }

            rezOverlay.Clear();
            rezOverlay.Markers.Clear();

            for (double i = xist - 0.11; i < xist + 0.11; i += 0.001)
            {
                for (double j = yist - 0.2; j < yist + 0.2; j += 0.001)
                {
                    Qpole(i, j, s1, s2);
                }
            }

            if (map.Overlays.Contains(rezOverlay))
            {
                map.Overlays.Clear();
            }

            map.Overlays.Add(rezOverlay);
           // PointsLoad(map);

        }
    }
}



