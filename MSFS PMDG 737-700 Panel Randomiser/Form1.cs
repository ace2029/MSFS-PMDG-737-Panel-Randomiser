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

namespace MSFS_PMDG_737_700_Panel_Randomiser
{    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        
                
        private void button1_Click(object sender, EventArgs e)
        {
            // Set the path for the required Community directory and the first PMDG folder
            string root = @"..\pmdg-aircraft-737";

            // Check to see if we are running in the correct location
            if (Directory.Exists(root))
            {
                // MessageBox.Show("We are in the correct folder.");
            }
            else
            {
                MessageBox.Show("Application needs to be in a folder WITHIN the MSFS Community folder. Please check, relocate and try again.");
                // return;
            }

            // Set the path for the PMDG panel state folder in COMMUNITY
            string panelStateFolder = @"..\pmdg-aircraft-737\Config\PanelState\";
            string randomPanelFile = "RandPanel.sav";
            
            // Check to see if the random panel file already exists in the folder
            if (File.Exists(panelStateFolder+randomPanelFile))
            {
                // MessageBox.Show("File Exists");
                // Delete the existing file
                File.Delete(panelStateFolder+randomPanelFile);
            }
            else
            {
                // MessageBox.Show("File Doesn't Exist");
            }

            // Set the path for the PMDG WORK folder containing live panel states
            string livePMDGStateFolder = @"%userprofile%\appdata\local\packages\Microsoft.FlightSimulator_8wekyb3d8bbwe\LocalState\packages\pmdg-aircraft-737\work\PanelState\RandPanel.sav";
            var filePath = Environment.ExpandEnvironmentVariables(livePMDGStateFolder);
            // Check to see if there is a live RandPanel.sav file and delete if so
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            else
            {
                // MessageBox.Show("False");   
            }

            // Copy the existing COLDDARK.sav and rename as the basis for the random panel
            // string coldDarkSav = "COLDDARK.sav";
            // File.Copy(panelStateFolder + coldDarkSav, panelStateFolder + randomPanelFile, true);

            panelTemplate template = new panelTemplate();
            string templateString = template.coldAndDarkTemplate;
            File.WriteAllText(panelStateFolder + randomPanelFile, templateString);

            // list of items that can be set randomly
            // common
            // engine hyd pumps off, galley switch off, recirculation fans off, cabin pressure mode manual
            // unusual
            // bleeds off, wipers intermittent, packs on, nd off, gear handle middle, tcas standby, dome light

            // Eng Pump Switch A=1
            RandomGenerator randResult = new RandomGenerator();
            bool boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("Eng Pump Switch A=0");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("Eng Pump Switch A=1", "Eng Pump Switch A=0");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // Eng Pump Switch B=1
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("Eng Pump Switch B=0");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("Eng Pump Switch B=1", "Eng Pump Switch B=0");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // GALLEY Switch=1
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("GALLEY Switch=0");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("GALLEY Switch=1", "GALLEY Switch=0");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // Recirc Fan Switch L=1
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("Recirc Fan Switch L=0");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("Recirc Fan Switch L=1", "Recirc Fan Switch L=0");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // Recirc Fan Switch R=1
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("Recirc Fan Switch L=0");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("Recirc Fan Switch R=1", "Recirc Fan Switch R=0");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // Cabin Press Mode Selector=0
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("Cabin Press Mode Selector=2");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("Cabin Press Mode Selector=0", "Cabin Press Mode Selector=2");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // Bleed Air Switch L=1
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("Bleed Air Switch L=0");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("Bleed Air Switch L=1", "Bleed Air Switch L=0");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // Bleed Air Switch R=1
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("Bleed Air Switch R=0");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("Bleed Air Switch R=1", "Bleed Air Switch R=0");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // APU Bleed Air Switch=0
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("APU Bleed Air Switch=1");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("APU Bleed Air Switch=0", "APU Bleed Air Switch=1");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // L Wiper Control=0
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("L Wiper Control=1");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("L Wiper Control=0", "L Wiper Control=1");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // R Wiper Control=0
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("R Wiper Control=1");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("R Wiper Control=0", "R Wiper Control=1");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // Pack Switch L=0
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("Pack Switch L=1");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("Pack Switch L=0", "Pack Switch L=1");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // Pack Switch R=0
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("Pack Switch R=1");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("Pack Switch R=0", "Pack Switch R=1");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }

