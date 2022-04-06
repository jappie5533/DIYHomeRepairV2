//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DIY_v2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    public partial class Tasker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tasker()
        {
            this.TaskerComment = new HashSet<TaskerComment>();
            this.TaskerService = new HashSet<TaskerService>();
        }
    
        [DisplayName("師傅編號")]
        public int TaskerID { get; set; }

        [Required(ErrorMessage = "請填寫姓名")]
        [DisplayName("師傅姓名")]
        public string TaskerName { get; set; }

        [Required(ErrorMessage = "請填寫每趟的服務報價")]
        [Range(1, 30000, ErrorMessage = "報價必須介於1~30000")]
        [DisplayName("服務報價/趟")]
        public short ServiceQuote { get; set; }

        [Required(ErrorMessage = "請填寫連絡電話")]
        [DisplayName("連絡電話")]
        public string TaskerTel { get; set; }

        [Required(ErrorMessage = "請填寫師傅手機")]
        [DisplayName("師傅手機")]
        public string TaskerPhone { get; set; }

        [Required(ErrorMessage = "請填寫營業時間")]
        [DisplayName("營業時間")]
        public System.TimeSpan ServiceTime_Start { get; set; }

        [Required(ErrorMessage = "請填寫打烊時間")]
        [DisplayName("打烊時間")]
        public System.TimeSpan ServiceTime_End { get; set; }

        [Required(ErrorMessage = "請填寫服務地區")]
        [DisplayName("服務地區")]
        public string ServiceArea { get; set; }

        [DisplayName("師傅頭像")]
        public string TaskerImage { get; set; }

        [DisplayName("專業證照")]
        public string License { get; set; }

        [DisplayName("特色")]
        [StringLength(500, ErrorMessage = "特色內容請控制在50個字以內")]
        public string Feature { get; set; }

        [DisplayName("服務內容")]
        [StringLength(500, ErrorMessage = "服務內容請控制在500個字以內")]
        public string TaskerDescription { get; set; }

        [DisplayName("施工案例")]
        public string CaseImage { get; set; }

        [DisplayName("評價")]
        public Nullable<decimal> Rate { get; set; }

        [Required]
        public int MemberID { get; set; }

        [DisplayName("權限")]
        [Required]
        public string Permission { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskerComment> TaskerComment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaskerService> TaskerService { get; set; }
    }
}
