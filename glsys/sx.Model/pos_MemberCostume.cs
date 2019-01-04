using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using NDolls.Data.Attribute;
using NDolls.Data.Entity;
namespace sx.Model
{
    [Entity("pos_MemberCostume", "ID")]
    public class pos_MemberCostume : EntityBase
    {

        /// <summary>
        /// ID
        /// </summary>		
        [DataField("ID", "nvarchar")]
        [Validate("不允许为空")]
        public string ID { get; set; }

        /// <summary>
        /// Size
        /// </summary>		
        [DataField("Size", "nvarchar")]
        public string Size { get; set; }

        /// <summary>
        /// Style
        /// </summary>		
        [DataField("Style", "nvarchar")]
        public string Style { get; set; }

        /// <summary>
        /// Feedback
        /// </summary>		
        [DataField("Feedback", "nvarchar")]
        public string Feedback { get; set; }

        /// <summary>
        /// Status
        /// </summary>		
        [DataField("Status", "int")]
        public int Status { get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>		
        [DataField("CreateTime", "datetime")]
        public DateTime CreateTime { get; set; }

        /// <summary>
        /// UpdateTime
        /// </summary>		
        [DataField("UpdateTime", "datetime")]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// Memo
        /// </summary>		
        [DataField("Memo", "nvarchar")]
        public string Memo { get; set; }

    }
}