// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai.Tables
{
    public partial class Weapon : KaitaiStruct
    {
        public static Weapon FromFile(string fileName)
        {
            return new Weapon(new KaitaiStream(fileName));
        }

        public Weapon(KaitaiStream p__io, KaitaiStruct p__parent = null, Weapon p__root = null) : base(p__io)
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

            public Uuid(KaitaiStream p__io, Weapon.Row p__parent = null, Weapon p__root = null) : base(p__io)
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
            private Weapon m_root;
            private Weapon.Row m_parent;
            public byte[] UuidType { get { return _uuidType; } }
            public Weapon M_Root { get { return m_root; } }
            public Weapon.Row M_Parent { get { return m_parent; } }
        }
        public partial class Trifloat : KaitaiStruct
        {
            public static Trifloat FromFile(string fileName)
            {
                return new Trifloat(new KaitaiStream(fileName));
            }

            public Trifloat(KaitaiStream p__io, KaitaiStruct p__parent = null, Weapon p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _floatA = m_io.ReadF4le();
                _floatB = m_io.ReadF4le();
                _floatC = m_io.ReadF4le();
            }
            private float _floatA;
            private float _floatB;
            private float _floatC;
            private Weapon m_root;
            private KaitaiStruct m_parent;
            public float FloatA { get { return _floatA; } }
            public float FloatB { get { return _floatB; } }
            public float FloatC { get { return _floatC; } }
            public Weapon M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Weapon p__parent = null, Weapon p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _itemId = new Uuid(m_io, this, m_root);
                _holsterModel = m_io.ReadS4le();
                _holsterMaterial = m_io.ReadS4le();
                _weaponClassId = m_io.ReadS4le();
                _weaponSubClassId = m_io.ReadS4le();
                _defense = m_io.ReadF4le();
                _maxStatus = m_io.ReadS4le();
                _strReq = m_io.ReadS4le();
                _agiReq = m_io.ReadS4le();
                _isBreakable = m_io.ReadS1();
            }
            private Uuid _itemId;
            private int _holsterModel;
            private int _holsterMaterial;
            private int _weaponClassId;
            private int _weaponSubClassId;
            private float _defense;
            private int _maxStatus;
            private int _strReq;
            private int _agiReq;
            private sbyte _isBreakable;
            private Weapon m_root;
            private Weapon m_parent;
            public Uuid ItemId { get { return _itemId; } }
            public int HolsterModel { get { return _holsterModel; } }
            public int HolsterMaterial { get { return _holsterMaterial; } }
            public int WeaponClassId { get { return _weaponClassId; } }
            public int WeaponSubClassId { get { return _weaponSubClassId; } }
            public float Defense { get { return _defense; } }
            public int MaxStatus { get { return _maxStatus; } }
            public int StrReq { get { return _strReq; } }
            public int AgiReq { get { return _agiReq; } }
            public sbyte IsBreakable { get { return _isBreakable; } }
            public Weapon M_Root { get { return m_root; } }
            public Weapon M_Parent { get { return m_parent; } }
        }
        public partial class Quat : KaitaiStruct
        {
            public static Quat FromFile(string fileName)
            {
                return new Quat(new KaitaiStream(fileName));
            }

            public Quat(KaitaiStream p__io, KaitaiStruct p__parent = null, Weapon p__root = null) : base(p__io)
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
            private Weapon m_root;
            private KaitaiStruct m_parent;
            public int QuatX { get { return _quatX; } }
            public int QuatY { get { return _quatY; } }
            public int QuatZ { get { return _quatZ; } }
            public int QuatW { get { return _quatW; } }
            public Weapon M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Quatt : KaitaiStruct
        {
            public static Quatt FromFile(string fileName)
            {
                return new Quatt(new KaitaiStream(fileName));
            }

            public Quatt(KaitaiStream p__io, KaitaiStruct p__parent = null, Weapon p__root = null) : base(p__io)
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
            private Weapon m_root;
            private KaitaiStruct m_parent;
            public byte[] QuattType { get { return _quattType; } }
            public Weapon M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Header : KaitaiStruct
        {
            public static Header FromFile(string fileName)
            {
                return new Header(new KaitaiStream(fileName));
            }

            public Header(KaitaiStream p__io, Weapon p__parent = null, Weapon p__root = null) : base(p__io)
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
            private Weapon m_root;
            private Weapon m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Weapon M_Root { get { return m_root; } }
            public Weapon M_Parent { get { return m_parent; } }
        }
        public partial class Vec3 : KaitaiStruct
        {
            public static Vec3 FromFile(string fileName)
            {
                return new Vec3(new KaitaiStream(fileName));
            }

            public Vec3(KaitaiStream p__io, KaitaiStruct p__parent = null, Weapon p__root = null) : base(p__io)
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
            private Weapon m_root;
            private KaitaiStruct m_parent;
            public int Vec3X { get { return _vec3X; } }
            public int Vec3Y { get { return _vec3Y; } }
            public int Vec3Z { get { return _vec3Z; } }
            public Weapon M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, Weapon p__root = null) : base(p__io)
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
            private Weapon m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public Weapon M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Weapon m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Weapon M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
