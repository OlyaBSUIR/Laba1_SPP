using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Threading;

namespace Laba1_SPP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            //Делаем таймер доступным
            timer.Enabled = true;
            //Запускаем таймер
            timer.Start();
            cbCities.SelectedIndex = 0;
        }

        private async void getWeatherInfo()
        {
            string city = cbCities.Items[cbCities.SelectedIndex].ToString();
            try
            {
                WeatherInfo parser = new WeatherInfo(city);
                await parser.Initialization();
                lbTemperature.Text = "Сейчас: " + parser.GetTemperature();
                lbSpeed.Text = parser.GetSpeed();
                lbHumadity.Text = parser.GetHumadity();
                lbPressure.Text = parser.GetPressure();
                lbData.Text = parser.GetTimeOfLastUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnMatch_Click(object sender, EventArgs e)
        {
            getWeatherInfo();          
        }

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            getWeatherInfo(); 
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            getWeatherInfo();

            lbTime.Text = string.Format("Время обновления: {0}", DateTime.Now.ToString("HH:mm:ss"));
        }

        }
    }

