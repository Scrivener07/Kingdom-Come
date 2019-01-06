// This is a generated file! Please edit source .ksy file and use kaitai-struct-compiler to rebuild

using Kaitai;
using System.Collections.Generic;

namespace KCD.Kaitai
{
    public partial class Soul : KaitaiStruct
    {
        public static Soul FromFile(string fileName)
        {
            return new Soul(new KaitaiStream(fileName));
        }

        public Soul(KaitaiStream p__io, KaitaiStruct p__parent = null, Soul p__root = null) : base(p__io)
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

            public Uuid(KaitaiStream p__io, Soul.Row p__parent = null, Soul p__root = null) : base(p__io)
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
            private Soul m_root;
            private Soul.Row m_parent;
            public byte[] UuidType { get { return _uuidType; } }
            public Soul M_Root { get { return m_root; } }
            public Soul.Row M_Parent { get { return m_parent; } }
        }
        public partial class Trifloat : KaitaiStruct
        {
            public static Trifloat FromFile(string fileName)
            {
                return new Trifloat(new KaitaiStream(fileName));
            }

            public Trifloat(KaitaiStream p__io, KaitaiStruct p__parent = null, Soul p__root = null) : base(p__io)
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
            private Soul m_root;
            private KaitaiStruct m_parent;
            public float FloatA { get { return _floatA; } }
            public float FloatB { get { return _floatB; } }
            public float FloatC { get { return _floatC; } }
            public Soul M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Row : KaitaiStruct
        {
            public static Row FromFile(string fileName)
            {
                return new Row(new KaitaiStream(fileName));
            }

            public Row(KaitaiStream p__io, Soul p__parent = null, Soul p__root = null) : base(p__io)
            {
                m_parent = p__parent;
                m_root = p__root;
                _read();
            }
            private void _read()
            {
                _computerName = m_io.ReadS4le();
                _timestamp = m_io.ReadS4le();
                _levelName = m_io.ReadS4le();
                _soulId = new Uuid(m_io, this, m_root);
                _soulName = m_io.ReadS4le();
                _soulClassId = m_io.ReadS4le();
                _soulVipClassId = m_io.ReadS4le();
                _socialClassId = m_io.ReadS4le();
                _soulArchetypeId = m_io.ReadS4le();
                _initialClothingPresetId = new Uuid(m_io, this, m_root);
                _initialClothingDirt = m_io.ReadF4le();
                _inventoryId = new Uuid(m_io, this, m_root);
                _initialWeaponPresetId = new Uuid(m_io, this, m_root);
                _xpMultiplier = m_io.ReadF4le();
                _digestionMultiplier = m_io.ReadF4le();
                _shadiness = m_io.ReadF4le();
                _charisma = m_io.ReadS4le();
                _faction = m_io.ReadS4le();
                _str = m_io.ReadS4le();
                _agi = m_io.ReadS4le();
                _vit = m_io.ReadS4le();
                _spc = m_io.ReadS4le();
                _vision = m_io.ReadS4le();
                _hearing = m_io.ReadS4le();
                _barter = m_io.ReadS4le();
                _courage = m_io.ReadS4le();
                _reputation = m_io.ReadF4le();
                _brainId = new Uuid(m_io, this, m_root);
                _aiBodyId = new Uuid(m_io, this, m_root);
                _activity0 = m_io.ReadS4le();
                _time0 = m_io.ReadS4le();
                _activity1 = m_io.ReadS4le();
                _time1 = m_io.ReadS4le();
                _activity2 = m_io.ReadS4le();
                _time2 = m_io.ReadS4le();
                _activity3 = m_io.ReadS4le();
                _time3 = m_io.ReadS4le();
                _activity4 = m_io.ReadS4le();
                _time4 = m_io.ReadS4le();
                _activity5 = m_io.ReadS4le();
                _time5 = m_io.ReadS4le();
                _activity6 = m_io.ReadS4le();
                _time6 = m_io.ReadS4le();
                _activity7 = m_io.ReadS4le();
                _time7 = m_io.ReadS4le();
                _activity8 = m_io.ReadS4le();
                _time8 = m_io.ReadS4le();
                _characterProportion = m_io.ReadS4le();
                _characterScale = m_io.ReadF4le();
                _characterBodyId = new Uuid(m_io, this, m_root);
                _characterSkinBrightness = m_io.ReadF4le();
                _characterSkinHue = m_io.ReadF4le();
                _characterSkinSaturation = m_io.ReadF4le();
                _characterSkinColor = m_io.ReadS4le();
                _characterHeadId = new Uuid(m_io, this, m_root);
                _characterHeadBrightness = m_io.ReadF4le();
                _characterHeadHue = m_io.ReadF4le();
                _characterHeadSaturation = m_io.ReadF4le();
                _characterHeadColor = m_io.ReadS4le();
                _characterEyesColor = m_io.ReadS4le();
                _characterEyesOcclusionStrength = m_io.ReadF4le();
                _characterHairId = new Uuid(m_io, this, m_root);
                _characterHairBrightness = m_io.ReadF4le();
                _characterHairHue = m_io.ReadF4le();
                _characterHairSaturation = m_io.ReadF4le();
                _characterHairColor = m_io.ReadS4le();
                _characterBeardId = new Uuid(m_io, this, m_root);
                _characterBeardBrightness = m_io.ReadF4le();
                _characterBeardHue = m_io.ReadF4le();
                _characterBeardSaturation = m_io.ReadF4le();
                _characterBeardColor = m_io.ReadS4le();
            }
            private int _computerName;
            private int _timestamp;
            private int _levelName;
            private Uuid _soulId;
            private int _soulName;
            private int _soulClassId;
            private int _soulVipClassId;
            private int _socialClassId;
            private int _soulArchetypeId;
            private Uuid _initialClothingPresetId;
            private float _initialClothingDirt;
            private Uuid _inventoryId;
            private Uuid _initialWeaponPresetId;
            private float _xpMultiplier;
            private float _digestionMultiplier;
            private float _shadiness;
            private int _charisma;
            private int _faction;
            private int _str;
            private int _agi;
            private int _vit;
            private int _spc;
            private int _vision;
            private int _hearing;
            private int _barter;
            private int _courage;
            private float _reputation;
            private Uuid _brainId;
            private Uuid _aiBodyId;
            private int _activity0;
            private int _time0;
            private int _activity1;
            private int _time1;
            private int _activity2;
            private int _time2;
            private int _activity3;
            private int _time3;
            private int _activity4;
            private int _time4;
            private int _activity5;
            private int _time5;
            private int _activity6;
            private int _time6;
            private int _activity7;
            private int _time7;
            private int _activity8;
            private int _time8;
            private int _characterProportion;
            private float _characterScale;
            private Uuid _characterBodyId;
            private float _characterSkinBrightness;
            private float _characterSkinHue;
            private float _characterSkinSaturation;
            private int _characterSkinColor;
            private Uuid _characterHeadId;
            private float _characterHeadBrightness;
            private float _characterHeadHue;
            private float _characterHeadSaturation;
            private int _characterHeadColor;
            private int _characterEyesColor;
            private float _characterEyesOcclusionStrength;
            private Uuid _characterHairId;
            private float _characterHairBrightness;
            private float _characterHairHue;
            private float _characterHairSaturation;
            private int _characterHairColor;
            private Uuid _characterBeardId;
            private float _characterBeardBrightness;
            private float _characterBeardHue;
            private float _characterBeardSaturation;
            private int _characterBeardColor;
            private Soul m_root;
            private Soul m_parent;
            public int ComputerName { get { return _computerName; } }
            public int Timestamp { get { return _timestamp; } }
            public int LevelName { get { return _levelName; } }
            public Uuid SoulId { get { return _soulId; } }
            public int SoulName { get { return _soulName; } }
            public int SoulClassId { get { return _soulClassId; } }
            public int SoulVipClassId { get { return _soulVipClassId; } }
            public int SocialClassId { get { return _socialClassId; } }
            public int SoulArchetypeId { get { return _soulArchetypeId; } }
            public Uuid InitialClothingPresetId { get { return _initialClothingPresetId; } }
            public float InitialClothingDirt { get { return _initialClothingDirt; } }
            public Uuid InventoryId { get { return _inventoryId; } }
            public Uuid InitialWeaponPresetId { get { return _initialWeaponPresetId; } }
            public float XpMultiplier { get { return _xpMultiplier; } }
            public float DigestionMultiplier { get { return _digestionMultiplier; } }
            public float Shadiness { get { return _shadiness; } }
            public int Charisma { get { return _charisma; } }
            public int Faction { get { return _faction; } }
            public int Str { get { return _str; } }
            public int Agi { get { return _agi; } }
            public int Vit { get { return _vit; } }
            public int Spc { get { return _spc; } }
            public int Vision { get { return _vision; } }
            public int Hearing { get { return _hearing; } }
            public int Barter { get { return _barter; } }
            public int Courage { get { return _courage; } }
            public float Reputation { get { return _reputation; } }
            public Uuid BrainId { get { return _brainId; } }
            public Uuid AiBodyId { get { return _aiBodyId; } }
            public int Activity0 { get { return _activity0; } }
            public int Time0 { get { return _time0; } }
            public int Activity1 { get { return _activity1; } }
            public int Time1 { get { return _time1; } }
            public int Activity2 { get { return _activity2; } }
            public int Time2 { get { return _time2; } }
            public int Activity3 { get { return _activity3; } }
            public int Time3 { get { return _time3; } }
            public int Activity4 { get { return _activity4; } }
            public int Time4 { get { return _time4; } }
            public int Activity5 { get { return _activity5; } }
            public int Time5 { get { return _time5; } }
            public int Activity6 { get { return _activity6; } }
            public int Time6 { get { return _time6; } }
            public int Activity7 { get { return _activity7; } }
            public int Time7 { get { return _time7; } }
            public int Activity8 { get { return _activity8; } }
            public int Time8 { get { return _time8; } }
            public int CharacterProportion { get { return _characterProportion; } }
            public float CharacterScale { get { return _characterScale; } }
            public Uuid CharacterBodyId { get { return _characterBodyId; } }
            public float CharacterSkinBrightness { get { return _characterSkinBrightness; } }
            public float CharacterSkinHue { get { return _characterSkinHue; } }
            public float CharacterSkinSaturation { get { return _characterSkinSaturation; } }
            public int CharacterSkinColor { get { return _characterSkinColor; } }
            public Uuid CharacterHeadId { get { return _characterHeadId; } }
            public float CharacterHeadBrightness { get { return _characterHeadBrightness; } }
            public float CharacterHeadHue { get { return _characterHeadHue; } }
            public float CharacterHeadSaturation { get { return _characterHeadSaturation; } }
            public int CharacterHeadColor { get { return _characterHeadColor; } }
            public int CharacterEyesColor { get { return _characterEyesColor; } }
            public float CharacterEyesOcclusionStrength { get { return _characterEyesOcclusionStrength; } }
            public Uuid CharacterHairId { get { return _characterHairId; } }
            public float CharacterHairBrightness { get { return _characterHairBrightness; } }
            public float CharacterHairHue { get { return _characterHairHue; } }
            public float CharacterHairSaturation { get { return _characterHairSaturation; } }
            public int CharacterHairColor { get { return _characterHairColor; } }
            public Uuid CharacterBeardId { get { return _characterBeardId; } }
            public float CharacterBeardBrightness { get { return _characterBeardBrightness; } }
            public float CharacterBeardHue { get { return _characterBeardHue; } }
            public float CharacterBeardSaturation { get { return _characterBeardSaturation; } }
            public int CharacterBeardColor { get { return _characterBeardColor; } }
            public Soul M_Root { get { return m_root; } }
            public Soul M_Parent { get { return m_parent; } }
        }
        public partial class Quat : KaitaiStruct
        {
            public static Quat FromFile(string fileName)
            {
                return new Quat(new KaitaiStream(fileName));
            }

