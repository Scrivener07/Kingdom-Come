// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai
{
    public partial class BodyPart : KaitaiStruct
    {
        public static BodyPart FromFile(string fileName)
        {
            return new BodyPart(new KaitaiStream(fileName));
        }

        public BodyPart(KaitaiStream p__io, KaitaiStruct p__parent = null, BodyPart p__root = null) : base(p__io)
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
        public partial class Uuid : KaitaiStruct
        {
            public static Uuid FromFile(string fileName)
            {
                return new Uuid(new KaitaiStream(fileName));
            }

            public Uuid(KaitaiStream p__io, BodyPart.Row p__parent = null, BodyPart p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _uuidType = m_io.ReadBytes(16);
            }
            private byte[] _uuidType;
            private BodyPart m_root;
            private BodyPart.Row m_parent;
            public byte[] UuidType { get { return _uuidType; } }
            public BodyPart M_Root { get { return m_root; } }
            public BodyPart.Row M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, BodyPart p__parent = null, BodyPart p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _bodyPartId = m_io.ReadS4le();
                _bodyPartName = m_io.ReadS4le();
                _bodyDamageCoeff = m_io.ReadF4le();
                _raceId = m_io.ReadS4le();
                _mnTag = m_io.ReadS4le();
                _injuryBuffId = new Uuid(m_io, this, m_root);
                _uiName = m_io.ReadS4le();
            }
            private int _bodyPartId;
            private int _bodyPartName;
            private float _bodyDamageCoeff;
            private int _raceId;
            private int _mnTag;
            private Uuid _injuryBuffId;
            private int _uiName;
            private BodyPart m_root;
            private BodyPart m_parent;
            public int BodyPartId { get { return _bodyPartId; } }
            public int BodyPartName { get { return _bodyPartName; } }
            public float BodyDamageCoeff { get { return _bodyDamageCoeff; } }
            public int RaceId { get { return _raceId; } }
            public int MnTag { get { return _mnTag; } }
            public Uuid InjuryBuffId { get { return _injuryBuffId; } }
            public int UiName { get { return _uiName; } }
            public BodyPart M_Root { get { return m_root; } }
            public BodyPart M_Parent { get { return m_parent; } }
        }
        public partial class Quat : KaitaiStruct
        {
            public static Quat FromFile(string fileName)
            {
                return new Quat(new KaitaiStream(fileName));
            }

            public Quat(KaitaiStream p__io, KaitaiStruct p__parent = null, BodyPart p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _quatX = m_io.ReadS4le();
                _quatY = m_io.ReadS4le();
                _quatZ = m_io.ReadS4le();
                _quatW = m_io.ReadS4le();
            }
            private int _quatX;
            private int _quatY;
            private int _quatZ;
            private int _quatW;
            private BodyPart m_root;
            private KaitaiStruct m_parent;
            public int QuatX { get { return _quatX; } }
            public int QuatY { get { return _quatY; } }
            public int QuatZ { get { return _quatZ; } }
            public int QuatW { get { return _quatW; } }
            public BodyPart M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Quatt : KaitaiStruct
        {
            public static Quatt FromFile(string fileName)
            {
                return new Quatt(new KaitaiStream(fileName));
            }

            public Quatt(KaitaiStream p__io, KaitaiStruct p__parent = null, BodyPart p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _quattType = m_io.ReadBytes(28);
            }
            private byte[] _quattType;
            private BodyPart m_root;
            private KaitaiStruct m_parent;
            public byte[] QuattType { get { return _quattType; } }
            public BodyPart M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Header : KaitaiStruct
        {
            public static Header FromFile(string fileName)
            {
                return new Header(new KaitaiStream(fileName));
            }

            public Header(KaitaiStream p__io, BodyPart p__parent = null, BodyPart p__root = null) : base(p__io)
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
            private BodyPart m_root;
            private BodyPart m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public BodyPart M_Root { get { return m_root; } }
            public BodyPart M_Parent { get { return m_parent; } }
        }
        public partial class Vec3 : KaitaiStruct
        {
            public static Vec3 FromFile(string fileName)
            {
                return new Vec3(new KaitaiStream(fileName));
            }

            public Vec3(KaitaiStream p__io, KaitaiStruct p__parent = null, BodyPart p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _vec3X = m_io.ReadS4le();
                _vec3Y = m_io.ReadS4le();
                _vec3Z = m_io.ReadS4le();
            }
            private int _vec3X;
            private int _vec3Y;
            private int _vec3Z;
            private BodyPart m_root;
            private KaitaiStruct m_parent;
            public int Vec3X { get { return _vec3X; } }
            public int Vec3Y { get { return _vec3Y; } }
            public int Vec3Z { get { return _vec3Z; } }
            public BodyPart M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, BodyPart p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _paddingType = m_io.ReadBytes(16);
            }
            private byte[] _paddingType;
            private BodyPart m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public BodyPart M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private BodyPart m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public BodyPart M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
