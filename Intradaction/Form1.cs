using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intradaction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Location = new System.Drawing.Point
                (
                System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width-this.Width-10,10
                );
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // label1.Text = DateTime.Now.ToString();
            string dateTime = DateTime.Now.ToString();
            string[] dt = dateTime.Split(' ');//Split - разделитель
            label1.Text = dt[1]+"\n";//вывод только времени на экран
          //label1.Text = dt[1]+" "+dt[2];//конкантенация строк
          //label1.Text = String.Format("{0} {1}", dt[0], dt[1]);//форматирование
          //label1.Text = $"{dt[0]} {dt[1]}";//интерполяция строк  
        if(cbShowDate.Checked)
            {
                label1.Text += dt[0];
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
           // this.FormBorderStyle = FormBorderStyle.Sizable;
            
            this.btnClose.Visible = true;
            this.btnHideControls.Visible = true;
            this.cbShowDate.Visible = true;
            this.btnDateCalculator.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();//это закрывает окно
        }

        private void btnHideControls_Click(object sender, EventArgs e)
        {
           // this.FormBorderStyle= FormBorderStyle.None;
            this.btnClose.Visible = false;
            this.btnHideControls.Visible = false;
            this.cbShowDate.Visible = false;
            this.btnDateCalculator.Visible = false;
        }

        private void btnDateCalculator_Click(object sender, EventArgs e)
        {
            DateCalculator dc = new DateCalculator{};
            dc.ShowDialog(this);
        }
    }
}
