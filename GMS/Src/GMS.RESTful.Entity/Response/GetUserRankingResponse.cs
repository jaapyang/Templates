using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class GetUserRankingResponse
    {
        public GetUserRankingResponse() {
            CurrentUserRanking = new UserRankingEntry();
            UserRankingEntries = new List<UserRankingEntry>();
        }
        /// <summary>
        /// 当前用户排名
        /// </summary>
        public UserRankingEntry CurrentUserRanking { get; set; }

        /// <summary>
        /// 用户排名列表
        /// </summary>
        public List<UserRankingEntry> UserRankingEntries { get; set; }

    }

    public class UserRankingEntry
    {
        /// <summary>
        /// 登录名
        /// </summary>        
        public string LoginName { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 排名序号
        /// </summary>       
        public int RankingNO { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public int Exp { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        public String AvatarUrl { get; set; }
        /// <summary>
        /// 游戏等级
        /// </summary>
        public int GameLevel { get; set; }
    }
}
