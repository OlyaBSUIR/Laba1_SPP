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

namespace Laba1_SPP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            cbCities.SelectedIndex = 0;
        }

        private void getData()
        {
            string city = cbCities.Items[cbCities.SelectedIndex].ToString();
            try
            {
                HtmlParser parser = new HtmlParser(city);
                lbTemperature.Text = "Сейчас: " + parser.GetTemperature();
                lbSpeed.Text = parser.GetSpeed();
                lbHumadity.Text = parser.GetHumadity();
                lbPressure.Text = parser.GetPressure();
                lbData.Text = parser.GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnMatch_Click(object sender, EventArgs e)
        {
            getData();          
        }

        private void cbCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            getData(); 
        }

        }
    }

