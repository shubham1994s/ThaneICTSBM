using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwachBharat.CMS.Bll.ViewModels.ChildModel.Model
{
    public class HSDashBoardVM
    {
        public int AppId { get; set; }
        public string AppName { get; set; }
        public Nullable<int> TotalHouse { get; set; }
        public Nullable<int> TotalHouseUpdated { get; set; }
        public Nullable<int> TotalHouseUpdated_CurrentDay { get; set; }

        public Nullable<int> TotalPoint { get; set; }
        public Nullable<int> TotalPointUpdated { get; set; }
        public Nullable<int> TotalPointUpdated_CurrentDay { get; set; }
        public Nullable<int> TotalDump { get; set; }
        public Nullable<int> TotalDumpUpdated { get; set; }
        public Nullable<int> TotalDumpUpdated_CurrentDay { get; set; }


        public Nullable<int> TotalLiquid { get; set; }
        public Nullable<int> TotalLiquidUpdated { get; set; }
        public Nullable<int> TotalLiquidUpdated_CurrentDay { get; set; }


        public Nullable<int> TotalStreet { get; set; }
        public Nullable<int> TotalStreetUpdated { get; set; }
        public Nullable<int> TotalStreetUpdated_CurrentDay { get; set; }

     
        public Nullable<int> TotalBuildingUpdated { get; set; }
        public Nullable<int> TotalBuildingUpdated_CurrentDay { get; set; }

        public Nullable<int> TotalSlumUpdated { get; set; }
        public Nullable<int> TotalSlumUpdated_CurrentDay { get; set; }

        public Nullable<int> TotalResidentialUpdated { get; set; }
        public Nullable<int> TotalResidentialUpdated_CurrentDay { get; set; }

        public Nullable<int> TotalCommercialUpdated { get; set; }
        public Nullable<int> TotalCommercialUpdated_CurrentDay { get; set; }

        public Nullable<int> TotalSWMUpdated { get; set; }
        public Nullable<int> TotalSWMUpdated_CurrentDay { get; set; }

        public Nullable<int> TotalCTPTUpdated { get; set; }
        public Nullable<int> TotalCTPTUpdated_CurrentDay { get; set; }



    }

}