            public Quat(KaitaiStream p__io, KaitaiStruct p__parent = null, Soul p__root = null) : base(p__io)
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
            private Soul m_root;
            private KaitaiStruct m_parent;
            public int QuatX { get { return _quatX; } }
            public int QuatY { get { return _quatY; } }
            public int QuatZ { get { return _quatZ; } }
            public int QuatW { get { return _quatW; } }
            public Soul M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Quatt : KaitaiStruct
        {
            public static Quatt FromFile(string fileName)
            {
                return new Quatt(new KaitaiStream(fileName));
            }

            public Quatt(KaitaiStream p__io, KaitaiStruct p__parent = null, Soul p__root = null) : base(p__io)
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
            private Soul m_root;
            private KaitaiStruct m_parent;
            public byte[] QuattType { get { return _quattType; } }
            public Soul M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Header : KaitaiStruct
        {
            public static Header FromFile(string fileName)
            {
                return new Header(new KaitaiStream(fileName));
            }

            public Header(KaitaiStream p__io, Soul p__parent = null, Soul p__root = null) : base(p__io)
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
            private Soul m_root;
            private Soul m_parent;
            public int Version { get { return _version; } }
            public uint DescriptorsHash { get { return _descriptorsHash; } }
            public uint LayoutHash { get { return _layoutHash; } }
            public int TableVersion { get { return _tableVersion; } }
            public int RowCount { get { return _rowCount; } }
            public int StringDataSize { get { return _stringDataSize; } }
            public int UniqueStringsCount { get { return _uniqueStringsCount; } }
            public Soul M_Root { get { return m_root; } }
            public Soul M_Parent { get { return m_parent; } }
        }
        public partial class Vec3 : KaitaiStruct
        {
            public static Vec3 FromFile(string fileName)
            {
                return new Vec3(new KaitaiStream(fileName));
            }

            public Vec3(KaitaiStream p__io, KaitaiStruct p__parent = null, Soul p__root = null) : base(p__io)
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
            private Soul m_root;
            private KaitaiStruct m_parent;
            public int Vec3X { get { return _vec3X; } }
            public int Vec3Y { get { return _vec3Y; } }
            public int Vec3Z { get { return _vec3Z; } }
            public Soul M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        public partial class Padding : KaitaiStruct
        {
            public static Padding FromFile(string fileName)
            {
                return new Padding(new KaitaiStream(fileName));
            }

            public Padding(KaitaiStream p__io, KaitaiStruct p__parent = null, Soul p__root = null) : base(p__io)
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
            private Soul m_root;
            private KaitaiStruct m_parent;
            public byte[] PaddingType { get { return _paddingType; } }
            public Soul M_Root { get { return m_root; } }
            public KaitaiStruct M_Parent { get { return m_parent; } }
        }
        private Header _table;
        private List<Row> _rows;
        private List<string> _strings;
        private Soul m_root;
        private KaitaiStruct m_parent;
        public Header Table { get { return _table; } }
        public List<Row> Rows { get { return _rows; } }
        public List<string> Strings { get { return _strings; } }
        public Soul M_Root { get { return m_root; } }
        public KaitaiStruct M_Parent { get { return m_parent; } }
    }
}
