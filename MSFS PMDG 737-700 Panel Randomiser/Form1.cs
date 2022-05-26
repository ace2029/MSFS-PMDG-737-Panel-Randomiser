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

        public class randCheck
        {
            public bool checkBool(int hScrollVal, string checkVal, string newVal)
            {
                string panelStateFolder = @"..\pmdg-aircraft-737\Config\PanelState\";
                string randomPanelFile = "RandPanel.sav";
                RandomGenerator randResult = new RandomGenerator();
                bool boolVal = randResult.randBool(hScrollVal);
                if (boolVal == true)
                {                    
                    string strFile = File.ReadAllText(panelStateFolder + randomPanelFile);
                    strFile = strFile.Replace(checkVal, newVal);
                    File.WriteAllText(panelStateFolder + randomPanelFile, strFile);
                }



                return true;
            }
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            // *************************************************************************
            // Set up paths, check for file existence and working directory
            // *************************************************************************

            // Set the path for the required Community directory and the first PMDG folder
            string root = @"..\pmdg-aircraft-737";

            // Check to see if we are running in the correct location
            if (!Directory.Exists(root))
            {
                MessageBox.Show("Application needs to be in a folder WITHIN the MSFS Community folder. Please check, relocate and try again.");
                return;
            }

            // Set the path for the PMDG panel state folder in COMMUNITY
            string panelStateFolder = @"..\pmdg-aircraft-737\Config\PanelState\";
            string randomPanelFile = "RandPanel.sav";

            // Check to see if the random panel file already exists in the folder
            if (File.Exists(panelStateFolder + randomPanelFile))
            {
                // Delete the existing file
                File.Delete(panelStateFolder + randomPanelFile);
            }

            // Set the path for the PMDG WORK folder containing live panel states
            string livePMDGStateFolder = @"%userprofile%\appdata\local\packages\Microsoft.FlightSimulator_8wekyb3d8bbwe\LocalState\packages\pmdg-aircraft-737\work\PanelState\RandPanel.sav";
            var filePath = Environment.ExpandEnvironmentVariables(livePMDGStateFolder);
            // Check to see if there is a live RandPanel.sav file and delete if so
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            coldAndDarkTemplate templateFile = new coldAndDarkTemplate();
            string templateString = templateFile.cADTemp;
            File.WriteAllText(panelStateFolder + randomPanelFile, templateString);




            // *************************************************************************
            // start of the switch amendment portion
            // *************************************************************************

            string checkItem = "";
            string newItem = "";
            int barVal = hScrollBar1.Value;
            
            // Eng Pump Switch A=1
            checkItem = "Eng Pump Switch A=1";
            newItem = "Eng Pump Switch A=0";            
            randCheck check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Eng Pump Switch B=1
            checkItem = "Eng Pump Switch B=1";
            newItem = "Eng Pump Switch B=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // GALLEY Switch=1
            checkItem = "GALLEY Switch=1";
            newItem = "GALLEY Switch=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Recirc Fan Switch L=1
            checkItem = "Recirc Fan Switch L=1";
            newItem = "Recirc Fan Switch L=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Recirc Fan Switch R=1
            checkItem = "Recirc Fan Switch R=1";
            newItem = "Recirc Fan Switch R=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Cabin Press Mode Selector=0
            checkItem = "Cabin Press Mode Selector=0";
            newItem = "Cabin Press Mode Selector=2";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Bleed Air Switch L=1
            checkItem = "Bleed Air Switch L=1";
            newItem = "Bleed Air Switch L=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Bleed Air Switch R=1
            checkItem = "Bleed Air Switch R=1";
            newItem = "Bleed Air Switch R=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // APU Bleed Air Switch=0
            checkItem = "APU Bleed Air Switch=0";
            newItem = "APU Bleed Air Switch=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // L Wiper Control=0
            checkItem = "L Wiper Control=0";
            newItem = "L Wiper Control=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // R Wiper Control=0
            checkItem = "R Wiper Control=0";
            newItem = "R Wiper Control=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Pack Switch L=0
            checkItem = "Pack Switch L=0";
            newItem = "Pack Switch L=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Pack Switch R=0
            checkItem = "Pack Switch R=0";
            newItem = "Pack Switch R=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Gear Lever=6
            checkItem = "Gear Lever=6";
            newItem = "Gear Lever=3";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Left Inbd DU Brightness=255
            checkItem = "Left Inbd DU Brightness=255";
            newItem = "Left Inbd DU Brightness=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Left Inbd DU Inner Brightness=255
            checkItem = "Left Inbd DU Inner Brightness=255";
            newItem = "Left Inbd DU Inner Brightness=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Dome Light Switch=1
            checkItem = "Dome Light Switch=1";
            newItem = "Dome Light Switch=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Left Outbd DU Brightness=255
            checkItem = "Left Outbd DU Brightness=255";
            newItem = "Left Outbd DU Brightness=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Pump Switch 1 Fwd=0
            checkItem = "Pump Switch 1 Fwd=0";
            newItem = "Pump Switch 1 Fwd=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Pump Switch 2 Fwd=0
            checkItem = "Pump Switch 2 Fwd=0";
            newItem = "Pump Switch 2 Fwd=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Pump Switch 1 Aft=0
            checkItem = "Pump Switch 1 Aft=0";
            newItem = "Pump Switch 1 Aft=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Pump Switch 2 Aft=0
            checkItem = "Pump Switch 2 Aft=0";
            newItem = "Pump Switch 2 Aft=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Pump Switch Left Center=0
            checkItem = "Pump Switch Left Center=0";
            newItem = "Pump Switch Left Center=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Pump Switch Right Center=0
            checkItem = "Pump Switch Right Center=0";
            newItem = "Pump Switch Right Center=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // CONT Temp Selector=115
            checkItem = "CONT Temp Selector=115";
            newItem = "CONT Temp Selector=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // PASS Temp Selector=115
            checkItem = "PASS Temp Selector=115";
            newItem = "PASS Temp Selector=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Taxi Light=0
            checkItem = "Taxi Light=0";
            newItem = "Taxi Light=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Logo Light=0
            checkItem = "Logo Light=0";
            newItem = "Logo Light=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Anti Collision Light=0
            checkItem = "Anti Collision Light=0";
            newItem = "Anti Collision Light=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // Wing Light=0
            checkItem = "Wing Light=0";
            newItem = "Wing Light=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // 
            checkItem = "Wheel Well Light=0";
            newItem = "Wheel Well Light=1";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // 
            checkItem = "Autobrakes Selector=1";
            newItem = "Autobrakes Selector=0";
            check = new randCheck();
            check.checkBool(barVal, checkItem, newItem);

            // TEMPLATE
            // checkItem = "";
            // newItem = "";
            // check = new randCheck();
            // check.checkBool(barVal, checkItem, newItem);

            MessageBox.Show("Panel randomisation complete. Enjoy your flight!");
            
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
            int chanceVal = 0 + percentChance;
            var rndInt = new Random();
            int randNumber = rndInt.Next(100);
            if (chanceVal > randNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
