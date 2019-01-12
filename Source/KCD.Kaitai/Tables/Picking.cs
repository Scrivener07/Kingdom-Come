// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class Picking : KaitaiStruct
    {
        public static Picking FromFile(string fileName)
        {
            return new Picking(new KaitaiStream(fileName));
        }

        public Picking(KaitaiStream p__io, KaitaiStruct p__parent = null, Picking p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, Picking p__parent = null, Picking p__root = null) : base(p__io)
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
            private Picking m_root;
            private Picking m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Picking M_Root { get { return m_root; } }
            public Picking M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Picking p__parent = null, Picking p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _mnFragment = m_io.ReadS4le();
                _mnFragTagState = m_io.ReadS4le();
                _mnOptionIdx = m_io.ReadS4le();
                _handOffset = new Vec3(m_io, this, m_root);
                _handRot = new Vec3(m_io, this, m_root);
                _handRotW = m_io.ReadF4le();
                _actorClassHash = m_io.ReadS4le();
                _isRightHand = m_io.ReadS1();
                _timestamp = m_io.ReadS8le();
                _isBSpace = m_io.ReadS1();
                _isSpecialized = m_io.ReadS1();
            }
            private int _mnFragment;
            private int _mnFragTagState;
            private int _mnOptionIdx;
            private Vec3 _handOffset;
            private Vec3 _handRot;
            private float _handRotW;
            private int _actorClassHash;
            private sbyte _isRightHand;
            private long _timestamp;
            private sbyte _isBSpace;
            private sbyte _isSpecialized;
            private Picking m_root;
            private Picking m_parent;
            public int MnFragment { get { return _mnFragment; } }
            public int MnFragTagState { get { return _mnFragTagState; } }
            public int MnOptionIdx { get { return _mnOptionIdx; } }
            public Vec3 HandOffset { get { return _handOffset; } }
            public Vec3 HandRot { get { return _handRot; } }
            public float HandRotW { get { return _handRotW; } }
            public int ActorClassHash { get { return _actorClassHash; } }
            public sbyte IsRightHand { get { return _isRightHand; } }
            public long Timestamp { get { return _timestamp; } }
            public sbyte IsBSpace { get { return _isBSpace; } }
            public sbyte IsSpecialized { get { return _isSpecialized; } }
            public Picking M_Root { get { return m_root; } }
            public Picking M_Parent { get { return m_parent; } }
        }
        public partial class Vec3 : KaitaiStruct
        {
            public static Vec3 FromFile(string fileName)
            {
                return new Vec3(new KaitaiStream(fileName));
            }

            public Vec3(KaitaiStream p__io, Picking.Row p__parent = null, Picking p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _x = m_io.ReadS4le();
                _y = m_io.ReadS4le();
                _z = m_io.ReadS4le();
            }
            private int _x;
            private int _y;
            private int _z;
            private Picking m_root;
            private Picking.Row m_parent;
            public int X { get { return _x; } }
            public int Y { get { return _y; } }
            public int Z { get { return _z; } }
            public Picking M_Root { get { return m_root; } }
            public Picking.Row M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Picking m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Picking M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
