//=============================================================================================================================
//==                                                      Discription                                                        ==
//=============================================================================================================================
//
//S3D Estimator
//This program gives you a closer estimate of the time it will take to print something then Simplify3D by taking the error
//from previous prints and multiplying S3D's time by that error amount. 
//
//=============================================================================================================================
//==                                                        Creator                                                          ==
//=============================================================================================================================
//
//David McKenna(3centsMcKenna Github: davidflypei)
//
//=============================================================================================================================
//==                                                      Contributers                                                       ==
//=============================================================================================================================
//
//
//
//


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
using System.Configuration;



namespace S3D_ETE
{


    public partial class Form1 : Form
    {
        //Vars
        int intS3DTime;
        double intEstTime;
        double intError = 0;
        double intError2 = 1;
        double intFinTime;
        public double[] aryError = new double[10];
        public string[] aryPrinter = new string[10];
        string printerPath = @"printers.xml";
        string printer;

        //XML Settings
        XmlWriterSettings settings = new XmlWriterSettings()
        {
            Indent = true,
            IndentChars = ("\t")
        };


        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(printerPath))
            {
                writeXML("Printer 1", "1");
            }

            readXML();
            int i = 0;
            while(aryPrinter[i] != null){
                cbxPrinter.Items.Add(aryPrinter[i]);
            }
        }

        //When Get print time is clicked calculate the time
        private void cmdGetPrint_Click(object sender, EventArgs e)
        {
            readXML();
            estCalc();
        }

        private void cmdGetError_Click(object sender, EventArgs e)
        {
            getValues(1);
            readXML();

            intError2 = intFinTime / intS3DTime;

            if (aryError[0] < 1)
            {
                intError2 = (aryError[0] + intError2) / 2;
            }

            txtError.Text = intError2.ToString();

            printer = cbxPrinter.SelectedValue.ToString();

            writeXML(printer, intError2.ToString());


        }

        public void getValues(int intGet)
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
            //Get the error from array (0 for now till multi printer is created
            intError = aryError[0];

            if (intError == 0)
            {
                intError = 1;
            }

            getValues(0);
            intEstTime = intS3DTime * intError;
            TimeSpan strEstTime = TimeSpan.FromMinutes(intEstTime);
            txtEstTime.Text = $"{strEstTime:hh\\:mm}";
        }

        public void readXML()
        {

            XmlTextReader errorReader = new XmlTextReader(printerPath);
            //Setup XML
            errorReader.Read();

            //Set the array position to 0
            int y = 0;
            int x = 0;
            string Val;

            //While reading the XML store the values in array
            while (errorReader.Read())
            {
                //Dont add value to array if the element is not on this list
                    switch (errorReader.Name)
                    {
                        case "Error":
                         errorReader.Read();
                            Val = errorReader.Value;
                            aryError[x] = Convert.ToDouble(Val);
                            //+1 in array
                            x = x + 1;
                            break;
                    case "PrinterName":
                            errorReader.Read();
                            Val = errorReader.Value;
                            aryPrinter[y] = Val.ToString();
                            //+1 in array
                            y = y + 1;
                            break;
                    }
            }
            //Close reader
            errorReader.Close();
        }

        //Save the document to a file and auto-indent the output.
        public void writeXML(string printerName , string errorVal)
        {
            XmlWriter writer = XmlWriter.Create(printerPath, settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("Printers");
            writer.WriteStartElement("Printer");
            writer.WriteElementString("PrinterName", printerName);
            writer.WriteElementString("Error", errorVal);
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }


    }
}
