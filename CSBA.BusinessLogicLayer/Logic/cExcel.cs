using System;
using System.Collections.Generic;
using CSBA.BusinessLogicLayer;
using CSBA.DomainModels;
using Microsoft.Office.Interop.Excel;

using Excel = Microsoft.Office.Interop.Excel;



namespace CSBA.BusinessLogicLayer.Logic
{
    public class cExcel
    {
        

        public static string CreateSpreadsheet(int iSeasonID)
        {
            SeasonDomainModel season = new SeasonDomainModel();
            season.SeasonID = iSeasonID;
            SeasonTeamBusinessLogic stBLL = new SeasonTeamBusinessLogic();
            SeasonTeamPlayerPositionBLL stppBLL = new SeasonTeamPlayerPositionBLL();
            List<SeasonTeamDomainModel> listSeasonTeam = stBLL.ListSelectedTeams(season.SeasonID);
            List<SeasonTeamPlayerDomainModel> listSeasonTeamPlayer = new List<SeasonTeamPlayerDomainModel>();
            TeamDomainModel team = new TeamDomainModel();
            Excel.Application xlApp = new Excel.Application();
            Workbook wb = xlApp.Workbooks.Add();

            for (int i = 0; i < listSeasonTeam.Count; i++)
            {
                Worksheet sh = wb.Worksheets.Add();
                xlApp.ActiveWindow.Zoom = 140;
                SeasonTeamDomainModel st = listSeasonTeam[i];

                team.TeamID = st.TeamID;
                List<SeasonTeamPlayerPositionDomainModel> stpList = stppBLL.STPP_Detail(season, team);
                sh.Name = st.TeamName.Trim();

                int rowNbr = 1;
                sh.Cells[rowNbr, "A"].Value2 = "Player Name";
                sh.Cells[rowNbr, "A"].ColumnWidth = 30;
                sh.Cells[rowNbr, "B"].Value2 = "Position";
                sh.Cells[rowNbr, "A"].ColumnWidth = 20;
                sh.Cells[rowNbr, "C"].Value2 = "Points";
                sh.Cells[rowNbr, "A"].ColumnWidth = 20;

                sh.Cells[rowNbr, "A"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                sh.Cells[rowNbr, "B"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
                sh.Cells[rowNbr, "C"].Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;

                var columnHeadingsRange = sh.Range[sh.Cells[rowNbr, "A"], sh.Cells[rowNbr, "C"]];
                columnHeadingsRange.Interior.Color = XlRgbColor.rgbSkyBlue;
                columnHeadingsRange.Font.Color = XlRgbColor.rgbWhite;

                rowNbr++;

                foreach (SeasonTeamPlayerPositionDomainModel stp in stpList)
                {
                    sh.Cells[rowNbr, "A"].Value2 = stp.PlayerName.Trim();
                    sh.Cells[rowNbr, "B"].Value2 = stp.PositionName.Trim();
                    sh.Cells[rowNbr, "C"].Value2 = stp.Points;
                    rowNbr++;
                }
            }

            xlApp.DisplayAlerts = false;
            for (int i = xlApp.ActiveWorkbook.Worksheets.Count; i > 0; i--)
            {
                Worksheet wkSheet = (Worksheet)xlApp.ActiveWorkbook.Worksheets[i];
                if (wkSheet.Name == "Sheet1")
                {
                    wkSheet.Delete();
                }
            }
            xlApp.DisplayAlerts = true;

            
            Random random = new  Random();
            int randomNumber = random.Next(0, 10000);
            string path = AppDomain.CurrentDomain.BaseDirectory;

            string CWorkbook = path +  randomNumber + ".xlsx ";
            wb.Application.ActiveWorkbook.CheckCompatibility = false;
            wb.Application.ActiveWorkbook.SaveAs(CWorkbook, Excel.XlFileFormat.xlOpenXMLWorkbook);

            wb.Close(true);

            xlApp.Quit();

            return CWorkbook;

        }

    }
}