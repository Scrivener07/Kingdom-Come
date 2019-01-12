// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class BodyMaterial2subpart : KaitaiStruct
    {
        public static BodyMaterial2subpart FromFile(string fileName)
        {
            return new BodyMaterial2subpart(new KaitaiStream(fileName));
        }

        public BodyMaterial2subpart(KaitaiStream p__io, KaitaiStruct p__parent = null, BodyMaterial2subpart p__root = null) : base(p__io)
        {
            m_parent = p__parent;
            m_root = p__root ?? this;
            _read();
        }
        private void _read()
        {
            _table = new Header(m_io, this, m_root);
            _rows = new List<Row>((int) (Table.RowCount));
            for (var i = 0; i < Table.RowCount; i++)
            {
                _rows.Add(new Row(m_io, this, m_root));
            }
            _strings = new List<string>((int) (Table.UniqueStringsCount));
            for (var i = 0; i < Table.UniqueStringsCount; i++)
            {
                _strings.Add(System.Text.Encoding.GetEncoding("utf-8").GetString(m_io.ReadBytesTerm(0, false, true, true)));
            }
        }
        public partial class Header : KaitaiStruct
        {
            public static Header FromFile(string fileName)
            {
                return new Header(new KaitaiStream(fileName));
            }

            public Header(KaitaiStream p__io, BodyMaterial2subpart p__parent = null, BodyMaterial2subpart p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _version = m_io.ReadS4le();
                _descriptorsHash = m_io.ReadU4le();
                _layoutHash = m_io.ReadU4le();
                _tableVersion = m_io.ReadS4le();
                _rowCount = m_io.ReadS4le();
                _stringDataSize = m_io.ReadS4le();
                _uniqueStringsCount = m_io.ReadS4le();
            }
            private int _version;
            private uint _descriptorsHash;
            private uint _layoutHash;
            private int _tableVersion;
            private int _rowCount;
            private int _stringDataSize;
            private int _uniqueStringsCount;
            private BodyMaterial2subpart m_root;
            private BodyMaterial2subpart m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public BodyMaterial2subpart M_Root { get { return m_root; } }
            public BodyMaterial2subpart M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, BodyMaterial2subpart p__parent = null, BodyMaterial2subpart p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _bodyMaterialId = m_io.ReadS4le();
                _raceId = m_io.ReadS4le();
                _bodyMaterialName = m_io.ReadS4le();
                _bodySubpartId = m_io.ReadS4le();
                _bloodZoneId = m_io.ReadS4le();
            }
            private int _bodyMaterialId;
            private int _raceId;
            private int _bodyMaterialName;
            private int _bodySubpartId;
            private int _bloodZoneId;
            private BodyMaterial2subpart m_root;
            private BodyMaterial2subpart m_parent;
            public int BodyMaterialId { get { return _bodyMaterialId; } }
            public int RaceId { get { return _raceId; } }
            public int BodyMaterialName { get { return _bodyMaterialName; } }
            public int BodySubpartId { get { return _bodySubpartId; } }
            public int BloodZoneId { get { return _bloodZoneId; } }
            public BodyMaterial2subpart M_Root { get { return m_root; } }
            public BodyMaterial2subpart M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private BodyMaterial2subpart m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public BodyMaterial2subpart M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
