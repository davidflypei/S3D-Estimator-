using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Xml;
using System.IO;
using System.Text.RegularExpressions;
namespace S3D_ETE
{


    public partial class Form1 : Form
    {
        int intS3DTime;
        double intEstTime;
        double intError = 1;
        double intError2 = 1;
        double intFinTime;
        public double[] aryError = new double[10];
        public string[] aryPrinter = new string[10];



        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdGetPrint_Click(object sender, EventArgs e)
        {
            getXML();
            estCalc();
        }

        private void cmdGetError_Click(object sender, EventArgs e)
        {
            getTimes(1);
            getXML();
            intError2 = intFinTime / intS3DTime;
            //intError2 = (aryError[0] + intError2) / 2;
            txtError.Text = intError2.ToString();
            // Save the document to a file and auto-indent the output.
            XmlTextWriter writer = new XmlTextWriter(Path.Combine(Environment.CurrentDirectory, "\\printers.xml"), null);
            writer.WriteStartDocument();
            writer.WriteStartElement("Error");
            writer.WriteString(intError2.ToString());
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();

        }

        public void getTimes(int intGet)
        {
            if (intGet == 0)
            {
                intS3DTime = (Convert.ToInt32(Math.Round(s3dTimeHour.Value, 0)) * 60) + Convert.ToInt32(Math.Round(s3dTimeMin.Value, 0));
            }
            else
            {
                intS3DTime = (Convert.ToInt32(Math.Round(s3dTimeHour.Value, 0)) * 60) + Convert.ToInt32(Math.Round(s3dTimeMin.Value, 0));
                intFinTime = (Convert.ToInt32(Math.Round(finTimeHour.Value, 0)) * 60) + Convert.ToInt32(Math.Round(finTimeMin.Value, 0));
            }
        }

        public void estCalc()
        {
            getTimes(0);
            intError = aryError[0];
            intEstTime = intS3DTime * intError;
            TimeSpan strEstTime = TimeSpan.FromMinutes(intEstTime);
            txtEstTime.Text = $"{strEstTime:hh\\:mm}";

        }

        public void getXML()
        {
            XmlTextReader errorReader = new XmlTextReader(Path.Combine(Environment.CurrentDirectory, "\\printers.xml"));
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;

            errorReader.Read();

            int i = 0;
            while (errorReader.Read())
            {
                if (errorReader.NodeType == XmlNodeType.Text)
                {
                    string error = errorReader.Value;
                    aryError[i] = Convert.ToDouble(error);
                    i = i + 1;
                }
            }
            errorReader.Close();
        }


    }
}
