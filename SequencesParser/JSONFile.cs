using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencesParser
{


    public class Rootobject
    {
        private BioseqSet bioseqset;

        public BioseqSet Bioseqset { get => bioseqset; set => bioseqset = value; }

    }

    public class BioseqSet
    {
        private BioseqSet_SeqSet bioseqset_seqset;

        public BioseqSet_SeqSet Bioseqset_seqset { get => bioseqset_seqset; set => bioseqset_seqset = value; }
    }

    public class BioseqSet_SeqSet
    {
        private SeqEntry seqentry;

        public SeqEntry Seqentry { get => seqentry; set => seqentry = value; }
    }

    public class SeqEntry
    {
        private SeqEntry_Set seqentry_set;

        public SeqEntry_Set Seqentry_set { get => seqentry_set; set => seqentry_set = value; }
    }

    public class SeqEntry_Set
    {
        private BioseqSet1 bioseqset;

        public BioseqSet1 Bioseqset { get => bioseqset; set => bioseqset = value; }
    }

    public class BioseqSet1
    {
        private BioseqSet_Class bioseqset_class;
        private BioseqSet_Descr bioseqset_descr;

        public BioseqSet_Class Bioseqset_class { get => bioseqset_class; set => bioseqset_class = value; }
        public BioseqSet_Descr Bioseqset_descr { get => bioseqset_descr; set => bioseqset_descr = value; }
        public BioseqSet_SeqSet1 Bioseqset_seqset { get; set; }
        public BioseqSet_Annot Bioseqset_annot { get; set; }
    }

    public class BioseqSet_Class
    {
        public string value { get; set; }
    }

    public class BioseqSet_Descr
    {
        public SeqDescr Seqdescr { get; set; }
    }

    public class SeqDescr
    {
        public Seqdesc[] Seqdesc { get; set; }
    }

    public class Seqdesc
    {
        public Seqdesc_Source Seqdesc_source { get; set; }
        public Seqdesc_Pub Seqdesc_pub { get; set; }
        public string Seqdesc_comment { get; set; }
        public Seqdesc_User Seqdesc_user { get; set; }
        public Seqdesc_UpdateDate Seqdesc_updatedate { get; set; }
    }

    public class Seqdesc_Source
    {
        public Biosource BioSource { get; set; }
    }

    public class Biosource
    {
        public Biosource_Genome BioSource_genome { get; set; }
        public Biosource_Org BioSource_org { get; set; }
        public Biosource_Subtype BioSource_subtype { get; set; }
    }

    public class Biosource_Genome
    {
        public string value { get; set; }
        public string text { get; set; }
    }

    public class Biosource_Org
    {
        public OrgRef Orgref { get; set; }
    }

    public class OrgRef
    {
        public string Orgref_taxname { get; set; }
        public OrgRef_Db Orgref_db { get; set; }
        public OrgRef_Orgname Orgref_orgname { get; set; }
    }

    public class OrgRef_Db
    {
        public Dbtag Dbtag { get; set; }
    }

    public class Dbtag
    {
        public string Dbtag_db { get; set; }
        public Dbtag_Tag Dbtag_tag { get; set; }
    }

    public class Dbtag_Tag
    {
        public ObjectId Objectid { get; set; }
    }

    public class ObjectId
    {
        public string Objectid_id { get; set; }
    }

    public class OrgRef_Orgname
    {
        public Orgname OrgName { get; set; }
    }

    public class Orgname
    {
        public Orgname_Name OrgName_name { get; set; }
        public string OrgName_attrib { get; set; }
        public Orgname_Mod OrgName_mod { get; set; }
        public string OrgName_lineage { get; set; }
        public string OrgName_gcode { get; set; }
        public string OrgName_div { get; set; }
    }

    public class Orgname_Name
    {
        public string OrgName_name_virus { get; set; }
    }

    public class Orgname_Mod
    {
        public Orgmod[] OrgMod { get; set; }
    }

    public class Orgmod
    {
        public Orgmod_Subtype OrgMod_subtype { get; set; }
        public string OrgMod_subname { get; set; }
    }

    public class Orgmod_Subtype
    {
        public string value { get; set; }
        public string text { get; set; }
    }

    public class Biosource_Subtype
    {
        public Subsource[] SubSource { get; set; }
    }

    public class Subsource
    {
        public Subsource_Subtype SubSource_subtype { get; set; }
        public string SubSource_name { get; set; }
    }

    public class Subsource_Subtype
    {
        public string value { get; set; }
        public string text { get; set; }
    }

    public class Seqdesc_Pub
    {
        public Pubdesc Pubdesc { get; set; }
    }

    public class Pubdesc
    {
        public Pubdesc_Pub Pubdesc_pub { get; set; }
    }

    public class Pubdesc_Pub
    {
        public PubEquiv Pubequiv { get; set; }
    }

    public class PubEquiv
    {
        public Pub Pub { get; set; }
    }

    public class Pub
    {
        public Pub_Gen Pub_gen { get; set; }
        public Pub_Sub Pub_sub { get; set; }
    }

    public class Pub_Gen
    {
        public CitGen Citgen { get; set; }
    }

    public class CitGen
    {
        public string Citgen_cit { get; set; }
        public CitGen_Authors Citgen_authors { get; set; }
        public string Citgen_title { get; set; }
    }

    public class CitGen_Authors
    {
        public AuthList Authlist { get; set; }
    }

    public class AuthList
    {
        public AuthList_Names Authlist_names { get; set; }
    }

    public class AuthList_Names
    {
        public AuthList_Names_Std Authlist_names_std { get; set; }
    }

    public class AuthList_Names_Std
    {
        public Author[] Author { get; set; }
    }

    public class Author
    {
        public Author_Name Author_name { get; set; }
    }

    public class Author_Name
    {
        public PersonId Personid { get; set; }
    }

    public class PersonId
    {
        public PersonId_Name Personid_name { get; set; }
    }

    public class PersonId_Name
    {
        public NameStd Namestd { get; set; }
    }

    public class NameStd
    {
        public string Namestd_last { get; set; }
        public string Namestd_first { get; set; }
        public string Namestd_initials { get; set; }
    }

    public class Pub_Sub
    {
        public CitSub Citsub { get; set; }
    }

    public class CitSub
    {
        public CitSub_Authors Citsub_authors { get; set; }
        public CitSub_Medium Citsub_medium { get; set; }
        public CitSub_Date Citsub_date { get; set; }
    }

    public class CitSub_Authors
    {
        public AuthList1 Authlist { get; set; }
    }

    public class AuthList1
    {
        public AuthList_Names1 Authlist_names { get; set; }
        public AuthList_Affil Authlist_affil { get; set; }
    }

    public class AuthList_Names1
    {
        public AuthList_Names_Std1 Authlist_names_std { get; set; }
    }

    public class AuthList_Names_Std1
    {
        public object Author { get; set; }
    }

    public class AuthList_Affil
    {
        public Affil Affil { get; set; }
    }

    public class Affil
    {
        public Affil_Std Affil_std { get; set; }
    }

    public class Affil_Std
    {
        public string Affil_std_affil { get; set; }
        public string Affil_std_div { get; set; }
        public string Affil_std_city { get; set; }
        public string Affil_std_country { get; set; }
        public string Affil_std_sub { get; set; }
        public string Affil_std_postalcode { get; set; }
    }

    public class CitSub_Medium
    {
        public string value { get; set; }
    }

    public class CitSub_Date
    {
        public Date Date { get; set; }
    }

    public class Date
    {
        public Date_Std Date_std { get; set; }
    }

    public class Date_Std
    {
        public DateStd Datestd { get; set; }
    }

    public class DateStd
    {
        public string Datestd_year { get; set; }
        public string Datestd_month { get; set; }
        public string Datestd_day { get; set; }
    }

    public class Seqdesc_User
    {
        public UserObject Userobject { get; set; }
    }

    public class UserObject
    {
        public UserObject_Type Userobject_type { get; set; }
        public UserObject_Data Userobject_data { get; set; }
    }

    public class UserObject_Type
    {
        public ObjectId1 Objectid { get; set; }
    }

    public class ObjectId1
    {
        public string Objectid_str { get; set; }
    }

    public class UserObject_Data
    {
        public object Userfield { get; set; }
    }

    public class Seqdesc_UpdateDate
    {
        public Date1 Date { get; set; }
    }

    public class Date1
    {
        public Date_Std1 Date_std { get; set; }
    }

    public class Date_Std1
    {
        public DateStd1 Datestd { get; set; }
    }

    public class DateStd1
    {
        public string Datestd_year { get; set; }
        public string Datestd_month { get; set; }
        public string Datestd_day { get; set; }
    }

    public class BioseqSet_SeqSet1
    {
        public SeqEntry1[] Seqentry { get; set; }
    }

    public class SeqEntry1
    {
        public SeqEntry_Seq Seqentry_seq { get; set; }
    }

    public class SeqEntry_Seq
    {
        public Bioseq Bioseq { get; set; }
    }

    public class Bioseq
    {
        public Bioseq_Id Bioseq_id { get; set; }
        public Bioseq_Descr Bioseq_descr { get; set; }
        public Bioseq_Inst Bioseq_inst { get; set; }
        public Bioseq_Annot Bioseq_annot { get; set; }
    }

    public class Bioseq_Id
    {
        public SeqId[] Seqid { get; set; }
    }

    public class SeqId
    {
        public SeqId_Other Seqid_other { get; set; }
        public string Seqid_gi { get; set; }
    }

    public class SeqId_Other
    {
        public TextseqId Textseqid { get; set; }
    }

    public class TextseqId
    {
        public string Textseqid_accession { get; set; }
        public string Textseqid_version { get; set; }
    }

    public class Bioseq_Descr
    {
        public SeqDescr1 Seqdescr { get; set; }
    }

    public class SeqDescr1
    {
        public Seqdesc1[] Seqdesc { get; set; }
    }

    public class Seqdesc1
    {
        public string Seqdesc_title { get; set; }
        public Seqdesc_Molinfo Seqdesc_molinfo { get; set; }
        public Seqdesc_User1 Seqdesc_user { get; set; }
        public Seqdesc_CreateDate Seqdesc_createdate { get; set; }
    }

    public class Seqdesc_Molinfo
    {
        public Molinfo MolInfo { get; set; }
    }

    public class Molinfo
    {
        public Molinfo_Biomol MolInfo_biomol { get; set; }
        public Molinfo_Completeness MolInfo_completeness { get; set; }
        public Molinfo_Tech MolInfo_tech { get; set; }
    }

    public class Molinfo_Biomol
    {
        public string value { get; set; }
        public string text { get; set; }
    }

    public class Molinfo_Completeness
    {
        public string value { get; set; }
        public string text { get; set; }
    }

    public class Molinfo_Tech
    {
        public string value { get; set; }
        public string text { get; set; }
    }

    public class Seqdesc_User1
    {
        public UserObject1 Userobject { get; set; }
    }

    public class UserObject1
    {
        public string Userobject_class { get; set; }
        public UserObject_Type1 Userobject_type { get; set; }
        public UserObject_Data1 Userobject_data { get; set; }
    }

    public class UserObject_Type1
    {
        public ObjectId2 Objectid { get; set; }
    }

    public class ObjectId2
    {
        public string Objectid_str { get; set; }
    }

    public class UserObject_Data1
    {
        public object Userfield { get; set; }
    }

    public class Seqdesc_CreateDate
    {
        public Date2 Date { get; set; }
    }

    public class Date2
    {
        public Date_Std2 Date_std { get; set; }
    }

    public class Date_Std2
    {
        public DateStd2 Datestd { get; set; }
    }

    public class DateStd2
    {
        public string Datestd_year { get; set; }
        public string Datestd_month { get; set; }
        public string Datestd_day { get; set; }
    }

    public class Bioseq_Inst
    {
        public SeqInst Seqinst { get; set; }
    }

    public class SeqInst
    {
        public SeqInst_Repr Seqinst_repr { get; set; }
        public SeqInst_Mol Seqinst_mol { get; set; }
        public string Seqinst_length { get; set; }
        public SeqInst_Strand Seqinst_strand { get; set; }
        public SeqInst_SeqData Seqinst_seqdata { get; set; }
        public SeqInst_Hist Seqinst_hist { get; set; }
    }

    public class SeqInst_Repr
    {
        public string value { get; set; }
    }

    public class SeqInst_Mol
    {
        public string value { get; set; }
    }

    public class SeqInst_Strand
    {
        public string value { get; set; }
    }

    public class SeqInst_SeqData
    {
        public SeqData Seqdata { get; set; }
    }

    public class SeqData
    {
        public SeqData_Ncbi2na Seqdata_ncbi2na { get; set; }
        public SeqData_Ncbieaa Seqdata_ncbieaa { get; set; }
    }

    public class SeqData_Ncbi2na
    {
        public string NCBI2na { get; set; }
    }

    public class SeqData_Ncbieaa
    {
        public string NCBIeaa { get; set; }
    }

    public class SeqInst_Hist
    {
        public SeqHist Seqhist { get; set; }
    }

    public class SeqHist
    {
        public SeqHist_Replaces Seqhist_replaces { get; set; }
    }

    public class SeqHist_Replaces
    {
        public SeqHistRec Seqhistrec { get; set; }
    }

    public class SeqHistRec
    {
        public SeqHistRec_Date Seqhistrec_date { get; set; }
        public SeqHistRec_Ids Seqhistrec_ids { get; set; }
    }

    public class SeqHistRec_Date
    {
        public Date3 Date { get; set; }
    }

    public class Date3
    {
        public Date_Std3 Date_std { get; set; }
    }

    public class Date_Std3
    {
        public DateStd3 Datestd { get; set; }
    }

    public class DateStd3
    {
        public string Datestd_year { get; set; }
        public string Datestd_month { get; set; }
        public string Datestd_day { get; set; }
    }

    public class SeqHistRec_Ids
    {
        public SeqId1 Seqid { get; set; }
    }

    public class SeqId1
    {
        public string Seqid_gi { get; set; }
    }

    public class Bioseq_Annot
    {
        public SeqAnnot Seqannot { get; set; }
    }

    public class SeqAnnot
    {
        public SeqAnnot_Data Seqannot_data { get; set; }
    }

    public class SeqAnnot_Data
    {
        public SeqAnnot_Data_Ftable Seqannot_data_ftable { get; set; }
    }

    public class SeqAnnot_Data_Ftable
    {
        public object Seqfeat { get; set; }
    }

    public class BioseqSet_Annot
    {
        public SeqAnnot1 Seqannot { get; set; }
    }

    public class SeqAnnot1
    {
        public SeqAnnot_Data1 Seqannot_data { get; set; }
    }

    public class SeqAnnot_Data1
    {
        public SeqAnnot_Data_Ftable1 Seqannot_data_ftable { get; set; }
    }

    public class SeqAnnot_Data_Ftable1
    {
        public SeqFeat[] Seqfeat { get; set; }
    }

    public class SeqFeat
    {
        public SeqFeat_Id Seqfeat_id { get; set; }
        public SeqFeat_Data Seqfeat_data { get; set; }
        public SeqFeat_Except Seqfeat_except { get; set; }
        public string Seqfeat_comment { get; set; }
        public SeqFeat_Product Seqfeat_product { get; set; }
        public SeqFeat_Location Seqfeat_location { get; set; }
        public string Seqfeat_excepttext { get; set; }
    }

    public class SeqFeat_Id
    {
        public FeatId Featid { get; set; }
    }

    public class FeatId
    {
        public FeatId_Local Featid_local { get; set; }
    }

    public class FeatId_Local
    {
        public ObjectId3 Objectid { get; set; }
    }

    public class ObjectId3
    {
        public string Objectid_id { get; set; }
    }

    public class SeqFeat_Data
    {
        public Seqfeatdata SeqFeatData { get; set; }
    }

    public class Seqfeatdata
    {
        public Seqfeatdata_Cdregion SeqFeatData_cdregion { get; set; }
    }

    public class Seqfeatdata_Cdregion
    {
        public Cdregion Cdregion { get; set; }
    }

    public class Cdregion
    {
        public Cdregion_Frame Cdregion_frame { get; set; }
        public Cdregion_Code Cdregion_code { get; set; }
    }

    public class Cdregion_Frame
    {
        public string value { get; set; }
    }

    public class Cdregion_Code
    {
        public GeneticCode Geneticcode { get; set; }
    }

    public class GeneticCode
    {
        public GeneticCode_E Geneticcode_E { get; set; }
    }

    public class GeneticCode_E
    {
        public string Geneticcode_E_id { get; set; }
    }

    public class SeqFeat_Except
    {
        public string value { get; set; }
    }

    public class SeqFeat_Product
    {
        public SeqLoc Seqloc { get; set; }
    }

    public class SeqLoc
    {
        public SeqLoc_Whole Seqloc_whole { get; set; }
    }

    public class SeqLoc_Whole
    {
        public SeqId2 Seqid { get; set; }
    }

    public class SeqId2
    {
        public string Seqid_gi { get; set; }
    }

    public class SeqFeat_Location
    {
        public SeqLoc1 Seqloc { get; set; }
    }

    public class SeqLoc1
    {
        public SeqLoc_PackedInt Seqloc_packedint { get; set; }
        public SeqLoc_Int Seqloc_int { get; set; }
    }

    public class SeqLoc_PackedInt
    {
        public PackedSeqint Packedseqint { get; set; }
    }

    public class PackedSeqint
    {
        public SeqInterval[] Seqinterval { get; set; }
    }

    public class SeqInterval
    {
        public string Seqinterval_from { get; set; }
        public string Seqinterval_to { get; set; }
        public SeqInterval_Strand Seqinterval_strand { get; set; }
        public SeqInterval_Id Seqinterval_id { get; set; }
    }

    public class SeqInterval_Strand
    {
        public NaStrand Nastrand { get; set; }
    }

    public class NaStrand
    {
        public string value { get; set; }
    }

    public class SeqInterval_Id
    {
        public SeqId3 Seqid { get; set; }
    }

    public class SeqId3
    {
        public string Seqid_gi { get; set; }
    }

    public class SeqLoc_Int
    {
        public SeqInterval1 Seqinterval { get; set; }
    }

    public class SeqInterval1
    {
        public string Seqinterval_from { get; set; }
        public string Seqinterval_to { get; set; }
        public SeqInterval_Strand1 Seqinterval_strand { get; set; }
        public SeqInterval_Id1 Seqinterval_id { get; set; }
    }

    public class SeqInterval_Strand1
    {
        public NaStrand1 Nastrand { get; set; }
    }

    public class NaStrand1
    {
        public string value { get; set; }
    }

    public class SeqInterval_Id1
    {
        public SeqId4 Seqid { get; set; }
    }

    public class SeqId4
    {
        public string Seqid_gi { get; set; }
    }
}
