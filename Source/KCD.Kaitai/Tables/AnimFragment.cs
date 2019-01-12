// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Library.Tables
{
    public partial class AnimFragment : KaitaiStruct
    {
        public static AnimFragment FromFile(string fileName)
        {
            return new AnimFragment(new KaitaiStream(fileName));
        }

        public AnimFragment(KaitaiStream p__io, KaitaiStruct p__parent = null, AnimFragment p__root = null) : base(p__io)
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

            public Header(KaitaiStream p__io, AnimFragment p__parent = null, AnimFragment p__root = null) : base(p__io)
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
            private AnimFragment m_root;
            private AnimFragment m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public AnimFragment M_Root { get { return m_root; } }
            public AnimFragment M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, AnimFragment p__parent = null, AnimFragment p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _actorClassHash = m_io.ReadS4le();
                _mnFragmentId = m_io.ReadS4le();
                _mnTags = m_io.ReadS4le();
                _mnOptionIndex = m_io.ReadS4le();
                _looped = m_io.ReadS1();
                _aligned = m_io.ReadS1();
                _alignTmPos = new Vec3(m_io, this, m_root);
                _alignTmRotv = new Vec3(m_io, this, m_root);
                _alignTmRotw = m_io.ReadF4le();
                _alignSecondary = new Quatt(m_io, this, m_root);
                _relativeMovementY = m_io.ReadF4le();
                _totalDuration = m_io.ReadF4le();
                _timestamp = m_io.ReadS8le();
                _relativeMovement = new Quatt(m_io, this, m_root);
            }
            private int _actorClassHash;
            private int _mnFragmentId;
            private int _mnTags;
            private int _mnOptionIndex;
            private sbyte _looped;
            private sbyte _aligned;
            private Vec3 _alignTmPos;
            private Vec3 _alignTmRotv;
            private float _alignTmRotw;
            private Quatt _alignSecondary;
            private float _relativeMovementY;
            private float _totalDuration;
            private long _timestamp;
            private Quatt _relativeMovement;
            private AnimFragment m_root;
            private AnimFragment m_parent;
            public int ActorClassHash { get { return _actorClassHash; } }
            public int MnFragmentId { get { return _mnFragmentId; } }
            public int MnTags { get { return _mnTags; } }
            public int MnOptionIndex { get { return _mnOptionIndex; } }
            public sbyte Looped { get { return _looped; } }
            public sbyte Aligned { get { return _aligned; } }
            public Vec3 AlignTmPos { get { return _alignTmPos; } }
            public Vec3 AlignTmRotv { get { return _alignTmRotv; } }
            public float AlignTmRotw { get { return _alignTmRotw; } }
            public Quatt AlignSecondary { get { return _alignSecondary; } }
            public float RelativeMovementY { get { return _relativeMovementY; } }
            public float TotalDuration { get { return _totalDuration; } }
            public long Timestamp { get { return _timestamp; } }
            public Quatt RelativeMovement { get { return _relativeMovement; } }
            public AnimFragment M_Root { get { return m_root; } }
            public AnimFragment M_Parent { get { return m_parent; } }
        }
        public partial class Quatt : KaitaiStruct
        {
            public static Quatt FromFile(string fileName)
            {
                return new Quatt(new KaitaiStream(fileName));
            }

            public Quatt(KaitaiStream p__io, AnimFragment.Row p__parent = null, AnimFragment p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _quattData = m_io.ReadBytes(28);
            }
            private byte[] _quattData;
            private AnimFragment m_root;
            private AnimFragment.Row m_parent;
            public byte[] QuattData { get { return _quattData; } }
            public AnimFragment M_Root { get { return m_root; } }
            public AnimFragment.Row M_Parent { get { return m_parent; } }
        }
        public partial class Vec3 : KaitaiStruct
        {
            public static Vec3 FromFile(string fileName)
            {
                return new Vec3(new KaitaiStream(fileName));
            }

            public Vec3(KaitaiStream p__io, AnimFragment.Row p__parent = null, AnimFragment p__root = null) : base(p__io)
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
            private AnimFragment m_root;
            private AnimFragment.Row m_parent;
            public int X { get { return _x; } }
            public int Y { get { return _y; } }
            public int Z { get { return _z; } }
            public AnimFragment M_Root { get { return m_root; } }
            public AnimFragment.Row M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private AnimFragment m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public AnimFragment M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
