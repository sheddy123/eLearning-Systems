//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eLearningEntity.MODEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuestionXDuration
    {
        public int TestXQuestionsId { get; set; }
        public int Id { get; set; }
        public int RegistrationId { get; set; }
        public int TestXQuestionId { get; set; }
        public System.DateTime RequestTime { get; set; }
        public System.DateTime LeaveTime { get; set; }
        public System.DateTime AnsweredTime { get; set; }
    
        public virtual Registration Registration { get; set; }
        public virtual TestXQuestion TestXQuestion { get; set; }
    }
}
