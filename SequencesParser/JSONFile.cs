
using System.Collections.Generic;

public class Root
{
    private List<SeqFeat> seqfeat;

    public List<SeqFeat> Seqfeat { get => seqfeat; set => seqfeat = value; }
}

public class SeqFeat
{
    private SeqFeat_Id seqfeat_id;
    private SeqFeat_Data seqfeat_data;
    private SeqFeat_Except seqfeat_except;
    private string seqfeat_comment;
    private SeqFeat_Product seqfeat_product;
    private SeqFeat_Location seqfeat_location;
    private string seqfeat_excepttext;

    public SeqFeat_Id Seqfeat_id { get => seqfeat_id; set => seqfeat_id = value; }
    public SeqFeat_Data Seqfeat_data { get => seqfeat_data; set => seqfeat_data = value; }
    public SeqFeat_Except Seqfeat_except { get => seqfeat_except; set => seqfeat_except = value; }
    public string Seqfeat_comment { get => seqfeat_comment; set => seqfeat_comment = value; }
    public SeqFeat_Product Seqfeat_product { get => seqfeat_product; set => seqfeat_product = value; }
    public SeqFeat_Location Seqfeat_location { get => seqfeat_location; set => seqfeat_location = value; }
    public string Seqfeat_excepttext { get => seqfeat_excepttext; set => seqfeat_excepttext = value; }
}

public class SeqFeat_Id
{
    private FeatId featid;

    public FeatId Featid { get => featid; set => featid = value; }
}

public class FeatId
{
    private FeatId_Local featid_local;

    public FeatId_Local Featid_local { get => featid_local; set => featid_local = value; }
}

public class FeatId_Local
{
    private ObjectId objectid;

    public ObjectId Objectid { get => objectid; set => objectid = value; }
}

public class ObjectId
{
    private string objectid_id;

    public string Objectid_id { get => objectid_id; set => objectid_id = value; }
}

public class SeqFeat_Data
{
    private Seqfeatdata seqFeatData;

    public Seqfeatdata SeqFeatData { get => seqFeatData; set => seqFeatData = value; }
}

public class Seqfeatdata
{
    private Seqfeatdata_Cdregion seqFeatData_cdregion;

    public Seqfeatdata_Cdregion SeqFeatData_cdregion { get => seqFeatData_cdregion; set => seqFeatData_cdregion = value; }
}

public class Seqfeatdata_Cdregion
{
    private Cdregion cdregion;

    public Cdregion Cdregion { get => cdregion; set => cdregion = value; }
}

public class Cdregion
{
    private Cdregion_Frame cdregion_frame;
    private Cdregion_Code cdregion_code;

    public Cdregion_Frame Cdregion_frame { get => cdregion_frame; set => cdregion_frame = value; }
    public Cdregion_Code Cdregion_code { get => cdregion_code; set => cdregion_code = value; }
}

public class Cdregion_Frame
{
    private string value1;

    public string value { get => value1; set => value1 = value; }
}

public class Cdregion_Code
{
    private GeneticCode geneticcode;

    public GeneticCode Geneticcode { get => geneticcode; set => geneticcode = value; }
}

public class GeneticCode
{
    private GeneticCode_E geneticcode_E;

    public GeneticCode_E Geneticcode_E { get => geneticcode_E; set => geneticcode_E = value; }
}

public class GeneticCode_E
{
    private string geneticcode_E_id;

    public string Geneticcode_E_id { get => geneticcode_E_id; set => geneticcode_E_id = value; }
}

public class SeqFeat_Except
{
    private string value1;

    public string value { get => value1; set => value1 = value; }
}

public class SeqFeat_Product
{
    private SeqLoc seqloc;

    public SeqLoc Seqloc { get => seqloc; set => seqloc = value; }
}

public class SeqLoc
{
    private SeqLoc_Whole seqloc_whole;

    public SeqLoc_Whole Seqloc_whole { get => seqloc_whole; set => seqloc_whole = value; }
}

public class SeqLoc_Whole
{
    private SeqId seqid;

    public SeqId Seqid { get => seqid; set => seqid = value; }
}

public class SeqId
{
    private string seqid_gi;

    public string Seqid_gi { get => seqid_gi; set => seqid_gi = value; }
}

public class SeqFeat_Location
{
    private SeqLoc1 seqloc;

    public SeqLoc1 Seqloc { get => seqloc; set => seqloc = value; }
}

public class SeqLoc1
{
    private SeqLoc_PackedInt seqloc_packedint;
    private SeqLoc_Int seqloc_int;

    public SeqLoc_PackedInt Seqloc_packedint { get => seqloc_packedint; set => seqloc_packedint = value; }
    public SeqLoc_Int Seqloc_int { get => seqloc_int; set => seqloc_int = value; }
}

public class SeqLoc_PackedInt
{
    private PackedSeqint packedseqint;

    public PackedSeqint Packedseqint { get => packedseqint; set => packedseqint = value; }
}

public class PackedSeqint
{
    private SeqInterval[] seqinterval;

    public SeqInterval[] Seqinterval { get => seqinterval; set => seqinterval = value; }
}

public class SeqInterval
{
    private string seqinterval_from;
    private string seqinterval_to;
    private SeqInterval_Strand seqinterval_strand;
    private SeqInterval_Id seqinterval_id;

    public string Seqinterval_from { get => seqinterval_from; set => seqinterval_from = value; }
    public string Seqinterval_to { get => seqinterval_to; set => seqinterval_to = value; }
    public SeqInterval_Strand Seqinterval_strand { get => seqinterval_strand; set => seqinterval_strand = value; }
    public SeqInterval_Id Seqinterval_id { get => seqinterval_id; set => seqinterval_id = value; }
}

public class SeqInterval_Strand
{
    private NaStrand nastrand;

    public NaStrand Nastrand { get => nastrand; set => nastrand = value; }
}

public class NaStrand
{
    private string value1;

    public string value { get => value1; set => value1 = value; }
}

public class SeqInterval_Id
{
    private SeqId1 seqid;

    public SeqId1 Seqid { get => seqid; set => seqid = value; }
}

public class SeqId1
{
    private string seqid_gi;

    public string Seqid_gi { get => seqid_gi; set => seqid_gi = value; }
}

public class SeqLoc_Int
{
    private SeqInterval1 seqinterval;

    public SeqInterval1 Seqinterval { get => seqinterval; set => seqinterval = value; }
}

public class SeqInterval1
{
    private string seqinterval_from;
    private string seqinterval_to;
    private SeqInterval_Strand1 seqinterval_strand;
    private SeqInterval_Id1 seqinterval_id;

    public string Seqinterval_from { get => seqinterval_from; set => seqinterval_from = value; }
    public string Seqinterval_to { get => seqinterval_to; set => seqinterval_to = value; }
    public SeqInterval_Strand1 Seqinterval_strand { get => seqinterval_strand; set => seqinterval_strand = value; }
    public SeqInterval_Id1 Seqinterval_id { get => seqinterval_id; set => seqinterval_id = value; }
}

public class SeqInterval_Strand1
{
    private NaStrand1 nastrand;

    public NaStrand1 Nastrand { get => nastrand; set => nastrand = value; }
}

public class NaStrand1
{
    private string value1;

    public string value { get => value1; set => value1 = value; }
}

public class SeqInterval_Id1
{
    private SeqId2 seqid;

    public SeqId2 Seqid { get => seqid; set => seqid = value; }
}

public class SeqId2
{
    private string seqid_gi;

    public string Seqid_gi { get => seqid_gi; set => seqid_gi = value; }
}
