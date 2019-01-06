// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai
{
    public partial class SoulArchetype : KaitaiStruct
    {
        public static SoulArchetype FromFile(string fileName)
        {
            return new SoulArchetype(new KaitaiStream(fileName));
        }

        public SoulArchetype(KaitaiStream p__io, KaitaiStruct p__parent = null, SoulArchetype p__root = null) : base(p__io)
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

            public Uuid(KaitaiStream p__io, KaitaiStruct p__parent = null, SoulArchetype p__root = null) : base(p__io)
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
            private SoulArchetype m_root;
            private KaitaiStruct m_parent;
            public byte[] UuidType { get { return _uuidType; } }
            public SoulArchetype M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, SoulArchetype p__parent = null, SoulArchetype p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _soulArchetypeId = m_io.ReadS4le();
                _soulArchetypeName = m_io.ReadS4le();
                _raceId = m_io.ReadS4le();
                _genderId = m_io.ReadS4le();
                _normalBodyWeight = m_io.ReadF4le();
                _bodyBaseArmor = m_io.ReadF4le();
                _bodyBaseVisibility = m_io.ReadF4le();
                _bodyBaseConspicuousness = m_io.ReadF4le();
                _inventoryCapacityMultiplier = m_io.ReadF4le();
                _baseStamina = m_io.ReadF4le();
                _relativeVitalityToStamina = m_io.ReadF4le();
            }
            private int _soulArchetypeId;
            private int _soulArchetypeName;
            private int _raceId;
            private int _genderId;
            private float _normalBodyWeight;
            private float _bodyBaseArmor;
            private float _bodyBaseVisibility;
            private float _bodyBaseConspicuousness;
            private float _inventoryCapacityMultiplier;
            private float _baseStamina;
            private float _relativeVitalityToStamina;
            private SoulArchetype m_root;
            private SoulArchetype m_parent;
            public int SoulArchetypeId { get { return _soulArchetypeId; } }
            public int SoulArchetypeName { get { return _soulArchetypeName; } }
            public int RaceId { get { return _raceId; } }
            public int GenderId { get { return _genderId; } }
            public float NormalBodyWeight { get { return _normalBodyWeight; } }
            public float BodyBaseArmor { get { return _bodyBaseArmor; } }
            public float BodyBaseVisibility { get { return _bodyBaseVisibility; } }
            public float BodyBaseConspicuousness { get { return _bodyBaseConspicuousness; } }
            public float InventoryCapacityMultiplier { get { return _inventoryCapacityMultiplier; } }
            public float BaseStamina { get { return _baseStamina; } }
            public float RelativeVitalityToStamina { get { return _relativeVitalityToStamina; } }
            public SoulArchetype M_Root { get { return m_root; } }
            public SoulArchetype M_Parent { get { return m_parent; } }
        }
        public partial class Quat : KaitaiStruct
        {
            public static Quat FromFile(string fileName)
            {
                return new Quat(new KaitaiStream(fileName));
            }

            public Quat(KaitaiStream p__io, KaitaiStruct p__parent = null, SoulArchetype p__root = null) : base(p__io)
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
            private SoulArchetype m_root;
            private KaitaiStruct m_parent;
            public int QuatX { get { return _quatX; } }
            public int QuatY { get { return _quatY; } }
            public int QuatZ { get { return _quatZ; } }
            public int QuatW { get { return _quatW; } }
            public SoulArchetype M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Quatt : KaitaiStruct
        {
            public static Quatt FromFile(string fileName)
            {
                return new Quatt(new KaitaiStream(fileName));
            }

            public Quatt(KaitaiStream p__io, KaitaiStruct p__parent = null, SoulArchetype p__root = null) : base(p__io)
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
            private SoulArchetype m_root;
            private KaitaiStruct m_parent;
            public byte[] QuattType { get { return _quattType; } }
            public SoulArchetype M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Header : KaitaiStruct
        {
            public static Header FromFile(string fileName)
            {
                return new Header(new KaitaiStream(fileName));
            }

            public Header(KaitaiStream p__io, SoulArchetype p__parent = null, SoulArchetype p__root = null) : base(p__io)
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
            private SoulArchetype m_root;
            private SoulArchetype m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public SoulArchetype M_Root { get { return m_root; } }
            public SoulArchetype M_Parent { get { return m_parent; } }
        }
        public partial class Vec3 : KaitaiStruct
        {
            public static Vec3 FromFile(string fileName)
            {
                return new Vec3(new KaitaiStream(fileName));
            }

            public Vec3(KaitaiStream p__io, KaitaiStruct p__parent = null, SoulArchetype p__root = null) : base(p__io)
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
            private SoulArchetype m_root;
            private KaitaiStruct m_parent;
            public int Vec3X { get { return _vec3X; } }
            public int Vec3Y { get { return _vec3Y; } }
            public int Vec3Z { get { return _vec3Z; } }
            public SoulArchetype M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, SoulArchetype p__root = null) : base(p__io)
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
            private SoulArchetype m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public SoulArchetype M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private SoulArchetype m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public SoulArchetype M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
