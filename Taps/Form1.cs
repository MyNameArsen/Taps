using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Taps
{
    public partial class Form1 : Form
    {
        char[] mobs = new char[20]; // Массив мобов

        int taps = 0,           // Количество кликов
            gold = 0,       // Кол-во золота
            mobGold = 5,    // Золото за моба
            curTime,        // Время с первого клика
            damage=1,       // Урон от клика
            dps = 0,      // Урон от автокликов
            dcost,          // Цена апгрейда урона
            dpscost,        // Цена апгрейда автоклика
            sHealth=10,     // Здоровье врага стартовое
            cHealth=10;     // Здоровье врага текущее

        public Form1()
        {
            InitializeComponent();
            string fname = Path.GetTempFileName();
            File.WriteAllBytes(fname, Properties.Resources.InvadersFont);
            System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
            pfc.AddFontFile(fname);
            mob.Font = new Font (pfc.Families[0], 48f, FontStyle.Regular);
            SetDCost();
            SetDPSCost();
            char c = 'b';
            for (int i = 0; i < 20; i++, c++) mobs[i] = c; // Заполняем массив мобов
            label1.Text = cHealth + "/" + sHealth;
        }

        private void GoldEnough(object sender, EventArgs e)
        {
            if (gold >= dcost)
                DMGUL.ForeColor = Color.White;
            else
                DMGUL.ForeColor = Color.Gray;
            if (gold >= dpscost)
                DPSUL.ForeColor = Color.White;
            else
                DPSUL.ForeColor = Color.Gray;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void DMGUL_Click(object sender, EventArgs e)
        {
            if (gold >= dcost)
            {
                damage++;
                DmgLbl.Text = $"Damage: {damage}";
                gold -= dcost;
                SetDCost();
                GoldLbl.Text = $"Gold: {gold}";
            }
        }
        
        private void DPSUL_Click(object sender, EventArgs e)
        {
            if (gold >= dpscost)
            {
                dps++;
                DPSLbl.Text = $"DPS: {dps}";
                gold -= dpscost;
                SetDPSCost();
                GoldLbl.Text = $"Gold: {gold}";
            }
        }
                        
        private void timer1_Tick(object sender, EventArgs e)
        {
            curTime++;
            label5.Text = curTime.ToString();
            cHealth -= dps;
            label1.Text = cHealth + "/" + sHealth;
            ReInv();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            taps++;
            cHealth -= damage;
            timer1.Enabled = true;
            label6.Visible = false;
            TapsLbl.Text = "Taps: " + taps;
            label1.Text = cHealth + "/" + sHealth;
            ReInv();
        }

        void ReInv()
        {
            if (cHealth <= 0)
            {
                Random rand = new Random();
                cHealth = sHealth = (int)(sHealth * 1.2);
                label1.Text = cHealth + "/" + sHealth;
                mob.Text = mobs[rand.Next(20)].ToString();
                GotMobGold();
                SetMobGold();
            }
        }

        void SetDCost()
        {
            dcost = (int)(0.0068 * Math.Pow(damage, 3) - 0.06 * Math.Pow(damage, 2) + 17 * damage + 20 - 1);
            DMGUL.Text = $"Upgrade({dcost}g)";
        }

        void SetDPSCost()
        {
            dpscost = (int)(0.02 * Math.Pow(dps, 3) - 0.1 * Math.Pow(dps, 2) + 17 * dps + 31);
            DPSUL.Text = $"Upgrade({dpscost}g)";
        }

        void SetMobGold() => mobGold = (int)(mobGold * 1.2);

        void GotMobGold()
        {
            gold += mobGold;
            GoldLbl.Text = $"Gold: {gold}";
        }
    }
}
