using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SequencesParser
{
  


    // NOTA: con il codice generato potrebbe essere richiesto almeno .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute("Bioseq-set", Namespace = "", IsNullable = false)]
        public partial class Bioseqset
        {

            private BioseqsetBioseqset_seqset bioseqset_seqsetField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Bioseq-set_seq-set")]
            public BioseqsetBioseqset_seqset Bioseqset_seqset
            {
                get
                {
                    return this.bioseqset_seqsetField;
                }
                set
                {
                    this.bioseqset_seqsetField = value;
                }
            }

        public Bioseqset DeserializeObject(string filename)
        {
            Console.WriteLine("Reading with Stream");
            // Create an instance of the XmlSerializer.
            XmlSerializer serializer =
            new XmlSerializer(typeof(Bioseqset));

            // Declare an object variable of the type to be deserialized.
            Bioseqset i;

            using (Stream reader = new FileStream(filename, FileMode.Open))
            {
                // Call the Deserialize method to restore the object's state.
                i = (Bioseqset)serializer.Deserialize(reader);
                return i;
            }

            // Write out the properties of the object.

        }

    }

    /// <remarks/>
    [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqset
        {

            private BioseqsetBioseqset_seqsetSeqentry seqentryField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-entry")]
            public BioseqsetBioseqset_seqsetSeqentry Seqentry
            {
                get
                {
                    return this.seqentryField;
                }
                set
                {
                    this.seqentryField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentry
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_set seqentry_setField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-entry_set")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_set Seqentry_set
            {
                get
                {
                    return this.seqentry_setField;
                }
                set
                {
                    this.seqentry_setField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_set
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqset bioseqsetField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Bioseq-set")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqset Bioseqset
            {
                get
                {
                    return this.bioseqsetField;
                }
                set
                {
                    this.bioseqsetField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqset
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_class bioseqset_classField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descr bioseqset_descrField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentry[] bioseqset_seqsetField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annot bioseqset_annotField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Bioseq-set_class")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_class Bioseqset_class
            {
                get
                {
                    return this.bioseqset_classField;
                }
                set
                {
                    this.bioseqset_classField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Bioseq-set_descr")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descr Bioseqset_descr
            {
                get
                {
                    return this.bioseqset_descrField;
                }
                set
                {
                    this.bioseqset_descrField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Bioseq-set_seq-set")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Seq-entry", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentry[] Bioseqset_seqset
            {
                get
                {
                    return this.bioseqset_seqsetField;
                }
                set
                {
                    this.bioseqset_seqsetField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Bioseq-set_annot")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annot Bioseqset_annot
            {
                get
                {
                    return this.bioseqset_annotField;
                }
                set
                {
                    this.bioseqset_annotField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_class
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descr
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdesc[] seqdescrField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Seq-descr")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Seqdesc", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdesc[] Seqdescr
            {
                get
                {
                    return this.seqdescrField;
                }
                set
                {
                    this.seqdescrField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdesc
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedate seqdesc_updatedateField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_user seqdesc_userField;

            private string seqdesc_commentField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pub seqdesc_pubField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_source seqdesc_sourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seqdesc_update-date")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedate Seqdesc_updatedate
            {
                get
                {
                    return this.seqdesc_updatedateField;
                }
                set
                {
                    this.seqdesc_updatedateField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_user Seqdesc_user
            {
                get
                {
                    return this.seqdesc_userField;
                }
                set
                {
                    this.seqdesc_userField = value;
                }
            }

            /// <remarks/>
            public string Seqdesc_comment
            {
                get
                {
                    return this.seqdesc_commentField;
                }
                set
                {
                    this.seqdesc_commentField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pub Seqdesc_pub
            {
                get
                {
                    return this.seqdesc_pubField;
                }
                set
                {
                    this.seqdesc_pubField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_source Seqdesc_source
            {
                get
                {
                    return this.seqdesc_sourceField;
                }
                set
                {
                    this.seqdesc_sourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedate
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedateDate dateField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedateDate Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedateDate
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedateDateDate_std date_stdField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedateDateDate_std Date_std
            {
                get
                {
                    return this.date_stdField;
                }
                set
                {
                    this.date_stdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedateDateDate_std
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedateDateDate_stdDatestd datestdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedateDateDate_stdDatestd Datestd
            {
                get
                {
                    return this.datestdField;
                }
                set
                {
                    this.datestdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_updatedateDateDate_stdDatestd
        {

            private ushort datestd_yearField;

            private byte datestd_monthField;

            private byte datestd_dayField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_year")]
            public ushort Datestd_year
            {
                get
                {
                    return this.datestd_yearField;
                }
                set
                {
                    this.datestd_yearField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_month")]
            public byte Datestd_month
            {
                get
                {
                    return this.datestd_monthField;
                }
                set
                {
                    this.datestd_monthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_day")]
            public byte Datestd_day
            {
                get
                {
                    return this.datestd_dayField;
                }
                set
                {
                    this.datestd_dayField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_user
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobject userobjectField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-object")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobject Userobject
            {
                get
                {
                    return this.userobjectField;
                }
                set
                {
                    this.userobjectField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobject
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserobject_type userobject_typeField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfield[] userobject_dataField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-object_type")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserobject_type Userobject_type
            {
                get
                {
                    return this.userobject_typeField;
                }
                set
                {
                    this.userobject_typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("User-object_data")]
            [System.Xml.Serialization.XmlArrayItemAttribute("User-field", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfield[] Userobject_data
            {
                get
                {
                    return this.userobject_dataField;
                }
                set
                {
                    this.userobject_dataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserobject_type
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserobject_typeObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserobject_typeObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserobject_typeObjectid
        {

            private string objectid_strField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_str")]
            public string Objectid_str
            {
                get
                {
                    return this.objectid_strField;
                }
                set
                {
                    this.objectid_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfield
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_label userfield_labelField;

            private byte userfield_numField;

            private bool userfield_numFieldSpecified;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_data userfield_dataField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_label")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_label Userfield_label
            {
                get
                {
                    return this.userfield_labelField;
                }
                set
                {
                    this.userfield_labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_num")]
            public byte Userfield_num
            {
                get
                {
                    return this.userfield_numField;
                }
                set
                {
                    this.userfield_numField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Userfield_numSpecified
            {
                get
                {
                    return this.userfield_numFieldSpecified;
                }
                set
                {
                    this.userfield_numFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_data Userfield_data
            {
                get
                {
                    return this.userfield_dataField;
                }
                set
                {
                    this.userfield_dataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_label
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_labelObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_labelObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_labelObjectid
        {

            private string objectid_strField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_str")]
            public string Objectid_str
            {
                get
                {
                    return this.objectid_strField;
                }
                set
                {
                    this.objectid_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_data
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_strs userfield_data_strsField;

            private string userfield_data_strField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_strs")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_strs Userfield_data_strs
            {
                get
                {
                    return this.userfield_data_strsField;
                }
                set
                {
                    this.userfield_data_strsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_str")]
            public string Userfield_data_str
            {
                get
                {
                    return this.userfield_data_strField;
                }
                set
                {
                    this.userfield_data_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_strs
        {

            private string userfield_data_strs_EField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_strs_E")]
            public string Userfield_data_strs_E
            {
                get
                {
                    return this.userfield_data_strs_EField;
                }
                set
                {
                    this.userfield_data_strs_EField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pub
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdesc pubdescField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdesc Pubdesc
            {
                get
                {
                    return this.pubdescField;
                }
                set
                {
                    this.pubdescField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdesc
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pub pubdesc_pubField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pub Pubdesc_pub
            {
                get
                {
                    return this.pubdesc_pubField;
                }
                set
                {
                    this.pubdesc_pubField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pub
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequiv pubequivField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Pub-equiv")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequiv Pubequiv
            {
                get
                {
                    return this.pubequivField;
                }
                set
                {
                    this.pubequivField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequiv
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPub pubField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPub Pub
            {
                get
                {
                    return this.pubField;
                }
                set
                {
                    this.pubField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPub
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_sub pub_subField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_gen pub_genField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_sub Pub_sub
            {
                get
                {
                    return this.pub_subField;
                }
                set
                {
                    this.pub_subField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_gen Pub_gen
            {
                get
                {
                    return this.pub_genField;
                }
                set
                {
                    this.pub_genField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_sub
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsub citsubField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-sub")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsub Citsub
            {
                get
                {
                    return this.citsubField;
                }
                set
                {
                    this.citsubField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsub
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authors citsub_authorsField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_medium citsub_mediumField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_date citsub_dateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-sub_authors")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authors Citsub_authors
            {
                get
                {
                    return this.citsub_authorsField;
                }
                set
                {
                    this.citsub_authorsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-sub_medium")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_medium Citsub_medium
            {
                get
                {
                    return this.citsub_mediumField;
                }
                set
                {
                    this.citsub_mediumField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-sub_date")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_date Citsub_date
            {
                get
                {
                    return this.citsub_dateField;
                }
                set
                {
                    this.citsub_dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authors
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlist authlistField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Auth-list")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlist Authlist
            {
                get
                {
                    return this.authlistField;
                }
                set
                {
                    this.authlistField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlist
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_names authlist_namesField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_affil authlist_affilField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Auth-list_names")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_names Authlist_names
            {
                get
                {
                    return this.authlist_namesField;
                }
                set
                {
                    this.authlist_namesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Auth-list_affil")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_affil Authlist_affil
            {
                get
                {
                    return this.authlist_affilField;
                }
                set
                {
                    this.authlist_affilField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_names
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthor[] authlist_names_stdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Auth-list_names_std")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Author", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthor[] Authlist_names_std
            {
                get
                {
                    return this.authlist_names_stdField;
                }
                set
                {
                    this.authlist_names_stdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthor
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_name author_nameField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_name Author_name
            {
                get
                {
                    return this.author_nameField;
                }
                set
                {
                    this.author_nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_name
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonid personidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Person-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonid Personid
            {
                get
                {
                    return this.personidField;
                }
                set
                {
                    this.personidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonid
        {

            private string personid_consortiumField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_name personid_nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Person-id_consortium")]
            public string Personid_consortium
            {
                get
                {
                    return this.personid_consortiumField;
                }
                set
                {
                    this.personid_consortiumField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Person-id_name")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_name Personid_name
            {
                get
                {
                    return this.personid_nameField;
                }
                set
                {
                    this.personid_nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_name
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_nameNamestd namestdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_nameNamestd Namestd
            {
                get
                {
                    return this.namestdField;
                }
                set
                {
                    this.namestdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_nameNamestd
        {

            private string namestd_lastField;

            private string namestd_firstField;

            private string namestd_initialsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std_last")]
            public string Namestd_last
            {
                get
                {
                    return this.namestd_lastField;
                }
                set
                {
                    this.namestd_lastField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std_first")]
            public string Namestd_first
            {
                get
                {
                    return this.namestd_firstField;
                }
                set
                {
                    this.namestd_firstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std_initials")]
            public string Namestd_initials
            {
                get
                {
                    return this.namestd_initialsField;
                }
                set
                {
                    this.namestd_initialsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_affil
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_affilAffil affilField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_affilAffil Affil
            {
                get
                {
                    return this.affilField;
                }
                set
                {
                    this.affilField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_affilAffil
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_affilAffilAffil_std affil_stdField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_affilAffilAffil_std Affil_std
            {
                get
                {
                    return this.affil_stdField;
                }
                set
                {
                    this.affil_stdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_authorsAuthlistAuthlist_affilAffilAffil_std
        {

            private string affil_std_affilField;

            private string affil_std_divField;

            private string affil_std_cityField;

            private string affil_std_subField;

            private string affil_std_countryField;

            private ushort affil_std_postalcodeField;

            private bool affil_std_postalcodeFieldSpecified;

            /// <remarks/>
            public string Affil_std_affil
            {
                get
                {
                    return this.affil_std_affilField;
                }
                set
                {
                    this.affil_std_affilField = value;
                }
            }

            /// <remarks/>
            public string Affil_std_div
            {
                get
                {
                    return this.affil_std_divField;
                }
                set
                {
                    this.affil_std_divField = value;
                }
            }

            /// <remarks/>
            public string Affil_std_city
            {
                get
                {
                    return this.affil_std_cityField;
                }
                set
                {
                    this.affil_std_cityField = value;
                }
            }

            /// <remarks/>
            public string Affil_std_sub
            {
                get
                {
                    return this.affil_std_subField;
                }
                set
                {
                    this.affil_std_subField = value;
                }
            }

            /// <remarks/>
            public string Affil_std_country
            {
                get
                {
                    return this.affil_std_countryField;
                }
                set
                {
                    this.affil_std_countryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Affil_std_postal-code")]
            public ushort Affil_std_postalcode
            {
                get
                {
                    return this.affil_std_postalcodeField;
                }
                set
                {
                    this.affil_std_postalcodeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Affil_std_postalcodeSpecified
            {
                get
                {
                    return this.affil_std_postalcodeFieldSpecified;
                }
                set
                {
                    this.affil_std_postalcodeFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_medium
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_date
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_dateDate dateField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_dateDate Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_dateDate
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_dateDateDate_std date_stdField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_dateDateDate_std Date_std
            {
                get
                {
                    return this.date_stdField;
                }
                set
                {
                    this.date_stdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_dateDateDate_std
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_dateDateDate_stdDatestd datestdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_dateDateDate_stdDatestd Datestd
            {
                get
                {
                    return this.datestdField;
                }
                set
                {
                    this.datestdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_subCitsubCitsub_dateDateDate_stdDatestd
        {

            private ushort datestd_yearField;

            private byte datestd_monthField;

            private byte datestd_dayField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_year")]
            public ushort Datestd_year
            {
                get
                {
                    return this.datestd_yearField;
                }
                set
                {
                    this.datestd_yearField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_month")]
            public byte Datestd_month
            {
                get
                {
                    return this.datestd_monthField;
                }
                set
                {
                    this.datestd_monthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_day")]
            public byte Datestd_day
            {
                get
                {
                    return this.datestd_dayField;
                }
                set
                {
                    this.datestd_dayField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_gen
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgen citgenField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-gen")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgen Citgen
            {
                get
                {
                    return this.citgenField;
                }
                set
                {
                    this.citgenField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgen
        {

            private string citgen_citField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authors citgen_authorsField;

            private string citgen_titleField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-gen_cit")]
            public string Citgen_cit
            {
                get
                {
                    return this.citgen_citField;
                }
                set
                {
                    this.citgen_citField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-gen_authors")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authors Citgen_authors
            {
                get
                {
                    return this.citgen_authorsField;
                }
                set
                {
                    this.citgen_authorsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-gen_title")]
            public string Citgen_title
            {
                get
                {
                    return this.citgen_titleField;
                }
                set
                {
                    this.citgen_titleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authors
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlist authlistField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Auth-list")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlist Authlist
            {
                get
                {
                    return this.authlistField;
                }
                set
                {
                    this.authlistField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlist
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_names authlist_namesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Auth-list_names")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_names Authlist_names
            {
                get
                {
                    return this.authlist_namesField;
                }
                set
                {
                    this.authlist_namesField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_names
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthor[] authlist_names_stdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Auth-list_names_std")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Author", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthor[] Authlist_names_std
            {
                get
                {
                    return this.authlist_names_stdField;
                }
                set
                {
                    this.authlist_names_stdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthor
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_name author_nameField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_name Author_name
            {
                get
                {
                    return this.author_nameField;
                }
                set
                {
                    this.author_nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_name
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonid personidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Person-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonid Personid
            {
                get
                {
                    return this.personidField;
                }
                set
                {
                    this.personidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonid
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_name personid_nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Person-id_name")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_name Personid_name
            {
                get
                {
                    return this.personid_nameField;
                }
                set
                {
                    this.personid_nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_name
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_nameNamestd namestdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_nameNamestd Namestd
            {
                get
                {
                    return this.namestdField;
                }
                set
                {
                    this.namestdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_pubPubdescPubdesc_pubPubequivPubPub_genCitgenCitgen_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_nameNamestd
        {

            private string namestd_lastField;

            private string namestd_firstField;

            private string namestd_initialsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std_last")]
            public string Namestd_last
            {
                get
                {
                    return this.namestd_lastField;
                }
                set
                {
                    this.namestd_lastField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std_first")]
            public string Namestd_first
            {
                get
                {
                    return this.namestd_firstField;
                }
                set
                {
                    this.namestd_firstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std_initials")]
            public string Namestd_initials
            {
                get
                {
                    return this.namestd_initialsField;
                }
                set
                {
                    this.namestd_initialsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_source
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSource bioSourceField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSource BioSource
            {
                get
                {
                    return this.bioSourceField;
                }
                set
                {
                    this.bioSourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSource
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_genome bioSource_genomeField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_org bioSource_orgField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceSubSource[] bioSource_subtypeField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_genome BioSource_genome
            {
                get
                {
                    return this.bioSource_genomeField;
                }
                set
                {
                    this.bioSource_genomeField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_org BioSource_org
            {
                get
                {
                    return this.bioSource_orgField;
                }
                set
                {
                    this.bioSource_orgField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("SubSource", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceSubSource[] BioSource_subtype
            {
                get
                {
                    return this.bioSource_subtypeField;
                }
                set
                {
                    this.bioSource_subtypeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_genome
        {

            private string valueField;

            private byte valueField1;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField1;
                }
                set
                {
                    this.valueField1 = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_org
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgref orgrefField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Org-ref")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgref Orgref
            {
                get
                {
                    return this.orgrefField;
                }
                set
                {
                    this.orgrefField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgref
        {

            private string orgref_taxnameField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_db orgref_dbField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgname orgref_orgnameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Org-ref_taxname")]
            public string Orgref_taxname
            {
                get
                {
                    return this.orgref_taxnameField;
                }
                set
                {
                    this.orgref_taxnameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Org-ref_db")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_db Orgref_db
            {
                get
                {
                    return this.orgref_dbField;
                }
                set
                {
                    this.orgref_dbField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Org-ref_orgname")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgname Orgref_orgname
            {
                get
                {
                    return this.orgref_orgnameField;
                }
                set
                {
                    this.orgref_orgnameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_db
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_dbDbtag dbtagField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_dbDbtag Dbtag
            {
                get
                {
                    return this.dbtagField;
                }
                set
                {
                    this.dbtagField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_dbDbtag
        {

            private string dbtag_dbField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_dbDbtagDbtag_tag dbtag_tagField;

            /// <remarks/>
            public string Dbtag_db
            {
                get
                {
                    return this.dbtag_dbField;
                }
                set
                {
                    this.dbtag_dbField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_dbDbtagDbtag_tag Dbtag_tag
            {
                get
                {
                    return this.dbtag_tagField;
                }
                set
                {
                    this.dbtag_tagField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_dbDbtagDbtag_tag
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_dbDbtagDbtag_tagObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_dbDbtagDbtag_tagObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_dbDbtagDbtag_tagObjectid
        {

            private uint objectid_idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_id")]
            public uint Objectid_id
            {
                get
                {
                    return this.objectid_idField;
                }
                set
                {
                    this.objectid_idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgname
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgName orgNameField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgName OrgName
            {
                get
                {
                    return this.orgNameField;
                }
                set
                {
                    this.orgNameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgName
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgNameOrgName_name orgName_nameField;

            private string orgName_attribField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgNameOrgMod[] orgName_modField;

            private string orgName_lineageField;

            private byte orgName_gcodeField;

            private string orgName_divField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgNameOrgName_name OrgName_name
            {
                get
                {
                    return this.orgName_nameField;
                }
                set
                {
                    this.orgName_nameField = value;
                }
            }

            /// <remarks/>
            public string OrgName_attrib
            {
                get
                {
                    return this.orgName_attribField;
                }
                set
                {
                    this.orgName_attribField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("OrgMod", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgNameOrgMod[] OrgName_mod
            {
                get
                {
                    return this.orgName_modField;
                }
                set
                {
                    this.orgName_modField = value;
                }
            }

            /// <remarks/>
            public string OrgName_lineage
            {
                get
                {
                    return this.orgName_lineageField;
                }
                set
                {
                    this.orgName_lineageField = value;
                }
            }

            /// <remarks/>
            public byte OrgName_gcode
            {
                get
                {
                    return this.orgName_gcodeField;
                }
                set
                {
                    this.orgName_gcodeField = value;
                }
            }

            /// <remarks/>
            public string OrgName_div
            {
                get
                {
                    return this.orgName_divField;
                }
                set
                {
                    this.orgName_divField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgNameOrgName_name
        {

            private string orgName_name_virusField;

            /// <remarks/>
            public string OrgName_name_virus
            {
                get
                {
                    return this.orgName_name_virusField;
                }
                set
                {
                    this.orgName_name_virusField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgNameOrgMod
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgNameOrgModOrgMod_subtype orgMod_subtypeField;

            private string orgMod_subnameField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgNameOrgModOrgMod_subtype OrgMod_subtype
            {
                get
                {
                    return this.orgMod_subtypeField;
                }
                set
                {
                    this.orgMod_subtypeField = value;
                }
            }

            /// <remarks/>
            public string OrgMod_subname
            {
                get
                {
                    return this.orgMod_subnameField;
                }
                set
                {
                    this.orgMod_subnameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceBioSource_orgOrgrefOrgref_orgnameOrgNameOrgModOrgMod_subtype
        {

            private string valueField;

            private byte valueField1;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField1;
                }
                set
                {
                    this.valueField1 = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceSubSource
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceSubSourceSubSource_subtype subSource_subtypeField;

            private string subSource_nameField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceSubSourceSubSource_subtype SubSource_subtype
            {
                get
                {
                    return this.subSource_subtypeField;
                }
                set
                {
                    this.subSource_subtypeField = value;
                }
            }

            /// <remarks/>
            public string SubSource_name
            {
                get
                {
                    return this.subSource_nameField;
                }
                set
                {
                    this.subSource_nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_descrSeqdescSeqdesc_sourceBioSourceSubSourceSubSource_subtype
        {

            private string valueField;

            private byte valueField1;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField1;
                }
                set
                {
                    this.valueField1 = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentry
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seq seqentry_seqField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-entry_seq")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seq Seqentry_seq
            {
                get
                {
                    return this.seqentry_seqField;
                }
                set
                {
                    this.seqentry_seqField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seq
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseq bioseqField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseq Bioseq
            {
                get
                {
                    return this.bioseqField;
                }
                set
                {
                    this.bioseqField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseq
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqSeqid[] bioseq_idField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descr bioseq_descrField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_inst bioseq_instField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annot bioseq_annotField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Seq-id", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqSeqid[] Bioseq_id
            {
                get
                {
                    return this.bioseq_idField;
                }
                set
                {
                    this.bioseq_idField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descr Bioseq_descr
            {
                get
                {
                    return this.bioseq_descrField;
                }
                set
                {
                    this.bioseq_descrField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_inst Bioseq_inst
            {
                get
                {
                    return this.bioseq_instField;
                }
                set
                {
                    this.bioseq_instField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annot Bioseq_annot
            {
                get
                {
                    return this.bioseq_annotField;
                }
                set
                {
                    this.bioseq_annotField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqSeqid
        {

            private uint seqid_giField;

            private bool seqid_giFieldSpecified;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqSeqidSeqid_other seqid_otherField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id_gi")]
            public uint Seqid_gi
            {
                get
                {
                    return this.seqid_giField;
                }
                set
                {
                    this.seqid_giField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Seqid_giSpecified
            {
                get
                {
                    return this.seqid_giFieldSpecified;
                }
                set
                {
                    this.seqid_giFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id_other")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqSeqidSeqid_other Seqid_other
            {
                get
                {
                    return this.seqid_otherField;
                }
                set
                {
                    this.seqid_otherField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqSeqidSeqid_other
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqSeqidSeqid_otherTextseqid textseqidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Textseq-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqSeqidSeqid_otherTextseqid Textseqid
            {
                get
                {
                    return this.textseqidField;
                }
                set
                {
                    this.textseqidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqSeqidSeqid_otherTextseqid
        {

            private string textseqid_accessionField;

            private byte textseqid_versionField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Textseq-id_accession")]
            public string Textseqid_accession
            {
                get
                {
                    return this.textseqid_accessionField;
                }
                set
                {
                    this.textseqid_accessionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Textseq-id_version")]
            public byte Textseqid_version
            {
                get
                {
                    return this.textseqid_versionField;
                }
                set
                {
                    this.textseqid_versionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descr
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdesc[] seqdescrField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Seq-descr")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Seqdesc", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdesc[] Seqdescr
            {
                get
                {
                    return this.seqdescrField;
                }
                set
                {
                    this.seqdescrField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdesc
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdate seqdesc_createdateField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_user seqdesc_userField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfo seqdesc_molinfoField;

            private string seqdesc_titleField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seqdesc_create-date")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdate Seqdesc_createdate
            {
                get
                {
                    return this.seqdesc_createdateField;
                }
                set
                {
                    this.seqdesc_createdateField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_user Seqdesc_user
            {
                get
                {
                    return this.seqdesc_userField;
                }
                set
                {
                    this.seqdesc_userField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfo Seqdesc_molinfo
            {
                get
                {
                    return this.seqdesc_molinfoField;
                }
                set
                {
                    this.seqdesc_molinfoField = value;
                }
            }

            /// <remarks/>
            public string Seqdesc_title
            {
                get
                {
                    return this.seqdesc_titleField;
                }
                set
                {
                    this.seqdesc_titleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdate
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdateDate dateField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdateDate Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdateDate
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdateDateDate_std date_stdField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdateDateDate_std Date_std
            {
                get
                {
                    return this.date_stdField;
                }
                set
                {
                    this.date_stdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdateDateDate_std
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdateDateDate_stdDatestd datestdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdateDateDate_stdDatestd Datestd
            {
                get
                {
                    return this.datestdField;
                }
                set
                {
                    this.datestdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_createdateDateDate_stdDatestd
        {

            private ushort datestd_yearField;

            private byte datestd_monthField;

            private byte datestd_dayField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_year")]
            public ushort Datestd_year
            {
                get
                {
                    return this.datestd_yearField;
                }
                set
                {
                    this.datestd_yearField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_month")]
            public byte Datestd_month
            {
                get
                {
                    return this.datestd_monthField;
                }
                set
                {
                    this.datestd_monthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_day")]
            public byte Datestd_day
            {
                get
                {
                    return this.datestd_dayField;
                }
                set
                {
                    this.datestd_dayField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_user
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobject userobjectField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-object")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobject Userobject
            {
                get
                {
                    return this.userobjectField;
                }
                set
                {
                    this.userobjectField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobject
        {

            private decimal userobject_classField;

            private bool userobject_classFieldSpecified;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserobject_type userobject_typeField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfield[] userobject_dataField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-object_class")]
            public decimal Userobject_class
            {
                get
                {
                    return this.userobject_classField;
                }
                set
                {
                    this.userobject_classField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Userobject_classSpecified
            {
                get
                {
                    return this.userobject_classFieldSpecified;
                }
                set
                {
                    this.userobject_classFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-object_type")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserobject_type Userobject_type
            {
                get
                {
                    return this.userobject_typeField;
                }
                set
                {
                    this.userobject_typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("User-object_data")]
            [System.Xml.Serialization.XmlArrayItemAttribute("User-field", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfield[] Userobject_data
            {
                get
                {
                    return this.userobject_dataField;
                }
                set
                {
                    this.userobject_dataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserobject_type
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserobject_typeObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserobject_typeObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserobject_typeObjectid
        {

            private string objectid_strField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_str")]
            public string Objectid_str
            {
                get
                {
                    return this.objectid_strField;
                }
                set
                {
                    this.objectid_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfield
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_label userfield_labelField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_data userfield_dataField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_label")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_label Userfield_label
            {
                get
                {
                    return this.userfield_labelField;
                }
                set
                {
                    this.userfield_labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_data Userfield_data
            {
                get
                {
                    return this.userfield_dataField;
                }
                set
                {
                    this.userfield_dataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_label
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_labelObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_labelObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_labelObjectid
        {

            private string objectid_strField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_str")]
            public string Objectid_str
            {
                get
                {
                    return this.objectid_strField;
                }
                set
                {
                    this.objectid_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_data
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fields userfield_data_fieldsField;

            private string userfield_data_strField;

            private byte userfield_data_intField;

            private bool userfield_data_intFieldSpecified;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_bool userfield_data_boolField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_fields")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fields Userfield_data_fields
            {
                get
                {
                    return this.userfield_data_fieldsField;
                }
                set
                {
                    this.userfield_data_fieldsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_str")]
            public string Userfield_data_str
            {
                get
                {
                    return this.userfield_data_strField;
                }
                set
                {
                    this.userfield_data_strField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_int")]
            public byte Userfield_data_int
            {
                get
                {
                    return this.userfield_data_intField;
                }
                set
                {
                    this.userfield_data_intField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Userfield_data_intSpecified
            {
                get
                {
                    return this.userfield_data_intFieldSpecified;
                }
                set
                {
                    this.userfield_data_intFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_bool")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_bool Userfield_data_bool
            {
                get
                {
                    return this.userfield_data_boolField;
                }
                set
                {
                    this.userfield_data_boolField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fields
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfield userfieldField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfield Userfield
            {
                get
                {
                    return this.userfieldField;
                }
                set
                {
                    this.userfieldField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfield
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_label userfield_labelField;

            private byte userfield_numField;

            private bool userfield_numFieldSpecified;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_data userfield_dataField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_label")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_label Userfield_label
            {
                get
                {
                    return this.userfield_labelField;
                }
                set
                {
                    this.userfield_labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_num")]
            public byte Userfield_num
            {
                get
                {
                    return this.userfield_numField;
                }
                set
                {
                    this.userfield_numField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Userfield_numSpecified
            {
                get
                {
                    return this.userfield_numFieldSpecified;
                }
                set
                {
                    this.userfield_numFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_data Userfield_data
            {
                get
                {
                    return this.userfield_dataField;
                }
                set
                {
                    this.userfield_dataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_label
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_labelObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_labelObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_labelObjectid
        {

            private byte objectid_idField;

            private bool objectid_idFieldSpecified;

            private string objectid_strField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_id")]
            public byte Objectid_id
            {
                get
                {
                    return this.objectid_idField;
                }
                set
                {
                    this.objectid_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Objectid_idSpecified
            {
                get
                {
                    return this.objectid_idFieldSpecified;
                }
                set
                {
                    this.objectid_idFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_str")]
            public string Objectid_str
            {
                get
                {
                    return this.objectid_strField;
                }
                set
                {
                    this.objectid_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_data
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfield[] userfield_data_fieldsField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfield_data_strs userfield_data_strsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("User-field_data_fields")]
            [System.Xml.Serialization.XmlArrayItemAttribute("User-field", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfield[] Userfield_data_fields
            {
                get
                {
                    return this.userfield_data_fieldsField;
                }
                set
                {
                    this.userfield_data_fieldsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_strs")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfield_data_strs Userfield_data_strs
            {
                get
                {
                    return this.userfield_data_strsField;
                }
                set
                {
                    this.userfield_data_strsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfield
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfieldUserfield_label userfield_labelField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfieldUserfield_data userfield_dataField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_label")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfieldUserfield_label Userfield_label
            {
                get
                {
                    return this.userfield_labelField;
                }
                set
                {
                    this.userfield_labelField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfieldUserfield_data Userfield_data
            {
                get
                {
                    return this.userfield_dataField;
                }
                set
                {
                    this.userfield_dataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfieldUserfield_label
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfieldUserfield_labelObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfieldUserfield_labelObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfieldUserfield_labelObjectid
        {

            private string objectid_strField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_str")]
            public string Objectid_str
            {
                get
                {
                    return this.objectid_strField;
                }
                set
                {
                    this.objectid_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfieldUserfield_data
        {

            private uint userfield_data_intField;

            private bool userfield_data_intFieldSpecified;

            private string userfield_data_strField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_int")]
            public uint Userfield_data_int
            {
                get
                {
                    return this.userfield_data_intField;
                }
                set
                {
                    this.userfield_data_intField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Userfield_data_intSpecified
            {
                get
                {
                    return this.userfield_data_intFieldSpecified;
                }
                set
                {
                    this.userfield_data_intFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_str")]
            public string Userfield_data_str
            {
                get
                {
                    return this.userfield_data_strField;
                }
                set
                {
                    this.userfield_data_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_fieldsUserfieldUserfield_dataUserfield_data_strs
        {

            private string userfield_data_strs_EField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("User-field_data_strs_E")]
            public string Userfield_data_strs_E
            {
                get
                {
                    return this.userfield_data_strs_EField;
                }
                set
                {
                    this.userfield_data_strs_EField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_userUserobjectUserfieldUserfield_dataUserfield_data_bool
        {

            private bool valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfo
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfo molInfoField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfo MolInfo
            {
                get
                {
                    return this.molInfoField;
                }
                set
                {
                    this.molInfoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfo
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfoMolInfo_biomol molInfo_biomolField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfoMolInfo_tech molInfo_techField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfoMolInfo_completeness molInfo_completenessField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfoMolInfo_biomol MolInfo_biomol
            {
                get
                {
                    return this.molInfo_biomolField;
                }
                set
                {
                    this.molInfo_biomolField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfoMolInfo_tech MolInfo_tech
            {
                get
                {
                    return this.molInfo_techField;
                }
                set
                {
                    this.molInfo_techField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfoMolInfo_completeness MolInfo_completeness
            {
                get
                {
                    return this.molInfo_completenessField;
                }
                set
                {
                    this.molInfo_completenessField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfoMolInfo_biomol
        {

            private string valueField;

            private byte valueField1;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField1;
                }
                set
                {
                    this.valueField1 = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfoMolInfo_tech
        {

            private string valueField;

            private byte valueField1;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField1;
                }
                set
                {
                    this.valueField1 = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_descrSeqdescSeqdesc_molinfoMolInfoMolInfo_completeness
        {

            private string valueField;

            private byte valueField1;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField1;
                }
                set
                {
                    this.valueField1 = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_inst
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinst seqinstField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-inst")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinst Seqinst
            {
                get
                {
                    return this.seqinstField;
                }
                set
                {
                    this.seqinstField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinst
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_repr seqinst_reprField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_mol seqinst_molField;

            private ushort seqinst_lengthField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_strand seqinst_strandField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdata seqinst_seqdataField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_hist seqinst_histField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-inst_repr")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_repr Seqinst_repr
            {
                get
                {
                    return this.seqinst_reprField;
                }
                set
                {
                    this.seqinst_reprField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-inst_mol")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_mol Seqinst_mol
            {
                get
                {
                    return this.seqinst_molField;
                }
                set
                {
                    this.seqinst_molField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-inst_length")]
            public ushort Seqinst_length
            {
                get
                {
                    return this.seqinst_lengthField;
                }
                set
                {
                    this.seqinst_lengthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-inst_strand")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_strand Seqinst_strand
            {
                get
                {
                    return this.seqinst_strandField;
                }
                set
                {
                    this.seqinst_strandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-inst_seq-data")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdata Seqinst_seqdata
            {
                get
                {
                    return this.seqinst_seqdataField;
                }
                set
                {
                    this.seqinst_seqdataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-inst_hist")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_hist Seqinst_hist
            {
                get
                {
                    return this.seqinst_histField;
                }
                set
                {
                    this.seqinst_histField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_repr
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_mol
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_strand
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdata
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdataSeqdata seqdataField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-data")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdataSeqdata Seqdata
            {
                get
                {
                    return this.seqdataField;
                }
                set
                {
                    this.seqdataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdataSeqdata
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdataSeqdataSeqdata_ncbieaa seqdata_ncbieaaField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdataSeqdataSeqdata_ncbi2na seqdata_ncbi2naField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-data_ncbieaa")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdataSeqdataSeqdata_ncbieaa Seqdata_ncbieaa
            {
                get
                {
                    return this.seqdata_ncbieaaField;
                }
                set
                {
                    this.seqdata_ncbieaaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-data_ncbi2na")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdataSeqdataSeqdata_ncbi2na Seqdata_ncbi2na
            {
                get
                {
                    return this.seqdata_ncbi2naField;
                }
                set
                {
                    this.seqdata_ncbi2naField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdataSeqdataSeqdata_ncbieaa
        {

            private string nCBIeaaField;

            /// <remarks/>
            public string NCBIeaa
            {
                get
                {
                    return this.nCBIeaaField;
                }
                set
                {
                    this.nCBIeaaField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_seqdataSeqdataSeqdata_ncbi2na
        {

            private string nCBI2naField;

            /// <remarks/>
            public string NCBI2na
            {
                get
                {
                    return this.nCBI2naField;
                }
                set
                {
                    this.nCBI2naField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_hist
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhist seqhistField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-hist")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhist Seqhist
            {
                get
                {
                    return this.seqhistField;
                }
                set
                {
                    this.seqhistField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhist
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replaces seqhist_replacesField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-hist_replaces")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replaces Seqhist_replaces
            {
                get
                {
                    return this.seqhist_replacesField;
                }
                set
                {
                    this.seqhist_replacesField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replaces
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrec seqhistrecField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-hist-rec")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrec Seqhistrec
            {
                get
                {
                    return this.seqhistrecField;
                }
                set
                {
                    this.seqhistrecField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrec
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_date seqhistrec_dateField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_ids seqhistrec_idsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-hist-rec_date")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_date Seqhistrec_date
            {
                get
                {
                    return this.seqhistrec_dateField;
                }
                set
                {
                    this.seqhistrec_dateField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-hist-rec_ids")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_ids Seqhistrec_ids
            {
                get
                {
                    return this.seqhistrec_idsField;
                }
                set
                {
                    this.seqhistrec_idsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_date
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_dateDate dateField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_dateDate Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_dateDate
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_dateDateDate_std date_stdField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_dateDateDate_std Date_std
            {
                get
                {
                    return this.date_stdField;
                }
                set
                {
                    this.date_stdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_dateDateDate_std
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_dateDateDate_stdDatestd datestdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_dateDateDate_stdDatestd Datestd
            {
                get
                {
                    return this.datestdField;
                }
                set
                {
                    this.datestdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_dateDateDate_stdDatestd
        {

            private ushort datestd_yearField;

            private byte datestd_monthField;

            private byte datestd_dayField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_year")]
            public ushort Datestd_year
            {
                get
                {
                    return this.datestd_yearField;
                }
                set
                {
                    this.datestd_yearField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_month")]
            public byte Datestd_month
            {
                get
                {
                    return this.datestd_monthField;
                }
                set
                {
                    this.datestd_monthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_day")]
            public byte Datestd_day
            {
                get
                {
                    return this.datestd_dayField;
                }
                set
                {
                    this.datestd_dayField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_ids
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_idsSeqid seqidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_idsSeqid Seqid
            {
                get
                {
                    return this.seqidField;
                }
                set
                {
                    this.seqidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_instSeqinstSeqinst_histSeqhistSeqhist_replacesSeqhistrecSeqhistrec_idsSeqid
        {

            private uint seqid_giField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id_gi")]
            public uint Seqid_gi
            {
                get
                {
                    return this.seqid_giField;
                }
                set
                {
                    this.seqid_giField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annot
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannot seqannotField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-annot")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannot Seqannot
            {
                get
                {
                    return this.seqannotField;
                }
                set
                {
                    this.seqannotField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannot
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_data seqannot_dataField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-annot_data")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_data Seqannot_data
            {
                get
                {
                    return this.seqannot_dataField;
                }
                set
                {
                    this.seqannot_dataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_data
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeat[] seqannot_data_ftableField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Seq-annot_data_ftable")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Seq-feat", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeat[] Seqannot_data_ftable
            {
                get
                {
                    return this.seqannot_data_ftableField;
                }
                set
                {
                    this.seqannot_data_ftableField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeat
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_id seqfeat_idField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_data seqfeat_dataField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_partial seqfeat_partialField;

            private string seqfeat_commentField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_product seqfeat_productField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_location seqfeat_locationField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatGbqual[] seqfeat_qualField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxref seqfeat_dbxrefField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_id Seqfeat_id
            {
                get
                {
                    return this.seqfeat_idField;
                }
                set
                {
                    this.seqfeat_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_data")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_data Seqfeat_data
            {
                get
                {
                    return this.seqfeat_dataField;
                }
                set
                {
                    this.seqfeat_dataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_partial")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_partial Seqfeat_partial
            {
                get
                {
                    return this.seqfeat_partialField;
                }
                set
                {
                    this.seqfeat_partialField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_comment")]
            public string Seqfeat_comment
            {
                get
                {
                    return this.seqfeat_commentField;
                }
                set
                {
                    this.seqfeat_commentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_product")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_product Seqfeat_product
            {
                get
                {
                    return this.seqfeat_productField;
                }
                set
                {
                    this.seqfeat_productField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_location")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_location Seqfeat_location
            {
                get
                {
                    return this.seqfeat_locationField;
                }
                set
                {
                    this.seqfeat_locationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Seq-feat_qual")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Gb-qual", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatGbqual[] Seqfeat_qual
            {
                get
                {
                    return this.seqfeat_qualField;
                }
                set
                {
                    this.seqfeat_qualField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_dbxref")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxref Seqfeat_dbxref
            {
                get
                {
                    return this.seqfeat_dbxrefField;
                }
                set
                {
                    this.seqfeat_dbxrefField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_id
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatid featidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Feat-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatid Featid
            {
                get
                {
                    return this.featidField;
                }
                set
                {
                    this.featidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatid
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_local featid_localField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Feat-id_local")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_local Featid_local
            {
                get
                {
                    return this.featid_localField;
                }
                set
                {
                    this.featid_localField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_local
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_localObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_localObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_localObjectid
        {

            private byte objectid_idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_id")]
            public byte Objectid_id
            {
                get
                {
                    return this.objectid_idField;
                }
                set
                {
                    this.objectid_idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_data
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatData seqFeatDataField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatData SeqFeatData
            {
                get
                {
                    return this.seqFeatDataField;
                }
                set
                {
                    this.seqFeatDataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatData
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_prot seqFeatData_protField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pub seqFeatData_pubField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_imp seqFeatData_impField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_gene seqFeatData_geneField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_prot SeqFeatData_prot
            {
                get
                {
                    return this.seqFeatData_protField;
                }
                set
                {
                    this.seqFeatData_protField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pub SeqFeatData_pub
            {
                get
                {
                    return this.seqFeatData_pubField;
                }
                set
                {
                    this.seqFeatData_pubField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_imp SeqFeatData_imp
            {
                get
                {
                    return this.seqFeatData_impField;
                }
                set
                {
                    this.seqFeatData_impField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_gene SeqFeatData_gene
            {
                get
                {
                    return this.seqFeatData_geneField;
                }
                set
                {
                    this.seqFeatData_geneField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_prot
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_protProtref protrefField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Prot-ref")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_protProtref Protref
            {
                get
                {
                    return this.protrefField;
                }
                set
                {
                    this.protrefField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_protProtref
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_protProtrefProtref_name protref_nameField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_protProtrefProtref_processed protref_processedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Prot-ref_name")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_protProtrefProtref_name Protref_name
            {
                get
                {
                    return this.protref_nameField;
                }
                set
                {
                    this.protref_nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Prot-ref_processed")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_protProtrefProtref_processed Protref_processed
            {
                get
                {
                    return this.protref_processedField;
                }
                set
                {
                    this.protref_processedField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_protProtrefProtref_name
        {

            private string protref_name_EField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Prot-ref_name_E")]
            public string Protref_name_E
            {
                get
                {
                    return this.protref_name_EField;
                }
                set
                {
                    this.protref_name_EField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_protProtrefProtref_processed
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pub
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdesc pubdescField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdesc Pubdesc
            {
                get
                {
                    return this.pubdescField;
                }
                set
                {
                    this.pubdescField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdesc
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pub pubdesc_pubField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pub Pubdesc_pub
            {
                get
                {
                    return this.pubdesc_pubField;
                }
                set
                {
                    this.pubdesc_pubField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pub
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPub[] pubequivField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Pub-equiv")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Pub", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPub[] Pubequiv
            {
                get
                {
                    return this.pubequivField;
                }
                set
                {
                    this.pubequivField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPub
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_article pub_articleField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_pmid pub_pmidField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_article Pub_article
            {
                get
                {
                    return this.pub_articleField;
                }
                set
                {
                    this.pub_articleField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_pmid Pub_pmid
            {
                get
                {
                    return this.pub_pmidField;
                }
                set
                {
                    this.pub_pmidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_article
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitart citartField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-art")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitart Citart
            {
                get
                {
                    return this.citartField;
                }
                set
                {
                    this.citartField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitart
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_title citart_titleField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authors citart_authorsField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_from citart_fromField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_ids citart_idsField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-art_title")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_title Citart_title
            {
                get
                {
                    return this.citart_titleField;
                }
                set
                {
                    this.citart_titleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-art_authors")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authors Citart_authors
            {
                get
                {
                    return this.citart_authorsField;
                }
                set
                {
                    this.citart_authorsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-art_from")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_from Citart_from
            {
                get
                {
                    return this.citart_fromField;
                }
                set
                {
                    this.citart_fromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-art_ids")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_ids Citart_ids
            {
                get
                {
                    return this.citart_idsField;
                }
                set
                {
                    this.citart_idsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_title
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_titleTitle titleField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_titleTitle Title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_titleTitle
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_titleTitleTitle_E title_EField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_titleTitleTitle_E Title_E
            {
                get
                {
                    return this.title_EField;
                }
                set
                {
                    this.title_EField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_titleTitleTitle_E
        {

            private string title_E_nameField;

            /// <remarks/>
            public string Title_E_name
            {
                get
                {
                    return this.title_E_nameField;
                }
                set
                {
                    this.title_E_nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authors
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlist authlistField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Auth-list")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlist Authlist
            {
                get
                {
                    return this.authlistField;
                }
                set
                {
                    this.authlistField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlist
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_names authlist_namesField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_affil authlist_affilField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Auth-list_names")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_names Authlist_names
            {
                get
                {
                    return this.authlist_namesField;
                }
                set
                {
                    this.authlist_namesField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Auth-list_affil")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_affil Authlist_affil
            {
                get
                {
                    return this.authlist_affilField;
                }
                set
                {
                    this.authlist_affilField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_names
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthor[] authlist_names_stdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Auth-list_names_std")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Author", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthor[] Authlist_names_std
            {
                get
                {
                    return this.authlist_names_stdField;
                }
                set
                {
                    this.authlist_names_stdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthor
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_name author_nameField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_affil author_affilField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_name Author_name
            {
                get
                {
                    return this.author_nameField;
                }
                set
                {
                    this.author_nameField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_affil Author_affil
            {
                get
                {
                    return this.author_affilField;
                }
                set
                {
                    this.author_affilField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_name
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonid personidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Person-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonid Personid
            {
                get
                {
                    return this.personidField;
                }
                set
                {
                    this.personidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonid
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_name personid_nameField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Person-id_name")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_name Personid_name
            {
                get
                {
                    return this.personid_nameField;
                }
                set
                {
                    this.personid_nameField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_name
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_nameNamestd namestdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_nameNamestd Namestd
            {
                get
                {
                    return this.namestdField;
                }
                set
                {
                    this.namestdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_namePersonidPersonid_nameNamestd
        {

            private string namestd_lastField;

            private string namestd_firstField;

            private string namestd_initialsField;

            private string namestd_suffixField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std_last")]
            public string Namestd_last
            {
                get
                {
                    return this.namestd_lastField;
                }
                set
                {
                    this.namestd_lastField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std_first")]
            public string Namestd_first
            {
                get
                {
                    return this.namestd_firstField;
                }
                set
                {
                    this.namestd_firstField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std_initials")]
            public string Namestd_initials
            {
                get
                {
                    return this.namestd_initialsField;
                }
                set
                {
                    this.namestd_initialsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Name-std_suffix")]
            public string Namestd_suffix
            {
                get
                {
                    return this.namestd_suffixField;
                }
                set
                {
                    this.namestd_suffixField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_affil
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_affilAffil affilField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_affilAffil Affil
            {
                get
                {
                    return this.affilField;
                }
                set
                {
                    this.affilField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_namesAuthorAuthor_affilAffil
        {

            private string affil_strField;

            /// <remarks/>
            public string Affil_str
            {
                get
                {
                    return this.affil_strField;
                }
                set
                {
                    this.affil_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_affil
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_affilAffil affilField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_affilAffil Affil
            {
                get
                {
                    return this.affilField;
                }
                set
                {
                    this.affilField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_authorsAuthlistAuthlist_affilAffil
        {

            private string affil_strField;

            /// <remarks/>
            public string Affil_str
            {
                get
                {
                    return this.affil_strField;
                }
                set
                {
                    this.affil_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_from
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journal citart_from_journalField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-art_from_journal")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journal Citart_from_journal
            {
                get
                {
                    return this.citart_from_journalField;
                }
                set
                {
                    this.citart_from_journalField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journal
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjour citjourField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-jour")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjour Citjour
            {
                get
                {
                    return this.citjourField;
                }
                set
                {
                    this.citjourField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjour
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_title citjour_titleField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_imp citjour_impField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-jour_title")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_title Citjour_title
            {
                get
                {
                    return this.citjour_titleField;
                }
                set
                {
                    this.citjour_titleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Cit-jour_imp")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_imp Citjour_imp
            {
                get
                {
                    return this.citjour_impField;
                }
                set
                {
                    this.citjour_impField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_title
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_titleTitle_E[] titleField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("Title_E", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_titleTitle_E[] Title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_titleTitle_E
        {

            private string title_E_nameField;

            private string title_E_issnField;

            private string title_E_mljtaField;

            private string title_E_isojtaField;

            /// <remarks/>
            public string Title_E_name
            {
                get
                {
                    return this.title_E_nameField;
                }
                set
                {
                    this.title_E_nameField = value;
                }
            }

            /// <remarks/>
            public string Title_E_issn
            {
                get
                {
                    return this.title_E_issnField;
                }
                set
                {
                    this.title_E_issnField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Title_E_ml-jta")]
            public string Title_E_mljta
            {
                get
                {
                    return this.title_E_mljtaField;
                }
                set
                {
                    this.title_E_mljtaField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Title_E_iso-jta")]
            public string Title_E_isojta
            {
                get
                {
                    return this.title_E_isojtaField;
                }
                set
                {
                    this.title_E_isojtaField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_imp
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprint imprintField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprint Imprint
            {
                get
                {
                    return this.imprintField;
                }
                set
                {
                    this.imprintField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprint
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_date imprint_dateField;

            private ushort imprint_volumeField;

            private byte imprint_issueField;

            private string imprint_pagesField;

            private string imprint_languageField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_pubstatus imprint_pubstatusField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_history imprint_historyField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_date Imprint_date
            {
                get
                {
                    return this.imprint_dateField;
                }
                set
                {
                    this.imprint_dateField = value;
                }
            }

            /// <remarks/>
            public ushort Imprint_volume
            {
                get
                {
                    return this.imprint_volumeField;
                }
                set
                {
                    this.imprint_volumeField = value;
                }
            }

            /// <remarks/>
            public byte Imprint_issue
            {
                get
                {
                    return this.imprint_issueField;
                }
                set
                {
                    this.imprint_issueField = value;
                }
            }

            /// <remarks/>
            public string Imprint_pages
            {
                get
                {
                    return this.imprint_pagesField;
                }
                set
                {
                    this.imprint_pagesField = value;
                }
            }

            /// <remarks/>
            public string Imprint_language
            {
                get
                {
                    return this.imprint_languageField;
                }
                set
                {
                    this.imprint_languageField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_pubstatus Imprint_pubstatus
            {
                get
                {
                    return this.imprint_pubstatusField;
                }
                set
                {
                    this.imprint_pubstatusField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_history Imprint_history
            {
                get
                {
                    return this.imprint_historyField;
                }
                set
                {
                    this.imprint_historyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_date
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_dateDate dateField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_dateDate Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_dateDate
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_dateDateDate_std date_stdField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_dateDateDate_std Date_std
            {
                get
                {
                    return this.date_stdField;
                }
                set
                {
                    this.date_stdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_dateDateDate_std
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_dateDateDate_stdDatestd datestdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_dateDateDate_stdDatestd Datestd
            {
                get
                {
                    return this.datestdField;
                }
                set
                {
                    this.datestdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_dateDateDate_stdDatestd
        {

            private ushort datestd_yearField;

            private byte datestd_monthField;

            private byte datestd_dayField;

            private bool datestd_dayFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_year")]
            public ushort Datestd_year
            {
                get
                {
                    return this.datestd_yearField;
                }
                set
                {
                    this.datestd_yearField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_month")]
            public byte Datestd_month
            {
                get
                {
                    return this.datestd_monthField;
                }
                set
                {
                    this.datestd_monthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_day")]
            public byte Datestd_day
            {
                get
                {
                    return this.datestd_dayField;
                }
                set
                {
                    this.datestd_dayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Datestd_daySpecified
            {
                get
                {
                    return this.datestd_dayFieldSpecified;
                }
                set
                {
                    this.datestd_dayFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_pubstatus
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_pubstatusPubStatus pubStatusField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_pubstatusPubStatus PubStatus
            {
                get
                {
                    return this.pubStatusField;
                }
                set
                {
                    this.pubStatusField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_pubstatusPubStatus
        {

            private string valueField;

            private byte valueField1;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField1;
                }
                set
                {
                    this.valueField1 = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_history
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDate[] pubStatusDateSetField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("PubStatusDate", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDate[] PubStatusDateSet
            {
                get
                {
                    return this.pubStatusDateSetField;
                }
                set
                {
                    this.pubStatusDateSetField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDate
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_pubstatus pubStatusDate_pubstatusField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_date pubStatusDate_dateField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_pubstatus PubStatusDate_pubstatus
            {
                get
                {
                    return this.pubStatusDate_pubstatusField;
                }
                set
                {
                    this.pubStatusDate_pubstatusField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_date PubStatusDate_date
            {
                get
                {
                    return this.pubStatusDate_dateField;
                }
                set
                {
                    this.pubStatusDate_dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_pubstatus
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_pubstatusPubStatus pubStatusField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_pubstatusPubStatus PubStatus
            {
                get
                {
                    return this.pubStatusField;
                }
                set
                {
                    this.pubStatusField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_pubstatusPubStatus
        {

            private string valueField;

            private byte valueField1;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public byte Value
            {
                get
                {
                    return this.valueField1;
                }
                set
                {
                    this.valueField1 = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_date
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_dateDate dateField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_dateDate Date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_dateDate
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_dateDateDate_std date_stdField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_dateDateDate_std Date_std
            {
                get
                {
                    return this.date_stdField;
                }
                set
                {
                    this.date_stdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_dateDateDate_std
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_dateDateDate_stdDatestd datestdField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_dateDateDate_stdDatestd Datestd
            {
                get
                {
                    return this.datestdField;
                }
                set
                {
                    this.datestdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_fromCitart_from_journalCitjourCitjour_impImprintImprint_historyPubStatusDatePubStatusDate_dateDateDate_stdDatestd
        {

            private ushort datestd_yearField;

            private byte datestd_monthField;

            private byte datestd_dayField;

            private byte datestd_hourField;

            private bool datestd_hourFieldSpecified;

            private byte datestd_minuteField;

            private bool datestd_minuteFieldSpecified;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_year")]
            public ushort Datestd_year
            {
                get
                {
                    return this.datestd_yearField;
                }
                set
                {
                    this.datestd_yearField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_month")]
            public byte Datestd_month
            {
                get
                {
                    return this.datestd_monthField;
                }
                set
                {
                    this.datestd_monthField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_day")]
            public byte Datestd_day
            {
                get
                {
                    return this.datestd_dayField;
                }
                set
                {
                    this.datestd_dayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_hour")]
            public byte Datestd_hour
            {
                get
                {
                    return this.datestd_hourField;
                }
                set
                {
                    this.datestd_hourField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Datestd_hourSpecified
            {
                get
                {
                    return this.datestd_hourFieldSpecified;
                }
                set
                {
                    this.datestd_hourFieldSpecified = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Date-std_minute")]
            public byte Datestd_minute
            {
                get
                {
                    return this.datestd_minuteField;
                }
                set
                {
                    this.datestd_minuteField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlIgnoreAttribute()]
            public bool Datestd_minuteSpecified
            {
                get
                {
                    return this.datestd_minuteFieldSpecified;
                }
                set
                {
                    this.datestd_minuteFieldSpecified = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_ids
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleId[] articleIdSetField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("ArticleId", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleId[] ArticleIdSet
            {
                get
                {
                    return this.articleIdSetField;
                }
                set
                {
                    this.articleIdSetField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleId
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_pii articleId_piiField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_other articleId_otherField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_doi articleId_doiField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_pubmed articleId_pubmedField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_pii ArticleId_pii
            {
                get
                {
                    return this.articleId_piiField;
                }
                set
                {
                    this.articleId_piiField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_other ArticleId_other
            {
                get
                {
                    return this.articleId_otherField;
                }
                set
                {
                    this.articleId_otherField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_doi ArticleId_doi
            {
                get
                {
                    return this.articleId_doiField;
                }
                set
                {
                    this.articleId_doiField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_pubmed ArticleId_pubmed
            {
                get
                {
                    return this.articleId_pubmedField;
                }
                set
                {
                    this.articleId_pubmedField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_pii
        {

            private string pIIField;

            /// <remarks/>
            public string PII
            {
                get
                {
                    return this.pIIField;
                }
                set
                {
                    this.pIIField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_other
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_otherDbtag dbtagField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_otherDbtag Dbtag
            {
                get
                {
                    return this.dbtagField;
                }
                set
                {
                    this.dbtagField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_otherDbtag
        {

            private string dbtag_dbField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_otherDbtagDbtag_tag dbtag_tagField;

            /// <remarks/>
            public string Dbtag_db
            {
                get
                {
                    return this.dbtag_dbField;
                }
                set
                {
                    this.dbtag_dbField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_otherDbtagDbtag_tag Dbtag_tag
            {
                get
                {
                    return this.dbtag_tagField;
                }
                set
                {
                    this.dbtag_tagField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_otherDbtagDbtag_tag
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_otherDbtagDbtag_tagObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_otherDbtagDbtag_tagObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_otherDbtagDbtag_tagObjectid
        {

            private string objectid_strField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_str")]
            public string Objectid_str
            {
                get
                {
                    return this.objectid_strField;
                }
                set
                {
                    this.objectid_strField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_doi
        {

            private string dOIField;

            /// <remarks/>
            public string DOI
            {
                get
                {
                    return this.dOIField;
                }
                set
                {
                    this.dOIField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_articleCitartCitart_idsArticleIdArticleId_pubmed
        {

            private uint pubMedIdField;

            /// <remarks/>
            public uint PubMedId
            {
                get
                {
                    return this.pubMedIdField;
                }
                set
                {
                    this.pubMedIdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_pubPubdescPubdesc_pubPubPub_pmid
        {

            private uint pubMedIdField;

            /// <remarks/>
            public uint PubMedId
            {
                get
                {
                    return this.pubMedIdField;
                }
                set
                {
                    this.pubMedIdField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_imp
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_impImpfeat impfeatField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Imp-feat")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_impImpfeat Impfeat
            {
                get
                {
                    return this.impfeatField;
                }
                set
                {
                    this.impfeatField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_impImpfeat
        {

            private string impfeat_keyField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Imp-feat_key")]
            public string Impfeat_key
            {
                get
                {
                    return this.impfeat_keyField;
                }
                set
                {
                    this.impfeat_keyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_gene
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_geneGeneref generefField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Gene-ref")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_geneGeneref Generef
            {
                get
                {
                    return this.generefField;
                }
                set
                {
                    this.generefField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_geneGeneref
        {

            private string generef_locusField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_geneGenerefGeneref_syn generef_synField;

            private string generef_locustagField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Gene-ref_locus")]
            public string Generef_locus
            {
                get
                {
                    return this.generef_locusField;
                }
                set
                {
                    this.generef_locusField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Gene-ref_syn")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_geneGenerefGeneref_syn Generef_syn
            {
                get
                {
                    return this.generef_synField;
                }
                set
                {
                    this.generef_synField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Gene-ref_locus-tag")]
            public string Generef_locustag
            {
                get
                {
                    return this.generef_locustagField;
                }
                set
                {
                    this.generef_locustagField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_geneGenerefGeneref_syn
        {

            private string generef_syn_EField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Gene-ref_syn_E")]
            public string Generef_syn_E
            {
                get
                {
                    return this.generef_syn_EField;
                }
                set
                {
                    this.generef_syn_EField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_partial
        {

            private bool valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_product
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqloc seqlocField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqloc Seqloc
            {
                get
                {
                    return this.seqlocField;
                }
                set
                {
                    this.seqlocField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqloc
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_whole seqloc_wholeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc_whole")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_whole Seqloc_whole
            {
                get
                {
                    return this.seqloc_wholeField;
                }
                set
                {
                    this.seqloc_wholeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_whole
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_wholeSeqid seqidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_wholeSeqid Seqid
            {
                get
                {
                    return this.seqidField;
                }
                set
                {
                    this.seqidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_wholeSeqid
        {

            private uint seqid_giField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id_gi")]
            public uint Seqid_gi
            {
                get
                {
                    return this.seqid_giField;
                }
                set
                {
                    this.seqid_giField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_location
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqloc seqlocField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqloc Seqloc
            {
                get
                {
                    return this.seqlocField;
                }
                set
                {
                    this.seqlocField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqloc
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mix seqloc_mixField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_int seqloc_intField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc_mix")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mix Seqloc_mix
            {
                get
                {
                    return this.seqloc_mixField;
                }
                set
                {
                    this.seqloc_mixField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc_int")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_int Seqloc_int
            {
                get
                {
                    return this.seqloc_intField;
                }
                set
                {
                    this.seqloc_intField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mix
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqloc[] seqlocmixField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Seq-loc-mix")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Seq-loc", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqloc[] Seqlocmix
            {
                get
                {
                    return this.seqlocmixField;
                }
                set
                {
                    this.seqlocmixField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqloc
        {

            private object seqloc_nullField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_int seqloc_intField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc_null")]
            public object Seqloc_null
            {
                get
                {
                    return this.seqloc_nullField;
                }
                set
                {
                    this.seqloc_nullField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc_int")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_int Seqloc_int
            {
                get
                {
                    return this.seqloc_intField;
                }
                set
                {
                    this.seqloc_intField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_int
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqinterval seqintervalField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqinterval Seqinterval
            {
                get
                {
                    return this.seqintervalField;
                }
                set
                {
                    this.seqintervalField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqinterval
        {

            private ushort seqinterval_fromField;

            private ushort seqinterval_toField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_strand seqinterval_strandField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_id seqinterval_idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_from")]
            public ushort Seqinterval_from
            {
                get
                {
                    return this.seqinterval_fromField;
                }
                set
                {
                    this.seqinterval_fromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_to")]
            public ushort Seqinterval_to
            {
                get
                {
                    return this.seqinterval_toField;
                }
                set
                {
                    this.seqinterval_toField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_strand")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_strand Seqinterval_strand
            {
                get
                {
                    return this.seqinterval_strandField;
                }
                set
                {
                    this.seqinterval_strandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_id Seqinterval_id
            {
                get
                {
                    return this.seqinterval_idField;
                }
                set
                {
                    this.seqinterval_idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_strand
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_strandNastrand nastrandField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Na-strand")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_strandNastrand Nastrand
            {
                get
                {
                    return this.nastrandField;
                }
                set
                {
                    this.nastrandField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_strandNastrand
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_id
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_idSeqid seqidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_idSeqid Seqid
            {
                get
                {
                    return this.seqidField;
                }
                set
                {
                    this.seqidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_mixSeqlocSeqloc_intSeqintervalSeqinterval_idSeqid
        {

            private uint seqid_giField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id_gi")]
            public uint Seqid_gi
            {
                get
                {
                    return this.seqid_giField;
                }
                set
                {
                    this.seqid_giField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_int
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqinterval seqintervalField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqinterval Seqinterval
            {
                get
                {
                    return this.seqintervalField;
                }
                set
                {
                    this.seqintervalField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqinterval
        {

            private ushort seqinterval_fromField;

            private ushort seqinterval_toField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strand seqinterval_strandField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_id seqinterval_idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_from")]
            public ushort Seqinterval_from
            {
                get
                {
                    return this.seqinterval_fromField;
                }
                set
                {
                    this.seqinterval_fromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_to")]
            public ushort Seqinterval_to
            {
                get
                {
                    return this.seqinterval_toField;
                }
                set
                {
                    this.seqinterval_toField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_strand")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strand Seqinterval_strand
            {
                get
                {
                    return this.seqinterval_strandField;
                }
                set
                {
                    this.seqinterval_strandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_id Seqinterval_id
            {
                get
                {
                    return this.seqinterval_idField;
                }
                set
                {
                    this.seqinterval_idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strand
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strandNastrand nastrandField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Na-strand")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strandNastrand Nastrand
            {
                get
                {
                    return this.nastrandField;
                }
                set
                {
                    this.nastrandField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strandNastrand
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_id
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_idSeqid seqidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_idSeqid Seqid
            {
                get
                {
                    return this.seqidField;
                }
                set
                {
                    this.seqidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_idSeqid
        {

            private uint seqid_giField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id_gi")]
            public uint Seqid_gi
            {
                get
                {
                    return this.seqid_giField;
                }
                set
                {
                    this.seqid_giField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatGbqual
        {

            private string gbqual_qualField;

            private string gbqual_valField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Gb-qual_qual")]
            public string Gbqual_qual
            {
                get
                {
                    return this.gbqual_qualField;
                }
                set
                {
                    this.gbqual_qualField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Gb-qual_val")]
            public string Gbqual_val
            {
                get
                {
                    return this.gbqual_valField;
                }
                set
                {
                    this.gbqual_valField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxref
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxrefDbtag dbtagField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxrefDbtag Dbtag
            {
                get
                {
                    return this.dbtagField;
                }
                set
                {
                    this.dbtagField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxrefDbtag
        {

            private string dbtag_dbField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxrefDbtagDbtag_tag dbtag_tagField;

            /// <remarks/>
            public string Dbtag_db
            {
                get
                {
                    return this.dbtag_dbField;
                }
                set
                {
                    this.dbtag_dbField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxrefDbtagDbtag_tag Dbtag_tag
            {
                get
                {
                    return this.dbtag_tagField;
                }
                set
                {
                    this.dbtag_tagField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxrefDbtagDbtag_tag
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxrefDbtagDbtag_tagObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxrefDbtagDbtag_tagObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetSeqentrySeqentry_seqBioseqBioseq_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dbxrefDbtagDbtag_tagObjectid
        {

            private uint objectid_idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_id")]
            public uint Objectid_id
            {
                get
                {
                    return this.objectid_idField;
                }
                set
                {
                    this.objectid_idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annot
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannot seqannotField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-annot")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannot Seqannot
            {
                get
                {
                    return this.seqannotField;
                }
                set
                {
                    this.seqannotField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannot
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_data seqannot_dataField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-annot_data")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_data Seqannot_data
            {
                get
                {
                    return this.seqannot_dataField;
                }
                set
                {
                    this.seqannot_dataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_data
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeat[] seqannot_data_ftableField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Seq-annot_data_ftable")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Seq-feat", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeat[] Seqannot_data_ftable
            {
                get
                {
                    return this.seqannot_data_ftableField;
                }
                set
                {
                    this.seqannot_data_ftableField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeat
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_id seqfeat_idField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_data seqfeat_dataField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_except seqfeat_exceptField;

            private string seqfeat_commentField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_product seqfeat_productField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_location seqfeat_locationField;

            private string seqfeat_excepttextField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_id Seqfeat_id
            {
                get
                {
                    return this.seqfeat_idField;
                }
                set
                {
                    this.seqfeat_idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_data")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_data Seqfeat_data
            {
                get
                {
                    return this.seqfeat_dataField;
                }
                set
                {
                    this.seqfeat_dataField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_except")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_except Seqfeat_except
            {
                get
                {
                    return this.seqfeat_exceptField;
                }
                set
                {
                    this.seqfeat_exceptField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_comment")]
            public string Seqfeat_comment
            {
                get
                {
                    return this.seqfeat_commentField;
                }
                set
                {
                    this.seqfeat_commentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_product")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_product Seqfeat_product
            {
                get
                {
                    return this.seqfeat_productField;
                }
                set
                {
                    this.seqfeat_productField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_location")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_location Seqfeat_location
            {
                get
                {
                    return this.seqfeat_locationField;
                }
                set
                {
                    this.seqfeat_locationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-feat_except-text")]
            public string Seqfeat_excepttext
            {
                get
                {
                    return this.seqfeat_excepttextField;
                }
                set
                {
                    this.seqfeat_excepttextField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_id
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatid featidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Feat-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatid Featid
            {
                get
                {
                    return this.featidField;
                }
                set
                {
                    this.featidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatid
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_local featid_localField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Feat-id_local")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_local Featid_local
            {
                get
                {
                    return this.featid_localField;
                }
                set
                {
                    this.featid_localField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_local
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_localObjectid objectidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_localObjectid Objectid
            {
                get
                {
                    return this.objectidField;
                }
                set
                {
                    this.objectidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_idFeatidFeatid_localObjectid
        {

            private byte objectid_idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Object-id_id")]
            public byte Objectid_id
            {
                get
                {
                    return this.objectid_idField;
                }
                set
                {
                    this.objectid_idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_data
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatData seqFeatDataField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatData SeqFeatData
            {
                get
                {
                    return this.seqFeatDataField;
                }
                set
                {
                    this.seqFeatDataField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatData
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregion seqFeatData_cdregionField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregion SeqFeatData_cdregion
            {
                get
                {
                    return this.seqFeatData_cdregionField;
                }
                set
                {
                    this.seqFeatData_cdregionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregion
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregion cdregionField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregion Cdregion
            {
                get
                {
                    return this.cdregionField;
                }
                set
                {
                    this.cdregionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregion
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_frame cdregion_frameField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_code cdregion_codeField;

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_frame Cdregion_frame
            {
                get
                {
                    return this.cdregion_frameField;
                }
                set
                {
                    this.cdregion_frameField = value;
                }
            }

            /// <remarks/>
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_code Cdregion_code
            {
                get
                {
                    return this.cdregion_codeField;
                }
                set
                {
                    this.cdregion_codeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_frame
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_code
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_codeGeneticcode geneticcodeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Genetic-code")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_codeGeneticcode Geneticcode
            {
                get
                {
                    return this.geneticcodeField;
                }
                set
                {
                    this.geneticcodeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_codeGeneticcode
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_codeGeneticcodeGeneticcode_E geneticcode_EField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Genetic-code_E")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_codeGeneticcodeGeneticcode_E Geneticcode_E
            {
                get
                {
                    return this.geneticcode_EField;
                }
                set
                {
                    this.geneticcode_EField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_dataSeqFeatDataSeqFeatData_cdregionCdregionCdregion_codeGeneticcodeGeneticcode_E
        {

            private byte geneticcode_E_idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Genetic-code_E_id")]
            public byte Geneticcode_E_id
            {
                get
                {
                    return this.geneticcode_E_idField;
                }
                set
                {
                    this.geneticcode_E_idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_except
        {

            private bool valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_product
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqloc seqlocField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqloc Seqloc
            {
                get
                {
                    return this.seqlocField;
                }
                set
                {
                    this.seqlocField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqloc
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_whole seqloc_wholeField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc_whole")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_whole Seqloc_whole
            {
                get
                {
                    return this.seqloc_wholeField;
                }
                set
                {
                    this.seqloc_wholeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_whole
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_wholeSeqid seqidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_wholeSeqid Seqid
            {
                get
                {
                    return this.seqidField;
                }
                set
                {
                    this.seqidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_productSeqlocSeqloc_wholeSeqid
        {

            private uint seqid_giField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id_gi")]
            public uint Seqid_gi
            {
                get
                {
                    return this.seqid_giField;
                }
                set
                {
                    this.seqid_giField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_location
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqloc seqlocField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqloc Seqloc
            {
                get
                {
                    return this.seqlocField;
                }
                set
                {
                    this.seqlocField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqloc
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_int seqloc_intField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedint seqloc_packedintField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc_int")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_int Seqloc_int
            {
                get
                {
                    return this.seqloc_intField;
                }
                set
                {
                    this.seqloc_intField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-loc_packed-int")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedint Seqloc_packedint
            {
                get
                {
                    return this.seqloc_packedintField;
                }
                set
                {
                    this.seqloc_packedintField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_int
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqinterval seqintervalField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqinterval Seqinterval
            {
                get
                {
                    return this.seqintervalField;
                }
                set
                {
                    this.seqintervalField = value;
                }
            }
        }
     //cazzo
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqinterval
        {

            private ushort seqinterval_fromField;

            private ushort seqinterval_toField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strand seqinterval_strandField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_id seqinterval_idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_from")]
            public ushort Seqinterval_from
            {
                get
                {
                    return this.seqinterval_fromField;
                }
                set
                {
                    this.seqinterval_fromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_to")]
            public ushort Seqinterval_to
            {
                get
                {
                    return this.seqinterval_toField;
                }
                set
                {
                    this.seqinterval_toField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_strand")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strand Seqinterval_strand
            {
                get
                {
                    return this.seqinterval_strandField;
                }
                set
                {
                    this.seqinterval_strandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_id Seqinterval_id
            {
                get
                {
                    return this.seqinterval_idField;
                }
                set
                {
                    this.seqinterval_idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strand
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strandNastrand nastrandField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Na-strand")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strandNastrand Nastrand
            {
                get
                {
                    return this.nastrandField;
                }
                set
                {
                    this.nastrandField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_strandNastrand
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_id
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_idSeqid seqidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_idSeqid Seqid
            {
                get
                {
                    return this.seqidField;
                }
                set
                {
                    this.seqidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_intSeqintervalSeqinterval_idSeqid
        {

            private uint seqid_giField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id_gi")]
            public uint Seqid_gi
            {
                get
                {
                    return this.seqid_giField;
                }
                set
                {
                    this.seqid_giField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedint
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqinterval[] packedseqintField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayAttribute("Packed-seqint")]
            [System.Xml.Serialization.XmlArrayItemAttribute("Seq-interval", IsNullable = false)]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqinterval[] Packedseqint
            {
                get
                {
                    return this.packedseqintField;
                }
                set
                {
                    this.packedseqintField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqinterval
        {

            private ushort seqinterval_fromField;

            private ushort seqinterval_toField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_strand seqinterval_strandField;

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_id seqinterval_idField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_from")]
            public ushort Seqinterval_from
            {
                get
                {
                    return this.seqinterval_fromField;
                }
                set
                {
                    this.seqinterval_fromField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_to")]
            public ushort Seqinterval_to
            {
                get
                {
                    return this.seqinterval_toField;
                }
                set
                {
                    this.seqinterval_toField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_strand")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_strand Seqinterval_strand
            {
                get
                {
                    return this.seqinterval_strandField;
                }
                set
                {
                    this.seqinterval_strandField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-interval_id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_id Seqinterval_id
            {
                get
                {
                    return this.seqinterval_idField;
                }
                set
                {
                    this.seqinterval_idField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_strand
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_strandNastrand nastrandField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Na-strand")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_strandNastrand Nastrand
            {
                get
                {
                    return this.nastrandField;
                }
                set
                {
                    this.nastrandField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_strandNastrand
        {

            private string valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_id
        {

            private BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_idSeqid seqidField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id")]
            public BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_idSeqid Seqid
            {
                get
                {
                    return this.seqidField;
                }
                set
                {
                    this.seqidField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class BioseqsetBioseqset_seqsetSeqentrySeqentry_setBioseqsetBioseqset_annotSeqannotSeqannot_dataSeqfeatSeqfeat_locationSeqlocSeqloc_packedintSeqintervalSeqinterval_idSeqid
        {

            private uint seqid_giField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Seq-id_gi")]
            public uint Seqid_gi
            {
                get
                {
                    return this.seqid_giField;
                }
                set
                {
                    this.seqid_giField = value;
                }
            }
        }


    
}
