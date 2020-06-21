using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.Entity
{
    public class JudgeInfo
    {
        private int questionNum;
        private int questionErrorNum;
        private DateTime? lastestCompleteTime;

        public JudgeInfo(int questionNum, int questionErrorNum, DateTime? lastestCompleteTime)
        {
            this.questionNum = questionNum;
            this.questionErrorNum = questionErrorNum;
            this.lastestCompleteTime = lastestCompleteTime;
        }

        public int QuestionNum { get => questionNum; set => questionNum = value; }
        public int QuestionErrorNum { get => questionErrorNum; set => questionErrorNum = value; }
        public float CorrectRate { get => questionNum == 0 ? 0f : 1f - (float)questionErrorNum / (float)questionNum; }
        public float ErrorRate { get => questionNum == 0 ? 0f : (float)questionErrorNum / (float)questionNum; }
        public DateTime? LastestCompleteTime { get => lastestCompleteTime; set => lastestCompleteTime = value; }
    }
}