using Android.App;
using System;

namespace classinfo
{
    public partial class MainActivity
    {
        void ShowData_mon()
        {
            textView15.Text = "空き";
            textView16.Text = "----";
            textView18.Text = "空き";
            textView19.Text = "----";
            textView21.Text = "空き";
            textView22.Text = "----";
            textView24.Text = "空き";
            textView25.Text = "----";
            textView27.Text = "空き";
            textView28.Text = "----";
        }
        void ShowData_tue()
        {
            textView15.Text = "空き";
            textView16.Text = "----";
            textView18.Text = "空き";
            textView19.Text = "----";
            textView21.Text = "空き";
            textView22.Text = "----";
            textView24.Text = "ウェブデザイン論";
            textView25.Text = "3103";
            textView27.Text = "空き";
            textView28.Text = "----";
        }
        void ShowData_wed()
        {
            textView15.Text = "空き";
            textView16.Text = "----";
            textView18.Text = "システムプログラミング演習";
            textView19.Text = "7501";
            textView21.Text = "英語IIIA";
            textView22.Text = "7308";
            textView24.Text = "空き";
            textView25.Text = "----";
            textView27.Text = "現代自然科学";
            textView28.Text = "3404";
        }
        void ShowData_thr()
        {
            textView15.Text = "空き";
            textView16.Text = "----";
            textView18.Text = "記録管理論";
            textView19.Text = "7301";
            textView21.Text = "空き";
            textView22.Text = "----";
            textView24.Text = "空き";
            textView25.Text = "----";
            textView27.Text = "空き";
            textView28.Text = "----";
        }
        void ShowData_fri()
        {
            textView15.Text = "空き";
            textView16.Text = "----";
            textView18.Text = "プレゼミナールIII";
            textView19.Text = "3104";
            textView21.Text = "情報処理概論";
            textView22.Text = "7203";
            textView24.Text = "空き";
            textView25.Text = "----";
            textView27.Text = "空き";
            textView28.Text = "----";
        }
        void ShowData_sat()
        {
            textView15.Text = "空き";
            textView16.Text = "----";
            textView18.Text = "空き";
            textView19.Text = "----";
            textView21.Text = "森林文化I";
            textView22.Text = "3103";
            textView24.Text = "森林文化I";
            textView25.Text = "3103";
            textView27.Text = "空き";
            textView28.Text = "----";
        }
        void PopData_mon()
        {
            var dialog = new AlertDialog.Builder(this);
            switch (popNo)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    break;
            }
        }
        void PopData_tue()
        {
            var dialog = new AlertDialog.Builder(this);
            switch (popNo)
            {
                case 1:
                case 2:
                case 3:
                    break;
                case 4:
                    dialog.SetTitle("火曜日4限");
                    dialog.SetMessage("授業名 ウェブデザイン論" + Environment.NewLine + "時間 15:00～16:30" + Environment.NewLine + "講師名 本池 巧" + Environment.NewLine + "教室 3103");
                    dialog.Create().Show();
                    break;
                case 5:
                    break;
            }
        }
        void PopData_wed()
        {
            var dialog = new AlertDialog.Builder(this);
            switch (popNo)
            {
                case 1:
                    break;
                case 2:
                    dialog.SetTitle("水曜日2限");
                    dialog.SetMessage("システムプログラミング演習" + Environment.NewLine + "時間 11:00～12:30" + Environment.NewLine + "講師名 水沼 友宏" + Environment.NewLine + "教室 7501");
                    dialog.Create().Show();
                    break;
                case 3:
                    dialog.SetTitle("水曜日3限");
                    dialog.SetMessage("授業名 英語IIIA" + Environment.NewLine + "時間 13:20～14:50" + Environment.NewLine + "講師名 石川 真知子" + Environment.NewLine + "教室 7308");
                    dialog.Create().Show();
                    break;
                case 4:
                    break;
                case 5:
                    dialog.SetTitle("水曜日5限");
                    dialog.SetMessage("現代自然科学I" + Environment.NewLine + "時間 16:40～18:10" + Environment.NewLine + "講師名 本池 巧" + Environment.NewLine + "教室 3404");
                    dialog.Create().Show();
                    break;
            }
        }
        void PopData_thr()
        {
            var dialog = new AlertDialog.Builder(this);
            switch (popNo)
            {
                case 1:
                    break;
                case 2:
                    dialog.SetTitle("木曜日2限");
                    dialog.SetMessage("授業名 記録管理論" + Environment.NewLine + "時間 11:00～12:30" + Environment.NewLine + "講師名 吉国 三千子" + Environment.NewLine + "教室 7301");
                    dialog.Create().Show();
                    break;
                case 3:
                case 4:
                case 5:
                    break;
            }
        }
        void PopData_fri()
        {
            var dialog = new AlertDialog.Builder(this);
            switch (popNo)
            {
                case 1:
                    break;
                case 2:
                    dialog.SetTitle("金曜日2限");
                    dialog.SetMessage("授業名 プレゼミナールIII" + Environment.NewLine + "時間 11:00～12:30" + Environment.NewLine + "講師名 本池 巧" + Environment.NewLine + "教室 3104");
                    dialog.Create().Show();
                    break;
                case 3:
                    dialog.SetTitle("金曜日3限");
                    dialog.SetMessage("授業名 情報処理概論" + Environment.NewLine + "時間 13:20～14:50" + Environment.NewLine + "講師名 寺嶋 秀美" + Environment.NewLine + "教室 7203");
                    dialog.Create().Show();
                    break;
                case 4:
                case 5:
                    break;
            }
        }
        void PopData_sat()
        {
            var dialog = new AlertDialog.Builder(this);
            switch (popNo)
            {
                case 1:
                case 2:
                    break;
                case 3:
                    dialog.SetTitle("土曜日3限");
                    dialog.SetMessage("授業名 森林文化I" + Environment.NewLine + "時間 13:20～14:50" + Environment.NewLine + "講師名 原聰 他" + Environment.NewLine + "教室 3103");
                    dialog.Create().Show();
                    break;
                case 4:
                    dialog.SetTitle("土曜日4限");
                    dialog.SetMessage("授業名 森林文化I" + Environment.NewLine + "時間 13:20～14:50" + Environment.NewLine + "講師名 原聰 他" + Environment.NewLine + "教室 3103");
                    dialog.Create().Show();
                    break;
                case 5:
                    break;
            }
        }
        void ClassData_mon()
        {
            switch (classNo)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    ClassData_end();
                    break;
            }
        }
        void ClassData_tue()
        {
            switch (classNo)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    textView6.Text = "ウェブデザイン論";
                    textView7.Text = "15:00～16:30";
                    textView10.Text = "本池 巧";
                    textView11.Text = "3103";
                    break;
                case 5:
                    ClassData_end();
                    break;
            }
        }
        void ClassData_wed()
        {
            switch (classNo)
            {
                case 1:
                case 2:
                    textView6.Text = "システムプログラミング演習";
                    textView7.Text = "11:00～12:30";
                    textView10.Text = "水沼 友宏";
                    textView11.Text = "7501";
                    break;
                case 3:
                    textView6.Text = "英語IIIA";
                    textView7.Text = "13:20～14:50";
                    textView10.Text = "石川 真知子";
                    textView11.Text = "7308";
                    break;
                case 4:
                case 5:
                    textView6.Text = "現代自然科学I";
                    textView7.Text = "16:40～18:10";
                    textView10.Text = "本池 巧";
                    textView11.Text = "3404";
                    break;
            }
        }
        void ClassData_thr()
        {
            switch (classNo)
            {
                case 1:
                case 2:
                    textView6.Text = "記録管理論";
                    textView7.Text = "11:00～12:30";
                    textView10.Text = "吉国 三千子";
                    textView11.Text = "7301";
                    break;
                case 3:
                case 4:
                case 5:
                    ClassData_end();
                    break;
            }
        }
        void ClassData_fri()
        {
            switch (classNo)
            {
                case 1:
                case 2:
                    textView6.Text = "プレゼミナールIII";
                    textView7.Text = "11:00～12:30";
                    textView10.Text = "本池 巧";
                    textView11.Text = "3104";
                    break;
                case 3:
                    textView6.Text = "情報処理概論";
                    textView7.Text = "13:20～14:50";
                    textView10.Text = "寺嶋 秀美";
                    textView11.Text = "7203";
                    break;
                case 4:
                case 5:
                    ClassData_end();
                    break;
            }
        }
        void ClassData_sat()
        {
            switch (classNo)
            {
                case 1:
                case 2:
                case 3:
                    textView6.Text = "森林文化I";
                    textView7.Text = "13:20～14:50";
                    textView10.Text = "原聰 他";
                    textView11.Text = "3103";
                    break;
                case 4:
                    textView6.Text = "森林文化I";
                    textView7.Text = "15:00～16:30";
                    textView10.Text = "原聰 他";
                    textView11.Text = "3103";
                    break;
                case 5:
                    ClassData_end();
                    break;
            }
        }
    }
}