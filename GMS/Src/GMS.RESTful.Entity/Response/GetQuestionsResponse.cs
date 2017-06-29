using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GMS.RESTful.Entity
{
    public class GetQuestionsResponse
    {
        public GetQuestionsResponse() {
            QuestionEntries = new List<QuestionEntry>();
        }
        /// <summary>
        /// 问题详情列表
        /// </summary>
        public List<QuestionEntry> QuestionEntries { get; set; }
    }

    public class QuestionEntry
    {
        /// <summary>
        /// 问题ID
        /// </summary>
        public int QuestionID { get; set; }
        /// <summary>
        /// 题目内容
        /// </summary>
        public String Topic { get; set; }  
        /// <summary>
        /// 最终答案
        /// </summary>
        public int Answer { get; set; }
        /// <summary>
        /// 试题解析
        /// </summary>
        public String Analysis { get; set; }
        /// <summary>
        /// 答案列表
        /// </summary>
        public String[] AnswerList { get; set; }
        /// <summary>
        /// 考点
        /// </summary>
        public String KnowledgePoint { get; set; }
    }
}
