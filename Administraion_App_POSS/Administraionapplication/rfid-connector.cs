using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidgets;
using Phidgets.Events;

namespace Administraionapplication
{
    class rfid_connector
    {
        
        public RFID myRFIDReader;
        public string Exception_error;
        public string output;
        public rfid_connector()
        {
            try
            {
                myRFIDReader = new RFID();
               
                myRFIDReader.Tag += new TagEventHandler(ProcessThisTag);
                
            }
            catch (PhidgetException) { Exception_error = "error at start-up."; }   

        }
         public bool OpenConnection()
        {
            try
            {
                myRFIDReader.open();
                myRFIDReader.waitForAttachment(3000);
               // listBox1.Items.Add("an RFID-reader is found and opened.");
                myRFIDReader.Antenna = true;
                myRFIDReader.LED = true;
                return true;
            }
            catch (PhidgetException) { Exception_error =  "no RFID-reader opened.";
            return false;
            }  
        }
         public void closeconnection()
         {
             myRFIDReader.LED = false;
             myRFIDReader.Antenna = false;
             myRFIDReader.close();
         }
         private void ProcessThisTag(object sender, TagEventArgs e)
         {
             
             output = e.Tag;
         }
    }
}
