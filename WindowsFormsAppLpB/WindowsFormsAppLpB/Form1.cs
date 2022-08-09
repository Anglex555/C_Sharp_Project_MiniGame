using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLpB
{
    public partial class Form1 : Form
    {
        int HP = 100;
        long Money = 5000;
        int Morale = 1000;
        int exp = 10;
        int knowledge = 10;
        int homeLevel = 1;
        int pcLevel = 1;
        bool isEc = false;
        bool isPs = false;
        bool isSim = false;

        Timer timer1 = new Timer();
        Timer refresh = new Timer();
        Timer MoneyT = new Timer();

        public Form1()
        {
            InitializeComponent();

            refresh.Interval = 50;
            refresh.Tick += (s, e) =>
            {
                mHP.Text = "HP = " + HP;
                mMoney.Text = "Money = " + Money + "$";
                mMorale.Text = "Morale = " + Morale;
                ex.Text = "Exp = " + exp;
                know.Text = "Skills = " + knowledge;
            };
            refresh.Start();


            //timer1.Interval = 1000;
            //timer1.Tick += (s, e) =>
            //{
            //    Money+=5000;
            //};
            //timer1.Start();

            MoneyT.Interval = 30000;
            MoneyT.Tick += (s, e) =>
            {
                ChangeMoney(-100 * homeLevel, "Ежемесячные расходы");
            };
            MoneyT.Start();
        }

        private void mMorale_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Money > 1200)
            {
                ChangeMoney(-1200, "Курс по геймдеву");
                knowledge += 30;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Money > 1000)
            {
                ChangeMoney(-1000, "ООП в c#");
                knowledge += 25;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(Money > 800)
            {
                ChangeMoney(-800, "Векторная графика");
                knowledge += 20;
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (GameName.Text == "GiveMeMoneyPls")
            {
                Money += 999999999;
            }
            else
            {
                if (Money >= Convert.ToInt32(mon.Text))
                {
                    Money -= Convert.ToInt32(mon.Text);
                    if (v1.Checked && (t1.Checked || t3.Checked))
                    {
                        if (!isEc)
                        {
                            isPs = false;
                            isEc = true;
                            isSim = false;
                            Correct();
                        }
                        else ChangeMoney(-(Convert.ToInt32(mon.Text) * 2), ("Разработка игры " + GameName.Text));
                    }
                    else if (v2.Checked && (t4.Checked || t2.Checked))
                    {
                        if (!isPs)
                        {
                            isPs = true;
                            isEc = false;
                            isSim = false;
                            Correct();
                        }
                        else ChangeMoney(-(Convert.ToInt32(mon.Text) * 2), ("Разработка игры " + GameName.Text));
                    }
                    else if (v3.Checked && (t5.Checked || t6.Checked))
                    {
                        if (!isSim)
                        {
                            isPs = false;
                            isEc = false;
                            isSim = true;
                            Correct();
                        }
                        else ChangeMoney(-(Convert.ToInt32(mon.Text) * 2), ("Разработка игры " + GameName.Text));
                    }
                    else
                    {
                        ChangeMoney(-(Convert.ToInt32(mon.Text) * 2), ("Разработка игры " + GameName.Text));
                    }
                    exp += 10;
                    GameName.Text = "";
                }
            }

        }

        private void Correct()
        {
            //ChangeMoney((Convert.ToInt32(mon.Text) * knowledge * exp) / 50, ("Разработка игры " + GameName.Text));
            ChangeMoney((Convert.ToInt32(mon.Text) * knowledge * exp) / 1000  , ("Разработка игры " + GameName.Text));
        }

        private void ChangeMoney(int Mon, String whi)
        {
            Money += Mon;
            if (Mon > 0) moneyText.ForeColor = Color.LawnGreen;
            else if (Mon < 0) moneyText.ForeColor = Color.Red;
            else if (Mon == 0) moneyText.ForeColor = Color.Peru;
            moneyText.Text = Mon.ToString() + "$ " + whi;
        }

        private void newHome_Click(object sender, EventArgs e)
        {
            if (homeLevel < 7)
            {
                int priceH = 100000 * homeLevel * homeLevel;
                if (Money >= priceH)
                {
                    ChangeMoney(priceH * -1, "Новый дом");
                    homeLevel++;
                    if (homeLevel == 1) Home.BackgroundImage = Properties.Resources.home1;
                    else if (homeLevel == 2) Home.BackgroundImage = Properties.Resources.home2;
                    else if (homeLevel == 3) Home.BackgroundImage = Properties.Resources.home3;
                    else if (homeLevel == 4) Home.BackgroundImage = Properties.Resources.home4;
                    else if (homeLevel == 5) Home.BackgroundImage = Properties.Resources.home5;
                    else if (homeLevel == 6) Home.BackgroundImage = Properties.Resources.home6;
                    else if (homeLevel == 7) Home.BackgroundImage = Properties.Resources.home7;
                }
                priceH = 100000 * homeLevel * homeLevel;
                newHome.Text = "Переехать (" + priceH.ToString() + "$)";
            }
            if (homeLevel >= 7) newHome.Text = "Недоступно";
        }

        private void newPC_Click(object sender, EventArgs e)
        {
            int price_PC = 1000 * pcLevel * pcLevel;
            if (pcLevel < 5)
            {
                if (Money >= price_PC)
                {
                    ChangeMoney(price_PC * -1, "Новый пк");
                    pcLevel++;
                    if (pcLevel == 1) PC.BackgroundImage = Properties.Resources.pc1;
                    else if (pcLevel == 2) PC.BackgroundImage = Properties.Resources.pc2;
                    else if (pcLevel == 3) PC.BackgroundImage = Properties.Resources.pc3;
                    else if (pcLevel == 4) PC.BackgroundImage = Properties.Resources.pc4;
                    else if (pcLevel == 5) PC.BackgroundImage = Properties.Resources.pc51;
                }
                price_PC = 1000 * pcLevel * pcLevel;
                newPC.Text = "Переехать (" + price_PC.ToString() + "$)";
            }
            if (pcLevel >= 5) newPC.Text = "Недоступно";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            notification.Hide();
            Money = 5000;
        }

        private void notification_Enter(object sender, EventArgs e)
        {

        }
    }
}
