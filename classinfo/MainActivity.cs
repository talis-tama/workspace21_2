using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Text;

namespace classinfo
{
    [Activity(Label = "時間割", MainLauncher = true)]
    public partial class MainActivity : Activity
    {
        TextClock textClock2;
        TextView textView2, textView3, textView4, textView5, textView6, textView7,textView8, textView9, textView10, textView11, textView12, textView14, textView15, textView16, textView17, textView18, textView19, textView20, textView21, textView22, textView23, textView24, textView25, textView26, textView27, textView28;
        Button button1, button2;
        DateTime tim;
        int weekNo = 0, showNo = 0, popNo = 0, classNo = 0;
        bool first = true;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            tim = new DateTime();
            Initilizing();
        }
        void Initilizing()
        {
            textClock2 = (TextClock)FindViewById(Resource.Id.textClock2);
            textView2 = (TextView)FindViewById(Resource.Id.textView2);
            textView3 = (TextView)FindViewById(Resource.Id.textView3);
            textView4 = (TextView)FindViewById(Resource.Id.textView4);
            textView5 = (TextView)FindViewById(Resource.Id.textView5);
            textView6 = (TextView)FindViewById(Resource.Id.textView6);
            textView7 = (TextView)FindViewById(Resource.Id.textView7);
            textView8 = (TextView)FindViewById(Resource.Id.textView8);
            textView9 = (TextView)FindViewById(Resource.Id.textView9);
            textView10 = (TextView)FindViewById(Resource.Id.textView10);
            textView11 = (TextView)FindViewById(Resource.Id.textView11);
            textView12 = (TextView)FindViewById(Resource.Id.textView12);
            textView14 = (TextView)FindViewById(Resource.Id.textView14);
            textView15 = (TextView)FindViewById(Resource.Id.textView15);
            textView16 = (TextView)FindViewById(Resource.Id.textView16);
            textView17 = (TextView)FindViewById(Resource.Id.textView17);
            textView18 = (TextView)FindViewById(Resource.Id.textView18);
            textView19 = (TextView)FindViewById(Resource.Id.textView19);
            textView20 = (TextView)FindViewById(Resource.Id.textView20);
            textView21 = (TextView)FindViewById(Resource.Id.textView21);
            textView22 = (TextView)FindViewById(Resource.Id.textView22);
            textView23 = (TextView)FindViewById(Resource.Id.textView23);
            textView24 = (TextView)FindViewById(Resource.Id.textView24);
            textView25 = (TextView)FindViewById(Resource.Id.textView25);
            textView26 = (TextView)FindViewById(Resource.Id.textView26);
            textView27 = (TextView)FindViewById(Resource.Id.textView27);
            textView28 = (TextView)FindViewById(Resource.Id.textView28);
            button1 = (Button)FindViewById(Resource.Id.button1);
            button2 = (Button)FindViewById(Resource.Id.button2);
            WeekReader();
            TimeReader();
            textClock2.TextChanged += TextClock2_textChanged;
            button1.Click += Button1_click;
            button2.Click += Button2_click;
            textView14.Click += First_click;
            textView15.Click += First_click;
            textView16.Click += First_click;
            textView17.Click += Second_click;
            textView18.Click += Second_click;
            textView19.Click += Second_click;
            textView20.Click += Third_click;
            textView21.Click += Third_click;
            textView22.Click += Third_click;
            textView23.Click += Fourth_click;
            textView24.Click += Fourth_click;
            textView25.Click += Fourth_click;
            textView26.Click += Fifth_click;
            textView27.Click += Fifth_click;
            textView28.Click += Fifth_click;
        }
        void TextClock2_textChanged(object sender,TextChangedEventArgs e)
        {
            if (textClock2.Text == ")00:00") { WeekReader(); }
            else if (textClock2.Text == ")09:20") { classNo = 2; }
            else if (textClock2.Text == ")11:00") { classNo = 3; }
            else if (textClock2.Text == ")13:20") { classNo = 4; }
            else if (textClock2.Text == ")15:00") { classNo = 5; }
            else if (textClock2.Text == ")16:40") { ClassData_end(); }
            if (textClock2.Text == ")09:20" || textClock2.Text == ")11:00" || textClock2.Text == ")13:20" || textClock2.Text == ")15:00") { ClassData_jumper(); }
        }
        void Button1_click(object sender,EventArgs e)
        {
            showNo--;
            if (showNo == 0) { showNo = 6; }
            ShowData_jumper();
        }
        void Button2_click(object sender,EventArgs e)
        {
            showNo++;
            if (showNo == 7) { showNo = 1; }
            ShowData_jumper();
        }
        void First_click(object sender, EventArgs e)
        {
            popNo = 1;
            PopData_jumper();
        }
        void Second_click(object sender, EventArgs e)
        {
            popNo = 2;
            PopData_jumper();
        }
        void Third_click(object sender, EventArgs e)
        {
            popNo = 3;
            PopData_jumper();
        }
        void Fourth_click(object sender, EventArgs e)
        {
            popNo = 4;
            PopData_jumper();
        }
        void Fifth_click(object sender, EventArgs e)
        {
            popNo = 5;
            PopData_jumper();
        }
        void WeekReader()
        {
            tim = DateTime.Now;
            textView2.Text = tim.ToString("ddd");
            weekNo = (int)tim.DayOfWeek;
            showNo = weekNo;
            if (showNo == 0)
            {
                showNo++;
                first = false;
                textView3.Text = "";
                textView4.Text = "本日の予定";
                textView5.Text = "";
                textView6.Text = "本日は休日です";
                textView7.Text = "";
                textView8.Text = "";
                textView9.Text = "";
                textView10.Text = "";
                textView11.Text = "";
            }
            ShowData_jumper();
        }
        void TimeReader()
        {
            if ((tim.Hour >= 0 && tim.Hour <= 8) || (tim.Hour == 9 && tim.Minute <= 19)) { classNo = 1; }
            else if ((tim.Hour == 9 && tim.Minute >= 20) || tim.Hour == 10) { classNo = 2; }
            else if ((tim.Hour == 11 || tim.Hour == 12) || (tim.Hour == 13 && tim.Minute <= 19)) { classNo = 3; }
            else if ((tim.Hour == 13 && tim.Minute >= 20) || tim.Hour == 14) { classNo = 4; }
            else if (tim.Hour == 15 || (tim.Hour == 16 && tim.Minute <= 39)) { classNo = 5; }
            else if ((tim.Hour == 16 && tim.Minute >= 40) || tim.Hour >= 17) { ClassData_end(); }
            if ((tim.Hour >= 0 && tim.Hour <= 15) || (tim.Hour == 16 && tim.Minute <= 39)) { ClassData_jumper(); }
        }
        void ShowData_jumper()
        {
            switch (showNo)
            {
                case 1:
                    if (first == false) { textView12.Text = "月曜日の予定"; }
                    ShowData_mon();
                    break;
                case 2:
                    if (first == false) { textView12.Text = "火曜日の予定"; }
                    ShowData_tue();
                    break;
                case 3:
                    if (first == false) { textView12.Text = "水曜日の予定"; }
                    ShowData_wed();
                    break;
                case 4:
                    if (first == false) { textView12.Text = "木曜日の予定"; }
                    ShowData_thr();
                    break;
                case 5:
                    if (first == false) { textView12.Text = "金曜日の予定"; }
                    ShowData_fri();
                    break;
                case 6:
                    if(first == false) { textView12.Text = "土曜日の予定"; }
                    ShowData_sat();
                    break;
            }
            first = false;
        }
        void PopData_jumper()
        {
            switch (showNo)
            {
                case 1:
                    PopData_mon();
                    break;
                case 2:
                    PopData_tue();
                    break;
                case 3:
                    PopData_wed();
                    break;
                case 4:
                    PopData_thr();
                    break;
                case 5:
                    PopData_fri();
                    break;
                case 6:
                    PopData_sat();
                    break;
            }
        }
        void ClassData_jumper()
        {
            switch (weekNo)
            {
                case 1:
                    ClassData_mon();
                    break;
                case 2:
                    ClassData_tue();
                    break;
                case 3:
                    ClassData_wed();
                    break;
                case 4:
                    ClassData_thr();
                    break;
                case 5:
                    ClassData_fri();
                    break;
                case 6:
                    ClassData_sat();
                    break;
                default:
                    break;
            }
        }
        void ClassData_end()
        {
            textView3.Text = "";
            textView4.Text = "本日の予定";
            textView5.Text = "";
            textView6.Text = "本日の予定はすべて終了しました";
            textView7.Text = "";
            textView8.Text = "";
            textView9.Text = "";
            textView10.Text = "";
            textView11.Text = "";
            Button2_click(null,null);
        }
    }
}

