// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class AttachmentBase : KaitaiStruct
    {
        public static AttachmentBase FromFile(string fileName)
        {
            return new AttachmentBase(new KaitaiStream(fileName));
        }

        public AttachmentBase(KaitaiStream p__io, KaitaiStruct p__parent = null, AttachmentBase p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, AttachmentBase p__parent = null, AttachmentBase p__root = null) : base(p__io)
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
            private AttachmentBase m_root;
            private AttachmentBase m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public AttachmentBase M_Root { get { return m_root; } }
            public AttachmentBase M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, AttachmentBase p__parent = null, AttachmentBase p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _computerName = m_io.ReadS4le();
                _timestamp = m_io.ReadS4le();
                _attachmentBaseId = m_io.ReadBytes(16);
                _attachmentBaseName = m_io.ReadS4le();
                _raceId = m_io.ReadS4le();
                _genderId = m_io.ReadS4le();
                _model = m_io.ReadS4le();
                _material = m_io.ReadS4le();
                _lodPersistence = m_io.ReadF4le();
                _attachmentSlotId = m_io.ReadS4le();
            }
            private int _computerName;
            private int _timestamp;
            private byte[] _attachmentBaseId;
            private int _attachmentBaseName;
            private int _raceId;
            private int _genderId;
            private int _model;
            private int _material;
            private float _lodPersistence;
            private int _attachmentSlotId;
            private AttachmentBase m_root;
            private AttachmentBase m_parent;
            public int ComputerName { get { return _computerName; } }
            public int Timestamp { get { return _timestamp; } }
            public byte[] AttachmentBaseId { get { return _attachmentBaseId; } }
            public int AttachmentBaseName { get { return _attachmentBaseName; } }
            public int RaceId { get { return _raceId; } }
            public int GenderId { get { return _genderId; } }
            public int Model { get { return _model; } }
            public int Material { get { return _material; } }
            public float LodPersistence { get { return _lodPersistence; } }
            public int AttachmentSlotId { get { return _attachmentSlotId; } }
            public AttachmentBase M_Root { get { return m_root; } }
            public AttachmentBase M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private AttachmentBase m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public AttachmentBase M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
