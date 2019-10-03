using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static InciOneSoft.Common.Constants;


namespace InciOneSoft.DAL.Entities
{
    [Table("FileData")]
    public class FileData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [ForeignKey("FileInfoId")]
        public int FileInfoId { get; set; }

        public FileInfo FileInfo { get; set; }
        public string ClientPayeur { get; set; }

        public int CodeClient { get; set; }

        public int CodeTiers { get; set; }

        public int NumeroV1 { get; set; }

        public DateTime DateFacture { get; set; }

        public DateTime DateEcheance { get; set; }

        public string Type { get; set; }

        public string Activite { get; set; }

        public string ModeReglement { get; set; }

        public double TTC { get; set; }

        public double MontantDu { get; set; }

        public bool Teletransmissable { get; set; }

        public double DuRo { get; set; }

        public double PartRo { get; set; }

        public string EtatT1 { get; set; }

        public double DuRc { get; set; }

        public double PartRc { get; set; }

        public string EtatT2 { get; set; }

        public double DuClient { get; set; }

        public double PartClient { get; set; }

        public string Ets { get; set; }

        public string ClientLivre { get; set; }

        public string AgentCommercial { get; set; }

        public DateTime DebutLoc1 { get; set; }

        public DateTime FinLoc1 { set; get; }

        public string OrgAmo { set; get; }

        public string OrgAmc { set; get; }

        public DateTime PremiereRelanceClient { get; set; }

        public DateTime DeuxiemeRelanceClient { get; set; }

        public DateTime TroisiemeRelanceClient { get; set; }

        public DateTime PremiereRelanceAmo { get; set; }

        public DateTime DeuxiemeRelanceAmo { get; set; }

        public DateTime TroisiemeRelanceAmo { get; set; }

        public DateTime PremiereRelanceAmc { get; set; }

        public DateTime DeuxiemeRelanceAmc { get; set; }

        public DateTime TroisiemeRelanceAmc { get; set; }

        public double MontantRegle { get; set; }

        public DateTime DateReglemet { get; set; }

        public int DelaiReglemet { get; set; }

        public int DepasseEcheance { get; set; }

    }
}