            // Left Inbd DU Brightness=255
            randResult = new RandomGenerator();
            boolVal = randResult.randBool(hScrollBar1.Value);
            if (boolVal == true)
            {
                // MessageBox.Show("Left Inbd DU Brightness=0");
                string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                strFile = strFile.Replace("Left Inbd DU Brightness=255", "Left Inbd DU Brightness=0");
                File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
            }
        }

        public void scrollChange(object sender, EventArgs e)
        {
            int scroll = hScrollBar1.Value;
            label1.Text = scroll.ToString();
        }
    }

    public class RandomGenerator
    {
        public bool randBool(int percentChance)
        {
            int chanceVal = 100 - percentChance;
            var rndInt = new Random();
            int randNumber = rndInt.Next(100);
            if (randNumber > chanceVal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class panelTemplate
    {
        public string coldAndDarkTemplate = @"[Failures]
Service Based Failures=0

[Failure Groups]
Random Failures.0=0
Random Per 10hr.0=0
Limit Random Failures.0=0
Randoms To Fire.0=1
Randoms Fired.0=0
Random Timer.0=26395.039062 26395.039062 -1.000000 0 0
Random Failures.1=0
Random Per 10hr.1=0
Limit Random Failures.1=0
Randoms To Fire.1=1
Randoms Fired.1=0
Random Timer.1=26395.039062 26395.039062 -1.000000 0 0
Random Failures.2=0
Random Per 10hr.2=0
Limit Random Failures.2=0
Randoms To Fire.2=1
Randoms Fired.2=0
Random Timer.2=26395.039062 26395.039062 -1.000000 0 0
Random Failures.3=0
Random Per 10hr.3=0
Limit Random Failures.3=0
Randoms To Fire.3=1
Randoms Fired.3=0
Random Timer.3=26395.039062 26395.039062 -1.000000 0 0
Random Failures.4=0
Random Per 10hr.4=0
Limit Random Failures.4=0
Randoms To Fire.4=1
Randoms Fired.4=0
Random Timer.4=26395.039062 26395.039062 -1.000000 0 0
Random Failures.5=0
Random Per 10hr.5=0
Limit Random Failures.5=0
Randoms To Fire.5=1
Randoms Fired.5=0
Random Timer.5=26395.039062 26395.039062 -1.000000 0 0
Random Failures.6=0
Random Per 10hr.6=0
Limit Random Failures.6=0
Randoms To Fire.6=1
Randoms Fired.6=0
Random Timer.6=26395.039062 26395.039062 -1.000000 0 0
Random Failures.7=0
Random Per 10hr.7=0
Limit Random Failures.7=0
Randoms To Fire.7=1
Randoms Fired.7=0
Random Timer.7=26395.039062 26395.039062 -1.000000 0 0
Random Failures.8=0
Random Per 10hr.8=0
Limit Random Failures.8=0
Randoms To Fire.8=1
Randoms Fired.8=0
Random Timer.8=26395.039062 26395.039062 -1.000000 0 0
Random Failures.9=0
Random Per 10hr.9=0
Limit Random Failures.9=0
Randoms To Fire.9=1
Randoms Fired.9=0
Random Timer.9=26395.039062 26395.039062 -1.000000 0 0
Random Failures.10=0
Random Per 10hr.10=0
Limit Random Failures.10=0
Randoms To Fire.10=1
Randoms Fired.10=0
Random Timer.10=26395.039062 26395.039062 -1.000000 0 0
Random Failures.11=0
Random Per 10hr.11=0
Limit Random Failures.11=0
Randoms To Fire.11=1
Randoms Fired.11=0
Random Timer.11=26395.039062 26395.039062 -1.000000 0 0
Random Failures.12=0
Random Per 10hr.12=0
Limit Random Failures.12=0
Randoms To Fire.12=1
Randoms Fired.12=0
Random Timer.12=26395.039062 26395.039062 -1.000000 0 0
Random Failures.13=0
Random Per 10hr.13=0
Limit Random Failures.13=0
Randoms To Fire.13=1
Randoms Fired.13=0
Random Timer.13=26395.039062 26395.039062 -1.000000 0 0
Random Failures.14=0
Random Per 10hr.14=0
Limit Random Failures.14=0
Randoms To Fire.14=1
Randoms Fired.14=0
Random Timer.14=26395.039062 26395.039062 -1.000000 0 0
Random Failures.15=0
Random Per 10hr.15=0
Limit Random Failures.15=0
Randoms To Fire.15=1
Randoms Fired.15=0
Random Timer.15=26395.039062 26395.039062 -1.000000 0 0
Random Failures.16=0
Random Per 10hr.16=0
Limit Random Failures.16=0
Randoms To Fire.16=1
Randoms Fired.16=0
Random Timer.16=26395.039062 26395.039062 -1.000000 0 0

[Failure Items]
Status.0=0
Armed Timer.0=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.0=26395.039062 26395.039062 -1.000000 0 0
Status.1=0
Armed Timer.1=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.1=26395.039062 26395.039062 -1.000000 0 0
Status.2=0
Armed Timer.2=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.2=26395.039062 26395.039062 -1.000000 0 0
Status.3=0
Armed Timer.3=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.3=26395.039062 26395.039062 -1.000000 0 0
Status.4=0
Armed Timer.4=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.4=26395.039062 26395.039062 -1.000000 0 0
Status.5=0
Armed Timer.5=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.5=26395.039062 26395.039062 -1.000000 0 0
Status.6=0
Armed Timer.6=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.6=26395.039062 26395.039062 -1.000000 0 0
Status.7=0
Armed Timer.7=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.7=26395.039062 26395.039062 -1.000000 0 0
Status.8=0
Armed Timer.8=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.8=26395.039062 26395.039062 -1.000000 0 0
Status.9=0
Armed Timer.9=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.9=26395.039062 26395.039062 -1.000000 0 0
Status.10=0
Armed Timer.10=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.10=26395.039062 26395.039062 -1.000000 0 0
Status.11=0
Armed Timer.11=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.11=26395.039062 26395.039062 -1.000000 0 0
Status.12=0
Armed Timer.12=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.12=26395.039062 26395.039062 -1.000000 0 0
Status.13=0
Armed Timer.13=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.13=26395.039062 26395.039062 -1.000000 0 0
Status.14=0
Armed Timer.14=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.14=26395.039062 26395.039062 -1.000000 0 0
Status.15=0
Armed Timer.15=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.15=26395.039062 26395.039062 -1.000000 0 0
Status.16=0
Armed Timer.16=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.16=26395.039062 26395.039062 -1.000000 0 0
Status.17=0
Armed Timer.17=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.17=26395.039062 26395.039062 -1.000000 0 0
Status.18=0
Armed Timer.18=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.18=26395.039062 26395.039062 -1.000000 0 0
Status.19=0
Armed Timer.19=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.19=26395.039062 26395.039062 -1.000000 0 0
Status.20=0
Armed Timer.20=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.20=26395.039062 26395.039062 -1.000000 0 0
Status.21=0
Armed Timer.21=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.21=26395.039062 26395.039062 -1.000000 0 0
Status.22=0
Armed Timer.22=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.22=26395.039062 26395.039062 -1.000000 0 0
Status.23=0
Armed Timer.23=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.23=26395.039062 26395.039062 -1.000000 0 0
Status.24=0
Armed Timer.24=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.24=26395.039062 26395.039062 -1.000000 0 0
Status.25=0
Armed Timer.25=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.25=26395.039062 26395.039062 -1.000000 0 0
Status.26=0
Armed Timer.26=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.26=26395.039062 26395.039062 -1.000000 0 0
Status.27=0
Armed Timer.27=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.27=26395.039062 26395.039062 -1.000000 0 0
Status.28=0
Armed Timer.28=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.28=26395.039062 26395.039062 -1.000000 0 0
Status.29=0
Armed Timer.29=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.29=26395.039062 26395.039062 -1.000000 0 0
Status.30=0
Armed Timer.30=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.30=26395.039062 26395.039062 -1.000000 0 0
Status.31=0
Armed Timer.31=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.31=26395.039062 26395.039062 -1.000000 0 0
Status.32=0
Armed Timer.32=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.32=26395.039062 26395.039062 -1.000000 0 0
Status.33=0
Armed Timer.33=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.33=26395.039062 26395.039062 -1.000000 0 0
Status.34=0
Armed Timer.34=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.34=26395.039062 26395.039062 -1.000000 0 0
Status.35=0
Armed Timer.35=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.35=26395.039062 26395.039062 -1.000000 0 0
Status.36=0
Armed Timer.36=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.36=26395.039062 26395.039062 -1.000000 0 0
Status.37=0
Armed Timer.37=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.37=26395.039062 26395.039062 -1.000000 0 0
Status.38=0
Armed Timer.38=18473.933594 18473.933594 -1.000000 0 0
Failed Timer.38=18473.933594 18473.933594 -1.000000 0 0
Status.39=0
Armed Timer.39=18473.933594 18473.933594 -1.000000 0 0
Failed Timer.39=18473.933594 18473.933594 -1.000000 0 0
Status.40=0
Armed Timer.40=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.40=26395.039062 26395.039062 -1.000000 0 0
Status.41=0
Armed Timer.41=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.41=26395.039062 26395.039062 -1.000000 0 0
Status.42=0
Armed Timer.42=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.42=26395.039062 26395.039062 -1.000000 0 0
Status.43=0
Armed Timer.43=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.43=26395.039062 26395.039062 -1.000000 0 0
Status.44=0
Armed Timer.44=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.44=26395.039062 26395.039062 -1.000000 0 0
Status.45=0
Armed Timer.45=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.45=26395.039062 26395.039062 -1.000000 0 0
Status.46=0
Armed Timer.46=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.46=26395.039062 26395.039062 -1.000000 0 0
Status.47=0
Armed Timer.47=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.47=26395.039062 26395.039062 -1.000000 0 0
Status.48=0
Armed Timer.48=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.48=26395.039062 26395.039062 -1.000000 0 0
Status.49=0
Armed Timer.49=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.49=26395.039062 26395.039062 -1.000000 0 0
Status.50=0
Armed Timer.50=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.50=26395.039062 26395.039062 -1.000000 0 0
Status.51=0
Armed Timer.51=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.51=26395.039062 26395.039062 -1.000000 0 0
Status.52=0
Armed Timer.52=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.52=26395.039062 26395.039062 -1.000000 0 0
Status.53=0
Armed Timer.53=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.53=26395.039062 26395.039062 -1.000000 0 0
Status.54=0
Armed Timer.54=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.54=26395.039062 26395.039062 -1.000000 0 0
Status.55=0
Armed Timer.55=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.55=26395.039062 26395.039062 -1.000000 0 0
Status.56=0
Armed Timer.56=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.56=26395.039062 26395.039062 -1.000000 0 0
Status.57=0
Armed Timer.57=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.57=26395.039062 26395.039062 -1.000000 0 0
Status.58=0
Armed Timer.58=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.58=26395.039062 26395.039062 -1.000000 0 0
Status.59=0
Armed Timer.59=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.59=26395.039062 26395.039062 -1.000000 0 0
Status.60=0
Armed Timer.60=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.60=26395.039062 26395.039062 -1.000000 0 0
Status.61=0
Armed Timer.61=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.61=26395.039062 26395.039062 -1.000000 0 0
Status.62=0
Armed Timer.62=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.62=26395.039062 26395.039062 -1.000000 0 0
Status.63=0
Armed Timer.63=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.63=26395.039062 26395.039062 -1.000000 0 0
Status.64=0
Armed Timer.64=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.64=26395.039062 26395.039062 -1.000000 0 0
Status.65=0
Armed Timer.65=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.65=26395.039062 26395.039062 -1.000000 0 0
Status.66=0
Armed Timer.66=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.66=26395.039062 26395.039062 -1.000000 0 0
Status.67=0
Armed Timer.67=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.67=26395.039062 26395.039062 -1.000000 0 0
Status.68=0
Armed Timer.68=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.68=26395.039062 26395.039062 -1.000000 0 0
Status.69=0
Armed Timer.69=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.69=26395.039062 26395.039062 -1.000000 0 0
Status.70=0
Armed Timer.70=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.70=26395.039062 26395.039062 -1.000000 0 0
Status.71=0
Armed Timer.71=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.71=26395.039062 26395.039062 -1.000000 0 0
Status.72=0
Armed Timer.72=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.72=26395.039062 26395.039062 -1.000000 0 0
Status.73=0
Armed Timer.73=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.73=26395.039062 26395.039062 -1.000000 0 0
Status.74=0
Armed Timer.74=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.74=26395.039062 26395.039062 -1.000000 0 0
Status.75=0
Armed Timer.75=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.75=26395.039062 26395.039062 -1.000000 0 0
Status.76=0
Armed Timer.76=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.76=26395.039062 26395.039062 -1.000000 0 0
Status.77=0
Armed Timer.77=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.77=26395.039062 26395.039062 -1.000000 0 0
Status.78=0
Armed Timer.78=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.78=26395.039062 26395.039062 -1.000000 0 0
Status.79=0
Armed Timer.79=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.79=26395.039062 26395.039062 -1.000000 0 0
Status.80=0
Armed Timer.80=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.80=26395.039062 26395.039062 -1.000000 0 0
Status.81=0
Armed Timer.81=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.81=26395.039062 26395.039062 -1.000000 0 0
Status.82=0
Armed Timer.82=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.82=26395.039062 26395.039062 -1.000000 0 0
Status.83=0
Armed Timer.83=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.83=26395.039062 26395.039062 -1.000000 0 0
Status.84=0
Armed Timer.84=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.84=26395.039062 26395.039062 -1.000000 0 0
Status.85=0
Armed Timer.85=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.85=26395.039062 26395.039062 -1.000000 0 0
Status.86=0
Armed Timer.86=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.86=26395.039062 26395.039062 -1.000000 0 0
Status.87=0
Armed Timer.87=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.87=26395.039062 26395.039062 -1.000000 0 0
Status.88=0
Armed Timer.88=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.88=26395.039062 26395.039062 -1.000000 0 0
Status.89=0
Armed Timer.89=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.89=26395.039062 26395.039062 -1.000000 0 0
Status.90=0
Armed Timer.90=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.90=26395.039062 26395.039062 -1.000000 0 0
Status.91=0
Armed Timer.91=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.91=26395.039062 26395.039062 -1.000000 0 0
Status.92=0
Armed Timer.92=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.92=26395.039062 26395.039062 -1.000000 0 0
Status.93=0
Armed Timer.93=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.93=26395.039062 26395.039062 -1.000000 0 0
Status.94=0
Armed Timer.94=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.94=26395.039062 26395.039062 -1.000000 0 0
Status.95=0
Armed Timer.95=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.95=26395.039062 26395.039062 -1.000000 0 0
Status.96=0
Armed Timer.96=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.96=26395.039062 26395.039062 -1.000000 0 0
Status.97=0
Armed Timer.97=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.97=26395.039062 26395.039062 -1.000000 0 0
Status.98=0
Armed Timer.98=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.98=26395.039062 26395.039062 -1.000000 0 0
Status.99=0
Armed Timer.99=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.99=26395.039062 26395.039062 -1.000000 0 0
Status.100=0
Armed Timer.100=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.100=26395.039062 26395.039062 -1.000000 0 0
Status.101=0
Armed Timer.101=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.101=26395.039062 26395.039062 -1.000000 0 0
Status.102=0
Armed Timer.102=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.102=26395.039062 26395.039062 -1.000000 0 0
Status.103=0
Armed Timer.103=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.103=26395.039062 26395.039062 -1.000000 0 0
Status.104=0
Armed Timer.104=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.104=26395.039062 26395.039062 -1.000000 0 0
Status.105=0
Armed Timer.105=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.105=26395.039062 26395.039062 -1.000000 0 0
Status.106=0
Armed Timer.106=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.106=26395.039062 26395.039062 -1.000000 0 0
Status.107=0
Armed Timer.107=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.107=26395.039062 26395.039062 -1.000000 0 0
Status.108=0
Armed Timer.108=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.108=26395.039062 26395.039062 -1.000000 0 0
Status.109=0
Armed Timer.109=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.109=26395.039062 26395.039062 -1.000000 0 0
Status.110=0
Armed Timer.110=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.110=26395.039062 26395.039062 -1.000000 0 0
Status.111=0
Armed Timer.111=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.111=26395.039062 26395.039062 -1.000000 0 0
Status.112=0
Armed Timer.112=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.112=26395.039062 26395.039062 -1.000000 0 0
Status.113=0
Armed Timer.113=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.113=26395.039062 26395.039062 -1.000000 0 0
Status.114=0
Armed Timer.114=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.114=26395.039062 26395.039062 -1.000000 0 0
Status.115=0
Armed Timer.115=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.115=26395.039062 26395.039062 -1.000000 0 0
Status.116=0
Armed Timer.116=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.116=26395.039062 26395.039062 -1.000000 0 0
Status.117=0
Armed Timer.117=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.117=26395.039062 26395.039062 -1.000000 0 0
Status.118=0
Armed Timer.118=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.118=26395.039062 26395.039062 -1.000000 0 0
Status.119=0
Armed Timer.119=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.119=26395.039062 26395.039062 -1.000000 0 0
Status.120=0
Armed Timer.120=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.120=26395.039062 26395.039062 -1.000000 0 0
Status.121=0
Armed Timer.121=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.121=26395.039062 26395.039062 -1.000000 0 0
Status.122=0
Armed Timer.122=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.122=26395.039062 26395.039062 -1.000000 0 0
Status.123=0
Armed Timer.123=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.123=26395.039062 26395.039062 -1.000000 0 0
Status.124=0
Armed Timer.124=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.124=26395.039062 26395.039062 -1.000000 0 0
Status.125=0
Armed Timer.125=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.125=26395.039062 26395.039062 -1.000000 0 0
Status.126=0
Armed Timer.126=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.126=26395.039062 26395.039062 -1.000000 0 0
Status.127=0
Armed Timer.127=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.127=26395.039062 26395.039062 -1.000000 0 0
Status.128=0
Armed Timer.128=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.128=26395.039062 26395.039062 -1.000000 0 0
Status.129=0
Armed Timer.129=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.129=26395.039062 26395.039062 -1.000000 0 0
Status.130=0
Armed Timer.130=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.130=26395.039062 26395.039062 -1.000000 0 0
Status.131=0
Armed Timer.131=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.131=26395.039062 26395.039062 -1.000000 0 0
Status.132=0
Armed Timer.132=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.132=26395.039062 26395.039062 -1.000000 0 0
Status.133=0
Armed Timer.133=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.133=26395.039062 26395.039062 -1.000000 0 0
Status.134=0
Armed Timer.134=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.134=26395.039062 26395.039062 -1.000000 0 0
Status.135=0
Armed Timer.135=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.135=26395.039062 26395.039062 -1.000000 0 0
Status.136=0
Armed Timer.136=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.136=26395.039062 26395.039062 -1.000000 0 0
Status.137=0
Armed Timer.137=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.137=26395.039062 26395.039062 -1.000000 0 0
Status.138=0
Armed Timer.138=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.138=26395.039062 26395.039062 -1.000000 0 0
Status.139=0
Armed Timer.139=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.139=26395.039062 26395.039062 -1.000000 0 0
Status.140=0
Armed Timer.140=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.140=26395.039062 26395.039062 -1.000000 0 0
Status.141=0
Armed Timer.141=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.141=26395.039062 26395.039062 -1.000000 0 0
Status.142=0
Armed Timer.142=25125.263672 25125.263672 -1.000000 0 0
Failed Timer.142=25125.263672 25125.263672 -1.000000 0 0
Status.143=0
Armed Timer.143=18473.988281 18473.988281 -1.000000 0 0
Failed Timer.143=18473.988281 18473.988281 -1.000000 0 0
Status.144=0
Armed Timer.144=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.144=26395.039062 26395.039062 -1.000000 0 0
Status.145=0
Armed Timer.145=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.145=26395.039062 26395.039062 -1.000000 0 0
Status.146=0
Armed Timer.146=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.146=26395.039062 26395.039062 -1.000000 0 0
Status.147=0
Armed Timer.147=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.147=26395.039062 26395.039062 -1.000000 0 0
Status.148=0
Armed Timer.148=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.148=26395.039062 26395.039062 -1.000000 0 0
Status.149=0
Armed Timer.149=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.149=26395.039062 26395.039062 -1.000000 0 0
Status.150=0
Armed Timer.150=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.150=26395.039062 26395.039062 -1.000000 0 0
Status.151=0
Armed Timer.151=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.151=26395.039062 26395.039062 -1.000000 0 0
Status.152=0
Armed Timer.152=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.152=26395.039062 26395.039062 -1.000000 0 0
Status.153=0
Armed Timer.153=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.153=26395.039062 26395.039062 -1.000000 0 0
Status.154=0
Armed Timer.154=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.154=26395.039062 26395.039062 -1.000000 0 0
Status.155=0
Armed Timer.155=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.155=26395.039062 26395.039062 -1.000000 0 0
Status.156=0
Armed Timer.156=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.156=26395.039062 26395.039062 -1.000000 0 0
Status.157=0
Armed Timer.157=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.157=26395.039062 26395.039062 -1.000000 0 0
Status.158=0
Armed Timer.158=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.158=26395.039062 26395.039062 -1.000000 0 0
Status.159=0
Armed Timer.159=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.159=26395.039062 26395.039062 -1.000000 0 0
Status.160=0
Armed Timer.160=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.160=26395.039062 26395.039062 -1.000000 0 0
Status.161=0
Armed Timer.161=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.161=26395.039062 26395.039062 -1.000000 0 0
Status.162=0
Armed Timer.162=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.162=26395.039062 26395.039062 -1.000000 0 0
Status.163=0
Armed Timer.163=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.163=26395.039062 26395.039062 -1.000000 0 0
Status.164=0
Armed Timer.164=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.164=26395.039062 26395.039062 -1.000000 0 0
Status.165=0
Armed Timer.165=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.165=26395.039062 26395.039062 -1.000000 0 0
Status.166=0
Armed Timer.166=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.166=26395.039062 26395.039062 -1.000000 0 0
Status.167=0
Armed Timer.167=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.167=26395.039062 26395.039062 -1.000000 0 0
Status.168=0
Armed Timer.168=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.168=26395.039062 26395.039062 -1.000000 0 0
Status.169=0
Armed Timer.169=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.169=26395.039062 26395.039062 -1.000000 0 0
Status.170=0
Armed Timer.170=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.170=26395.039062 26395.039062 -1.000000 0 0
Status.171=0
Armed Timer.171=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.171=26395.039062 26395.039062 -1.000000 0 0
Status.172=0
Armed Timer.172=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.172=26395.039062 26395.039062 -1.000000 0 0
Status.173=0
Armed Timer.173=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.173=26395.039062 26395.039062 -1.000000 0 0
Status.174=0
Armed Timer.174=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.174=26395.039062 26395.039062 -1.000000 0 0
Status.175=0
Armed Timer.175=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.175=26395.039062 26395.039062 -1.000000 0 0
Status.176=0
Armed Timer.176=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.176=26395.039062 26395.039062 -1.000000 0 0
Status.177=0
Armed Timer.177=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.177=26395.039062 26395.039062 -1.000000 0 0
Status.178=0
Armed Timer.178=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.178=26395.039062 26395.039062 -1.000000 0 0
Status.179=0
Armed Timer.179=22436.042969 22436.042969 -1.000000 0 0
Failed Timer.179=22436.042969 22436.042969 -1.000000 0 0
Status.180=0
Armed Timer.180=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.180=26395.039062 26395.039062 -1.000000 0 0
Status.181=0
Armed Timer.181=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.181=26395.039062 26395.039062 -1.000000 0 0
Status.182=0
Armed Timer.182=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.182=26395.039062 26395.039062 -1.000000 0 0
Status.183=0
Armed Timer.183=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.183=26395.039062 26395.039062 -1.000000 0 0
Status.184=0
Armed Timer.184=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.184=26395.039062 26395.039062 -1.000000 0 0
Status.185=0
Armed Timer.185=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.185=26395.039062 26395.039062 -1.000000 0 0
Status.186=0
Armed Timer.186=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.186=26395.039062 26395.039062 -1.000000 0 0
Status.187=0
Armed Timer.187=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.187=26395.039062 26395.039062 -1.000000 0 0
Status.188=0
Armed Timer.188=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.188=26395.039062 26395.039062 -1.000000 0 0
Status.189=0
Armed Timer.189=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.189=26395.039062 26395.039062 -1.000000 0 0
Status.190=0
Armed Timer.190=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.190=26395.039062 26395.039062 -1.000000 0 0
Status.191=0
Armed Timer.191=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.191=26395.039062 26395.039062 -1.000000 0 0
Status.192=0
Armed Timer.192=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.192=26395.039062 26395.039062 -1.000000 0 0
Status.193=0
Armed Timer.193=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.193=26395.039062 26395.039062 -1.000000 0 0
Status.194=0
Armed Timer.194=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.194=26395.039062 26395.039062 -1.000000 0 0
Status.195=0
Armed Timer.195=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.195=26395.039062 26395.039062 -1.000000 0 0
Status.196=0
Armed Timer.196=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.196=26395.039062 26395.039062 -1.000000 0 0
Status.197=0
Armed Timer.197=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.197=26395.039062 26395.039062 -1.000000 0 0
Status.198=0
Armed Timer.198=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.198=26395.039062 26395.039062 -1.000000 0 0
Status.199=0
Armed Timer.199=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.199=26395.039062 26395.039062 -1.000000 0 0
Status.200=0
Armed Timer.200=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.200=26395.039062 26395.039062 -1.000000 0 0
Status.201=0
Armed Timer.201=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.201=26395.039062 26395.039062 -1.000000 0 0
Status.202=0
Armed Timer.202=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.202=26395.039062 26395.039062 -1.000000 0 0
Status.203=0
Armed Timer.203=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.203=26395.039062 26395.039062 -1.000000 0 0
Status.204=0
Armed Timer.204=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.204=26395.039062 26395.039062 -1.000000 0 0
Status.205=0
Armed Timer.205=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.205=26395.039062 26395.039062 -1.000000 0 0
Status.206=0
Armed Timer.206=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.206=26395.039062 26395.039062 -1.000000 0 0
Status.207=0
Armed Timer.207=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.207=26395.039062 26395.039062 -1.000000 0 0
Status.208=0
Armed Timer.208=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.208=26395.039062 26395.039062 -1.000000 0 0
Status.209=0
Armed Timer.209=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.209=26395.039062 26395.039062 -1.000000 0 0
Status.210=0
Armed Timer.210=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.210=26395.039062 26395.039062 -1.000000 0 0
Status.211=0
Armed Timer.211=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.211=26395.039062 26395.039062 -1.000000 0 0
Status.212=0
Armed Timer.212=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.212=26395.039062 26395.039062 -1.000000 0 0
Status.213=0
Armed Timer.213=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.213=26395.039062 26395.039062 -1.000000 0 0
Status.214=0
Armed Timer.214=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.214=26395.039062 26395.039062 -1.000000 0 0
Status.215=0
Armed Timer.215=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.215=26395.039062 26395.039062 -1.000000 0 0
Status.216=0
Armed Timer.216=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.216=26395.039062 26395.039062 -1.000000 0 0
Status.217=0
Armed Timer.217=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.217=26395.039062 26395.039062 -1.000000 0 0
Status.218=0
Armed Timer.218=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.218=26395.039062 26395.039062 -1.000000 0 0
Status.219=0
Armed Timer.219=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.219=26395.039062 26395.039062 -1.000000 0 0
Status.220=0
Armed Timer.220=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.220=26395.039062 26395.039062 -1.000000 0 0
Status.221=0
Armed Timer.221=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.221=26395.039062 26395.039062 -1.000000 0 0
Status.222=0
Armed Timer.222=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.222=26395.039062 26395.039062 -1.000000 0 0
Status.223=0
Armed Timer.223=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.223=26395.039062 26395.039062 -1.000000 0 0
Status.224=0
Armed Timer.224=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.224=26395.039062 26395.039062 -1.000000 0 0
Status.225=0
Armed Timer.225=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.225=26395.039062 26395.039062 -1.000000 0 0
Status.226=0
Armed Timer.226=26395.039062 26395.039062 -1.000000 0 0
Failed Timer.226=26395.039062 26395.039062 -1.000000 0 0

[Engines]
EngineState.0=0
OilQ.0=1799
OffTime.0=308
EGT.0=9
OilQ_Last.0=1799
ind_OilQ.0=1799
EngineState.1=0
OilQ.1=1901
OffTime.1=308
EGT.1=9
OilQ_Last.1=1901
ind_OilQ.1=1901

[ElectricalSystem]
DC Meter Selector=2
AC Meter Selector=1
GALLEY Switch=1
Disconnect 1 Switch=1
Disconnect 1 Switch  Guard=0
Disconnect 2 Switch=1
Disconnect 2 Switch  Guard=0
Battery Switch=0
Battery Switch  Guard=1
Standby Power Selector=2
Standby Power Selector  Guard=0
Ground Power Selector=1
Bus Transfer Switch=1
Bus Transfer Switch  Guard=0
Gen 1 Selector=1
Gen 2 Selector=1
APU Gen 1 Selector=1
APU Gen 2 Selector=1
Main Bat=1
Main Bat Charger=0
Main Bat Charger Mode=0
Aux Bat=1
Aux Bat Charger=0
Aux Bat Charger Mode=0
DC Hot Battery Bus=1
DC Battery Bus=0
DC Standby Bus=0
Hot Switched Bat Bus=0
DC Ground Svc Bus=0
AC Transfer Bus 1=0
AC Transfer Bus 2=0
AC Main Bus 1=0
AC Main Bus 2=0
AC Galley Bus 1=0
AC Galley Bus 2=0
AC Transfer Bus 1 Source=0
AC Transfer Bus 2 Source=0
Bus Tie Breaker 1=0
Bus Tie Breaker 2=0
CrossTie Relay=0
CrossTie Relay Source=0
AC Standby Bus=0
Inverter=0
AC Ground Service Bus 1=0
AC Ground Service Bus 2=0
Transformer/Rectifier 1=0
Transformer/Rectifier 2=0
Transformer/Rectifier 3=0
DC Bus 1=0
DC Bus 2=0
Galley Bus AB=1
Galley Bus CD=1
GPU XPC Closed=0
GPU State=0
APU GCB L Closed=0
APU State=0
APU Gen Field=1
IDG GEN 0 Comm=1
IDG GEN 0 Field=1
IDG GEN 0 Test=0
IDG Gen 0 State=2
IDG DRIVE 0 Online=0
IDG GEN 0 Disco=0
IDG GEN 0 GCB Closed=0
IDG GEN 1 Comm=1
IDG GEN 1 Field=1
IDG GEN 1 Test=0
IDG Gen 1 State=2
IDG DRIVE 1 Online=0
IDG GEN 1 Disco=0
IDG GEN 1 GCB Closed=0
APU/IDG Power Save Arm=0
APU/IDG Power Save Cancel=0
Main Battery Voltage=23.803068
Aux Battery Voltage=27.803333

[FuelSystem.0]
Pump Switch 1 Fwd=0
Pump Switch 2 Fwd=0
Pump Switch 1 Aft=0
Pump Switch 2 Aft=0
Pump Switch Left Center=0
Pump Switch Right Center=0
Pump Switch Crossfeed=1
AUX FWD A=1
AUX FWD B=1
AUX AFT A=1
AUX AFT B=1
GND XFR=1
GND XFR  Guard=0
Tank 0 Volume=1288.000000
Tank 0 Density=6.699219
Tank 0 Temperature=510.000000
Tank 1 Volume=1288.000000
Tank 1 Density=6.699219
Tank 1 Temperature=510.000000
Tank 2 Volume=1155.778286
Tank 2 Density=6.699219
Tank 2 Temperature=519.000000
Tank 3 Volume=0.000000
Tank 3 Density=6.699219
Tank 3 Temperature=520.000000
Tank 4 Volume=0.000000
Tank 4 Density=6.699219
Tank 4 Temperature=520.000000
Pump 0 State=5
Input SO Pump.0=0
Output SO Pump.0=0
Failed Pump.0=0
Rotation Pump.0=0.000000
Pump 1 State=5
Input SO Pump.1=0
Output SO Pump.1=0
Failed Pump.1=0
Rotation Pump.1=0.000000
Pump 2 State=5
Input SO Pump.2=0
Output SO Pump.2=0
Failed Pump.2=0
Rotation Pump.2=0.000000
Pump 3 State=5
Input SO Pump.3=0
Output SO Pump.3=0
Failed Pump.3=0
Rotation Pump.3=0.000000
Pump 4 State=5
Input SO Pump.4=0
Output SO Pump.4=0
Failed Pump.4=0
Rotation Pump.4=0.000000
Fuel Type=0
Fuel Used 1=0.000000
Fuel Used 2=0.000000
APU Fuel Source=4
Aft Aux Tanks=0
Fwd Aux Tanks=0
Crossfeed Fuel Valve=0
APU Fuel Valve=0
Left Engine Fuel Valve=0
Right Engine Fuel Valve=0
Left Spar Fuel Valve=0
Right Spar Fuel Valve=0
Aux Fwd A Fuel Valve=0
Aux Fwd B Fuel Valve=0
Aux Aft A Fuel Valve=0
Aux Aft B Fuel Valve=0

[Aircraft]
Model=2

[Payload]
SingleClass=0
Freighter=0
PayloadLevel=1.000000
PayloadStation.0=1520
PayloadStation.1=6080
PayloadStation.2=7600
PayloadStation.3=7600
PayloadStation.4=5824
PayloadStation.5=5598
PayloadStation.6=190
PayloadStation.7=190
PayloadStation.8=0
PayloadStation.9=635
PayloadStation.10=860
InclFixedItem.0=0
InclFixedItem.1=0
InclFixedItem.2=0
InclFixedItem.3=0
InclFixedItem.4=0
InclFixedItem.5=0
InclFixedItem.6=0
InclFixedItem.7=0
LastMinStationSta.0=0
LastMinStationArm.0=0
LastMinStationLoad.0=0
LastMinStationName.0=
LastMinStationSta.1=0
LastMinStationArm.1=0
LastMinStationLoad.1=0
LastMinStationName.1=
LastMinStationSta.2=0
LastMinStationArm.2=0
LastMinStationLoad.2=0
LastMinStationName.2=
Main Cargo Container 1=0.000000 0.000000 0.000000 -10.000000
Main Cargo Container 2=0.000000 0.000000 0.000000 -10.000000
Main Cargo Container 3=0.000000 0.000000 0.000000 -10.000000
Main Cargo Container 4=0.000000 0.000000 0.000000 -10.000000

[FlightControls]
Flight Control A Switch=2
Flight Control A Switch  Guard=0
Flight Control B Switch=2
Flight Control B Switch  Guard=0
Alt Flaps Master Switch=0
Alt Flaps Master Switch  Guard=0
Alt Flaps Position Switch=1
Yoke Trim Switches=1
Spoiler A Switch=1
Spoiler A Switch  Guard=0
Spoiler B Switch=1
Spoiler B Switch  Guard=0
Yaw Damper Switch=0
YokeCounterDigit.0=20.000000 0.000000 0.000000 19150.044141
YokeCounterDigit.1=20.000000 60.000000 60.000000 19150.044141
YokeCounterDigit.2=20.000000 50.000000 50.000000 19150.044141
YokeCounterDigit.3=20.000000 50.000000 50.000000 19150.044141
YokeCounterDigit.4=20.000000 80.000000 80.000000 19150.044141
YokeCounterDigit.5=20.000000 0.000000 0.000000 19150.044141
StabTrim=200
MachTrim=200
AilTrim=200
RudTrim=200
FlapsDown=0
TEFlapsPos0=0.000000
TEFlapsPos1=0.000000
YDState=0
StabTrimSnd=0

[SMYD]
SS_CHARGE_L=18.722212 18.722212 -1.000000 0 0
SS_CHARGE_R=18892.656250 18892.656250 -1.000000 0 0

[AntiIceSystem.0]
Window Heat Switch 1=0
Window Heat Switch 2=0
Window Heat Switch 3=0
Window Heat Switch 4=0
Probe Heat Switch 1=0
Probe Heat Switch 2=0
Wing AntiIce Switch=0
Engine AntiIce Switch 1=0
Engine AntiIce Switch 2=0

[Hydraulics]
Eng Pump Switch A=1
Eng Pump Switch B=1
Elec Pump Switch A=0
Elec Pump Switch B=0
Qty Low A=1
Qty Low B=1
Qty Low S=0
Qty Low LA=0
Qty Low LB=0
Qty Low LS=0
EDMP1 Ovht Latch=0
EDMP2 Ovht Latch=0
EDMP1 Ovht Kill=0
EDMP2 Ovht Kill=0
EDP1 SOV=0
EDMP2 SOV=0
Landing Gear Transfer Valve State=0
Eng Pump Switch A=1

[OxygenSystem.0]
Passenger Oxygen Switch=0
Passenger Oxygen Switch  Guard=0

[CenterOverhead]
CB Panel Brightness=0
Overhead Panel Brightness=0
Equipment Cooling Supply Switch=0
Equipment Cooling Exhaust Switch=0
EmergencyLightsSwitch=0
EmergencyLightsSwitch  Guard=1
Seat Belts Switch=0
Smoking Switch=0
Attend Call Switch=0
Ground Call Switch=0
L Wiper Control=0
R Wiper Control=0

[Doors.0]
Door 1L Position=0.200000 1.000000 1.000000 19150.044141
Door 1R Position=0.200000 0.000000 0.000000 19150.044141
Door 2L Position=0.200000 0.000000 0.000000 19150.044141
Door 2R Position=0.200000 0.000000 0.000000 19150.044141
Overwing L Fwd Position=0.500000 0.000000 0.000000 19150.044141
Overwing R Fwd Position=0.500000 0.000000 0.000000 19150.044141
Overwing L Aft Position=0.500000 0.000000 0.000000 675.388486
Overwing R Aft Position=0.500000 0.000000 0.000000 675.388486
EE Hatch Position=0.333333 0.000000 0.000000 19150.044141
Cargo Door Fwd Position=0.333333 0.000000 0.000000 19150.044141
Cargo Door Aft Position=0.333333 0.000000 0.000000 19150.044141
Air Stairs=0.066667 0.000000 0.000000 19150.044141
Air Stairs Rails=0.200000 0.000000 0.000000 19150.044141
Cargo Door Main Position=0.000000 0.000000 0.000000 19150.044141
Cargo Door Pressure Relief Position=1.000000 0.000000 0.000000 19150.044141

[ServiceInterphone]
Service Interphone Switch=0

[ADFPanel]
ModeSelector=0
ToneSwitch=0
StbyFrequency=3300

[ACP.0]
Receiver Switch.00=0
Receiver Switch.01=0
Receiver Switch.02=0
Receiver Switch.03=0
Receiver Switch.04=0
Receiver Switch.05=0
Receiver Switch.06=0
Receiver Switch.07=0
Receiver Switch.08=0
Receiver Switch.09=0
Receiver Switch.10=0
Receiver Switch.11=0
Receiver Switch.12=0
Receiver Switch.13=0
RT IC Switch=1
Mask Boom Switch=1
Alt Norm Switch=1
Filter Switch=1
Selected Mic=0
Powered=0

[RadioPanel.0]
HFSensor=265
SelectedRadio=
AMSelected=
PnlOff=

[ACP.1]
Receiver Switch.00=0
Receiver Switch.01=0
Receiver Switch.02=0
Receiver Switch.03=0
Receiver Switch.04=0
Receiver Switch.05=0
Receiver Switch.06=0
Receiver Switch.07=0
Receiver Switch.08=0
Receiver Switch.09=0
Receiver Switch.10=0
Receiver Switch.11=0
Receiver Switch.12=0
Receiver Switch.13=0
RT IC Switch=1
Mask Boom Switch=1
Alt Norm Switch=1
Filter Switch=1
Selected Mic=0
Powered=0

[RadioPanel.1]
HFSensor=265
SelectedRadio=1
AMSelected=
PnlOff=

[ACP.2]
Receiver Switch.00=0
Receiver Switch.01=0
Receiver Switch.02=0
Receiver Switch.03=0
Receiver Switch.04=0
Receiver Switch.05=0
Receiver Switch.06=0
Receiver Switch.07=0
Receiver Switch.08=0
Receiver Switch.09=0
Receiver Switch.10=0
Receiver Switch.11=0
Receiver Switch.12=0
Receiver Switch.13=0
RT IC Switch=0
Mask Boom Switch=1
Alt Norm Switch=1
Filter Switch=1
Selected Mic=0
Powered=0

[RadioPanel.2]
HFSensor=265
SelectedRadio=2
AMSelected=
PnlOff=

[Comms]
COMFreq00=124000
COMFreq01=124850
COMFreq10=124850
COMFreq11=124850
COMFreq20=118000
COMFreq21=135000
COMFreq30=7160
COMFreq31=2800
COMFreq50=12300
COMFreq51=25150
COMFreqBCD00=9216
COMFreqBCD01=9349
COMFreqBCD10=9349
COMFreqBCD11=9349
NAVFreq00=4176
NAVFreq01=5008
NAVFreq10=4176
NAVFreq11=5008
ADFFreq=2192
SATCOMAvailabilityTimer=18474.656250 18474.656250 0.000000 0 0
FO_V1_called=0
FO_VR_called=0
FO_V2_called=0

[CommRadios]
DataMode.0.0=0
DataMode.0.1=0
DataMode.1.0=0
DataMode.1.1=0
DataMode.2.0=1
DataMode.2.1=0
DataMode.3.0=0
DataMode.3.1=0
DataMode.4.0=0
DataMode.4.1=0
DataMode.5.0=0
DataMode.5.1=0

[DataLink]
AltnListPos=---°--.- ----°--.-
Source=0

[APU]
APUState=0
EGT=120
StateTime=1542366
FaultTime=0
PowerTime=0
SCUStress=0

[AirCondSystem.600_700]
Temp Source Selector=0
CONT Temp Selector=115
PASS Temp Selector=115

[BleedAirSystem.0]
Recirc Fan Switch L=1
Recirc Fan Switch R=1
Pack Switch L=0
Pack Switch R=0
Bleed Air Switch L=1
Bleed Air Switch R=1
APU Bleed Air Switch=0
Isolation Valve Switch=2

[CabinPress]
Cabin Press Mode Selector=0
Cabin Press Landing Alt=10000
Cabin Press Flight Alt=10000
Cabin Phase=0
Cabin Alt=10003
OFV=10000
EXV=7000

[Lights.0]
Left Retractable Landing Light=0
Right Retractable Landing Light=0
Left Fixed Landing Light=0
Right Fixed Landing Light=0
Left Runway Turnoff Light=0
Right Runway Turnoff Light=0
Taxi Light=0
APU Start Selector=0
Left Engine Start Selector=1
Right Engine Start Selector=1
Ignition Selector=1
Logo Light=0
Position Light=2
Anti Collision Light=0
Wing Light=0
Wheel Well Light=0
Grimes Light=0
Compass Light=1
Cabin Lights Auto=1
Cabin Brightness=1.000000

[ISDU]
zOffset=0
Display Selector=1
System Display=0
WLAN Switch=1
WLAN Switch  Guard=0

[IRS.0]
Switch=0
OpMode=0
TruHdg=-1000000
DriftP=N0000.0W000-0.0
DriftR=0.000000
DriftD=0.000000
DriftT=0.000000

[IRS.1]
Switch=0
OpMode=0
TruHdg=-1000000
DriftP=N0000.0W000-0.0
DriftR=0.000000
DriftD=0.000000
DriftT=0.000000

[GPS.0]
OpMode=0

[GPS.1]
OpMode=0

[BottomAftOverhead]
Dome Light Switch=1

[EngineControlSystem.0]
EEC Switch L=1
EEC Switch L  Guard=0
EEC Switch R=1
EEC Switch R  Guard=0

[EFISControlPanel.0]
Minimums Switch=1
Baro Switch=0
VOR ADF Selector Left=0
VOR ADF Selector Right=0
Mode Selector=2
Range Selector=2
Baro Minimums=10200
Radio Minimums=10050
Show FPV=0
Show Meters=0
Baro STD=0
Baro In Hg=29.92
Baro HPa=1013.00
Baro Preselected=0
Mode Centered=0
Show TFC=0
Show WXR=0
Show STA=0
Show WPT=0
Show ARPT=0
Show DATA=0
Show POS=0
Show TERR=0
Show VSD=0
Baro Minimums State=0
Radio Minimums State=0
Altimeter Baro Minimums Displayed=0
Altimeter Radio Minimums Displayed=0
Powered=0
MinsRadioBaro=1
BaroInHpa=0
VORADF_left=0
VORADF_right=0
ModeSelect=2
RangeSelect=2

[DisplaysSourcePanel.0]
Main DU Selector=1
Lower DU Selector=1
Disengage Test Switch=1
FMC Annunciator State=1

[DisplaysSourcePanel.1]
Master Lights Switch=1
Main DU Selector=1
Lower DU Selector=1
Disengage Test Switch=1
FMC Annunciator State=1

[EFISControlPanel.1]
Minimums Switch=1
Baro Switch=0
VOR ADF Selector Left=0
VOR ADF Selector Right=0
Mode Selector=2
Range Selector=2
Baro Minimums=10200
Radio Minimums=10050
Show FPV=0
Show Meters=0
Baro STD=0
Baro In Hg=29.92
Baro HPa=1013.00
Baro Preselected=0
Mode Centered=0
Show TFC=0
Show WXR=0
Show STA=0
Show WPT=0
Show ARPT=0
Show DATA=0
Show POS=0
Show TERR=0
Show VSD=0
Baro Minimums State=0
Radio Minimums State=0
Altimeter Baro Minimums Displayed=0
Altimeter Radio Minimums Displayed=0
Powered=0
MinsRadioBaro=1
BaroInHpa=0
VORADF_left=0
VORADF_right=0
ModeSelect=2
RangeSelect=2

[LowerMainPanel]
Left Main Panel Brightness=0
Right Main Panel Brightness=0
Left Outbd DU Brightness=255
Right Outbd DU Brightness=255
Left Inbd DU Brightness=255
Right Inbd DU Brightness=255
Left Inbd DU Inner Brightness=255
Right Inbd DU Inner Brightness=255
Background Brightness=0
AFDS Flood Brightness=0
Lower DU Brightness=255
Lower DU Inner Brightness=255
Upper DU Brightness=255

[NavigationDispaysPanel.0]
VHF NAV Selector=1
IRS Selector=1
FMC Selector=1
Displays Source Selector=1
Control Panel Selector=1

[EFIS.0]
Altitude Alert State=0
Speed Reference Selector=1
ENG Selector=0
SYS Selector=0
Max Autoland=2
Show Autoland Advisory=0

[MCP]
FD_L=1
FD_R=1
MCP_BL=3
PWR=0
SPD=0
N1=0

[MainPanelMisc.0]
N1 Set Selector=2
Spd Ref Selector=1
Fuel Flow Switch=1

[MiscSystems]
Jumpseat=0
CombinerCover=0
Captain Left Armrest=0
Captain Right Armrest=0
FO Left Armrest=0
FO Right Armrest=0

[GroundOps]
GroundManagementAUTOActive=0
GroundManagement_MasterTimer=26395.039062 26395.039062 -1.000000 0 0
GroundTurnType=0
GroundPaxEntry=0
PushbackAuto=2
targetFuelIntoplane=0.000000
TXP200 Present=0

[GearPanel]
Gear Lever=6
Gear State=3
NSS=1000
MGSS0=1000
MGSS1=1000
GPO1=1000
GPO2=1000
GPO3=1000

[FireProtection]
Ovht Det 1=1
Ovht Det 2=1
Fire Handle 0=0
Fire Handle 1=0
Fire Handle 2=0

[CargoFire]
Detector Selector FWD=1
Detector Selector AFT=1
Detector Selector MAIN=1
Arm FWD=0
Arm AFT=0
Arm MAIN=0
Discharge=0
Discharge  Guard=0
CargoSmoke_Depress=0
CargoSmoke_Depress  Guard=0

[ControlStand]
Stab Trim MAIN ELECT=0
Stab Trim MAIN ELECT  Guard=0
Stab Trim AUTOPILOT=0
Stab Trim AUTOPILOT  Guard=0
Parking Brake Lever=0
Spoiler Lever=0
Flap Lever=0
Engine 1 Start Switch=1
Engine 2 Start Switch=1
Gear Warning Cutout Switch=0
LastFlapLeverPos=3
flapLeverPosition=0
flapTargetPos=0

[PedestalLights]
Pedestal Flood Brightness=0
Pedestal Panel Brightness=0

[FltDkDoor]
Stab Trim Ovrd Switch=0
Stab Trim Ovrd Switch  Guard=0

[GPWS]
FlapInhibit=1
FlapInhibit  Guard=0
GearInhibit=1
GearInhibit  Guard=0
TerrInhibit=1
TerrInhibit  Guard=0
Mode2ATimer=26395.039062 26395.039062 -1.000000 0 0
Mode2_AltGain_armed=0
Mode2_AltGain_active=0
Mode2_AltGain_startAltitude=0.00
Mode2_AltGain_timer=26395.039062 26395.039062 -1.000000 0 0
Mode2BTimer=26395.039062 26395.039062 -1.000000 0 0
Mode3Armed=0
Mode3ApproachCheck=0
Mode3DescentAltitude=-1000000.00
Mode3GainFilter=-1000000.00
Mode4Armed=0
GSInhibited=0
Mode6Armed=0
Mode6FirstCall=0
Mode6BankAmount=0
CalloutPlayed.1=0
CalloutPlayed.2=0
CalloutPlayed.3=0
CalloutPlayed.4=0
CalloutPlayed.5=0
CalloutPlayed.6=0
CalloutPlayed.7=0
CalloutPlayed.8=0
CalloutPlayed.9=0
CalloutPlayed.10=0
CalloutPlayed.11=0
CalloutPlayed.12=0
CalloutPlayed.13=0
CalloutPlayed.14=0
CalloutPlayed.15=0
CalloutPlayed.16=0
CalloutPlayed.17=0
CalloutPlayed.29=0
CalloutPlayed.30=0
CalloutPlayed.31=0

[TCAS]
Powered=0
Xpndr=0
AltSource=0
Mode=2
XpndrCode=4660
ActiveTCASAural=-1

[AIModels]
useTPU=0
useDualPlug=1
connected.0=0
connected.1=0
connected.2=0
connected.3=0
connected.4=0
connected.5=0
connected.6=0
connected.7=0
connected.8=0
connected.9=0
connected.10=0
connected.11=0
connected.12=1
connected.13=0
connected.14=0
connected.15=0
connected.16=0
connected.17=0
connected.18=0
connected.19=0
connected.20=0
connected.21=0
connected.22=0
connected.23=0
connected.24=0
connected.25=0
connected.26=0
connected.27=0
connected.28=0
connected.29=0
connected.30=0

[AnalogStandby]
ADI APP Mode Selector=0
Baro In Hg=29.92
RMI Knob L=0
RMI Knob R=1
Pitch Target=100.000000 0.000000 0.000000 -10.000000
Roll Target=100.000000 0.000000 0.000000 -10.000000
Gyro Speed=0.016667 0.000000 1.000000 3478.053482
Pitch Error=100.000000 0.000000 0.000000 -10.000000
Roll Error=100.000000 0.000000 0.000000 -10.000000
Gyro Powered=1
Att Error sin Theta=0.00
Att Error cos Theta=1.00

[HUD]
HUD mode=0
HUD standby mode=2
HUD cleared=0
AIII capable=0
AIII established=0
HUD runway length=10000
HUD runway elevation=0
RunwayLength_inMeters=0
HUD GS angle=300
HUD runway entry state=0
HUD GS entry state=0
onLocalizerTimer=26395.039062 26395.039062 -1.000000 0 0
HUD CP brightness=1.00
HUD Stowed=1
HUD Brightness=90
HUD Brightness Mode=0

[MasterCautionSystem.0]
MasterWarningIlluminated=1
SystemAnnunciatorIlluminated_0=0
SystemAnnunciatorIlluminated_1=1
SystemAnnunciatorIlluminated_2=1
SystemAnnunciatorIlluminated_3=0
SystemAnnunciatorIlluminated_4=1
SystemAnnunciatorIlluminated_5=0
SystemAnnunciatorIlluminated_6=1
SystemAnnunciatorIlluminated_7=1
SystemAnnunciatorIlluminated_8=1
SystemAnnunciatorIlluminated_9=0
SystemAnnunciatorIlluminated_10=0
SystemAnnunciatorIlluminated_11=1
SystemAnnunciatorIlluminated_12=1
SystemAnnunciatorIlluminated_13=1
SystemAnnunciatorIlluminated_14=0
light_on_0=0
light_cautionState_0=0
light_on_1=0
light_cautionState_1=0
light_on_2=0
light_cautionState_2=0
light_on_3=0
light_cautionState_3=0
light_on_4=0
light_cautionState_4=0
light_on_5=0
light_cautionState_5=0
light_on_6=0
light_cautionState_6=0
light_on_7=0
light_cautionState_7=0
light_on_8=0
light_cautionState_8=0
light_on_9=0
light_cautionState_9=0
light_on_10=0
light_cautionState_10=0
light_on_11=0
light_cautionState_11=0
light_on_12=0
light_cautionState_12=0
light_on_13=0
light_cautionState_13=0
light_on_14=0
light_cautionState_14=0
light_on_15=1
light_cautionState_15=1
light_on_16=0
light_cautionState_16=0
light_on_17=0
light_cautionState_17=0
light_on_18=0
light_cautionState_18=0
light_on_19=0
light_cautionState_19=0
light_on_20=0
light_cautionState_20=0
light_on_21=0
light_cautionState_21=0
light_on_22=0
light_cautionState_22=0
light_on_23=0
light_cautionState_23=0
light_on_24=0
light_cautionState_24=0
light_on_25=1
light_cautionState_25=1
light_on_26=1
light_cautionState_26=1
light_on_27=1
light_cautionState_27=1
light_on_28=1
light_cautionState_28=1
light_on_29=1
light_cautionState_29=1
light_on_30=1
light_cautionState_30=1
light_on_31=1
light_cautionState_31=1
light_on_32=1
light_cautionState_32=1
light_on_33=0
light_cautionState_33=0
light_on_34=0
light_cautionState_34=0
light_on_35=0
light_cautionState_35=0
light_on_36=0
light_cautionState_36=0
light_on_37=0
light_cautionState_37=0
light_on_38=0
light_cautionState_38=0
light_on_39=0
light_cautionState_39=0
light_on_40=1
light_cautionState_40=1
light_on_41=0
light_cautionState_41=0
light_on_42=1
light_cautionState_42=1
light_on_43=1
light_cautionState_43=1
light_on_44=0
light_cautionState_44=0
light_on_45=1
light_cautionState_45=1
light_on_46=0
light_cautionState_46=0
light_on_47=0
light_cautionState_47=0
light_on_48=0
light_cautionState_48=0
light_on_49=0
light_cautionState_49=0
light_on_50=0
light_cautionState_50=0
light_on_51=0
light_cautionState_51=0
light_on_52=0
light_cautionState_52=0
light_on_53=0
light_cautionState_53=0
light_on_54=0
light_cautionState_54=0
light_on_55=0
light_cautionState_55=0
light_on_56=0
light_cautionState_56=0
light_on_57=0
light_cautionState_57=0
light_on_58=1
light_cautionState_58=1
light_on_59=1
light_cautionState_59=1
light_on_60=1
light_cautionState_60=1
light_on_61=0
light_cautionState_61=0
light_on_62=0
light_cautionState_62=0
light_on_63=0
light_cautionState_63=0
light_on_64=1
light_cautionState_64=2
light_on_65=1
light_cautionState_65=2
light_on_66=1
light_cautionState_66=2
light_on_67=0
light_cautionState_67=0
light_on_68=0
light_cautionState_68=0
light_on_69=0
light_cautionState_69=0
light_on_70=0
light_cautionState_70=0
light_on_71=0
light_cautionState_71=0
light_on_72=1
light_cautionState_72=1
light_on_73=1
light_cautionState_73=1
light_on_74=1
light_cautionState_74=1
light_on_75=0
light_cautionState_75=0
light_on_76=0
light_cautionState_76=0
light_on_77=0
light_cautionState_77=0
light_on_78=1
light_cautionState_78=2
light_on_79=1
light_cautionState_79=2
light_on_80=1
light_cautionState_80=2
light_on_81=1
light_cautionState_81=2
light_on_82=0
light_cautionState_82=0
light_on_83=0
light_cautionState_83=0
light_on_84=0
light_cautionState_84=0
light_on_85=0
light_cautionState_85=0
light_on_86=1
light_cautionState_86=1
light_on_87=1
light_cautionState_87=2
light_on_88=1
light_cautionState_88=2
light_on_89=1
light_cautionState_89=1
light_on_90=0
light_cautionState_90=0
light_on_91=0
light_cautionState_91=0
light_on_92=0
light_cautionState_92=0
light_on_93=0
light_cautionState_93=0
light_on_94=0
light_cautionState_94=0
light_on_95=0
light_cautionState_95=0
light_on_96=1
light_cautionState_96=1
light_on_97=1
light_cautionState_97=1
light_on_98=1
light_cautionState_98=2
light_on_99=0
light_cautionState_99=0
light_on_100=0
light_cautionState_100=0
light_on_101=0
light_cautionState_101=0
light_on_102=0
light_cautionState_102=0
light_on_103=0
light_cautionState_103=0
light_on_104=0
light_cautionState_104=0
light_on_105=0
light_cautionState_105=0
light_on_106=0
light_cautionState_106=0
light_on_107=0
light_cautionState_107=0
light_on_108=0
light_cautionState_108=0
light_on_109=0
light_cautionState_109=0
light_on_110=0
light_cautionState_110=0
light_on_111=0
light_cautionState_111=0
light_on_112=0
light_cautionState_112=0
light_on_113=0
light_cautionState_113=0
light_on_114=0
light_cautionState_114=0
light_on_115=0
light_cautionState_115=0
light_on_116=0
light_cautionState_116=0

[WarningTestPanel.0]
Flight Recorder Switch=0
Flight Recorder Switch  Guard=0

[WXRadar]
TFR.1=0
TFR.2=0
WX.1=1
WX.2=1
WX_T.1=0
WX_T.2=0
MAP.1=0
MAP.2=0
AUTO_Switch=1
L_R_Switch=0
TiltControl.1=11
TiltControl.2=11
GainControl.1=50
GainControl.2=50
PWSScanning=0

[ISFD]
Baro_is_in_HPA=0
Baro_HPa=1013.207275
Baro_InHg=29.920000
Baro_STD=0
Baro_preselecting=0
ApproachMode=0
Brightness=0.800000
zeroPitch=0.000000
zeroRoll=0.000000
BatteryLevel=0.000111 0.022741 0.000000 19150.044141
PoweredTimer=15.722213 15.722213 -1.000000 0 0
AttitudeAlignTimer=26395.039062 26395.039062 -1.000000 0 0
HighAccTimer=26395.039062 26395.039062 -1.000000 0 0
BaroPreselectTimer=26395.039062 26395.039062 -1.000000 0 0
NotAligned=0
Aligning=0
AlignPitch=0.000000
AlignRoll=0.000000

[AFS]
AfterTOTimer=26395.039062 26395.039062 -1.000000 0 0
AfterLNDTimer=26395.039062 26395.039062 -1.000000 0 0
FD1=0
FD2=0
APMode=0
iDEVT=0
bSplit=1
mFCC=9
AL=0
APP=0
TO=0
GA=0
ATArmed=0
ATGRD_D=0
ATMode=0
ATSpdHldMode=0
ATIAS=1000
ATMach=60
tgtIAS_TOGA=1000
ias_D=1000
AutoIAS=1
AutoMach=1
VNAV=0
VNAV_N1_In=1
APPitchMode=0
APPitchModeArmed=0
AltCapInhb=0
APAlt=100000
QFESel=0
APRollMode=0
APRollModeArmed=0
LocCapInhb=0
APHdg=0
FTD_C=0
FTD_O=0
HoT=0
APYawMode=0
FMSSpdCtrl=0
MCPDialIAS=10000
MCPDialHdg_C=0
MCPDialHdg_O=0
MCPBankLim=25
MCPDialVS=-1000000
MCPDialAlt=10000
MCPOBS_L=0
MCPOBS_R=0
TAAH=-1000000
TAAH_Asl=-1000000
FMA_AP=0
FMA_AT=0
FMAPitch=0
FMAPitchArmed=0
FMARoll=0
FMARollArmed=0
I_O=765
q_O=101388
FD_Split_Timer=26395.039062 26395.039062 -1.000000 0 0
FD_OldP=1000
FD_OldR=1000
Elev_Trim=1000

[Brakes]
Autobrakes Selector=1
BrakeTemp.00=10009
BrakeTempTgt.00=10009
BrakeTemp.01=10009
BrakeTempTgt.01=10009
BrakeTemp.02=10009
BrakeTempTgt.02=10009
BrakeTemp.03=10009
BrakeTempTgt.03=10009
RTO Self Test=0
PBRK Applied=0
Brake Accumulator Pressure=1946.394043
Brakes Applied Latch=0
Antiskid BIT Running=0
Start Velo=0.000000
BOL L=0
BOL R=0
ABS State=0
BT=0.000000 0.000000 -1.000000 1 0
RTOST=23772.541016 23772.541016 -1.000000 0 0
ASBIT=26395.039062 26395.039062 -1.000000 0 0
ABRBIT=26395.039062 26395.039062 -1.000000 0 0
AGST=26395.039062 26395.039062 -1.000000 0 0
Brake Temp Advisory=0
BMDT=26395.039062 26395.039062 -1.000000 0 0
Brake Message Flag=0
Chocks Set=1

[CDU.0]
Page=-1
Hint=0
LastData=0
LastFMCPage=-1
FMCState=0
isPowered=0
MenuVirtualPower=0
Disabled=0
WarmingUp=0
WarmCoolTimer=18.666656 20.722210 1200.000000 1 0
WarmUpBrightness=0.817953
FMCpowered=1
Brightness=0.850000

[CDUPage.6.0]
LastSubPage=0
MaxSubPage=0

[CDUPage.9.0]
ShowQRHSpds=1

[CDUPage.10.0]
engOut=0
LHSEngOut=0
RHSEngOut=0

[CDUPage.11.0]
engOut=0
LHSEngOut=0
RHSEngOut=0

[CDUPage.12.0]
PlannedDesPressed=0

[CDUPage.13.0]
InpWeight=-1000000.000000

[CDUPage.14.0]
parent=-1

[CDUPage.15.0]
parent=-1
Other=0
Airport=NONE 0 0.0 0.0
TermProcSelected=0
RwySelected=0
TransSelected=0

[CDUPage.16.0]
parent=-1
Other=0
isDep=1
Airport=NONE 0 0.0 0.0
StarSelected=0
StarTransSelected=0
AppSelected=0
AppTransSelected=0
RwySelected=0

[CDUPage.17.0]
LegsDataDispl=1
LastSubPage=0
MaxSubPage=0

[CDUPage.19.0]
FIX.0=NONE 0 0.0 0.0
Radial.0.0=-1000000.000000
Distance.0.0=-1000000.000000
Radial.0.1=-1000000.000000
Distance.0.1=-1000000.000000
Radial.0.2=-1000000.000000
Distance.0.2=-1000000.000000
FIX.1=NONE 0 0.0 0.0
Radial.1.0=-1000000.000000
Distance.1.0=-1000000.000000
Radial.1.1=-1000000.000000
Distance.1.1=-1000000.000000
Radial.1.2=-1000000.000000
Distance.1.2=-1000000.000000
FIX.2=NONE 0 0.0 0.0
Radial.2.0=-1000000.000000
Distance.2.0=-1000000.000000
Radial.2.1=-1000000.000000
Distance.2.1=-1000000.000000
Radial.2.2=-1000000.000000
Distance.2.2=-1000000.000000
FIX.3=NONE 0 0.0 0.0
Radial.3.0=-1000000.000000
Distance.3.0=-1000000.000000
Radial.3.1=-1000000.000000
Distance.3.1=-1000000.000000
Radial.3.2=-1000000.000000
Distance.3.2=-1000000.000000
FIX.4=NONE 0 0.0 0.0
Radial.4.0=-1000000.000000
Distance.4.0=-1000000.000000
Radial.4.1=-1000000.000000
Distance.4.1=-1000000.000000
Radial.4.2=-1000000.000000
Distance.4.2=-1000000.000000
FIX.5=NONE 0 0.0 0.0
Radial.5.0=-1000000.000000
Distance.5.0=-1000000.000000
Radial.5.1=-1000000.000000
Distance.5.1=-1000000.000000
Radial.5.2=-1000000.000000
Distance.5.2=-1000000.000000

[CDUPage.28.0]
Mode=0

[CDUPage.99.0]
SubPage=0

[CDUPage.100.0]
group=0
SubPage=0

[CDUPage.101.0]
calledFromGroupPage=0

[CDUPage.103.0]
group=0

[CDUPage.121.0]
SubPage=0

[CDUPage.122.0]
group=1481654620
SubPage=0

[Chronometer.0]
TimeMode=0
DateTimer=26395.039062 26395.039062 -1.000000 0 0
CHRTimer=26395.039062 26395.039062 -1.000000 0 0
ETTimer=26395.039062 26395.039062 -1.000000 0 0
ETResetTimer=26395.039062 26395.039062 -1.000000 0 0

[NoseWheelSteering]
Nose Wheel Steering Switch=1
Nose Wheel Steering Switch  Guard=0

[SidePanel.0]
ChartLight=0

[CDU.1]
Page=-1
Hint=0
LastData=0
LastFMCPage=-1
FMCState=0
isPowered=0
MenuVirtualPower=0
Disabled=0
WarmingUp=0
WarmCoolTimer=18892.544922 19567.265625 1020.000000 1 0
WarmUpBrightness=0.846404
FMCpowered=1
Brightness=0.850000

[CDUPage.6.1]
LastSubPage=0
MaxSubPage=0

[CDUPage.9.1]
ShowQRHSpds=1

[CDUPage.10.1]
engOut=0
LHSEngOut=0
RHSEngOut=0

[CDUPage.11.1]
engOut=0
LHSEngOut=0
RHSEngOut=0

[CDUPage.12.1]
PlannedDesPressed=0

[CDUPage.13.1]
InpWeight=-1000000.000000

[CDUPage.14.1]
parent=-1

[CDUPage.15.1]
parent=-1
Other=0
Airport=NONE 0 0.0 0.0
TermProcSelected=0
RwySelected=0
TransSelected=0

[CDUPage.16.1]
parent=-1
Other=0
isDep=0
Airport=NONE 0 0.0 0.0
StarSelected=0
StarTransSelected=0
AppSelected=0
AppTransSelected=0
RwySelected=0

[CDUPage.17.1]
LegsDataDispl=1
LastSubPage=0
MaxSubPage=0

[CDUPage.28.1]
Mode=0

[CDUPage.99.1]
SubPage=0

[CDUPage.100.1]
group=0
SubPage=0

[CDUPage.101.1]
calledFromGroupPage=0

[CDUPage.103.1]
group=0

[CDUPage.121.1]
SubPage=0

[CDUPage.122.1]
group=0
SubPage=0

[Chronometer.1]
TimeMode=0
DateTimer=26395.039062 26395.039062 -1.000000 0 0
CHRTimer=26395.039062 26395.039062 -1.000000 0 0
ETTimer=26395.039062 26395.039062 -1.000000 0 0
ETResetTimer=26395.039062 26395.039062 -1.000000 0 0

[SidePanel.1]
ChartLight=0

[GlassData]
FlapsRetractedAfterTakeoff=0
ApproachVrefEntered=0
V2=80
V2_Entered=0
";
    }
}
