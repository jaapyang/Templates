using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class GetUserMissionsResponse
    {
        public GetUserMissionsResponse() {
            MissionEntries = new List<MissionEntry>();
        }
        
        /// <summary>
        /// 星星总数
        /// </summary>
        public int TotalStar { get; set; }
        /// <summary>
        /// 用户拥有的星星总数
        /// </summary>
        public int OwnedStar { get; set; }   
        /// <summary>
        /// 用户玩的最新关卡ID
        /// </summary>
        public int LastedMissionID { get; set; }
        /// <summary>
        /// 用户玩的最新关卡名
        /// </summary>
        public String LastedMissionName { get; set; }
        /// <summary>
        /// 关卡详情列表
        /// </summary>
        public List<MissionEntry> MissionEntries { get; set; }
    }

    public class MissionEntry
    {
        /// <summary>
        /// 关卡名
        /// </summary>
        public String Name { get; set; }   
        /// <summary>
        /// 用户通关获得的星星数量
        /// </summary>
        public int Star { get; set; }
        /// <summary>
        /// 关卡ID
        /// </summary>
        public int MissionID { get; set; }
        /// <summary>
        /// 关卡排序号
        /// </summary>
        public int OrderNO { get; set; }
        /// <summary>
        /// 通关所用时间
        /// </summary>
        public int Seconds { get; set; }
    }
}
