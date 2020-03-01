﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSBA.Contracts;
using CSBA.DomainModels;
using CSBA.Contracts;
using CSBA.DataAccessLayer;


namespace CSBA.BusinessLogicLayer
{
    public class DraftPlayerBusinessLogicLayer : DraftPlayerIDALBLL
    {
        DraftPlayerDAL DAL = new DraftPlayerDAL();
        public List<sp_SeasonTeamDraft_Select_ResultDomainModel> DraftTeamList(int SeasonID)
        {
            return DAL.DraftTeamList(SeasonID).OrderBy(x => x.TeamName).ToList();
        }

        public PickAPlayerDomainModel PickAPLayer(int SeasonID)
        {
            return DAL.PickAPLayer(SeasonID);
        }

        public void DraftPlayer(SeasonTeamPlayerDomainModel STP)
        {
            DAL.DraftPlayer(STP);
        }

        public void TradePlayer(SeasonTeamPlayerDomainModel STP, int NewTeamID, int Points)
        {
            DAL.TradePlayer(STP, NewTeamID, Points);
        }
        
        public DraftStatusDomainModel DraftStatus(int SeasonID)
        {
            return DAL.DraftStatus(SeasonID);
        }


        public List<DraftPlayerDomainModel> DraftPositionStatus(int SeasonID, int iDrafted)
        {
            return DAL.DraftPositionStatus(SeasonID, iDrafted);
        }
    }
}
