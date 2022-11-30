using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog;

namespace testNLog
{
    public partial class Form1 : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            try
            {
                double temp = Convert.ToDouble(text);
                textBox1.Text = (temp / 10.0).ToString();
            }
            catch (Exception ex)
            {
                logger.Error($"-- Ошибка при делении на 10:  {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            try
            {
                int res = text.Length;
                logger.Error($"-- Колличество символов: " + res);

            }
            catch
            {
                logger.Error($"-- Ошибка при подсчете символов");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            logger.Info($"-- Своя запись в лог");
        }
    }
}
