using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;


using System.Drawing;

using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace SQLWriter
{
    class Process
    {
        public bool repsChosen = true;

        public bool days7Chosen = true;
        public bool days14Chosen = false;
        public bool days5by2Chosen = false;
        public bool days5by4Chosen = false;
        public bool days5by8Chosen = false;
        public bool days5by12Chosen = false;



        public int numSession = 100;
        public int numReps = 5000;
        public string query = "";
        public string patientGuid = "dedffe93-90f2-4d96-9710-6a715d37a788";

        public int BCIEnabled = 1;
        public int IsVolitionalEnabled = 0;
        public int BCITotalReps = 50;
        public int ActiveTotalReps = 50;

        string SessionFirstHalf = "INSERT INTO Session(id, SessionTableId, PatientId, DeviceID, IsScreen, SessionComplete, SessionStartTime, SessionDuration, GPSCoordinates, CalMeanSpectralSampleRest, CalStevSpectralSampleRest, CalMedianSpectralSampleRest, CalMedianSpectralSampleImagine, BCITotalRepetiations, BCITotalTime, BCISuccessOpenPct, BCISuccessClosePct, BCIMedianSpectralSampleImagine, BCIMedianSpectralSampleRest, PassiveSpasticityForce, BCICorrelationSpectralWCues, ActiveTotalRepetiations, ActiveTotalTime, ActiveROMOpen, ActiveROMClose, PassiveTotalRepetitions, PassiveTotalTime, EEGNumberOfResets, MaxOpenForce, MaxCloseForce, IsDeleted, DeleterUserId, CreationDateTime, CreatorUserId, LastModificationTime, ModifierUserId, SyncLocationId) VALUES(";
        string SessionSecHalf = "', '93a84db1-9922-4c43-b439-8247aa89f8b3', '0', '1', '1609248999.51', '00:00:48.6860567', '0,0,0', '0.0', '0.0', '0.0', '0.0', '5000', '00:00:00', '0.0', '0.0', '0.0', '0.0', '0.0', '0.0', '0', '00:06:00', '0.0', '0.0', '0', '00:12:00', '0', '0.0', '0.0', '0', '00000000-0000-0000-0000-000000000000', '1616511147.418', 'bf3a79b4-9f23-4a84-9bfa-33c5f3170764', '1609249048.197', '00000000-0000-0000-0000-000000000000', '8a39fb74-020d-4b50-9547-1b385dfcd3a9');\r\n";

        string sessionSettingFirstHalf = "INSERT INTO SessionSettings(id, SessionSettingTableId, SessionId, RightHandEnabled, EEGSensor, ControlFrequency, BCIBias, BCIGain, MotorOpenRange, CueLength, FidgetTime, BaselineLength, BCIEnabled, IsVolitionalEnabled, PassiveEnabled, FlexionEnabled, NumberOfSets, SessionDuration, NumberOfReps, NumberofBCIRepsPerSet, NumberofPassiveRepsPerSet, NumberofActiveRepsPerSet, BCISetOrder, PassiveSetOrder, ActiveSetOrder, ActiveOpenDifficulty, ActiveCloseDifficulty, VolitionalWaitTime, IsDeleted, DeleterUserId, CreationDateTime, CreatorUserId, LastModificationTime, ModifierUserId, SyncLocationId) VALUES(";
        string sessionSettingSecHalf = "','0','0','17','0.0','0.0','75','8','3','30','1','1','1','0','5','00:01:14.3422694','6','3','7','3','1','2','3','3000','3000','12','0','00000000-0000-0000-0000-000000000000','1604703682.646','fe69ab82-922c-42b9-ac10-8093ac890641','1604703682.647','00000000-0000-0000-0000-000000000000','8a39fb74-020d-4b50-9547-1b385dfcd3a9');\r\n";



        public string DumpText(string val) 
        {
            return val;
        }

        public string GenQuery() 
        {
            query = "";

            if (this.repsChosen == true)
                query = this.GenRepsQuery();
            else // genDateQuerys based on consitency groupbox
                query = this.GenConsistQuery() ;// "To be implemented next...";

            return query;
        }
        public void SaveFile(string val) 
        {
            TextWriter txt = new StreamWriter("SQLQuery.txt");
            txt.Write(val);
            txt.Close();
        }

        public string GenRepsQuery()
        {
            string query = "";
            
            int [] reps =  new int[numSession];
            for (int i = 0; i < numSession; i++) 
            {
                reps[i] = numReps / numSession;
                if (i == (numSession - 1)) 
                {
                    reps[i] += numReps % numSession;
                }
            }


            for (int i = 0; i < numSession; i++)
            {
                Guid sessionID = Guid.NewGuid();
                Guid sessSettingID = Guid.NewGuid();
                Guid sessionTableID = Guid.NewGuid();
                Guid SessionSettingTableId = Guid.NewGuid();

                if ((i % 2) == 0) 
                {
                    BCIEnabled = 1;
                    IsVolitionalEnabled = 0;
                    BCITotalReps = reps[i];
                    ActiveTotalReps = 0;
                }
                else
                {
                    BCIEnabled = 0;
                    IsVolitionalEnabled = 1;
                    BCITotalReps = 0; 
                    ActiveTotalReps = reps[i];
                }


                SessionSecHalf = $"'{sessionID}','{sessionTableID}','{patientGuid}', '93a84db1-9922-4c43-b439-8247aa89f8b3', '0', '1', '1609248999.51', '00:00:48.6860567', '0,0,0', '0.0', '0.0', '0.0', '0.0', '{BCITotalReps}', '00:00:00', '0.0', '0.0', '0.0', '0.0', '0.0', '0.0', '{ActiveTotalReps}', '00:06:00', '0.0', '0.0', '0', '00:12:00', '0', '0.0', '0.0', '0', null, '1616511147.418', 'bf3a79b4-9f23-4a84-9bfa-33c5f3170764', null, null, '8a39fb74-020d-4b50-9547-1b385dfcd3a9');\r\n";
                sessionSettingSecHalf = $"'{sessSettingID}','{SessionSettingTableId}','{sessionTableID}','0','0','17','0.0','0.0','75','8','3','30','{BCIEnabled}','{IsVolitionalEnabled}','1','0','5','00:01:14.3422694','6','3','7','3','1','2','3','3000','3000','12','0',null,'1604703682.646','fe69ab82-922c-42b9-ac10-8093ac890641',null,null,'8a39fb74-020d-4b50-9547-1b385dfcd3a9');\r\n";

                query = query + SessionFirstHalf  + SessionSecHalf;

                query = query + sessionSettingFirstHalf + sessionSettingSecHalf;
            }

            return query;
        }

        public string GenConsistQuery()
        {
            string query = "";
            int sessionIsScreen = 0;
            int  sessionComplete = 1;
            int skipdays = 0;

            DateTimeOffset now = DateTimeOffset.UtcNow;
            long nowInSeconds = now.ToUnixTimeMilliseconds() /1000;

            DateTimeOffset tomorrow = now.AddDays(1.0);
            long tomorrowMilli = tomorrow.ToUnixTimeMilliseconds() / 1000;  // dividing by 1000 converts to seconds 

            long oneDaySeconds = 86400;

            //query = unixTimeMilliseconds.ToString() + " " + tomorrowMilli.ToString();

            //query = ConvertDateTimetoMilli(today);

            if (days7Chosen == true)
            {
                numSession = 7;
            }
            if (days14Chosen == true)
            {
                numSession = 14;
                
            }
            if (days5by2Chosen == true) 
            {
                numSession = 10;
                skipdays = 2;
            }
            if (days5by4Chosen == true)
            {
                numSession = 20;
                skipdays = 2;
            }
            if (days5by8Chosen == true)
            {
                numSession = 40;
                skipdays = 2;
            }
            if (days5by12Chosen == true)
            {
                numSession = 60;
                skipdays = 2;
            }




            for (int i = 0; i < numSession; i++)
                {
                    Guid sessionID = Guid.NewGuid();
                    Guid sessSettingID = Guid.NewGuid();
                    Guid sessionTableID = Guid.NewGuid();
                    Guid SessionSettingTableId = Guid.NewGuid();

                //if ((i % 2) == 0)
                //{
                BCIEnabled = 1;
                        IsVolitionalEnabled = 0;
                        BCITotalReps = 50;
                        ActiveTotalReps = 0;
                   // }
                  //  else
                   // {
                    //    BCIEnabled = 0;
                   //     IsVolitionalEnabled = 1;
                    //    BCITotalReps = 0;
                     //   ActiveTotalReps = 50;
                    //}


                    SessionSecHalf = $"'{sessionID}','{sessionTableID}','{patientGuid}', '93a84db1-9922-4c43-b439-8247aa89f8b3', '{sessionIsScreen}', '{sessionComplete}', '{nowInSeconds}', '00:00:48.6860567', '0,0,0', '0.0', '0.0', '0.0', '0.0', '{BCITotalReps}', '00:00:00', '0.0', '0.0', '0.0', '0.0', '0.0', '0.0', '{ActiveTotalReps}', '00:06:00', '0.0', '0.0', '0', '00:12:00', '0', '0.0', '0.0', '0', null, '1616511147.418', 'bf3a79b4-9f23-4a84-9bfa-33c5f3170764', null, null, '8a39fb74-020d-4b50-9547-1b385dfcd3a9');\r\n";
                    sessionSettingSecHalf = $"'{sessSettingID}','{SessionSettingTableId}','{sessionTableID}','0','0','17','0.0','0.0','75','8','3','30','{BCIEnabled}','{IsVolitionalEnabled}','1','0','5','00:01:14.3422694','6','3','7','3','1','2','3','3000','3000','12','0',null,'1604703682.646','fe69ab82-922c-42b9-ac10-8093ac890641',null,null,'8a39fb74-020d-4b50-9547-1b385dfcd3a9');\r\n";

                    query = query + SessionFirstHalf + SessionSecHalf;

                    query = query + sessionSettingFirstHalf + sessionSettingSecHalf;

                    nowInSeconds -=   oneDaySeconds;

                    if ((i % 5) == 4)// after 5 days skip 2 days
                    {
                    nowInSeconds = nowInSeconds - skipdays * oneDaySeconds;
                    }
                }

            query = reverseQueryString(query);

            return query;
        
        }
        private string[] SplitStringByLineFeed(string inpString)
        {
            string[] locResult = Regex.Split(inpString, "[\r\n]+");
            return locResult;
        }
        public string reverseQueryString(string val) 
        {
            string[] strArray = SplitStringByLineFeed(val);
            string temp = "";
            int numLines = strArray.Length / 2;
            if (numLines > 2)
            {
                for (int i = numLines; i > 0; i--)
                {
                    temp = temp + strArray[2 * i - 2] + "\r\n"  + strArray[2*i - 1] + "\r\n";

                }
            }
            else
                temp = val;

            return temp;
        }

        public string ConvertDateTimetoMilli(DateTime val) 
        {
            string milliTime="";

           

            return milliTime;
        }

    }
}
