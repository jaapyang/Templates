using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class GetMyAchievementResponse
    {
        public GetMyAchievementResponse() {
            QuestionBankEntries = new List<QuestionBankAchievementEntry>();
        }
        /// <summary>
        /// 会员等级
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 会员积分
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// 获得星星总数
        /// </summary>
        public int TotalStar { get; set; }
        /// <summary>
        /// 题库详情
        /// </summary>
        public List<QuestionBankAchievementEntry> QuestionBankEntries { get; set; }
    }

    public class QuestionBankAchievementEntry
    {
        /// <summary>
        /// 题库名
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 题库通关星星总数
        /// </summary>
        public int TotalStar { get; set; }
        /// <summary>
        /// 用户当前拥有的星星数量
        /// </summary>
        public int OwnedStar { get; set; }
        /// <summary>
        /// 题库ID
        /// </summary>
        public int QuestionBankID { get; set; }
    }
}
