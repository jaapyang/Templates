using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class SaveUserMissionRequest
    {       
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 关卡ID
        /// </summary>
        public int MissionID { get; set; }  
        
        /// <summary>
        /// 所有的题目数量
        /// </summary>
        public int TotalQuestion { get; set; }        
        
        /// <summary>
        /// 答题详情
        /// </summary>
        public List<AnswerEntry> AnswerEntries { get; set; }

        /// <summary>
        /// 通关所用时间
        /// </summary>
        public int Seconds { get; set; }
    }

    /// <summary>
    /// 答题详情
    /// </summary>
    public class AnswerEntry {
        /// <summary>
        /// 问题ID
        /// </summary>
        public int QuestionID { get; set; }
        /// <summary>
        /// 答案
        /// </summary>
        public int Answer { get; set; }
        /// <summary>
        /// 结果
        /// </summary>
        public bool Result { get; set; }
    }
}
